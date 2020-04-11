using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Client: IKeyedElement<int>
    {
        private int _cardNumber;
        private string _bankName;
        private string _name;

        public Client(int cardNumber, string bankName, string name)
        {
            _cardNumber = cardNumber;
            _bankName = bankName;
            _name = name;
        }

        public int GetKey()
        {
            return _cardNumber;
        }

        public int Compare(IElement elem)
        {
            Client client = (Client) elem;
            return _cardNumber - client._cardNumber;
        }

        public int CardNumber => _cardNumber;

        public string BankName => _bankName;

        public string Name => _name;
    }
}