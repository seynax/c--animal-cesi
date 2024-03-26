using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            this.name = "Wolf";
        }

        public override void cry()
        {
            Console.WriteLine("Arou Arou !");
        }

        public void eat(Animal animal)
        {
            Console.WriteLine(this.name + " eat " + animal.name);
        }
    }
}
