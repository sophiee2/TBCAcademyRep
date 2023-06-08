Console.WriteLine("How many numbers do you want to have in massive?");
int count,number;
Int32.TryParse(Console.ReadLine(), out count);
int [] myarr = new int[count];

//enter massive
for (int i = 0; i < myarr.Length; i++)
{
     Int32.TryParse(Console.ReadLine(),out number);
    myarr[i] = number;
    //Console.WriteLine(myarr[i]);
}
//print massive

//order massive
Console.WriteLine("---------------------------");





    for (int i = 0; i < myarr.Length; i++)
    {
        for (int j = 0; j < myarr.Length - 1; j++)
        {
            if (myarr[j + 1] < myarr[j])
            {
            int temp = myarr[j + 1]; 
            myarr[j + 1] = myarr[j]; 
            myarr[j] = temp; 
            }
        }


    }

foreach (var item in myarr)
{
    Console.WriteLine(item);
}
Console.ReadKey();

