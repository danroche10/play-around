class Program
{
    static void Main()
    {
        DerivedClass derivedClass = new DerivedClass();
        derivedClass.MyMethod();

    }
    abstract class VeryBaseClass
    {
        public abstract int MyMethod();
    }
    class BaseClass : VeryBaseClass
    {
        public override int MyMethod()
        {
            Console.WriteLine("test");
            return 5;
        }
    }

    class DerivedClass : BaseClass
    {
        public override int MyMethod()
        {
            Console.WriteLine("MyMethod in DerivedClass");
            return 5;
        }
    }
}
