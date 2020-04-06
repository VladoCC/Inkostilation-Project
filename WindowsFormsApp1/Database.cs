﻿using System;
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
            if (_instance == null || filePath != null)
            {
                _instance = new Database(filePath);
            }
            return _instance;
        }

        public static Database GetNewInstance()
        {
            _instance = new Database(null);
            return _instance;
        }
        
        private Database(string filePath)
        {
            if (filePath != null)
            {
                //TODO load from file
            }
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