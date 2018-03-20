namespace Iterator.Iterator
{
    public class ArrayIterator : IIterator
    {
        public int _current { get; set; }
        public string[] _array { get; set; }

        public ArrayIterator(string [] array)
        {
            _current = 0;
            _array = array;
        }

        public string CurrentItem()
        {
            return _array[_current];
        }

        public string GetFirst()
        {
            return _array[0];
        }

        public bool IsDone()
        {
            return _current >= _array.Length ? true : false;
        }

        public int Next()
        {
           return _current = _current + 1;
        }

        public void SetFirst(string item)
        {
            _array[0] = item;
        }
    }
}
