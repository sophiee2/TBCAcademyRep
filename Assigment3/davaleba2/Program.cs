Console.WriteLine("please firs enter how many number are you going to enter");


int number = Convert.ToInt32(Console.ReadLine());

int sum = 0, avrg = 0, avrgcounter = 0;

int[] arr =  new int[number];

for (int i = 0; i < number; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
    {

        sum += arr[i];
        avrgcounter++;
    }
}
if (avrgcounter > 0)  avrg = sum / avrgcounter;

Console.WriteLine("sum of positive numbers are " +  sum);
Console.WriteLine("Average of positive numbers are " + avrg);

Console.ReadKey();


