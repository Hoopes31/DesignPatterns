using Iterator.Iterator;

namespace Iterator.Items_to_iterate
{
    public class ArrayItem : IIteratorItem
    {
        private string[] _things;
        public ArrayItem()
        {
            _things = new[]
            {
                "array thing_1",
                "array thing_2",
                "array thing_3"
            };
        }

        public IIterator CreateIterator()
        {
            return new ArrayIterator(_things);
        }
    }
}
