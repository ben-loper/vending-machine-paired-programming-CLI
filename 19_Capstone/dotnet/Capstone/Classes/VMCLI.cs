﻿using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Models;

namespace VendingMachineCLI
{
    public class VMCLI
    {
        public void MainMenu()
        {
            // Load items into vending machine


            //(1) Display Vending Machine Items(2) Purchase(3) Exit

            bool quitMenu = false;

            while (!quitMenu)
            {
                Console.Clear();
                Console.WriteLine("1) Display Vending Machine Items");
                Console.WriteLine("2) Purchase");
                Console.WriteLine("3) Exit");
                Console.WriteLine("4) Sales Report");

                Console.ReadKey();

                int selection = 0;

                if (selection == 1)
                {
                    //Display items
                }
                else if (selection == 2)
                {

                    Console.Clear();
                    Console.WriteLine("1) Feed Money");
                    Console.WriteLine("2) Select Product");
                    //Display items
                    Console.WriteLine("3) Finish Transaction");

                    Console.WriteLine("Current Money Provided: (money left variable)");
                }
                else if (selection == 3)
                {
                    Console.Clear();
                    quitMenu = true;
                }
                else if (selection == 4)
                {
                    //Sales report
                }


            }


        }




        private void LoadItems()
        {
            string fullFilePath = Environment.CurrentDirectory + @"\..\..\..\..\..\etc\vendingmachine.csv";

            Log.ReadItemsFromFile(fullFilePath);
        }
            
    }
}
