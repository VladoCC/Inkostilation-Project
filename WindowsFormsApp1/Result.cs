namespace WindowsFormsApp1
{
    /// <summary>
    /// Позволяет возвращать результат выполнения действия, содержащий информацию об успешности и описание события.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Описывает успешно ли действие
        /// </summary>
        private bool _success;
        /// <summary>
        /// Дает более подробное описание призошедшего события.
        /// </summary>
        private string _message = "";

        /// <summary>
        /// Конструктор для результата. 
        /// </summary>
        /// <param name="success"> Предпологаемая успешность действия. </param>
        public Result(bool success)
        {
            _success = success;
        }

        /// <summary>
        /// Добавляет дополнительную информацию о событии.
        /// </summary>
        /// <param name="message"> Дополнительная информация. </param>
        public void AddMessage(string message)
        {
            _message += message + "\n";
        }

        /// <summary>
        /// Публичный геттер и сеттер для успешности результата.
        /// </summary>
        public bool Success
        {
            get => _success;
            set => _success = value;
        }

        /// <summary>
        /// Публичный геттер и сеттер для описания результата.
        /// </summary>
        public string Message
        {
            get => _message;
        }
        
        /// <summary>
        /// Позволяет добавлять информацию к результату при помощи операции сложения.
        /// </summary>
        /// <param name="result"> Результат, к которому добавляется информация. </param>
        /// <param name="info"> Информация для добавления </param>
        /// <returns></returns>
        public static Result operator +(Result result, string info)
        {
            result.AddMessage(info);
            return result;
        }
        
        /// <summary>
        /// Оператор, позволяющий использовать результат в логических выражениях 
        /// </summary>
        /// <param name="result"> Результат для преобразования. </param>
        /// <returns> Логическое значение. </returns>
        public static bool operator true(Result result)
        {
            return result._success;
        }
        
        /// <summary>
        /// Оператор, позволяющий использовать результат в логических выражениях 
        /// </summary>
        /// <param name="result"> Результат для преобразования. </param>
        /// <returns> Логическое значение. </returns>
        public static bool operator false(Result result)
        {
            return !result._success;
        }
        
        /// <summary>
        /// Оператор, позволяющий использовать результат в логических выражениях 
        /// </summary>
        /// <param name="result"> Результат для преобразования. </param>
        /// <returns> Логическое значение. </returns>
        public static bool operator !(Result result)
        {
            return !result._success;
        }
    }
}