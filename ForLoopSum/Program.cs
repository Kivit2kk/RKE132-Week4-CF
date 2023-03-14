

int sum = 0;

for (int i = 2; i < 11; i++) //i-- =i-1
{
    Console.WriteLine($"i = {i} ");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;
}
//Console.WriteLine($"Final total{sum}");
