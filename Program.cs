namespace Yeni2;

//class Program
//{
// static void Main(string[] args)
// {
// const string dogruDeger = "Ambata";

// Console.Write("Sayı Lütfen: ");
//int girilenSayi = Convert.ToInt32(Console.ReadLine());
//if (girilenSayi % 2 == 0)
//{
// Console.WriteLine("Çift Sayı");
// }
//else
//{
//Console.WriteLine("Tek Sayı");
// }

// Console.ReadKey();



//}
//}

//class Program
//{
    //static void Main(string[] args)
   // {
       // Console.Write("Cevap Gir (zencigöt mü yoksa dreamybull mu?): ");
       // string cevap = Console.ReadLine().ToLower();

       // if (cevap == "dreamybull")
      //  {
           // Console.WriteLine("Doğru!!!");
       // }
       // else if (cevap == "zencigöt")
       // {
            //Console.WriteLine("Yanlışşş!!!!");
       // }
        //else
        //{
           // Console.WriteLine("Cevap Geçersiz");
        //}
    //}
//}

class Program
{
    static void Main(string[] args)
    {
        const string dogruDeger = "ambata";
        Console.Write("Gir : ");
        string girilenSayi = Console.ReadLine().ToLower();
        bool sonuc = (girilenSayi == dogruDeger);
        if (sonuc)
        {
            Console.Write("Veee Devamm : ");
            string dogruDeger2 = Console.ReadLine();
            if (dogruDeger2.ToLower() == "bust" || dogruDeger2.ToLower() == "cum")
            {
                   
                Console.WriteLine("Doğru Cevap zenci");
            }
            else
            {
                Console.WriteLine("Yanlış ÖLLL");
                Environment.Exit(0);
            }
        }
        else
        {
            Console.WriteLine("Yanlış Yapmayı Seviyon Anladığım Kadarıyla ÖLLLL!!!!");
            Environment.Exit(0);
        }


    }
}   