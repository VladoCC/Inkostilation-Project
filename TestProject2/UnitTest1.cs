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
        public void HashMapTest()
        {
            
        }
    }
}