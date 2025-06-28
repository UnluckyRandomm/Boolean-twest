/*class Nigger
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen Bir ondalıklı Sayı girin: ");
        double x = Convert.ToDouble(Console.ReadLine());
        int y = Convert.ToInt32(x);
        Console.WriteLine("Girdiğin Sayı = " + y);
        bool? z;
        if (x == y)
        {
            z = null;
        }
        else if (x > y)
        {
            z = true;
        }
        else
        {
            z = false;
        }
        if (z == true)
        {
            Console.WriteLine("Aşağıya Yuvarlanmıştır");
        }
        else if (z == null)
        {
            Console.WriteLine("Girilen Sayı bir Ondalıklı Ssayı değildir");
        }
        else
        {
            Console.WriteLine("Yukarıya Yuvarlanmıştır");
        }
        Console.ReadKey();

    }
}
*/
/*
class Mango{
    static void Main(string[] args)
    {
        Console.Write("Bir Ondalıklı Sayı Girin: ");
        double x = Convert.ToDouble(Console.ReadLine());
        int y = Convert.ToInt32(x);
        bool isDecimal = x != y;
        if(isDecimal){
            Console.WriteLine("Yuvarlanmış hali: " + y);
            bool isGreater = x  >  y;
            if(isGreater){
                Console.WriteLine("Aşağıya Yuvarlanmıştır");
            }
            else{
                Console.WriteLine("Yukarıya Yuvarlanmıştır");
            }
            bool isCharrable = y>= 0 && y<=65535;
            if(isCharrable){
                char ch = (char)y;
                Console.WriteLine("Character Budur: " + ch);
            }
            else{
                Console.WriteLine("Chara Çevrilemez");
            }
        }
        else{
            Console.WriteLine("Girdiğiniz Sayı Bir ondalıklı sayı değildir!!!");
        }


        Console.ReadKey();
    }
}
*/

/*
using System.Threading.Channels;

class Mango
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Write("İlk Dik Kenarı gir: ");
        double a = Convert.ToDouble(Console.ReadLine());
        bool isValid1 = a >= 0;
        if (!isValid1)
        {
            Console.WriteLine("Bir kenar negatif olamaz");
            Environment.Exit(0);
        }
        else
        {
            Console.Write("İkinci Dik Kenarı Gir: ");
            double b = Convert.ToDouble(Console.ReadLine());
            bool isValid2 = b >= 0;
            if (!isValid2)
            {
                Console.WriteLine("Bir kenar negatif olamaz");
                Environment.Exit(0);
            }
            else
            {
                double a2 = Math.Pow(a, 2);
                double b2 = Math.Pow(b, 2);
                double c2 = a2 + b2;
                double c = Math.Sqrt(c2);
                Console.WriteLine($"Hipotenüs: {c}");
            }
        }
        Console.ReadKey();
    }
}
*/
using System.Security.Cryptography.X509Certificates;

class Mango
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.ResetColor();
        /*  Console.WriteLine("En Büyük İnteger: {0}", int.MaxValue);
          Console.WriteLine("En Küçük İnteger: {0}", int.MinValue);
          Console.WriteLine("En Büyük long: {0}", long.MaxValue);
          Console.WriteLine("En Küçük long: {0}", long.MinValue);*/
        int x = 666;

        Console.WriteLine("En Büyük Double değeri: {0}", double.MaxValue);
        Console.WriteLine($"En Büyük Decimal Num: {decimal.MaxValue}");
        Console.WriteLine($"Garip Sayı {x}");
        Console.Write("Lütfen Bir Butona Basın: ");
        Console.ReadKey();

    }
}