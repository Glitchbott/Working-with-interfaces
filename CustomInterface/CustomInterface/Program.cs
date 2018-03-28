using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointy p = new IPointy(); //ошибка на этапе коомпиляции
        }
    }
}
