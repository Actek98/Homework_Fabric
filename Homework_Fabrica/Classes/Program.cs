using System;


namespace Demo.Shape
{

    class Program
    {
     
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            creator.SetProduct(Products.Circle);
            Shape myShape = creator.Create(1,2,3,4);
            
            myShape.Draw();

            Console.ReadKey();
        }
    }
}
