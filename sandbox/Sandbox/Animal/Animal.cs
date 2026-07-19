class Animal
{
    protected string _name;

    public Animal(string title)
    {
        _name = title;
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine($"{_name}: says the same thing every animal says.");
    }
}