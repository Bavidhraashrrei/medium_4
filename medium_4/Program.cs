using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medium_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emply = new Employee();
            emply.Insert_emply_details();
            emply.PrintEmployee_elder();
            Console.ReadKey();

        }
    }
}
