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

        //int long falan

        /*  Console.WriteLine("En Büyük İnteger: {0}", int.MaxValue);
          Console.WriteLine("En Küçük İnteger: {0}", int.MinValue);
          Console.WriteLine("En Büyük long: {0}", long.MaxValue);
          Console.WriteLine("En Küçük long: {0}", long.MinValue);*/
        //random ahh int 0_o
        //int x = 666;

        //double - decimal falan :D

        /* Console.WriteLine("En Büyük Double değeri: {0}",double.MaxValue);
         Console.WriteLine($"En Büyük Decimal Num: {decimal.MaxValue}");
         Console.WriteLine($"Garip Sayı {x}");
        decimal pi0 = 3.141592M;
        Console.WriteLine("Random Ahh Decimal {0}",pi0);
        double pi = 3.14159265359;
        double idk = 3.12412545451;
        Console.WriteLine("Lütfen Bir Butona Basın Toplama için: ");
        Console.ReadKey();
        Console.WriteLine("Hepsinin Toplamı = {0}",
            pi + x + idk);*/

        //float falan anladımmı beni ha 
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();

        Console.Write("Lütfen bir ondalıklı sayı girin: ");
        decimal sayi1 = decimal.Parse(Console.ReadLine());
        Console.Write("Lütfen ikinci ondalıklı sayıyı girin: ");
        decimal sayi2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("İkisinin toplamı: {0}",
            sayi1 + sayi2);
        Console.WriteLine("Ve decimal max tan çıkarılmış hali: {0}",
            decimal.MaxValue - (sayi1 + sayi2));
        Console.WriteLine("Devam Etmek İçin bir butana bas");
        Console.ReadKey();
        Console.Clear();
        Console.Write("Lütfen 1 ile 20 arasında bir sayı gir (ondalıklı): ");
        double x = double.Parse(Console.ReadLine());
        double z = Math.Truncate(x);
        bool y = x >= 1 || x <= 20;
        bool ts = x == z;
        if (y)
        {
            if (ts)
            {
                Console.WriteLine("Ondalıklı Dedim !!!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Girdiğin Sayı: {x}, ve türü: {x.GetType}");
            }
        }
        else if (ts && y){
            Console.WriteLine("Ne Diyon Oluuum");
        }

        else
        {
            Console.WriteLine("Geçersiz Sayı");
            Environment.Exit(0);
        }
        Console.ReadKey();


                




    }
}