class Dog : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says bark!");
    }
}