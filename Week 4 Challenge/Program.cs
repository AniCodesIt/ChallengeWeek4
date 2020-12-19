using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dolphin dolphin = new Dolphin();
            Dodo dodo = new Dodo();
        }
    }
    public abstract class Animal
    {
        public abstract void WhatsMySound();
        public abstract bool Extinct
        {
            get; set;
        }
        public abstract bool Mammal
        {
            get; set;
        }
        public abstract bool Carnivore
        {
            get; set;
        }
        public abstract bool HasWings
        {
            get; set;
        }
        public abstract bool HasFins
        {
            get; set;
        }
        public abstract int NumberOfLegs
        {
            get; set;
        }
    }

    public class Cat : Animal
    {
        public override void WhatsMySound()
        {
            Console.WriteLine("Meow");
        }

        public override bool Carnivore
        {
            get { return true; }
            set { }
        }
        public override bool Mammal
        {
            get { return true; }
            set { }
        }
        public override bool HasWings
        {
            get { return false; }
            set { }
        }
        public override bool HasFins
        {
            get { return false; }
            set { }
        }
        public override int NumberOfLegs
        {
            get { return 4; }
            set { }
        }

        public override bool Extinct
        {
            get { return false; }
            set { }
        }
    }
    public class Dolphin : Animal
    {
        public override bool Extinct
        {
            get { return false; }
            set { }
        }
        public override bool Mammal
        {
            get { return false; }
            set { }
        }
        public override bool Carnivore
        {
            get { return true; }
            set { }
        }
        public override bool HasWings
        {
            get { return false; }
            set { }
        }
        public override bool HasFins
        {
            get { return true; }
            set { }
        }
        public override int NumberOfLegs
        {
            get { return 0; }
            set { }

        }


        public override void WhatsMySound()
        {
            Console.WriteLine("Eee! Eee!");
        }
    }
    public class Dodo : Animal
    {
        public override bool Extinct
        {
            get { return true; }
            set { }
        }
        public override bool Mammal
        {
            get { return false; }
            set { }
        }
        public override bool Carnivore
        {
            get { return false; }
            set { }
        }
        public override bool HasWings
        {
            get {return true;}
            set{}
        }
        public override bool HasFins 
        { 
            get { return false; }
            set { }
        }
        public override int NumberOfLegs 
        { 
            get { return 2; }
            set { }
        }

        public override void WhatsMySound()
        {
            Console.WriteLine("Sqwack!");
        }
    }
}





