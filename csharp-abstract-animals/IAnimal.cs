using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{

    public interface IAnimal
    {
        //species name
        public string Name { get; set; }
        public AnimalsDietList Diet { get; set; }
        public void Sleep();
        public abstract void recall();
        public void Eat();
    }
}
