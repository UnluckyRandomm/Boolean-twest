class Nigger
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