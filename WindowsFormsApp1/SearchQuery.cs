using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class SearchQuery<T> where T: IElement
    {
        protected T _request;
        private int _counter = 0;
        private T _result;

        public SearchQuery(T request)
        {
            _request = request;
        }

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

        public void Count()
        {
            _counter++;
        }

        public int Counter => _counter;

        public T Result => _result;

        public bool Found()
        {
            return _result != null;
        }
    }
}