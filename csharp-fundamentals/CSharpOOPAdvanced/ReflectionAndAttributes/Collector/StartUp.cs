﻿using System;

namespace Reflection
{
    public class StartUp
    {
        static void Main()
        {
            Spy spy = new Spy();

            string result = spy.CollectGettersAndSetters("Hacker");

            Console.WriteLine(result);
        }
    }
}
