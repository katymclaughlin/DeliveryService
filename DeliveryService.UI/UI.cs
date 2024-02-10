using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Data;
using DeliveryService.Repository;

namespace DeliveryService.UI
{
    public class UIHelper
    {
        DeliveryServiceRepository deliveryList = new DeliveryServiceRepository();
        public void AddDelivery()
        {
            Delivery NewDelivery = new Delivery();
            Console.WriteLine("Please type the delivery item name.");
            string inputName = Console.ReadLine();
            Guid g = Guid.NewGuid ();
            Console.WriteLine("Please type the order date in this format 'MM/DD/YYYY' ");
            string inputOrderDate = Console.ReadLine();
            Console.WriteLine ("What is the status: Scheduled / EnRoute / Complete / Canceled");
            string inputStatus = Console.ReadLine();
            Console.WriteLine ("Please enter the item number.");
            int inputItemNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Please enter the Item Quantity.");
            int inputQuantity = Convert.ToInt32(Console.ReadLine());
            NewDelivery.OrderName = inputName;
            NewDelivery.CustomerId = g;
            NewDelivery.OrderDate = inputOrderDate;
            NewDelivery.DeliveryStatus = inputStatus;
            NewDelivery.ItemNumber = inputItemNumber;
            NewDelivery.ItemQuantity = inputQuantity;
            bool AddDeliverytoList = deliveryList.AddDeliverytoList(NewDelivery);
        }

        public void ListofScheduledDeliveries()
        {
            List<Delivery> DeliveryList = deliveryList.GetDeliveryList();
            Console.WriteLine ("Delivery List Amount = " + DeliveryList.Count);
            Console.WriteLine("Delivery Name              | ID                                        | Order Date               | Delivery Status            | Item Number    | Item Quantity");             
            Console.WriteLine("===============================================================================================================================================================");
            for (int i = 0; i < DeliveryList.Count; i++ )
            {
            Console.WriteLine(i + "   " + DeliveryList[i].OrderName + "                " + DeliveryList[i].CustomerId + "              " + DeliveryList[i].OrderDate + "             " 
            + DeliveryList[i].DeliveryStatus + "                       " + DeliveryList[i].ItemNumber + "               " + DeliveryList[i].ItemQuantity + "           ");
            }
        }

        public void UpdateDelivery()
        {

        }

        public void DeleteDelivery()
        {

        }
    }
    public class UI
    {
        public static void Main (string[] args)
        {
            UIHelper uih = new UIHelper();
            while (true)
            {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ");
            Console.WriteLine("--> WARNER TRANSIT FEDERAL DELIVERY TRACKING APPLICATION <--");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================================================");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("How can we help you manage your deliveries?");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DELIVERIES");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("A. Add a Delivery");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("B. List of Deliveries: Scheduled / EnRoute / Complete / Canceled");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C. Update A Delivery");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("D. Delete a Delivery");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("X. EXIT THE APPLICATION");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================================================");
    
            string menuUserInput = Console.ReadLine().ToLower();
            //Console.WriteLine("menu input = "+menuUserInput);
            switch(menuUserInput)
                {
                case "a":
                    uih.AddDelivery();
                    break;
                case "b":
                    uih.ListofScheduledDeliveries();
                    break;
                case "c":
                    uih.UpdateDelivery();
                    break;
                case "d":
                    uih.DeleteDelivery();
                    break;        
                case "x":
                    return;
                    break;
                }
            }
        }
    }
}