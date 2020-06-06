using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Поисковый запрос, предостаавляющий возможности сравнения проверяемого элемента с искомым,
    /// который считает количество проверок.
    /// </summary>
    /// <typeparam name="T"> Тип данных для поиска. </typeparam>
    public class SearchQuery<T> where T: IElement
    {
        /// <summary>
        /// Искомое данное.
        /// </summary>
        protected T _request;
        /// <summary>
        /// Счетчик количества проверок.
        /// </summary>
        private int _counter = 0;
        /// <summary>
        /// Результирующее данное, соответсвующее искомому.
        /// </summary>
        private T _result;

        /// <summary>
        /// Конструктор, позволяющий создать поисковый запрос.
        /// </summary>
        /// <param name="request"> Искомое данное. </param>
        public SearchQuery(T request)
        {
            _request = request;
        }

        /// <summary>
        /// Проверка элемента на соответствие искомому.
        /// При совпадении сохраняет проверяемое данной в качестве результирующего.
        /// </summary>
        /// <param name="check"> Проверяемое данное. </param>
        /// <returns> Отрицательное число, если этот элемент меньше, чем поступающий на вход.
        /// Ноль, если элементы равны. Положительное число, если этот элемент больше,
        /// чем поступающий на вход. </returns>
        public int Check(T check)
        {
            _counter++;
            if (check == null)
            {
                return -1;
            }
            int cmp = check.Compare(_request);
            if (cmp  == 0)
            {
                _result = check;
            }
            return cmp;
        }

        /// <summary>
        /// Позволяет увелиить значение счетчика без проведения сравнений.
        /// </summary>
        public void Count()
        {
            _counter++;
        }

        /// <summary>
        /// Публичный геттер для количества проверок.
        /// </summary>
        public int Counter => _counter;

        /// <summary>
        /// Публичный геттер для результирующего данного.
        /// </summary>
        public T Result => _result;

        /// <summary>
        /// Сообщает найден ли элемент, соответствующий искомому.
        /// </summary>
        /// <returns> True, если элемент найден, false в ином случае. </returns>
        public bool Found()
        {
            return _result != null;
        }
    }
}