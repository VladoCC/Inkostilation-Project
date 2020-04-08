using System;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    [Serializable]
    public class OddFunction: HashFunction<int>
    {
        public override int Hash(int key)
        {
            return key % (GetStorageSize() - 1) / 2 * 2 + 1;
        }
    }
}