double number = 6;
int pow = 0;

while (number >= 2)
{
    number /= 2;
    pow++;
}

if(number == 1)
{
    Console.WriteLine("Eded 2-nin "+pow+"-in quvvetidir");
}else if (number <= 1.5)
{
    Console.WriteLine("Eded" + pow + "-in quvvetine yaxindir");
}
else
{
    pow++;
    Console.WriteLine("Eded " + pow + "-in quvvetine yaxindir");
}

