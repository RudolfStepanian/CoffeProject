using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using coffee.DataAccessLayer.DataAccessLayer;
using coffee.CTypes;

namespace coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to coffee machine" +
            	"/n1.coffee - 100" +
                "/n2.other coffe - 200" +
                "/n3.another coffee - 300" +
                "/n4.hot water - 50" +
                "/n5.cup - 500" +
                "/n6.dark coffe - 250" +
                "/n7.lite coffe - 150" +
                "/n8.milk - 100" +
                "/n9.sugar water - 50" +
                "/n10.darkest coffee - 400");
            int balance = 0;
            addBalance(ref balance);
            Console.WriteLine("your balance => " + balance);
            do
            {
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Coffee coffee = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 100
                        };
                        if (balance < coffee.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= coffee.price;
                        coffee.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 2:
                        Coffee othercoffee = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0.2M,
                            cup = 1,
                            price = 200
                        };
                        if (balance < othercoffee.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if(Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= othercoffee.price;
                        othercoffee.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 3:
                        Coffee anothercoffee = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 300
                        };
                        if (balance < anothercoffee.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= anothercoffee.price;
                        anothercoffee.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 4:
                        Coffee hotWater = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 50
                        };
                        if (balance < hotWater.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= hotWater.price;
                        hotWater.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 5:
                        Coffee cup = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 500
                        };
                        if (balance < cup.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= cup.price;
                        cup.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 6:
                        Coffee darkcoffee = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 250
                        };
                        if (balance < darkcoffee.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= darkcoffee.price;
                        darkcoffee.Serve();
                        Console.WriteLine(balance);
                        break;
                        case 7:
                        Coffee litecoffee = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 150
                        };
                        if (balance < litecoffee.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= litecoffee.price;
                        litecoffee.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 8:
                        Coffee milk = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 100
                        };
                        if (balance < milk.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= milk.price;
                        milk.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 9:
                        Coffee sugarwater = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 50
                        };
                        if (balance < sugarwater.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= sugarwater.price;
                        sugarwater.Serve();
                        Console.WriteLine(balance);
                        break;
                    case 10:
                        Coffee darkestcoffe = new Coffee()
                        {
                            coffee = 0.2M,
                            sugar = 0.2M,
                            water = 0.2M,
                            milk = 0,
                            cup = 1,
                            price = 400
                        };
                        if (balance < darkestcoffe.price)
                        {
                            Console.WriteLine("not enough money");
                            Console.WriteLine("recharge balance?(y/n)");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                addBalance(ref balance);
                            }
                            break;
                        }
                        balance -= darkestcoffe.price;
                        darkestcoffe.Serve();
                        Console.WriteLine(balance);
                        break;
                    default:
                        Console.WriteLine("wrong order");
                        break;
                }
                Console.WriteLine("press esc to continue or any other key to order more coffee");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            DataAccess.ExecuteSPWithNoParam("RefillStore");
        }

        public static void addBalance(ref int balance)
        {
            Console.WriteLine("Enter coin (only enter 50,100,200 or 500)");
            do
            {
                int a = 0;
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 50:
                        balance += a;
                        Console.WriteLine(balance);
                        break;
                    case 100:
                        balance += a;
                        Console.WriteLine(balance);
                        break;
                    case 200:
                        balance += a;
                        Console.WriteLine(balance);
                        break;
                    case 500:
                        balance += a;
                        Console.WriteLine(balance);
                        break;
                    default:
                        Console.WriteLine("wrong coin");
                        break;
                }
                Console.WriteLine("press esc to continue or any other key to add more coin");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}