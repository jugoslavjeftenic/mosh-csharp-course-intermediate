namespace t04_06_InheritanceExercise_Stack
{
    public class Stack
    {
        private object[] _items;
        private int _top;

        public Stack()
        {
            _items = new object[10];
            _top = -1;
        }

        public void Push(object obj)
        {
            if (_top == _items.Length - 1) { Array.Resize(ref _items, _items.Length * 2); }

            _items[++_top] = obj ?? throw new InvalidOperationException("Can't push null to the stack.");
        }

        public object Pop()
        {
            if (_top == -1) { throw new InvalidOperationException("The stack is empty."); }

            object poppedItem = _items[_top];
            _items.SetValue(null, _top);
            _top--;

            return poppedItem;
        }

        public void Clear()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                _items.SetValue(null, i);
            }

            Array.Resize(ref _items, 10);
            _top = -1;
        }
    }
}