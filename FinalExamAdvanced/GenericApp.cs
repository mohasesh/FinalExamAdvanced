using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinalExamAdvanced
{
   public  class GenericApp<T> where T:IEnumerable
    {
        private T mylist { get; set; }
        GenericApp<ArrayList> m = new GenericApp<ArrayList>();
        
    }
}
