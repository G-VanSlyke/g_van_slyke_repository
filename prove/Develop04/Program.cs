using System;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        while (selection != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity\n2. Start Reflecting Activity\n3.Start Listing Activity\n4. Quit");
            Console.Write("Select an option from the menu: ");
            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.WhatItDo();
            }

            if (selection == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.WhatItDo();
            }

            if (selection == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.WhatItDo();
            }
        }
    }
}