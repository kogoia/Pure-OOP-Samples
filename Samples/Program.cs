﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountAndSay.Run();

            Console.WriteLine(
                new MissingLetter(
                        new ConsecutiveLetters(
                            new []{ 'a', 'b', 'c', 'd', 'f' }
                        )
                 ).Result()
            );

            Console.ReadLine();
        }
    }
}
