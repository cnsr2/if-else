using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("ilk sayıyı girin.");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("ikinci sayıyı girin.");
             int b = Convert.ToInt32(Console.ReadLine());

                 if(a>b)
                 {
                     Console.WriteLine(a +">" +b);
                 }
                 else if(a<b)
                 {
                     Console.WriteLine(a +"<"+ b);
                
                 }
                 else
                 {
                     Console.WriteLine(a +"="+ b);
                 }
    













        }
    }
}
