using System;


Console.WriteLine("please fill array length");
Int32.TryParse(Console.ReadLine(), out int length);

int arrayLength = length;

Char[] myArr = new Char[length];

void fillCharMassive(char[] array)
{
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = Char.Parse(Console.ReadLine());
    }

    foreach (char c in array) {
        {
            Console.WriteLine(c);
        }
}