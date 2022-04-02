using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        { 
            //declare variables
            int age;
            string name;
            bool isValid;
            short num;
            long number;
            float val;
            byte data;
            char info;
            DateTime date;
            decimal dec;

            //implicit conversion
            val = 5; //val is a float while 5 is an integer. It implicitly converts 5 to a foat
            Console.WriteLine(val);
            age = (int)5.4;//we explicitly typecast 5.4 which is a float to an int.
            Console.WriteLine(age);
            //

           
            
        
        }
    }
}
