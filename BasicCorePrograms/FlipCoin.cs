﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{

    public class VowelConsonant
    {
        char value;
        public void alphabetcheck()
        {
            Console.WriteLine("Enter an alphabet to check :");
            value = Convert.ToChar(Console.ReadLine());

            if (value == 'a' || value == 'e' || value == 'i' || value == 'o' || value == 'u')
            {
                Console.WriteLine("This is a vowel");
            }
            else
            {
                Console.WriteLine("This is a consonant");
            }

        }
    }
}




