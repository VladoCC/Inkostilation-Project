using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Класс, описывающий процент по операции.
    /// </summary>
    [Serializable]
    public class Percent: IElement
    {
        /// <summary>
        /// Название операции.
        /// Cтрока букв русского алфавита без пробелов и других дополнительных символов,
        /// длиной не более 20 символов, начинающаяся с заглавной буквы (остальные строчные).
        /// </summary>
        private string _operationName;
        /// <summary>
        /// Название банка отправителя.
        /// Строка букв русского алфавита, без пробелов и других дополнительных символов,
        /// длиной не более 20 символов, начинающаяся с заглавной буквы.
        /// </summary>
        private string _senderBank;
        /// <summary>
        /// Название банка получателя.
        /// Строка букв русского алфавита, без пробелов и других дополнительных символов,
        /// длиной не более 20 символов, начинающаяся с заглавной буквы.
        /// </summary>
        private string _receiverBank;
        /// <summary>
        /// Процент по операции.
        /// Целое число от 0 до 100 включительно.
        /// </summary>
        private int _percent;

        /// <summary>
        /// Основной конструктор для создания процента по операции.
        /// </summary>
        /// <param name="operationName"></param>
        /// <param name="senderBank"></param>
        /// <param name="receiverBank"></param>
        /// <param name="percent"></param>
        public Percent(string operationName, string senderBank, string receiverBank, int percent)
        {
            _operationName = operationName;
            _senderBank = senderBank;
            _receiverBank = receiverBank;
            _percent = percent;
        }
        
        public int Compare(IElement elem)
        {
            Percent percent = (Percent) elem;
            string key = _operationName + " " + _senderBank + " " + _receiverBank;
            string otherKey = percent._operationName + " " + percent._senderBank + " " + percent._receiverBank;
            return String.Compare(key, otherKey, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            string result = "Operation type: " + _operationName + "\nSender: " + _senderBank + "\nReceiver: "
                            + _receiverBank + "\nPercent: " + _percent + "%";
            return result;
        }

        /// <summary>
        /// Публичный геттер для названия операции.
        /// </summary>
        public string OperationName => _operationName;

        /// <summary>
        /// Публичный геттер для названия банка отправителя.
        /// </summary>
        public string SenderBank => _senderBank;

        /// <summary>
        /// Публичный геттер для названия банка получателя.
        /// </summary>
        public string ReceiverBank => _receiverBank;

        /// <summary>
        /// Публичный геттер для процента по операции.
        /// </summary>
        public int Percent1 => _percent;
    }
}