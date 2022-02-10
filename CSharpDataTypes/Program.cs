using System; //all these stuffs are configuring the files. we can specify these things we can use. 

namespace StaticClassAttributes //same name as the project we are using. we are in the project.
                                //these two curly brackets is where we start our coding
{
    public static class Program //class is like a container that we can put our code. 
    {
        static void Main(string[] args) //this is sort of like another container we can put our code. This Main method any code we put inside of these curly brackets it will execute our code. 
        {
            string phase = "Giraffe Academy";
            char grade = 'A'; //difference between string and char is that i can only put one single character. these are two ways we can store text.

            int age = -30; //cannot be division. you can do whole number and negative numbers.

            //float, double, decimal these 3 types basically range from accurate with the float to most accurante with the decimal data type. so if you really want to super precise with decimal point that you're using
            //then you want to use the decmical point for things like money, or anything you need it to be extremely precise.

            //purpose of this course we will use double. which is right in the middle.

            double gpa = 3.2;
            double gpa = 3.0;

            //a boolean is essentially a true or false values. a lot of time in programming we want to store true or false information. a lot of time
            // storing true and false information can come super handy.

            bool isMale = true; //can be true or false only.

            //these are the core data types we will use more common. you will be fine with these data types.


            //you can print out string or number too. its not store in a variable. you can do the same thing for bool. again you don't have to store inside a variables.
            Console.WriteLine(false);
            Console.WriteLine("Hello World");


            Console.ReadLine();




        }




    }


}

/*
 Topic: What is data types?

A data type specifies the size and type of variable values. 
It is important to use the correct data type for the corresponding variable; to avoid errors, to save time and memory, 
but it will also make your code more maintainable and readable. 


 */