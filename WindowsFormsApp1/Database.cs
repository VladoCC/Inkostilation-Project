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
        public static Database GetInstance(string filePath = null)
        {
            if (filePath != null)
            {
                IFormatter formatter = new BinaryFormatter();  
                Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);  
                _instance = (Database) formatter.Deserialize(stream);  
                stream.Close();  
            }
            else if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
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
        public void Save(string filePath)
        {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);  
            formatter.Serialize(stream, this);  
            stream.Close();  
        }

        /// <summary>
        /// Добавляет клиента в базу данных, если это не нарушает целостность базы данных.
        /// </summary>
        /// <param name="client"> Клиент для добавления. </param>
        /// <returns> Сообщение об успешном добавлении или о проблеме целостности. </returns>
        public string AddClient(Client client)
        {
            _clients.Add(client);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string AddMachine(Machine machine)
        {
            _machines.Add(machine);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string AddOperation(Operation operation)
        {
            _operations.Add(operation);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string AddPercent(Percent percent)
        {
            _percents.Add(percent);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string RemoveClient(Client client)
        {
            _clients.Remove(client);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string RemoveMachine(Machine machine)
        { 
            _machines.Remove(machine);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string RemoveOperation(Operation operation)
        {
            _operations.Remove(operation);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string RemovePercent(Percent percent)
        {
            _percents.Remove(percent);
            string con = Consistence();
            if (con != "База данных совместима")
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
        public string Consistence()
        {
            string errors = "";
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
                        errors += "Процент с операцией " + percent.OperationName +
                                  " не соответствует ни одной операции\n";
                    }
                }
            }
            else if (_percents.Size() > 0 && _operations.Size() == 0)
            {
                count++;
                errors += "Процент не может существовать без хотя бы одной операции\n";
            }

            errors += "\n";

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
                        errors += "Операция с номером карты " + operation.CardNumber + " не соответствует ни одному клиенту\n";
                    }
                }
            }
            else if (_operations.Size() > 0 && _clients.Size() == 0)
            {
                count++;
                errors += "Операция не может существовать без хотя бы одного клиента\n";
            }

            errors += "\n";

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
                        errors += "Операция с номером банкомата " + operation.MachineNumber +
                                  " не соответствует ни одному банкомату\n";
                    }
                }
            }
            else if (_operations.Size() > 0 && _machines.Size() == 0)
            {
                count++;
                errors += "Операция не может существовать без хотя бы одного банкомата\n";
            }

            if (count == 0)
            {
                return "База данных совместима";
            }

            return errors;
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
        /// Создает отчет о процентах по операциям, проведенныи этим банкоматом.
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