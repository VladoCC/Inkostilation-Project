using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class Client: IKeyedElement<int>
    {
        private int _cardNumber;
        private int _bankNumber;
        private string _name;
        
        public int GetKey()
        {
            return _cardNumber;
        }

        public int Compare(IElement elem)
        {
            Client client = (Client) elem;
            return _cardNumber - client._cardNumber;
        }
    }
}