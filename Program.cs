void Pow3(int number)
{
    for (int i = 0; i <= number; ++i)
    Console.WriteLine( i + "   " + Math.Pow(i, 3) );
    Console.WriteLine();
}

int number = 3;
Pow3(number);

number = 5;
Pow3(number);