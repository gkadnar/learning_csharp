﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.TypeBasics
{
    class Basics
    {
        public static void Example01()
        {
            Console.WriteLine("**********TypeBasics.Example01 BEGIN**********");

            int x = 12 * 30;                                // variable declaration of type int
            Console.WriteLine(x);

            Console.WriteLine("**********TypeBasics.Example01 END************\n");
        }

        public static void Example02()
        {
            Console.WriteLine("**********TypeBasics.Example02 BEGIN**********");
            Console.WriteLine("**********Predefined types********************");
            // int - default type for numeric literals that fits into 32 bit of memory.
            int x = 12 * 30;                                
            Console.WriteLine(x);

            // string - represents a sequence of characters.
            string message = "Hello world";                    
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);               // HELLO WORLD
            x = 2019;
            message = message + x.ToString();
            Console.WriteLine(message);                    // Hello world2015

            // bool - exactly two possible values: true and false.
            bool simpleVar = false;
            if (simpleVar)
                Console.WriteLine("This will not print");
            x = 5000;
            bool lessThanAMile = x < 5280;
            if (lessThanAMile)
                Console.WriteLine("This will print");

            Console.WriteLine("**********TypeBasics.Example02 END************\n");
        }

        public static void Example03()
        {
            Console.WriteLine("**********TypeBasics.Example03 BEGIN**********");
            Console.WriteLine("**********Class custom type*******************");

            //declaration and instantiation of the UnitConverter type by calling the appropriate constructor
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);
            Console.WriteLine(feetToInchesConverter.Convert(30));    // 360
            Console.WriteLine(feetToInchesConverter.Convert(100));   // 1200
            Console.WriteLine(feetToInchesConverter.Convert(
                                 milesToFeetConverter.Convert(1)));   // 63360

            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");
            Console.WriteLine(p1.Name);      // Pan Dee
            Console.WriteLine(p2.Name);      // Pan Dah
            Console.WriteLine(Panda.Population);   // 2

            Console.WriteLine("**********TypeBasics.Example03 END************\n");
        }

        public static void Example04()
        {
            Console.WriteLine("**********TypeBasics.Example04 BEGIN**********");
            Console.WriteLine("**********Conversions*************************");
            int x = 12345;       // int is a 32-bit integer
            long y = x;          // Implicit conversion to 64-bit integer
            short z = (short)x;  // Explicit conversion to 16-bit integer

            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine("**********TypeBasics.Example04 END************\n");
        }
    }

    class UnitConverter                                             // class custom type
    {
        int ratio;                                                  // Instance Field
        public UnitConverter(int unitRatio) { ratio = unitRatio; }  // Constructor
        public int Convert(int unit) { return unit * ratio; }       // Instance Method
    }

    class Panda
    {
        public string Name;                                         // Public Instance field
        public static int Population;                               // Public Static field

        public Panda(string n)                                      // Constructor
        {
            Name = n;                                               // Assign the instance field
            Population = Population + 1;                            // Increment the static Population field
        }
    }
}
