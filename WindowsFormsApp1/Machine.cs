using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    ///\extends IKeyedElement<int>
    /// <summary>
    /// Класс, описывающий банкомат. Обладает ключом типа int.
    /// </summary>
    [Serializable]
    public class Machine: IKeyedElement<int>
    {
        /// <summary>
        /// Номер банкомата.
        /// Целое число от 1 до 500 включительно.
        /// </summary>
        private int _machineNumber;
        /// <summary>
        /// Адрес банкомата.
        /// Строка букв русского алфавита без пробелов и других дополнительных символов,
        /// длиной не более 20 символов, начинающаяся с заглавной буквы (остальные строчные).
        /// </summary>
        private string _address;
        /// <summary>
        /// Название обслуживающего банка.
        /// Строка букв русского алфавита, без пробелов и других дополнительных символов,
        /// длиной не более 20 символов, начинающаяся с заглавной буквы.
        /// </summary>
        private string _bankName;

        /// <summary>
        /// Основной конструктор для создания банкомата.
        /// </summary>
        /// <param name="machineNumber"> Номер банкомата. </param>
        /// <param name="address"> Адрес банкомата. </param>
        /// <param name="bankName"> Название обслуживающего банка. </param>
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

        /// <summary>
        /// Публичный геттер для номера банкомата.
        /// </summary>
        public int MachineNumber => _machineNumber;

        /// <summary>
        /// Публичный геттер для адреса банкомата.
        /// </summary>
        public string Address => _address;

        /// <summary>
        /// Публичный геттер для названия обслуживающего банка.
        /// </summary>
        public string BankName => _bankName;
    }
}