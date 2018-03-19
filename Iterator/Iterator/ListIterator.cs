using System;
using System.Collections.Generic;

namespace Iterator.Iterator
{
    public class ListIterator : IIterator
    {
        private int _current { get; set; }
        private List<string> _list { get; set; }

        public ListIterator(List<string> list)
        {
            _current = 0;
            _list = list;
        }

        public string CurrentItem()
        {
            return _list[_current];
        }

        public string GetFirst()
        {
            return _list[0];
        }

        public bool IsDone()
        {
            return _current >= _list.Count ? true : false;
        }

        public int Next()
        {
            return _current = _current + 1;
        }

        public void SetFirst(string item)
        {
            _list[0] = item;
        }
    }
}
