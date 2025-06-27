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