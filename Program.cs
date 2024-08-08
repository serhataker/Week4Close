using System;
using System.Threading.Channels;
using Week4Close;

namespace Week4ForClose
{

    class Week4
    {
        static void Main(string[] args)
        {
            

            do
            {


                Console.WriteLine("What do you Want to produce the product if you want to PC Click 1 or Phone Click 2"); //we ask the user which product you want to pruduce
                string choose = (Console.ReadLine()); //we assign the variable which the user input value


                switch (choose) // we controllled the variable
                {

                    case "1":// if choose  1 we created the PC machine and cretaed the property and call the method
                        Computer pc = new Computer();
                        Console.WriteLine("Please enter Pc Name");
                        pc.Name = Console.ReadLine();
                        Console.WriteLine("Please enter Serial Number");
                        pc.SerialNumber = Console.ReadLine();
                        Console.WriteLine("Please enter Pc's Description");
                        pc.Description = Console.ReadLine();
                        Console.WriteLine("Please enter Pc Operating System");
                        pc.OperatingSystem = Console.ReadLine();
                        Console.WriteLine("Please enter Pc Usb Port");
                        pc.UsbPortCount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter Pc is have Bluetooth (True/False)");
                        pc.BluetoothIsHave = Convert.ToBoolean(Console.ReadLine());
                        pc.GetProductName();
                        pc.WriteInfo();
                        pc.MainInfo();
                        break;


                    case "2":// if choose  2 we created the Phone machine and cretaed the property and call the method
                        Phone phone = new Phone(); 
                        Console.WriteLine("Please enter Phone Name");
                        phone.Name = Console.ReadLine();
                        Console.WriteLine("Please enter Serial Number");
                        phone.SerialNumber = Console.ReadLine();
                        Console.WriteLine("Please enter Phone's Description");
                        phone.Description = Console.ReadLine();
                        Console.WriteLine("Please enter Phone Operating System");
                        phone.OperatingSystem = Console.ReadLine();
                        Console.WriteLine("Please enter Phone KVK (True/False)");
                        phone.TurkishLicence = Convert.ToBoolean(Console.ReadLine());
                        phone.GetProductName();
                        phone.WriteInfo();
                        phone.MainInfo();
                        break;
                        default:
                        Console.WriteLine("please re enter 1 or 2"); //If user dont enter 1 or to we break and again we want to the user input 1 or 2
                        break;
                }
            
            } while (true);//we continuue if the MainInfo method return 'Y' value






        }

    }

}