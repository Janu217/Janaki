using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// //Not implemented factory pattern sample code.
        //static void Main()
        //{

        //    IcomputerManufacture compmanufacture = null;
        //    string comptype = "Desktop"; // or laptop
        //        if (comptype == "Desktop")
        //        {
        //            compmanufacture = new desktop();
        //        }
        //        else if (comptype == "Laptop")
        //        {
        //            compmanufacture = new laptop();
        //        }

        //        Console.WriteLine("Ram size : {0}", compmanufacture.RamSize());
        //        Console.WriteLine("Processor : {0}", compmanufacture.Processor());
        //        Console.WriteLine("Harddisk : {0}", compmanufacture.HardDiskSize());
        //        Console.ReadLine();

        //}

        //implemented factory pattern sample code.
        static void Main()
        {
            IcomputerManufacture compmanufacture = computerfacotry.getComputer("Laptop");
            Console.WriteLine("Ram size : {0}", compmanufacture.RamSize());
            Console.WriteLine("Processor : {0}", compmanufacture.Processor());
            Console.WriteLine("Harddisk : {0}", compmanufacture.HardDiskSize());
            Console.ReadLine();
        }
    }
}
