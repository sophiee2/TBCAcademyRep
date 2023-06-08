Console.WriteLine("How many numbers do you want to have in massive?");
int count,number;
Int32.TryParse(Console.ReadLine(), out count);
int [] myarr = new int[count];
for (int i = 0; i < myarr.Length; i++)
{    number=Int32.Parse(Console.ReadLine());
    myarr[i] = number;
    i++;
    Console.WriteLine(myarr[i])
}

Console.ReadKey();

