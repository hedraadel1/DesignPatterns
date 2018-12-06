using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRoad.PrototypeDesignPattern
{
    
        public class Head : ICloneable
        {
            public int Number { get; set; }
            public string Name { get; set; }


            public void Display()
            {
                Console.WriteLine("I have {0} {1} ", Number, Name);
            }

            #region ICloneable Members
            //create a shallow copy of current object 
            public object Clone()
            {
                return this.MemberwiseClone();
            }

            #endregion
        
    }
}
