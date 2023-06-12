using System;
Console.WriteLine("please enter index");
Int32.TryParse(Console.ReadLine(), out int a);
int index = a;
Console.WriteLine("please fill array length");
Int32.TryParse(Console.ReadLine(), out int length);

int arrayLength= length;

int[] myArr = new int[length];



int sum = PrintSumOfIndexedNumber(myArr, index);
Console.WriteLine($"Sum of digits at index {index}: {sum}");

int PrintSumOfIndexedNumber(int[] numberArr, int index)
{

    for (int i = 0; i <length; i++)
    {
        Int32.TryParse(Console.ReadLine(), out int n);
        numberArr[i] = n;
        if (i == index)
        {
            int element=n;
            int sum = 0;

            while (element > 0)
            {

                sum += element % 10;
                element /= 10;


            }
            return sum;

        }
           
 
        
        
    }
    return 0;
}
Console.WriteLine(PrintSumOfIndexedNumber(myArr, 2));
Console.WriteLine();




 

Console.ReadKey();