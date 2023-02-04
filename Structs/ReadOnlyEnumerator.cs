namespace Structs
{
    //code sample taken from : https://blogs.msdn.microsoft.com/seteplia/2018/03/07/the-in-modifier-and-the-readonly-structs-in-c/
    internal class ReadOnlyEnumerator
    {
        //private  readonly List<int>.Enumerator _enumerator;
        private List<int>.Enumerator _enumerator;

        public ReadOnlyEnumerator(List<int> list)
        {
            _enumerator = list.GetEnumerator();
        }

        public void PrintTheFirstElement()
        {
            _enumerator.MoveNext();
            Console.WriteLine(_enumerator.Current);
        }

    }

}
