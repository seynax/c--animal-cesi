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
            this.Name = "Wolf";
        }

        public Wolf(string name)
        {
            this.name = name;
        }

        public override void cry()
        {
            Console.WriteLine("Arou Arou !");
        }

        public void eat(Animal animal)
        {
            Console.WriteLine(this.Name + " eat " + animal.Name);
        }
    }
}
