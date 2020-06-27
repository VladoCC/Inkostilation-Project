using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Класс-оболочка базы данных, предоставляющий доступ ко всем методам,
    /// необходимым для работы со структурами данных.
    /// Реализует шаблон проектирования Singleton.
    /// Предоставляет возможности для сохранения и загрузки базы данных на жесткий диск,
    /// при помощи сериализации.
    /// </summary>
    [Serializable]
    public class Database
    {
        /// <summary>
        /// Singleton сущность базы данных, с которой на данный момент работает программа.
        /// </summary>
        private static Database _instance;

        /// <summary>
        /// Хэш-таблица клиентов, находящихся в базе данных.
        /// Принцип разрешения коллизий: открытая адресация (метод двойного хэширования).
        /// </summary>
        private HashMap<int, Client> _clients;
        /// <summary>
        /// Хэш-таблица банкоматов, находящихся в базе данных.
        /// Принцип разрешения коллизий: метод цепочек.
        /// Хэш функция: остаток от деления.
        /// </summary>
        private HashMap<int, Machine> _machines;
        /// <summary>
        /// Бинарное дерево операций, находящихся в базе данных.
        /// </summary>
        private Tree<Operation> _operations;
        /// <summary>
        /// Бинарное дерево процентов, находящихся в базе данных.
        /// </summary>
        private Tree<Percent> _percents;

        /// <summary>
        /// Функция, предоставляющая доступ к синглтону.
        /// При указании пути к файлу, загружает базу данных из него.
        /// Иначе при необходимости создает пустую базу данных и возвращает ее.
        /// </summary>
        /// <param name="filePath"> Путь к файлу базы данны. Файл должен иметь расширение ".kostil". </param>
        /// <returns> База данных, с которой на данный момент работает программа. </returns>
        public static Database GetInstance()
        { 
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }

        public static Result LoadInstance(string filePath)
        {
            Database database = new Database();
            Result result = new Result(true);
            Result adding = new Result(true);
            foreach (var str in File.ReadAllLines(filePath))
            {
                if (!result.Success || !adding.Success)
                {
                    break;
                }
                var elems = str.Split(' ');
                switch (str[0])
                {
                    case '1':
                        if (elems.Length == 4)
                        {
                            Result res1 = Checks.CheckClient(elems[1], elems[2], elems[3]);
                            result += res1;
                            if (res1)
                            {
                                adding = database.AddClient(new Client(Convert.ToInt32(elems[1]),
                                    elems[2], elems[3]));
                            }
                        }
                        else
                        {
                            result.Success = false;
                            result += "Количество аргументов в строке не соответствует количеству параметров клиента.";
                        }
                        break;
                    case '2':
                        if (elems.Length == 4)
                        {
                            Result res2 = Checks.CheckMachine(elems[1], elems[2], elems[3]);
                            result += res2;
                            if (res2)
                            {
                                adding = database.AddMachine(new Machine(Convert.ToInt32(elems[1]),
                                    elems[2], elems[3]));
                            }
                        }
                        else
                        {
                            result.Success = false;
                            result += "Количество аргументов в строке не соответствует количеству параметров банкомата.";
                        }

                        break;
                    case '3':
                        if (elems.Length == 5)
                        {
                            Result res3 = Checks.CheckOperation(elems[1], elems[2], elems[3], elems[4]);
                            result += res3;
                            if (res3)
                            {
                                adding = database.AddOperation(new Operation(elems[1],
                                    Convert.ToInt32(elems[2]), Convert.ToInt32(elems[3]),
                                    Convert.ToInt32(elems[4])));
                            }
                        }
                        else
                        {
                            result.Success = false;
                            result += "Количество аргументов в строке не соответствует количеству параметров операции.";
                        }

                        break;
                    case '4':
                        if (elems.Length == 5)
                        {
                            Result res4 = Checks.CheckPercent(elems[1], elems[2], elems[3], elems[4]);
                            result += res4;
                            if (res4)
                            {
                                adding = database.AddPercent(new Percent(elems[1],
                                    elems[2], elems[3],
                                    Convert.ToInt32(elems[4])));
                            }
                        }
                        else
                        {
                            result.Success = false;
                            result += "Количество аргументов в строке не соответствует количеству параметров процента операции.";
                        }

                        break;
                }
            }

            if (result.Success && (result += adding).Success)
            {
                _instance = database;
            }
            
            return result;
        }

        /// <summary>
        /// Заменяет рабочую базу данных на новую.
        /// </summary>
        /// <returns> Пустая база данных. </returns>
        public static Database GetNewInstance()
        {
            _instance = new Database();
            return _instance;
        }
        
        /// <summary>
        /// Приватный конструктор, используемый для создания пустой базы данных.
        /// Инициализирует все структуры данных пустыми.
        /// </summary>
        private Database()
        {
            _percents = new Tree<Percent>();
            _operations = new Tree<Operation>();
            _machines = new HashMap<int, Machine>(new ModFunction(), new ListStorage<int, Machine>());
            ModFunction function = new ModFunction();
            _clients = new HashMap<int, Client>(function, new DoubleHashStorage<int, Client>(new OddFunction(), function));
        }

        /// <summary>
        /// Сохраняет базу данных на жесткий диск.
        /// </summary>
        /// <param name="filePath"> Путь к файлу, в который будет производится сохранение. </param>
        public Result Save(string filePath)
        {
            if (ClientSize() > 0 || MachineSize() > 0 || OperationSize() > 0 || PercentSize() > 0)
            {
                String text = "";
                if (ClientSize() > 0)
                {
                    foreach (Client client in ClientArray())
                    {
                        text += "1 " + client.CardNumber + " " + client.BankName + " " + client.Name + "\n";
                    }
                }

                if (MachineSize() > 0)
                {
                    foreach (Machine machine in MachineArray())
                    {
                        text += "2 " + machine.MachineNumber + " " + machine.Address + " " + machine.BankName + "\n";
                    }
                }

                if (OperationSize() > 0)
                {
                    foreach (Operation operation in OperationArray())
                    {
                        text += "3 " + operation.OperationName + " " + operation.CardNumber + " " +
                                operation.MachineNumber + " " + operation.Sum + "\n";
                    }
                }

                if (PercentSize() > 0)
                {
                    foreach (Percent percent in PercentArray())
                    {
                        text += "4 " + percent.OperationName + " " + percent.SenderBank + " " + percent.ReceiverBank +
                                " " +
                                percent.Percent1 + "\n";
                    }
                }

                text = text.Remove(text.Length - 1);
                File.WriteAllText(filePath, text);
                return new Result(true);
            }
            return new Result(false) + "Нельзя сохранить пустую базу данных.";
        }

        /// <summary>
        /// Добавляет клиента в базу данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="client"> Клиент для добавления. </param>
        /// <returns> Сообщение об успешном добавлении или о проблеме целостности. </returns>
        public Result AddClient(Client client)
        {
            _clients.Add(client);
            Result con = Consistence();
            if (!con)
            {
                _clients.Remove(client);
            }
            return con;
        }

        /// <summary>
        /// Добавляет банкомат в базу данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="machine"> Банкомат для добавления. </param>
        /// <returns> Сообщение об успешном добавлении или о проблеме целостности. </returns>
        public Result AddMachine(Machine machine)
        {
            _machines.Add(machine);
            Result con = Consistence();
            if (!con)
            {
                _machines.Remove(machine);
            }
            return con;
        }

        /// <summary>
        /// Добавляет операцию в базу данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="operation"> Операция для добавления. </param>
        /// <returns> Сообщение об успешном добавлении или о проблеме целостности. </returns>
        public Result AddOperation(Operation operation)
        {
            _operations.Add(operation);
            Result con = Consistence();
            if (!con)
            {
                _operations.Remove(operation);
            }
            return con;
        }

        /// <summary>
        /// Добавляет процент в базу данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="percent"> Процент для добавления. </param>
        /// <returns> Сообщение об успешном добавлении или о проблеме целостности. </returns>
        public Result AddPercent(Percent percent)
        {
            _percents.Add(percent);
            Result con = Consistence();
            if (!con)
            {
                _percents.Remove(percent);
            }
            return con;
        }
        
        /// <summary>
        /// Удаляет клиента из базы данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="client"> Клиент для удаления. </param>
        /// <returns> Сообщение об успешном удалении или о проблеме целостности. </returns>
        public Result RemoveClient(Client client)
        {
            _clients.Remove(client);
            Result con = Consistence();
            if (!con)
            {
                _clients.Add(client);
            }
            return con;
        }

        /// <summary>
        /// Удаляет банкомат из базы данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="machine"> Банкомат для удаления. </param>
        /// <returns> Сообщение об успешном удалении или о проблеме целостности. </returns>
        public Result RemoveMachine(Machine machine)
        { 
            _machines.Remove(machine);
            Result con = Consistence();
            if (!con)
            {
                _machines.Add(machine);
            }
            return con;
        }

        /// <summary>
        /// Удаляет операцию из базы данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="operation"> Операция для удаления. </param>
        /// <returns> Сообщение об успешном удалении или о проблеме целостности. </returns>
        public Result RemoveOperation(Operation operation)
        {
            _operations.Remove(operation);
            Result con = Consistence();
            if (!con)
            {
                _operations.Add(operation);
            }
            return con;
        }

        /// <summary>
        /// Удаляет процент из базы данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="percent"> Процент для удаления. </param>
        /// <returns> Сообщение об успешном удалении или о проблеме целостности. </returns>
        public Result RemovePercent(Percent percent)
        {
            _percents.Remove(percent);
            Result con = Consistence();
            if (!con)
            {
                _percents.Remove(percent);
            }
            return con;
        }
        
        /// <summary>
        /// Производит поиск в базе данных клиента, соответствующего входным данным.
        /// </summary>
        /// <param name="client"> Клиент, соответствия которому необходимо найти. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Client> FindClient(Client client)
        {
            var query = new KeyedSearchQuery<int, Client>(client);
            _clients.Find(query);
            return query;
        }

        /// <summary>
        /// Производит поиск в базе данных банкомата, соответствующего входным данным.
        /// </summary>
        /// <param name="machine"> Банкомат, соответствия которому необходимо найти. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Machine> FindMachine(Machine machine)
        {
            var query = new KeyedSearchQuery<int, Machine>(machine);
            _machines.Find(query);
            return query;
        }

        /// <summary>
        /// Производит поиск в базе данных операции, соответствующей входным данным.
        /// </summary>
        /// <param name="operation"> Операция, соответствия которой необходимо найти. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Operation> FindOperation(Operation operation)
        {
            var query = new SearchQuery<Operation>(operation);
            _operations.Find(query);
            return query;
        }

        /// <summary>
        /// Производит поиск в базе данных процента, соответствующего входным данным.
        /// </summary>
        /// <param name="percent"> Процент, соответствия которому необходимо найти. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Percent> FindPercent(Percent percent)
        {
            var query = new SearchQuery<Percent>(percent);
            _percents.Find(query);
            return query;
        }
        
        /// <summary>
        /// Производит поиск в базе данных банкомата, соответствующего входным данным.
        /// </summary>
        /// <param name="cardNumber"> Номер карты искомого клиента. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Client> FindClient(int cardNumber)
        {
            return FindClient(new Client(cardNumber, "", ""));
        }

        /// <summary>
        /// Производит поиск в базе данных банкомата, соответствующего входным данным.
        /// </summary>
        /// <param name="machineNumber"> Номер банкомата, соответствия которому необходимо найти. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Machine> FindMachine(int machineNumber)
        {
            return FindMachine(new Machine(machineNumber, "", ""));
        }
        
        /// <summary>
        /// Производит поиск в базе данных операции, соответствующей входным данным.
        /// </summary>
        /// <param name="operationName"> Название операции. </param>
        /// <param name="cardNumber"> Номер карты, с которой произведена операция. </param>
        /// <param name="machineNumber"> Номер банкомата, на котором произведена операция. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Operation> FindOperation(string operationName, int cardNumber, int machineNumber)
        {
            return FindOperation(new Operation(operationName, cardNumber, machineNumber, 0));
        }

        /// <summary>
        /// Производит поиск в базе данных процента, соответствующего входным данным.
        /// </summary>
        /// <param name="operationName"> Название операции. </param>
        /// <param name="senderBank"> Название банка отправителя. </param>
        /// <param name="receiverBank"> Название банка получателя. </param>
        /// <returns> Результат запроса поиска, содержащий информацию
        /// о количестве сравнений и совпадение, если таковое найдено. </returns>
        public SearchQuery<Percent> FindPercent(string operationName, string senderBank, string receiverBank)
        {
            return FindPercent(new Percent(operationName, senderBank, receiverBank, 0));
        }
        
        /// <summary>
        /// Возвращает количество клиентов.
        /// </summary>
        /// <returns> Количество клиентов. </returns>
        public int ClientSize()
        {
            return _clients.Size();
        }

        /// <summary>
        /// Возвращает количество банкоматов.
        /// </summary>
        /// <returns> Количество банкоматов. </returns>
        public int MachineSize()
        {
            return _machines.Size();
        }

        /// <summary>
        /// Возвращает количество операций.
        /// </summary>
        /// <returns> Количество операций. </returns>
        public int OperationSize()
        {
            return _operations.Size();
        }
        
        /// <summary>
        /// Возвращает количество процентов.
        /// </summary>
        /// <returns> Количество процентов. </returns>
        public int PercentSize()
        {
            return _percents.Size();
        }
        
        /// <summary>
        /// Возвращает массив клиентов, доступных в базе данных.
        /// </summary>
        /// <returns> Массив клиентов. </returns>
        public Client[] ClientArray()
        {
            return _clients.ToArray();
        }

        /// <summary>
        /// Возвращает массив банкоматов, доступных в базе данных.
        /// </summary>
        /// <returns> Массив банкоматов. </returns>
        public Machine[] MachineArray()
        {
            return _machines.ToArray();
        }

        /// <summary>
        /// Возвращает массив операций, доступных в базе данных.
        /// </summary>
        /// <returns> Массив операций. </returns>
        public Operation[] OperationArray()
        {
            return _operations.ToArray();
        }

        /// <summary>
        /// Возвращает массив процентов, доступных в базе данных.
        /// </summary>
        /// <returns> Массив процентов. </returns>
        public Percent[] PercentArray()
        {
            return _percents.ToArray();
        }

        /// <summary>
        /// Возвращает хэш-функцию, используемую для таблицы клиентов данной базы данных.
        /// </summary>
        /// <returns> Хэш-функция клиентов. </returns>
        public HashFunction<int> ClientsFunction()
        {
            return _clients.Function;
        }
        
        /// <summary>
        /// Возвращает хэш-функцию, используемую для таблицы машин данной базы данных.
        /// </summary>
        /// <returns> Хэш-функция машин. </returns>
        public HashFunction<int> MachinesFunction()
        {
            return _machines.Function;
        }
        
        /// <summary>
        /// Производит проверку базы данных на целостность.
        /// </summary>
        /// <returns> Сообщение о причине нарушения целостности или отсутствия таковых. </returns>
        public Result Consistence()
        {
            Result result = new Result(false);
            int count = 0;
            if (_percents.Size() > 0 && _operations.Size() > 0)
            {
                foreach (Percent percent in _percents.ToArray())
                {
                    bool found = false;
                    foreach (Operation operation in _operations.ToArray())
                    {
                        if (percent.OperationName == operation.OperationName)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        count++;
                        result += "Процент с операцией " + percent.OperationName +
                                  " не соответствует ни одной операции\n";
                    }
                }
            }
            else if (_percents.Size() > 0 && _operations.Size() == 0)
            {
                count++;
                result += "Процент не может существовать без хотя бы одной операции\n";
            }

            result += "\n";

            if (_operations.Size() > 0 && _clients.Size() > 0)
            {
                foreach (Operation operation in _operations.ToArray())
                {
                    bool found = false;
                    foreach (Client client in _clients.ToArray())
                    {
                        if (operation.CardNumber == client.CardNumber)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        count++;
                        result += "Операция с номером карты " + operation.CardNumber + " не соответствует ни одному клиенту\n";
                    }
                }
            }
            else if (_operations.Size() > 0 && _clients.Size() == 0)
            {
                count++;
                result += "Операция не может существовать без хотя бы одного клиента\n";
            }

            result += "\n";

            if (_operations.Size() > 0 && _machines.Size() > 0)
            {
                foreach (Operation operation in _operations.ToArray())
                {
                    bool found = false;
                    foreach (Machine machine in _machines.ToArray())
                    {
                        if (operation.MachineNumber == machine.MachineNumber)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        count++;
                        result += "Операция с номером банкомата " + operation.MachineNumber +
                                  " не соответствует ни одному банкомату\n";
                    }
                }
            }
            else if (_operations.Size() > 0 && _machines.Size() == 0)
            {
                count++;
                result += "Операция не может существовать без хотя бы одного банкомата\n";
            }

            if (count == 0)
            {
                return new Result(true) + "База данных совместима";
            }

            return result;
        }

        /// <summary>
        /// Создает отчет об операциях, проведенных клиентом.
        /// </summary>
        /// <param name="client"> Клиент, операции которого попадут в отчет. </param>
        /// <returns> Отчет об операциях этого клиента, содержащий их количество и конкретные операции. </returns>
        public Report<Client, Operation> ClientOperationReport(Client client)
        {
            Report<Client, Operation> report = new Report<Client, Operation>(client, new ShellSorter<Operation>());
            if (_operations.Size() > 0)
            {
                foreach (Operation operation in _operations.ToArray())
                {
                    if (operation.CardNumber == client.CardNumber)
                    {
                        report.Add(operation);
                    }
                }
            }
            return report;
        }
        
        /// <summary>
        /// Создает отчет об операциях, проведенных этим банкоматом.
        /// </summary>
        /// <param name="machine"> Банкомат, операции которого попадут в отчет. </param>
        /// <returns> Отчет об операциях этого банкомата, содержащий их количество и конкретные операции. </returns>
        public Report<Machine, Operation> MachineOperationReport(Machine machine)
        {
            Report<Machine, Operation> report = new Report<Machine, Operation>(machine, new QuickStackSorter<Operation>());
            if (_operations.Size() > 0)
            {
                foreach (Operation operation in _operations.ToArray())
                {
                    if (operation.MachineNumber == machine.MachineNumber)
                    {
                        report.Add(operation);
                    }
                }
            }
            return report;
        }
        
        /// <summary>
        /// Создает отчет о процентах по указанному типу операций.
        /// </summary>
        /// <param name="operation"> Операция, проценты по которой попадут в отчет. </param>
        /// <returns> Отчет о процентах этой операции, содержащий их количество и конкретные операции. </returns>
        public Report<Operation, Percent> OperationPercentReport(Operation operation)
        {
            Report<Operation, Percent> report = new Report<Operation, Percent>(operation, new BubbleSorter<Percent>());
            if (_percents.Size() > 0)
            {
                foreach (Percent percent in _percents.ToArray())
                {
                    if (percent.OperationName == operation.OperationName)
                    {
                        report.Add(percent);
                    }   
                }
            }
            return report;
        }
        
        
        /// <summary>
        /// Создает отчет о процентах по операциям, проведенных этим банкоматом.
        /// </summary>
        /// <param name="machine"> Банкомат, проценты по операциям которого попадут в отчет. </param>
        /// <returns> Отчет о процентах по операциям этого банкомата, содержащий их количество и конкретные операции. </returns>
        public Report<Machine, Percent> MachinePercentReport(Machine machine)
        {
            Report<Machine, Percent> report = new Report<Machine, Percent>(machine, new QuickLastSorter<Percent>());
            if (_percents.Size() > 0 && _operations.Size() > 0)
            {
                foreach (Operation operation in _operations.ToArray())
                {
                    if (operation.MachineNumber == machine.MachineNumber)
                    {
                        foreach (Percent percent in _percents.ToArray())
                        {
                            if (percent.OperationName == operation.OperationName && percent.ReceiverBank != machine.BankName)
                            {
                                report.Add(percent);
                            }
                        }
                    }
                }
            }
            return report;
        }
    }
}