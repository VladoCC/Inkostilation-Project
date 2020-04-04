using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class Machine: IKeyedElement<int>
    {
        private int _machineNum;
        private string _address;
        private string _bankName;
        
        public int GetKey()
        {
            return _machineNum;
        }

        public int Compare(IElement elem)
        {
            Machine machine = (Machine) elem;
            return _machineNum - machine._machineNum;
        }
    }
}