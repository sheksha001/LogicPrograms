using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console_LogicPrograms
{
    class ReverseString
    {
        public void GetReverseString()
        {
            string name = "Vali";
            string rev = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                rev += name[i].ToString();
            }

            //int len = name.Length - 1;
            //while (len >= 0)
            //{
            //    rev += name[len].ToString();
            //    len--;
            //}
            Console.WriteLine("Given String : " + name);
            Console.WriteLine("Reverse String : " + rev);

        }


        public void GetReverseWords()
        {
            string name = "Sheksha Vali";  //-->O/P: Vali Sheksha 
            string rev = "";

            // reverse the Word 
           //  rev = string.Join(" ", name.Split(' ').Reverse());
            string[] ar = name.Split(' ').Reverse().ToArray();
            for (int i = 0; i <= ar.Length - 1; i++)
            {
                rev += ar[i] + " ";
            }


            // reverse the Word  string  //-->O/P:  ahskehS ilaV 
            string res = string.Join(" ", name.Split(' ').Select(s => new String(s.Reverse().ToArray())));

            Console.WriteLine("Given Words : " + name);
            Console.WriteLine("Reverse Words : " + rev);
            Console.WriteLine("Reverse String Words : " + res);
        }


        public void GetStringCount()
        {
            string name = "Sheksha Vali".ToUpper();  //-->O/P: S=2, H=1,E=1,......
            int count = 0;

            Console.WriteLine("Given String : " + name);

            while (name.Length > 0)
            {
                count = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[0] == name[i])
                        count++;
                }
                Console.WriteLine(name[0] + ": " + count);
                name = name.Replace(name[0].ToString(), "");
             }
        }


        public void GetString_CharactorTypes()
        {
            string name = "Sheksha Vali @ 12345 #";  //-->O/P: Alpha=10, num=2, specChar=1,
            int chars = 0, nums = 0, speChars = 0, spaces=0;

            for (int i = 0; i < name.Length; i++)
            {
                char cc = name[i];

                //if (cc >= 97 && cc <= 122 || cc >= 65 && cc <= 90)
                 if (cc >= 'a' && cc <= 'z' || cc >= 'A' && cc <= 'Z')
                    chars ++;
                else if (cc >= '0' && cc <= '9')
                    nums++;
                else if (cc == ' ')
                    spaces++;
                else 
                    speChars++;
            }
            Console.WriteLine("Given String : " + name);
            Console.WriteLine(" Charactors: " + chars);
            Console.WriteLine(" Numbers: " + nums);
            Console.WriteLine(" Specia Symbols: " + speChars);
            Console.WriteLine(" Spaces: " + spaces);

        }

    }
}
