﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*appel de la classe Class1 */
            Class1 c1= new Class1(); 
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");
            /*... */
        }
    }
}
