using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hellow C# ");            // this is console print function

            string fullname;                             // difine variable and assined name to the variable as fullname 
            fullname = Console.ReadLine();               // input the fullname variable using ReadLine() function

            Console.Write("\n hello " + fullname);       // print hellow statement in console and fullname that enteried

            Console.ReadKey();                           //Console ReadKey() function to stop console to see the output

        }
    }
}
