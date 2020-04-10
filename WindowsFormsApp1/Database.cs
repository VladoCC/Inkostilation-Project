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
        
        private HashMap<int, Client> _clients = new HashMap<int, Client>(new ModFunction(), new DoubleHashStorage<int, Client>(new OddFunction()));
        private HashMap<int, Machine> _machines = new HashMap<int, Machine>(new ModFunction(), new ListStorage<int, Machine>());
        private Tree<Operation> _operations = new Tree<Operation>();
        private Tree<Percent> _percents = new Tree<Percent>();

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
        }

        public void Save(string filePath)
        {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);  
            formatter.Serialize(stream, this);  
            stream.Close();  
        }

        public void AddClient(Client client)
        {
            _clients.Add(client);
        }

        public void AddMachine(Machine machine)
        {
            _machines.Add(machine);
        }

        public void AddOperation(Operation operation)
        {
            _operations.Add(operation);
        }

        public void AddPercent(Percent percent)
        {
            _percents.Add(percent);
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
        
        public string Consistence()
        {
            string errors = "";
            int count = 0;
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
                    errors += "Percent with operation type " + percent.OperationType + " not matching any operation\n";
                }
            }

            errors += "\n";

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
                    errors += "Operation with card number " + operation.CardNumber + " not matching any client\n";
                }
            }

            errors += "\n";

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
                    errors += "Operation with machine number " + operation.MachineNumber +
                              " not matching any machine\n";
                }
            }

            if (count == 0)
            {
                return "Database is consistent";
            }

            return errors;
        }
        
        
    }
}