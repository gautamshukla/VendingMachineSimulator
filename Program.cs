using System;

namespace VendingMachineApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] coin = new int[3] { 1, 2, 3 };//create an array to hold coin values
            int[] drink = new int[3] { 1, 2, 3 }; //create an array to hold drink values
            Showmenu(coin, drink);
            //sumCoininsert = inputcoin(coinInsert);
            //showdrinks(choice);
            //showbalace(sumCoininsert, price);
            //contmethod(cont);            
        }
        public static void Showmenu(int[] coin, int[] drink)
        {
            int drinkChoice = 0;
            int coinChoice = 0;
            Console.WriteLine("[Coins available : $1.00 [" + coin[0] + "] $0.50 [ " + coin[1] + "] $ 0.20 [ " + coin[2] + "] ]");
            Console.WriteLine("[Drinks available : Cola [" + drink[0] + "] Chips [" + drink[1] + "] Candy [" + drink[2] + "] ]");
            label:
            // get the users choice
            Console.Write("Select Drink: ");
            drinkChoice = Convert.ToInt32(Console.ReadLine());

            /*validate Drink*/

            if (drinkChoice != 1 && drinkChoice != 2 && drinkChoice != 3)
            {
                Console.WriteLine("Soory! Selected option Not Available!");
                goto label;
            }
            Console.Write("Select Coin: ");
            coinChoice = Convert.ToInt32(Console.ReadLine());
            /*validate Coin*/
            switch (coinChoice)
            {
                case 1:
                    Console.WriteLine("Thank You! Dispansing Drink: Cola");
                    break;
                case 2:
                    Console.WriteLine("Thank You! Dispansing Drink: Chips");
                    break;
                case 3:
                    Console.WriteLine("Thank You! Dispansing Drink: Candy");
                    break;
                default:
                    Console.WriteLine("please enter valid coin");
                    break;
            }
        }
    }
}
