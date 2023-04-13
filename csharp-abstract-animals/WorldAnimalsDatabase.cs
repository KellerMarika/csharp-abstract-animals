using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class WorldAnimalsDatabase
    {
      private List<Animal> animalsList;
        public List<Animal> AnimalsList { get => animalsList;}


        public WorldAnimalsDatabase()
        {
            animalsList = new List<Animal>();
        }
        public void addAnimal(Animal a)=> animalsList.Add(a);

        public void addAnimal(List <Animal> aList)
        {
            foreach(var a in aList)
            {
                animalsList.Add(a);
            }
        }
          
        public void MakeSwim(ISwimmingAnimal a)=> a.Swim();
        public void MakeFly(IFlyngAnimal a)=> a.Fly();      
        
        //non te lo faccio neanche vedere quanto me la stavo complicando la vita
    }
}
