using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** A First at Interface ***\n");
            //Все эти классы поддерживают интерфейс Cloneable
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();
            // они могут быть переданы методу,принимающему ICloneable
            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);

            Console.ReadLine();

             void CloneMe(ICloneable c)
            {
                //клонировать то что получено и вывести
                object theClone = c.Clone();
                Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
            }

        }
    }
}
