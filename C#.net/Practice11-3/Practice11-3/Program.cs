﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_3
{
    public abstract class Animal
    {
        abstract public void Eat();
    }
    public class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Lion eat meet");
        }
    }
    public class Elephant : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Elephant eat vegetation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lion objLion = new Lion();
            Elephant objElephant = new Elephant();
            Animal[] zoo = new Animal[2];
            zoo[0] = objLion;
            zoo[1] = objElephant;
            foreach (Animal animal in zoo)
            {
                animal.Eat();
            }
            Console.ReadKey();
        }
    }
}
