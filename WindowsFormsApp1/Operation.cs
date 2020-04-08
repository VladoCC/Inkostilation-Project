using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Operation: IElement
    {
        private int _operationType;
        private int _cardNumber;
        private int _machineNumber;
        private int _sum;

        public Operation(int operationType, int cardNumber, int machineNumber, int sum)
        {
            _operationType = operationType;
            _cardNumber = cardNumber;
            _machineNumber = machineNumber;
            _sum = sum;
        }

        public int Compare(IElement elem)
        {
            Operation operation = (Operation) elem;
            string key = _operationType + " " + _cardNumber + " " + _machineNumber;
            string otherKey = operation._operationType + " " + operation._cardNumber + " " + operation._machineNumber;
            return String.Compare(key, otherKey, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            string result = "Type: " + _operationType + "\nCard: " + _cardNumber + "\nMachine: " + _machineNumber
                            + "\nSum: " + _sum;
            return result;
        }

        public int OperationType => _operationType;

        public int CardNumber => _cardNumber;

        public int MachineNumber => _machineNumber;

        public int Sum => _sum;
    }
}