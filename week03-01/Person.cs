using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03_01
{
   public  class Person
    {
        //Private instance Var
       private string _name;

        //public properties 
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }

        }

    }
}
