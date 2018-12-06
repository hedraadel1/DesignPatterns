﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRoad.PrototypeDesignPattern;

namespace TheRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elizabeth starts building her first animal
            Animal firstAnimal = new Animal();

            firstAnimal.Name = "Deer";
            //work on head
            firstAnimal.AHead.Name = "Antlers";
            firstAnimal.AHead.Number = 2;

            Leg leftLeg = new Leg();
            leftLeg.Side = "Left";
            leftLeg.Name = "Hoove";

            Leg rightLeg = new Leg();
            rightLeg.Side = "Right";
            rightLeg.Name = "Hoove";

            firstAnimal.Legs.Add(leftLeg);
            firstAnimal.Legs.Add(rightLeg);

            firstAnimal.ATail.Color = "Brown";


            //Elizabeth copied the firstAnimal(prototype)
            Animal copiedAnimal = (Animal)firstAnimal.Clone();

            Console.WriteLine("Display the first animal");
            firstAnimal.Dispaly();

            Console.WriteLine("Display the copied animal");
            copiedAnimal.Dispaly();

            //play aroud with the 
            copiedAnimal.Name = "Copied Deer";
            copiedAnimal.AHead.Name = "Antlers";
            copiedAnimal.AHead.Number = 1;

            Animal secondCopy = (Animal)copiedAnimal.Clone();
            secondCopy.Name = "An other copy";



            Console.WriteLine("Display the copied animal after some play. Elizabeh only made 1 antler for it");
            copiedAnimal.Dispaly();

            Console.WriteLine("Display the original prototype");
            firstAnimal.Dispaly();

            secondCopy.Dispaly();
            Console.Read();
        }
    }
}
