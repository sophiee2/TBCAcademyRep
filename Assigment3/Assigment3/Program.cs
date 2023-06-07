
using System;

Console.Write("please Enter a number: ");
string input = Console.ReadLine();
int number;
int count = 1;
Int32.TryParse(input, out number);

if(number <= 1) { 
    Console.WriteLine(number + "- this number  is not prime or composite number");
}
else {
    for (int i = 2; i <= number; i++)
    {
        if (number % i == 0) count += 1;
    }
    if (count > 2) {
        Console.WriteLine("this number is composite");
        
            }
    else
    {
        Console.WriteLine("this number is prime");

    }

}


Console.ReadKey();  
