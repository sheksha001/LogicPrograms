using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_LogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString rs = new ReverseString();
            rs.GetReverseString();
            Console.WriteLine("-------------------------------------------------------------------------------\n");

            rs.GetReverseWords();
            Console.WriteLine("-------------------------------------------------------------------------------\n");

            rs.GetStringCount();
            Console.WriteLine("-------------------------------------------------------------------------------\n");

            rs.GetString_CharactorTypes();
            Console.WriteLine("-------------------------------------------------------------------------------\n");



            ReverseNumber rn = new ReverseNumber();
            rn.GetReverseNumber();
            Console.WriteLine("-------------------------------------------------------------------------------\n");
           
            rn.Swaaping();
            Console.WriteLine("-------------------------------------------------------------------------------\n");
            
            rn.Febananic();
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Diamond dd = new Diamond();
            dd.DispalyDiamond();
            Console.WriteLine("-------------------------------------------------------------------------------\n");


            Console.ReadLine();
        }

    }
       
}
