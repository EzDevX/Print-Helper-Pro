using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintHelperPro;

namespace Tester
{
    class Program
    {


        static void Main(string[] args)
        {
            PrintEngine MyPrintEngine = new PrintEngine();
            string Input = @"D:\Personals\Docs\Samples\pdf\sample5.pdf";
            string Output = @"D:\Personals\Docs\TestFile\here.pdf";

            try
            {

                MyPrintEngine.Test(Input, Output);
                Console.WriteLine("Done!");

            }
            catch(Exception ex)
            {
                Console.WriteLine("Test Failed!");
                Console.WriteLine(ex);
            }

            Console.WriteLine("Press any Key To continue ...");
            Console.ReadKey();

        }
    }
}
