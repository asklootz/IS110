﻿namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Multiplication().Calculate(); //Running task 1

            
            Car myCar = new Car(); //Running task 2
            myCar.SetBrand("Mercedes");
            myCar.SetModel("S-Class");
            myCar.SetYear("1998");
            myCar.GetBrand();
            myCar.GetModel();
            myCar.GetYear();
            

            Calculator myCalculator = new Calculator(); //Running task 3
            myCalculator.Calculate();


        }
    }
}