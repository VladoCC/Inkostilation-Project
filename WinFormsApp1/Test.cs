namespace WinFormsApp1
{
    public class Test : Element
    {
        private int num;

        public Test(int num)
        {
            this.num = num;
        }

        public int Num => num;

        public int Compare(Element elem)
        {
            Test test = (Test) elem;
            return num - test.Num;
        }
    }
}