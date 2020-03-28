using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /* Factory is a class with a method. That method will create and return different types of objects based on the input parameter, it received.
     * 
     * In the Factory Design pattern, we create an object without exposing the creation logic to the client and the client will refer to the newly created object using a common interface.
     * 
     * In simple words, if we have a superclass and n number of subclasses, and based on the data provided, if we have to create and return the object of one of the subclasses, then we need to use the factory design pattern.
     * 
     * The basic principle behind the factory design pattern is that, at run time, we get an object of similar type based on the parameter we pass.
     * */

    public class computerfacotry
    {
        public static IcomputerManufacture getComputer(string comptype)
        {
            IcomputerManufacture compmanufacture = null;
            if (comptype == "Desktop")
            {
                compmanufacture = new desktop();
            }
            else if (comptype == "Laptop")
            {
                compmanufacture = new laptop();
            }
            return compmanufacture;
        }
    }

    public interface IcomputerManufacture
    {
        string Processor();
        string RamSize();
        string HardDiskSize();

    }

    public class desktop : IcomputerManufacture
    {
        public string Processor()
        {
            return "i3 processor";
        }

        public string RamSize()
        {
            return "4 GB RAM";
        }

        public string HardDiskSize()
        {
            return "50 GB Harddisk";
        }
    }

    public class laptop : IcomputerManufacture
    {
        public string Processor()
        {
            return "i7 processor";
        }

        public string RamSize()
        {
            return "16 GB RAM";
        }

        public string HardDiskSize()
        {
            return "500 GB Harddisk";
        }
    }

}
