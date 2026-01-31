using System;

class GeometryGuru
{
    static void Main()
    {
        Console.WriteLine("GeometryGuru dasturiga xush kelibsiz!");
        Console.WriteLine("1. Kvadrat yuzasini topish");
        Console.WriteLine("2. Aylana yuzasini topish");
        Console.Write("Iltimos, tanlovni kiriting (1 yoki 2): ");

        string tanlov = Console.ReadLine();

        if (tanlov == "1")
        {
            Console.Write("Kvadrat tomoni (a) ni kiriting: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double yuzasi = a * a;
            Console.WriteLine("Kvadrat yuzasi: " + yuzasi);
        }
        else if (tanlov == "2")
        {
            Console.Write("Aylana radiusini (r) kiriting: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double yuzasi = 3.14 * r * r;
            Console.WriteLine("Aylana yuzasi: " + yuzasi);
        }
        else
        {
            Console.WriteLine("Xato tanlov! Iltimos 1 yoki 2 ni kiriting.");
        }
    }
}
