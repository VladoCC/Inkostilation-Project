using NUnit.Framework;
using WinFormsApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
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
            Assert.Pass();
        }
    }
}