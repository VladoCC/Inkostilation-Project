using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Percent: IElement
    {
        private int _operationType;
        private int _senderBank;
        private int _receiverBank;
        private int _percent;

        public Percent(int operationType, int senderBank, int receiverBank, int percent)
        {
            _operationType = operationType;
            _senderBank = senderBank;
            _receiverBank = receiverBank;
            _percent = percent;
        }

        public int Compare(IElement elem)
        {
            Percent percent = (Percent) elem;
            string key = _operationType + " " + _senderBank + " " + _receiverBank;
            string otherKey = percent._operationType + " " + percent._senderBank + " " + percent._receiverBank;
            return String.Compare(key, otherKey, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            string result = "Operation type: " + _operationType + "\nSender: " + _senderBank + "\nReceiver: "
                            + _receiverBank + "\nPercent: " + _percent + "%";
            return result;
        }

        public int OperationType => _operationType;

        public int SenderBank => _senderBank;

        public int ReceiverBank => _receiverBank;

        public int Percent1 => _percent;
    }
}