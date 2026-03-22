namespace ConsoleApp1;

public abstract class Equipment
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;

    protected Equipment(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{ID}: {Name} (Available: {IsAvailable})";
    }
}