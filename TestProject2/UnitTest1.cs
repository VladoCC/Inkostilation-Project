using System;
using System.IO;
using WindowsFormsApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TreeSizeTest()
        {
            Tree<Test> tree = new Tree<Test>();
            tree.Add(new Test(5));
            tree.Add(new Test(2));
            tree.Add(new Test(3));
            tree.Add(new Test(-1));
            tree.Add(new Test(1));
            tree.Add(new Test(0));
            tree.Add(new Test(-2));
            tree.Remove(new Test(2));
            Test[] tests = tree.ToArray();
            Assert.AreEqual(6, tests.Length);
        }

        [TestMethod]
        public void DoubleHashMapSameSlotTest()
        {
            Client client1 = new Client(17, "1", "sidorov");
            Client client2 = new Client(33, "2", "petrov");
            Client client3 = new Client(49, "3", "ivanov");
            Client client4 = new Client(4, "4", "smirnov");
            HashMap<int, Client> map = new HashMap<int, Client>(new ModFunction(),
                new DoubleHashStorage<int, Client>(new OddFunction()));
            map.Add(client1);
            map.Add(client2);
            map.Add(client3);
            map.Add(client4);
            Assert.AreEqual(4, map.Size());
            map.Remove(client2);
            Assert.AreEqual(3, map.Size());
        }
        
        [TestMethod]
        public void ListHashMapSameSlotTest()
        {
            Client client1 = new Client(17, "1", "sidorov");
            Client client2 = new Client(33, "2", "petrov");
            Client client3 = new Client(49, "3", "ivanov");
            Client client4 = new Client(4, "4", "smirnov");
            HashMap<int, Client> map = new HashMap<int, Client>(new ModFunction(),
                new ListStorage<int, Client>());
            map.Add(client1);
            map.Add(client2);
            map.Add(client3);
            map.Add(client4);
            Assert.AreEqual(4, map.Size());
            map.Remove(client2);
            Assert.AreEqual(3, map.Size());
        }
        
        [TestMethod]
        public void DoubleHashMapFillingTest()
        {
            HashMap<int, Client> map = new HashMap<int, Client>(new ModFunction(),
                new DoubleHashStorage<int, Client>(new OddFunction()));
            for (int i = 0; i < 20; i++)
            {
                Client client = new Client(i, "" + i, "name" + i);
                map.Add(client);
            }
            Assert.AreEqual(20, map.Size());
        }
        
        [TestMethod]
        public void F5F9Test()
        {
            if (File.Exists("test.bin"))    
            {    
                File.Delete("test.bin");  
            }

            Database database = Database.GetNewInstance();
            
            Client client1 = new Client(17, "1", "sidorov");
            Client client2 = new Client(33, "2", "petrov");
            database.AddClient(client1);
            database.AddClient(client2);
            
            Machine machine1 = new Machine(1, "test1", "b1");
            Machine machine2 = new Machine(2, "test2", "b2");
            Machine machine3 = new Machine(3, "test3", "b3");
            database.AddMachine(machine1);
            database.AddMachine(machine2);
            database.AddMachine(machine3);
            
            Operation operation = new Operation("1", 1, 1, 1);
            database.AddOperation(operation);
            
            database.Save("test.bin");
            Database instance = Database.GetInstance("test.bin");
            
            if (File.Exists("test.bin"))    
            {    
                File.Delete("test.bin");  
            }
            
            Assert.AreEqual(1, instance.OperationSize());
            Assert.AreEqual(2, instance.ClientSize());
            Assert.AreEqual(3, instance.MachineSize());
            Assert.AreEqual(0, instance.PercentSize());
        }
    }
}