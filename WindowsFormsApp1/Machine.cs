using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class Machine: IKeyedElement<int>
    {
        private int _machineNumber;
        private string _address;
        private string _bankName;

        public Machine(int machineNumber, string address, string bankName)
        {
            _machineNumber = machineNumber;
            _address = address;
            _bankName = bankName;
        }

        public int GetKey()
        {
            return _machineNumber;
        }

        public int Compare(IElement elem)
        {
            Machine machine = (Machine) elem;
            return _machineNumber - machine._machineNumber;
        }

        public int MachineNumber => _machineNumber;

        public string Address => _address;

        public string BankName => _bankName;
    }
}