using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._03._22_dz
{
    interface Herbivore
    {
        void Eat_Grass();
    }
    interface Carnivore
    {
        void Eat(Herbivore herbivore);
    }
    class Wildebeest : Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; }
        public Wildebeast(int weight)
        {
            Weight = weight;
            Life = true;
        }
        public void Eat_Grass()
        {
            Weight+=10;
        }
    }
    class Bison : Herbivore
    {
        public int Weight { get; set;}
        public bool Life { get; set;}
        public Bison(int weight)
        {
            Weight = weight;
            Life= true;
        }
        public void Eat_Grass()
        {
            Weight+=10;
        }
    }
    class Lion : Carnivore
    {
        public int Power;
        public Lion(int power)
        {
            Power = power;
        }
        public void Eat(Herbivore wildebeast)
        {
            if (wildebeest.Weight > Power)
            {
                Power -= 10;
            }
            else
            {
                Power+= 10;
            }
        }
    }
    /*Кушать травоядное животное (Eat) - метод конкретного
продукта, при выполнении которого проверяется,
является ли сила плотоядного животного больше, чем вес
травоядного, которого он съедает. Если является, то
хищник получает +10 к силе, иначе, если сила меньше,
чем вес травоядного животного, то сила плотоядного
уменьшаются на -10.
*/





    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
