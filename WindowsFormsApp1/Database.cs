using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Database
    {
        private static Database _instance;

        private HashMap<int, Client> _clients;
        private HashMap<int, Machine> _machines;
        private Tree<Operation> _operations;
        private Tree<Percent> _percents;

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

        public static Database GetNewInstance()
        {
            _instance = new Database();
            return _instance;
        }
        
        private Database()
        {
            _percents = new Tree<Percent>();
            _operations = new Tree<Operation>();
            _machines = new HashMap<int, Machine>(new ModFunction(), new ListStorage<int, Machine>());
            ModFunction function = new ModFunction();
            _clients = new HashMap<int, Client>(function, new DoubleHashStorage<int, Client>(new OddFunction(), function));
        }

        public void Save(string filePath)
        {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);  
            formatter.Serialize(stream, this);  
            stream.Close();  
        }

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
        
        public bool RemoveClient(Client client)
        {
            return _clients.Remove(client);
        }

        public bool RemoveMachine(Machine machine)
        {
            return _machines.Remove(machine);
        }

        public bool RemoveOperation(Operation operation)
        {
            return _operations.Remove(operation);
        }

        public bool RemovePercent(Percent percent)
        {
            return _percents.Remove(percent);
        }
        
        public string FindClient(Client client)
        {
            return _clients.Find(client);
        }

        public string FindMachine(Machine machine)
        {
            return _machines.Find(machine);
        }

        public string FindOperation(Operation operation)
        {
            return _operations.Find(operation);
        }

        public string FindPercent(Percent percent)
        {
            return _percents.Find(percent);
        }
        
        public int ClientSize()
        {
            return _clients.Size();
        }

        public int MachineSize()
        {
            return _machines.Size();
        }

        public int OperationSize()
        {
            return _operations.Size();
        }

        public int PercentSize()
        {
            return _percents.Size();
        }
        
        public Client[] ClientArray()
        {
            return _clients.ToArray();
        }

        public Machine[] MachineArray()
        {
            return _machines.ToArray();
        }

        public Operation[] OperationArray()
        {
            return _operations.ToArray();
        }

        public Percent[] PercentArray()
        {
            return _percents.ToArray();
        }

        public HashFunction<int> ClientsFunction()
        {
            return _clients.Function;
        }
        
        public HashFunction<int> MachinesFunction()
        {
            return _machines.Function;
        }
        
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
                        if (percent.OperationType == operation.OperationType)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        count++;
                        errors += "Процент с операцией " + percent.OperationType +
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
        
        public Report<Operation, Percent> OperationPercentReport(Operation operation)
        {
            Report<Operation, Percent> report = new Report<Operation, Percent>(operation, new BubbleSorter<Percent>());
            if (_percents.Size() > 0)
            {
                foreach (Percent percent in _percents.ToArray())
                {
                    if (percent.OperationType == operation.OperationType)
                    {
                        report.Add(percent);
                    }   
                }
            }
            return report;
        }
        
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
                            if (percent.OperationType == operation.OperationType && percent.ReceiverBank != machine.BankName)
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