using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRoad.PrototypeDesignPattern
{
   
        public class Animal : ICloneable
        {

            public Head AHead { get; set; }
            public List<Leg> Legs { get; set; }
            public Tail ATail { get; set; }
            public string Name { get; set; }

            public Animal()
            {
                AHead = new Head();
                Legs = new List<Leg>();
                ATail = new Tail();
            }

            public Animal(Animal aAnimal)
            {
                Name = aAnimal.Name;
                AHead = (Head)aAnimal.AHead.Clone();

                Legs = new List<Leg>();
                foreach (Leg aLeg in aAnimal.Legs)
                {
                    Legs.Add((Leg)aLeg.Clone());
                }
                ATail = (Tail)aAnimal.ATail.Clone();
            }

            public void Dispaly()
            {

                Console.WriteLine("I am a " + Name);
                AHead.Display();
                foreach (Leg aleg in Legs)
                {
                    aleg.Display();
                }
                ATail.Display();
                Console.WriteLine();
            }

            #region ICloneable Members
            //Perform deep coy
            public object Clone()
            {
                return new Animal(this);
            }

            #endregion
        
    }
}
