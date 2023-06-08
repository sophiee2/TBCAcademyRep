Console.Write("please Enter a number for pyramid: ");
string input = Console.ReadLine();
int rowNumber;
int count = 0;
Int32.TryParse(input, out rowNumber);



for (int i = 1; i <= rowNumber; i++)
{

    for (int j = 1; j <= rowNumber - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }


    Console.WriteLine();
}


Console.ReadKey();

