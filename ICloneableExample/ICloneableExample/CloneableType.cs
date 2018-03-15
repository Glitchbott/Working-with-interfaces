using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
  public abstract class CloneableType
    {
        //только производные типы могут поддерживать этот интерфейс.
        public abstract object Clone();
        public interface ICloneable
        {
            object Clone();
        }
       
    }
}
