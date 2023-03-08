using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Class1
    {
        private static void l1()
        {
            Console.WriteLine("please Enter the User Name :");
            string username = Console.ReadLine();
            int val = username.Length;
            Console.WriteLine("the lenght " + val);
            if (username.Length > 3)
            {
                Console.WriteLine("Hello " + username + " ,How are you?");
                Console.WriteLine("Hello {0} {1} {2} ,How are you?", username, "azarr", "Afridi");


            }
            else
            {
                Console.WriteLine("invalid name");
            }
        }
        public static void l2()
        {
            l1();
        }
    }
}
