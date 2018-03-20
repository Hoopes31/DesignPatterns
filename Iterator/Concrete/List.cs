using System;
using System.Collections.Generic;
using Iterator.Iterator;

namespace Iterator.Items_to_iterate
{
    public class ListItem : IIteratorItem
    {
        List<string> _list { get; set; }

        public ListItem()
        {
            _list = new List<string>()
            {
                "list item_1",
                "list item_2",
                "list item_3"
            };
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(_list);
        }
    }
}
