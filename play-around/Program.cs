delegate void MeDelegate();

class MainClass
{
    static void Main()
    {
        MeDelegate d = Foo;
        d += Goo;
        d += Sue;
        d -= Foo;
        d += Foo;
        foreach(MeDelegate m in d.GetInvocationList())
        {
            Console.WriteLine(m.Target + ": " + m.Method);
        }
        d();
    }
    static void Foo() { Console.WriteLine("Foo()"); }
    static void Goo() { Console.WriteLine("Goo()"); }
    static void Sue() { Console.WriteLine("Sue()"); }
}