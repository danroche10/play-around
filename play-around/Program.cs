class MainClass
{
    static void Main()
    {
        float a = (float)(1.0 / 81);
        float b = 0;
        for (int i = 0; i < 729; ++i)
            b += a;
        Console.WriteLine(b);


        double c = 1.0 / 81;
        double d = 0;
        for (int i = 0; i < 729; ++i)
            d += c;
        Console.WriteLine(d);
    }


}