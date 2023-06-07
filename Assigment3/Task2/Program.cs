Console.Write("please Enter a number: ");
string input = Console.ReadLine();
int number;
int count = 0;
Int32.TryParse(input, out number);

for (int i = 1; i <= number; i++)
{
    if (number % i == 0) count ++;
}
Console.WriteLine(number + "- number's divider's count are " + count);

Console.ReadKey();
