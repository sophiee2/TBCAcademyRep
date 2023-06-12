Console.WriteLine("How many numbers do you want to have in massive?");
int N, number;
Int32.TryParse(Console.ReadLine(), out N);
string[] myarr = new String[N];
int[] numberArr =  new int[N];
for (int i = 0; i < N; i++)

{
    Console.WriteLine("enter string");
    myarr[i] = Console.ReadLine();
    numberArr[i] = i;
}

