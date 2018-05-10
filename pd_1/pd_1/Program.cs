using System;

namespace pd_1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //1
            string ievade;

            Console.WriteLine("ludzu ievadi vardu uzvardu");
            ievade = Console.ReadLine();
            Console.WriteLine("jus sauc " + ievade);
            


            //2

            int c;
            int a;
            int b;

            Console.WriteLine("Kads ir gads ?");

            

            string ievada = Console.ReadLine();
            a = Convert.ToInt16(ievada);
            
            
            Console.WriteLine("Kads ir tavs dzimsanas gads ?");

            

            string ievadu = Console.ReadLine();
            b = Convert.ToInt16(ievadu);
           
            c = a - b;
            Console.WriteLine("tevi ir " + c);

            //3
            Console.WriteLine("ievadi rinka linijas radiusu ");
            string radius = Console.ReadLine();
            int t = Convert.ToInt16(radius);
            int diametrs;
            double linijasg;
            diametrs = t + t;
            linijasg = 2 * 3.14 * t;
            Console.WriteLine("tavs linijas laukums ir " + linijasg + "tavs diametrs ir " + diametrs);
            //4
            string z;
            Console.WriteLine("ievadi skaitli");
            z = Console.ReadLine();
            Console.WriteLine("tavs skaitlis ir"+ z);

            //5

            //6
            
            Console.WriteLine("velies sasveicinaties ? ");
            string atbilde = Console.ReadLine();
            if (atbilde == "ja")
            {
                Console.WriteLine("ludzu ievadi vardu uzvardu");
                atbilde = Console.ReadLine();
                Console.WriteLine("jus sauc " + atbilde);

            }
            else
            {
                if (atbilde == "ne")
                { Console.WriteLine("zheel gan "); }
                else
                { Console.WriteLine("tadu atbilzu nav"); }
            }
                    
                    
                    
            

                

            Console.ReadLine();
        }


            
        
    }
}
