namespace ConsoleApp1;

public abstract class Equipment
{
    private static int _NextID = 1;
    public int ID { get; private set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;

    protected Equipment(string name)
    {
        ID = _NextID++;
        Name = name;
    }

    public override string ToString()
    {
        return $"{ID}: {Name} (Available: {IsAvailable})";
    }
}