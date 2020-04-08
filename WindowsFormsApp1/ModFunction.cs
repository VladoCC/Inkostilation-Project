using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    [Serializable]
    public class ModFunction: HashFunction<int>
    {
        public override int Hash(int key)
        {
            return key % GetStorageSize();
        }
    }
}