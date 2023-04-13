using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dolphin : Animal, ISwimmingAnimal
    {
        private string verse;

        public Dolphin(string _name, AnimalsDietList _diet, string _verse)
        {
            Name = _name;
            this.Diet = _diet;
            this.verse = _verse;
        }
        public override void recall()=> Console.WriteLine($"my verse is:  {verse}");
       

        public void Swim() => Console.WriteLine("I'm a Swimming Animal!");
    }
}
