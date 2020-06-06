using System;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Структура, предоставляет информацию о размере хранилища данных, для объектов,
    /// не имеющих доступа к самому хранилищу данных.
    /// Экранирует это данное от внешних изменений, при этом предоставляя в любой момент
    /// актуальную информацию о размере.
    /// </summary>
    [Serializable]
    public class SizeContainer
    {
        /// <summary>
        /// Числовое представление размера хранилища данных.
        /// </summary>
        private int _size;

        /// <summary>
        /// Конструктор, создающий контейнер для числового данного.
        /// </summary>
        /// <param name="size"> Числовое представление размера. </param>
        public SizeContainer(int size)
        {
            _size = size;
        }

        /// <summary>
        /// Публичный геттер и сеттер для размера хранилища данных.
        /// </summary>
        public int Size
        {
            get => _size;
            set => _size = value;
        }
    }
}