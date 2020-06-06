using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Функция, определяющая хэш делением.
    /// </summary>
    [Serializable]
    public class ModFunction: HashFunction<int>
    {
        public override int Hash(int key)
        {
            return key % GetStorageSize();
        }
    }
}