using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99._02_CommadLineParms
{
    class Program
    {
        static void Main(string[] args)

        {
            if ( args.Length < 1 )
            {
                Console.WriteLine("Go on ...");
             
            }
            else
            {
                string param1 = args[0];
                switch (param1)
                {
                    case "/?":
                        Console.WriteLine("Help ...");
                        break;
                    default:
                        Console.WriteLine("No known params ...");
                        break;
                }

            }
        }
    }
}

// - lektor
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_ComandLine
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            foreach (string item in args)
//            {
//                switch (item)
//                {
//                    case "/?":
//                        Console.WriteLine("Help"); break;
//                    case "/d":
//                        Console.WriteLine(DateTime.Now.ToLongDateString()); break;
//                    case "/t":
//                        Console.WriteLine(DateTime.Now.ToLongTimeString()); break;
//                    default:
//                        Console.WriteLine("Unknown parameter");
//                        break;
//                }
//            }


//        }
//    }
//}

