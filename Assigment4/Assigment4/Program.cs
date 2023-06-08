Console.WriteLine("How many numbers do you want to have in massive?");
int count,number;
Int32.TryParse(Console.ReadLine(), out count);
int [] myarr = new int[count];
for (int i = 0; i < myarr.Length; i++)
{
     Int32.TryParse(Console.ReadLine(),out number);
    myarr[i] = number;
    //Console.WriteLine(myarr[i]);
}

foreach (var item in myarr)
{
    Console.WriteLine(item);
}
Console.ReadKey();

