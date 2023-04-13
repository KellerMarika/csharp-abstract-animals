using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    //possible diet
    public enum AnimalsDietList 
    {vegetarian, carnivorous, omnivorous, insectivorous, piscivorous}

    internal abstract class Animal:IAnimal
    {
        public string Name { get; set;}

        private AnimalsDietList diet;
        public AnimalsDietList Diet { get => diet; set => diet = value; }

        public void Sleep()
        {
            Console.WriteLine("ZZZzzzz....  now I'm sleepeng, come back later!");
        }

        public abstract void recall();

        public void Eat()
        {
            string food = diet switch
            {
                AnimalsDietList.vegetarian => "vegetables",
                AnimalsDietList.carnivorous=> "meat",
                AnimalsDietList.insectivorous=> "insects",
                AnimalsDietList.piscivorous=> "fishes",
                AnimalsDietList.omnivorous=>"all",
               _ => "unknown"
            };
            Console.WriteLine($"I am {diet}! feed me with {food}!");
        }
    }
}