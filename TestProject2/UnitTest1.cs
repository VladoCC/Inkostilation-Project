using System;
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
            Client client1 = new Client(17, 1, "sidorov");
            Client client2 = new Client(33, 2, "petrov");
            Client client3 = new Client(49, 3, "ivanov");
            Client client4 = new Client(4, 4, "smirnov");
            HashMap<int, Client> map = new HashMap<int, Client>(new ModFunction(16),
                new DoubleHashStorage<int, Client>(new OddFunction(16)));
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
            Client client1 = new Client(17, 1, "sidorov");
            Client client2 = new Client(33, 2, "petrov");
            Client client3 = new Client(49, 3, "ivanov");
            Client client4 = new Client(4, 4, "smirnov");
            HashMap<int, Client> map = new HashMap<int, Client>(new ModFunction(10),
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
            HashMap<int, Client> map = new HashMap<int, Client>(new ModFunction(16),
                new DoubleHashStorage<int, Client>(new OddFunction(16)));
            for (int i = 0; i < 20; i++)
            {
                Client client = new Client(i, i, "name" + i);
                map.Add(client);
            }
            Assert.AreEqual(20, map.Size());
        }
    }
}