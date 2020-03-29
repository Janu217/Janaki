using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /* In simple words we can say, the Abstract Factory is a super factory that creates other factories. This Factory is also called Factory of Factories.
     * 
     * Abstract Factory Pattern provides an interface for creating families of related dependent objects without specifying their concrete classes.
     * 
     * IThe Abstract Factory Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.
     * 
     * The abstract factory design pattern is merely an extension to the factory method pattern or factory pattern, which allows you to create objects without being concerned about the actual class of the object being created.
     * 
     * 
     * */

    public class ComputerShop
    {
        IComputerManufacture category;
        public ComputerShop(IComputerManufacture _category)
        {
            category = _category;
        }
        public void AssembleMachine()
        {
            IProcessor processor = category.GetRam();
            IHardDisk hdd = category.GetHardDisk();
            IMonitor monitor = category.GetMonitor();
            //use all three and create machine

            processor.PerformOperation();
            hdd.StoreData();
            monitor.DisplayPicture();
        }
    }


    public interface IProcessor 
    { 
        void PerformOperation();  
    }

    public interface IHardDisk 
    { 
        void StoreData(); 
    }

    public interface IMonitor 
    { 
        void DisplayPicture(); 
    }

    public class LaptopProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform quickly");
        }
    }
    public class DesktopProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform Slowly");
        }
    }

    public class LaptopHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take less time to store");
        }
    }
    public class DesktopHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take more time to store");
        }
    }

    public class LaptopMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Picture quality is Best");
        }
    }
    public class DesktopMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Picture quality is Average");
        }
    }

    public interface IComputerManufacture
    {
        IProcessor GetRam();
        IHardDisk GetHardDisk();
        IMonitor GetMonitor();
    }

    public class Desktop : IComputerManufacture
    {
        public IProcessor GetRam() { return new LaptopProcessor(); }
        public IHardDisk GetHardDisk() { return new LaptopHDD(); }
        public IMonitor GetMonitor() { return new LaptopMonitor(); }
    }
    public class Laptop : IComputerManufacture
    {
        public virtual IProcessor GetRam() { return new DesktopProcessor(); }
        public IHardDisk GetHardDisk() { return new DesktopHDD(); }
        public IMonitor GetMonitor() { return new DesktopMonitor(); }
    }

}
