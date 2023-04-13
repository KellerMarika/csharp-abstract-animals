using System.Security.Cryptography;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dog a1 = new Dog("canis familiaris", AnimalsDietList.carnivorous, "Wof wof!");
            Dolphin a2 = new Dolphin("Delphinus delphis", AnimalsDietList.piscivorous, "mordo le bambine");
            Eagle a3= new Eagle("Aquila chrysaetos", AnimalsDietList.carnivorous, "kaka kaka!");
            Sparrow a4 = new Sparrow ("Passer domesticus", AnimalsDietList.insectivorous, "cip cip!");

            WorldAnimalsDatabase db = new WorldAnimalsDatabase();

            db.addAnimal(a1);
            List<Animal> AnimalsList = new List<Animal>() { a2, a3, a4 };
            db.addAnimal(AnimalsList);

            db.AnimalsList.ForEach

                (a =>
                {
                    Console.WriteLine(a.Name);
                    a.recall();
                    a.Eat();
                    a.Sleep();
                    Console.WriteLine("...................");
                });


            MakeSwim(a2);
            MakeFly(a3);
            void MakeSwim(ISwimmingAnimal a) => a.Swim();
            void MakeFly(IFlyngAnimal a) => a.Fly();


            db.MakeFlyAll();

        }

        
    }
}