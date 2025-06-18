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
class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayı Girermisin ? ");
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