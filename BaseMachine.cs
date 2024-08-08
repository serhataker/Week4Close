using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Week4Close
{
    public abstract class BaseMachine // we created the basemachine abstract class main project for the our machine
    {
        // Define the properties
        public DateTime ProductDate { get; set; } 

        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        public BaseMachine() // constructor for the productdate
        {
            ProductDate = DateTime.Now;
        }

        public virtual void WriteInfo() // Pollymorfihisim for the project
        {
            Console.WriteLine($"Product Date:{ProductDate} Serial Number:{SerialNumber} Name:{Name} Description:{Description} Operation System:{OperatingSystem}");

        }

             public void MainInfo() // This method when our prouced is over we call
        {
            Console.WriteLine("Congratulations! You produced a product. Do you want to produce another product? (Y/N)");
            char response = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (response != 'Y')// if user don't another produce
            {
                Console.WriteLine("Thank you for using our product creator. Goodbye!");
                Environment.Exit(0);
               
            }
        }

        public abstract void GetProductName(); //we created the abstract method
    }
       public class Phone : BaseMachine // We cretaed the for Phone Class and inherit the basemachine class
        {
            public Boolean TurkishLicence { get; set; }// this propety special property for the Phone class
            public override void GetProductName() // we override the abstract method and dizayn for our Phone object
            {
            Console.WriteLine($"Your Phone's Name: {Name.ToString()}");
            }

            public override void WriteInfo() // we override the abstract method and dizayn for our Phone object printing
        {
                Console.WriteLine($"Product Date:{ProductDate} Serial Number:{SerialNumber} Name:{Name} Description:{Description} Operation System:{OperatingSystem} KVK:{TurkishLicence}");
            }
        } 
        
        public class Computer : BaseMachine //We cretaed the for PC Class and inherit the basemachine class
    {

            public Boolean BluetoothIsHave { get; set; } // this propety special property for the PC class
        private int _usbPortCount;// we created the field for the ncapsulation
        public int UsbPortCount// we ncapsulate this property if user input wrong value
        {
            get { return _usbPortCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPortCount = value;
                }
                else
                {
                    _usbPortCount = -1;
                }
            }
        }




        public override void GetProductName()   // we override the abstract method and dizayn for our PC object
        
            {
            Console.WriteLine($"Your Computer's Name: {Name.ToString()}");
        }

        public override void WriteInfo() // we override the abstract method and dizayn for our PC object printing

        {
                Console.WriteLine($"Product Date:{ProductDate} Serial Number:{SerialNumber} Name:{Name} Description:{Description} Operation System:{OperatingSystem} Bluetooth:{BluetoothIsHave} Use Number :{_usbPortCount}");
            }
        
    }
}
