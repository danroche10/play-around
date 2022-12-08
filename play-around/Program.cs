namespace SOLID_PRINCIPLES.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.foo();
        }

        public int foo()
        {
            return foo();
        }

    }
}