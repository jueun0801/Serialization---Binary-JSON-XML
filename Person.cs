using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._4_Serialization
{
    [Serializable] //dont forget this
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }    
        public string Phone { get; set; }
        
    }
}
