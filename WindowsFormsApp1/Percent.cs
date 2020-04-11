using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Percent: IElement
    {
        private int _operationType;
        private string _senderBank;
        private string _receiverBank;
        private int _percent;

        public Percent(int operationType, string senderBank, string receiverBank, int percent)
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

        public string SenderBank => _senderBank;

        public string ReceiverBank => _receiverBank;

        public int Percent1 => _percent;
    }
}