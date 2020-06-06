using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    ///\extends IKeyedElement<int>
    /// <summary>
    /// Класс, описывающий клиента банковской системы. Обладает ключом типа int.
    /// </summary>
    [Serializable]
    public class Client: IKeyedElement<int>
    {
        /// <summary>
        /// Номер карты клиента.
        /// Целое число от 1 до 99999999 включительно.
        /// </summary>
        private int _cardNumber;
        /// <summary>
        /// Название обслуживающего банка.
        /// Строка букв русского алфавита, без пробелов и других дополнительных символов,
        /// длиной не более 20 символов, начинающаяся с заглавной буквы.
        /// </summary>
        private string _bankName;
        /// <summary>
        /// Имя клиента.
        /// Строка букв русского алфавита, в которой могут присутствовать разделительные символы,
        /// длиной не более 40 символов, начинающаяся с заглавной буквы.
        /// </summary>
        private string _name;

        /// <summary>
        /// Основной конструктор для создания клиента.
        /// </summary>
        /// <param name="cardNumber"> Номер карты клиента. </param>
        /// <param name="bankName"> Название обслуживающего банка. </param>
        /// <param name="name"> Имя клиента. </param>
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

        /// <summary>
        /// Публичный геттер для номера карты.
        /// </summary>
        public int CardNumber => _cardNumber;

        /// <summary>
        /// Публичный геттер для названия обслуживающего банка.
        /// </summary>
        public string BankName => _bankName;

        /// <summary>
        /// Публичный геттер для имени клиента.
        /// </summary>
        public string Name => _name;
    }
}