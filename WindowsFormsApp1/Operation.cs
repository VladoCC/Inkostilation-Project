using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class Operation: IElement
    {
        private int _operationType;
        private int _cardNumber;
        private int _machineNumber;
        private int _sum;

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
    }
}