public class ImplementQueuUsingStackProblem
{
    public class MyQueue
    {
        private readonly Stack<int> _main;
        private readonly Stack<int> _aux;

        public MyQueue()
        {
            _main = new Stack<int>();
            _aux = new Stack<int>();
        }

        public void Push(int x)
        {
            _main.Push(x);
        }

        public int Pop()
        {
            CopyMainToAuxWhenAuxEmpty();

            return _aux.Pop();
        }

        public int Peek()
        {
            CopyMainToAuxWhenAuxEmpty();

            return _aux.Peek();
        }

        public bool Empty()
        {
            return (_aux.Count + _main.Count) == 0;
        }

        private void CopyMainToAuxWhenAuxEmpty()
        {
            if (_aux.Count > 0)
                return;
            
            while (_main.Count > 0)
                _aux.Push(_main.Pop());
        }
    }

}

