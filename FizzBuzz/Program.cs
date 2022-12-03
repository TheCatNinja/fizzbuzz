int len = 100;
string[] array = new string[len];

for (int i = 0; i < len; i++)
{
    int y = i + 1;
    if (y % 3 == 0 && y % 5 == 0)
        array[i] = "FizzBuzz";
    else if (y % 3 == 0)
        array[i] = "Fizz";
    else if (y % 5 == 0)
        array[i] = "Buzz";
    else
        array[i] = y.ToString();
    Console.WriteLine($"{y} - {array[i]}");
}

Console.Read();