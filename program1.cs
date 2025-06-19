using System.Data;

namespace Yeni2;

/*class Program1
{
    static void Main(string[] args)
    {
        int a = 5;
        float b = a;
        Console.WriteLine(b);
    }
}
*/

//Explicit
/*
class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ondalıklı bir sayı girermisin ? ");
        double x = Convert.ToDouble(Console.ReadLine());
        int y = (int)Math.Round(x);
        bool? isXGreater;
        if (Math.Round(x) == x)
        {
            isXGreater = null;
        }
        else
        {
            isXGreater = (y >= x);
        }

        if (isXGreater == true)
        {
            Console.WriteLine("Yukarı yuvarlanmış");
        }
        else if (isXGreater == null)
        {
            Console.WriteLine("Tamsayı bu");
        }
        else
        {
            Console.WriteLine("Aşağı yuvarlanmış");
        }
        Console.WriteLine("Yuvarlanmış Olduğu Sayı " + y + " Çıkmıştır");
    }
}
*/

/*
class Program1
{
    static void Main(string[] args)
    {
        Console.Write("1 ile 10 arasında bir sayı gir : ");
        int girilenSayi = Convert.ToInt32(Console.ReadLine());
        bool b = girilenSayi == 1 || girilenSayi == 2 || girilenSayi == 3 || girilenSayi == 4 || girilenSayi == 5 || girilenSayi == 6 || girilenSayi == 7 || girilenSayi == 8 || girilenSayi == 9 || girilenSayi == 10;
        if (b)
        {
            bool dogruSayi = girilenSayi == 5 || girilenSayi == 7;
            if (dogruSayi)
            {
                Console.WriteLine("JACKPOOOT");
            }
            else
            {
                Console.WriteLine("Yazııık Olduuu");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz Tekrar Dene");
            Environment.Exit(0);
        }

    }
}
*/
class Program1
{
    static void Main(string[] args)
    {
        Console.Write("1 - 65536 arasında bir sayı gir: ");
        int a = Convert.ToInt32(Console.ReadLine());
        char ch = (char)a;
        bool b = a >= 0 && a <= 65535;
        if (b)
        {
            Console.WriteLine("Bunu Girdin : " + ch);
        }
        else
        {
            Console.WriteLine("Yanlışş Tekrar dene");
            Environment.Exit(0);
        }
        Console.ReadKey();
    }
}
