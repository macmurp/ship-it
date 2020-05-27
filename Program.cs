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
            //add menu here
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
            //Console.WriteLine("Press any key to return to the menu");
            //keep in while loop

        }

        interface IShippable
        {
            decimal ShipCost { get; }
            string Product { get; }
        }
        class Bicycle : IShippable
        {
            public decimal ShipCost { get { return ShipCost; } set { ShipCost = 20.50M; } }
            public string Product { get { return Product; } set { Product = "Bicycle"; } }
        }

        class LawnMowers : IShippable
        {
            public decimal ShipCost { get { return ShipCost; } set { ShipCost = 24.00M; } }
            public string Product { get { return Product; } set { Product = "Lawn mowers"; } }
        }

        class BaseballGloves : IShippable
        {
            public decimal ShipCost { get { return ShipCost; } set { ShipCost = 3.23M; } }
            public string Product { get { return Product; } set { Product = "Baseball gloves"; } }
        }

        class Crackers : IShippable
        {
            public decimal ShipCost { get { return ShipCost; } set { ShipCost = 0.57M; } }
            public string Product { get { return Product; } set { Product = "Crackers"; } }
        }

        private class Shipper
        {
            private List<IShippable> Cart = new List<IShippable>();

            public void Add(int input)
            {
                //essentially the result of menu options, including adding items
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
                    Console.WriteLine("Your cart is empty!\n");
                }
                else
                {
                    int count = 0;
                    foreach (IShippable item in Cart)
                    {
                        if (item is Bicycle)
                        {
                            count++;
                        }
                    }
                    if (count == 0 || count > 1)
                        Console.WriteLine(count + " bicycles");
                    else
                        Console.WriteLine(count + " bicycle");

                    count = 0;

                    foreach (IShippable item in Cart)
                    {
                        if (item is LawnMowers)
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
                        if (item is BaseballGloves)
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
                        if (item is Crackers)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count + " crackers");
                }

            }
            public void Calculate()
            {
                //calculate shipping cost here
                //use count in congruence?
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

                        //if (item is Bicycle)
                        //{
                        //    total += item.ShipCost;
                        //}
                        //if (item is LawnMowers)
                        //{
                        //    total += item.ShipCost;
                        //}
                        //if (item is BaseballGloves)
                        //{
                        //    total += item.ShipCost;
                        //}
                        //if (item is Crackers)
                        //{
                        //    total += item.ShipCost;
                        //}

                    }
                    Console.WriteLine("Your shipping total is: $" + total);
                }

            }



        }
    }
}
