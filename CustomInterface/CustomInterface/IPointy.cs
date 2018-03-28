using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
  public  interface IPointy
    {
        
        byte GetNumberOfPonts();
        //Свойства достпун для чтения и записи
        retVal PropName { get; set; }

        // только для записи
        retVal PropName { set; }
        byte Points { get; }
    }
}
