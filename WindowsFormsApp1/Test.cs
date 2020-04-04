using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Test : IElement
    {
        private int num;

        public Test(int num)
        {
            this.num = num;
        }

        public int Num => num;

        public int Compare(IElement elem)
        {
            Test test = (Test)elem;
            return num - test.Num;
        }
    }
}