// See https://aka.ms/new-console-template for more information

string _ = Console.ReadLine();

int a;
Int32.TryParse(_, out a);
if (a < 0)
{
    Console.WriteLine("cold");
}else if (a >=0 && a<=30)
{
    Console.WriteLine("good weather");
}else
{
    Console.WriteLine("Hot");
}
