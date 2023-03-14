string userPin;

int triesUsed = 0;


while (triesUsed != 3)
{
    Console.WriteLine("Enter your PIN.");
    userPin= Console.ReadLine();
    if (userPin == "1234") 
    {
        Console.WriteLine("Welcome!");
    }
    else 
    {
        Console.WriteLine($"Wrong PIN Try again.{3-triesUsed} tries left.");
        triesUsed++;
    }
}
