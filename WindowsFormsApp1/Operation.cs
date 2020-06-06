using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Класс, описывающий банковскую операцию.
    /// </summary>
    [Serializable]
    public class Operation: IElement
    {
        /// <summary>
        /// Название операции.
        /// Cтрока букв русского алфавита без пробелов и других дополнительных символов,
        /// длиной не более 20 символов, начинающаяся с заглавной буквы (остальные строчные).
        /// </summary>
        private string _operationName;
        /// <summary>
        /// Номер карты клиента.
        /// Целое число от 1 до 99999999 включительно.
        /// </summary>
        private int _cardNumber;
        /// <summary>
        /// Номер банкомата.
        /// Целое число от 1 до 500 включительно.
        /// </summary>
        private int _machineNumber;
        /// <summary>
        /// Сумма операции.
        /// Целое число от 0 до 10000000 включительно.
        /// </summary>
        private int _sum;

        /// <summary>
        /// Основной конструктор для создания банковской операции.
        /// </summary>
        /// <param name="operationName"></param>
        /// <param name="cardNumber"></param>
        /// <param name="machineNumber"></param>
        /// <param name="sum"></param>
        public Operation(string operationName, int cardNumber, int machineNumber, int sum)
        {
            _operationName = operationName;
            _cardNumber = cardNumber;
            _machineNumber = machineNumber;
            _sum = sum;
        }

        public int Compare(IElement elem)
        {
            Operation operation = (Operation) elem;
            string key = _operationName + " " + _cardNumber + " " + _machineNumber;
            string otherKey = operation._operationName + " " + operation._cardNumber + " " + operation._machineNumber;
            return String.Compare(key, otherKey, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            string result = "Type: " + _operationName + "\nCard: " + _cardNumber + "\nMachine: " + _machineNumber
                            + "\nSum: " + _sum;
            return result;
        }

        /// <summary>
        /// Публичный геттер для названия операции.
        /// </summary>
        public string OperationName => _operationName;

        /// <summary>
        /// Публичный геттер для номера карты.
        /// </summary>
        public int CardNumber => _cardNumber;

        /// <summary>
        /// Публичный геттер для номера банкомата.
        /// </summary>
        public int MachineNumber => _machineNumber;

        /// <summary>
        /// Публичный геттер для суммы операции.
        /// </summary>
        public int Sum => _sum;
    }
}