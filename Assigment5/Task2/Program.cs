using System;
using System.Data;

Console.WriteLine("please fill array length");
Console.WriteLine();
Console.WriteLine();
Int32.TryParse(Console.ReadLine(), out int length);

int arrayLength = length;

char[] myArr = new char[length];

char[] CharArray = FillCharMassive(myArr, length);

Console.WriteLine();
Console.WriteLine("Array");

//print char massive
foreach (char c in CharArray)
{
    Console.WriteLine(c);
}


Console.WriteLine();
Console.WriteLine("--------");




Console.Write("Enter a symbol: ");
char symbol = Console.ReadKey().KeyChar;
Console.WriteLine();

int count = CheckCharNumbersInMassive(CharArray, symbol);

PrintSymbolCount(symbol, count);

void PrintSymbolCount(char symbol, int count)
{
    Console.WriteLine($"Symbol '{symbol}' occurs {count} times.");
}


//fillCharMassive
char[] FillCharMassive(char[] charArray, int length)
{
    for (int i = 0; i < length; i++)
    {
        char.TryParse(s: Console.ReadLine(),out char s);
        charArray[i] = s;
    }

        return charArray;

 
}


int CheckCharNumbersInMassive(char[] NewCharArray, char symbol)
{
  
        int count = 0;

        for (int i = 0; i < NewCharArray.Length; i++)
        {
            if (NewCharArray[i] == symbol)
                count++;
        }

        return count;
 
}

Console.ReadKey();