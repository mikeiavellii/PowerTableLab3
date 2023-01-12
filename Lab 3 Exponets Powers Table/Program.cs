Console.WriteLine("Alright kid, it's time to learn your squares and cubes!\n");
bool restart = true;
do
{
    Console.WriteLine("Please enter an integer.\n");
    int maxValue = int.Parse(Console.ReadLine());

    if (maxValue >= 1 && maxValue <= 1290.8)
    {
        int x;
        int sq = 1;
        int cu = 1;
        Console.WriteLine("" +
            "Number\t\tSquared\t\tCubed\n" +
            "=======\t\t=======\t\t=======\n");
        for (x = 1; x <= maxValue; x++)
        {
            sq = GetSquared(x);
            cu = GetCubed(x);

            Console.WriteLine("{0,7}\t\t{1,7}\t\t{2,7}", x, sq, cu);
        }

        Console.WriteLine("Would you like to enter another number?");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "yes" || choice == "y")
        {
            restart = true;
        }
        else
        {
            Console.WriteLine("Hope you learned something kid. Bye.");
            restart = false;
        }
    }
    else
        Console.WriteLine("Invalid response. Please enter a different number.");
}
while (restart == true);

static int GetSquared(int x)
{
    return x * x;
}
static int GetCubed(int x)
{
    return x * x * x;
}