using System;
using System.Collections.Generic;

namespace ship_it
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            var instance = new Shipper();
            while (input != 6)
            {
                Console.WriteLine("Choose from the following options:\n");
                Console.WriteLine("1.Add a Bicycle to the shipment");
                Console.WriteLine("2.Add a Lawn Mower to the Shipment");
                Console.WriteLine("3.Add a Baseball Glove to the shipment");
                Console.WriteLine("4.Add Crackers to the shipment");
                Console.WriteLine("5.List Shipment Items");
                Console.WriteLine("6.Compute Shipping Charges");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    instance.Add(input);
                }
                catch
                {
                    Console.WriteLine("Only enter a number to select a menu option\n");
                }
            }
            //take input here and pass into Shippable's add switch case
            //keeps in while loop until option 6 to calculate is selected

        }

        interface IShippable
        {
            //IShippable interface
            decimal ShipCost { get; }
            string Product { get; }
        }
        public class Bicycle : IShippable
        {
            private decimal cost;
            private string name;
            public decimal ShipCost { get { cost = 20.50M; return cost; } }
            public string Product { get { name = "Bicycle"; return name; } }
        }

        public class LawnMowers : IShippable
        {
            private decimal cost;
            private string name;
            public decimal ShipCost { get { cost = 24.00M; return cost; } }
            public string Product { get { name = "Lawn mowers"; return name; } }
        }

        public class BaseballGloves : IShippable
        {
            private decimal cost;
            private string name;
            public decimal ShipCost { get { cost = 3.23M; return cost; } }
            public string Product { get { name = "Baseball gloves"; return name; } }
        }

        public class Crackers : IShippable
        {
            private decimal cost;
            private string name;
            public decimal ShipCost { get { cost = 0.57M; return cost; } }
            public string Product { get { name = "Crackers"; return name; } }
        }

        private class Shipper
        {
            private List<IShippable> Cart = new List<IShippable>();

            public void Add(int input)
            {
                //the result part of the menu options, including adding items
                switch (input)
                {
                    case 1:
                        //add option to cart (bicycle)
                        Cart.Add(new Bicycle());
                        Console.WriteLine("1 bicycle has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 2:
                        //add option to cart (lawn mower)
                        Cart.Add(new LawnMowers());
                        Console.WriteLine("1 lawn mower has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 3:
                        //add option to cart (baseball glove)
                        Cart.Add(new BaseballGloves());
                        Console.WriteLine("1 baseball glove has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 4:
                        //add option to cart (crackers)
                        Cart.Add(new Crackers());
                        Console.WriteLine("1 package of crackers has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 5:
                        //list shipment items
                        Console.WriteLine("Your cart contains:\n");
                        Count();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 6:
                        //calculates with seperate method
                        Calculate();
                        Console.WriteLine("Thanks for using our shipping program");
                        break;
                }
            }
            public void Count()
            {
                if (Cart.Count == 0)
                {
                    //no use counting if nothing has been added
                    Console.WriteLine("Your cart is empty!\n");
                }
                else
                {
                    int count = 0;
                    //temporary int to count items then reset to 0
                    foreach (IShippable item in Cart)
                    {
                        if (item.Product == "Bicycle")
                            //alternatively I could use
                            //if (item is Bicycle)
                        {
                            count++;
                        }
                    }
                    if (count == 0 || count > 1)
                        //plurality
                        Console.WriteLine(count + " bicycles");
                    else
                        Console.WriteLine(count + " bicycle");

                    count = 0;

                    foreach (IShippable item in Cart)
                    {
                        if (item.Product == "Lawn mowers")
                        {
                            count++;
                        }
                    }
                    if (count == 0 || count > 1)
                        Console.WriteLine(count + " lawn mowers");
                    else
                        Console.WriteLine(count + " lawn mower");

                    count = 0;

                    foreach (IShippable item in Cart)
                    {
                        if (item.Product == "Baseball gloves")
                        {
                            count++;
                        }
                    }
                    if (count == 0 || count > 1)
                        Console.WriteLine(count + " baseball gloves");
                    else
                        Console.WriteLine(count + " baseball glove");

                    count = 0;

                    foreach (IShippable item in Cart)
                    {
                        if (item.Product == "Crackers")
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count + " packs of crackers");
                    //crackers always has an s, plural or singular
                }

            }
            public void Calculate()
            {
                //calculate shipping cost here
                if (Cart.Count == 0)
                {
                    Console.WriteLine("Your cart is empty!\n");
                }
                else
                {
                    decimal total = 0.00M;
                    foreach (IShippable item in Cart)
                    {
                        total += item.ShipCost;

                    }
                    Console.WriteLine("Your shipping total is: $" + total);
                }

            }



        }
    }
}
