using System;

namespace HotelRoom
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            double priceOfStudio = 0;
            double priceOfApartment = 0;

            if (month == "May" || month == "October")
            {
                priceOfApartment = 65;

                if (night > 7 && night <= 14)
                {
                    double price = 50 * 0.05;
                    priceOfStudio = 50-price;
                }
                else if (night > 14)
                {
                    double price1 = 50 * 0.3;
                    priceOfStudio = 50 - price1;
                    double price2 = 65 * 0.1;
                    priceOfApartment =  65- price2;
                }
            }

            else if (month == "June" || month == "September")
            {
                priceOfStudio = 75.20;
                priceOfApartment = 68.7;

                if (night > 14)
                {
                    double price1 = 75.20 * 0.2;
                    priceOfStudio = 75.20- price1;
                    double price2 = 68.7 * 0.1;
                    priceOfApartment =  68.7- price2;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceOfStudio = 76;
                priceOfApartment = 77;
                if (night > 14)
                {
                    double price = 77 * 0.1;
                    priceOfApartment =  77- price;
                }
            }
            if(priceOfStudio>=0)
            {
                Console.WriteLine($"Apartment: {(priceOfApartment*night):f2} lv.");
                Console.WriteLine($"Studio: {(priceOfStudio*night):f2} lv.");
            }
            
        }
    }
}
