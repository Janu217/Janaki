using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerManufacture factory = new Desktop();// Or new Laptop();
            ComputerShop shop = new ComputerShop(factory);
            shop.AssembleMachine();
            Console.ReadLine();
        }
    }
}
