using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayı1, sayı2;
            
            sayı1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ikinci sayı");
            sayı2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sayılarımız:{0},{1}", sayı1, sayı2);
            Console.WriteLine(sayı1 + " " + sayı2);
            Console.WriteLine("çarpım: {0}", sayı1*sayı2);
            Console.ReadLine();

        }
    }
}
