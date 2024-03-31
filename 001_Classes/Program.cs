namespace _001_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SomeClass a = new SomeClass("Первый");
            SomeClass b = new SomeClass("Второй");

            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);
            Console.ReadKey();
        }
    }

    public class SomeClass
    {
        public string Name => _name;
        private string _name;

        public SomeClass(string name)
        {
            _name = name;
        }


    }
}