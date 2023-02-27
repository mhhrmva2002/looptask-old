using System.ComponentModel.Design;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double reqem = 0;
            double tersreqem = 0;
            double  qaliq = 0;
            while ( reqem > 0)
            {
               if ( reqem == tersreqem) 
                {
                    qaliq = reqem % 10;
                    reqem = (reqem - qaliq) / 10;
                    tersreqem = tersreqem * 10 + qaliq;
                }
                
            }
            Console.WriteLine(true);
        



        }
    }
}