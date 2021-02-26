using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_LogicPrograms
{
    class ReverseNumber
    {
        public void GetReverseNumber()
        {
            int n = 123456, rem = 0, rev = 0;
            Console.WriteLine("Given Number : " + n);

            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse Number : " + rev);
        }

        public void Swaaping()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int temp = 0;


            ////------ Thired Variable ---------//
            //temp = a; //10
            //a = b; //20
            //b = temp; //10

            ////-----------  +,-  ---------------//
            //a = a + b; //30
            //b = a - b;  //10
            //a = a - b; //30-10=20

            ////-----------  *,/ ----------------//
            //a = a * b; //200
            //b = a / b;  //  200/20=10
            //a = a / b; //200/10=20


            //----------- 3 Numbers  ---------------//
            a = a + b + c;  // 60
            b = a - (b + c);  // 60-(20+30) =10
            c = a - (b + c); // 60-10+30 =20
            a = a - (b + c); // 60-(10+20)=30


            Console.WriteLine("A Value:" + a);
            Console.WriteLine("B Value : " + b);
            Console.WriteLine("C Value : " + c);

        }

        internal void Febananic()
        {
            Console.WriteLine("Febanaic length: 10");

            int a = 0, b = 1, result = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(result + " ");
                result = a + b;
                a = b;
                b = result;
            }

        }
    }
}
