using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dog : Animal
    {

        private string verse;
        public string Verse { get=>verse; set=> verse=value; }
        public Dog(string _name, AnimalsDietList _diet, string _verse) {
            Name = _name;
            this.Diet = _diet;
            this.verse= _verse;
        }
        public override void recall() => Console.WriteLine($"my verse is: {verse}");
    }
}
