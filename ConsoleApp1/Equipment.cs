namespace ConsoleApp1;

public abstract class Equipment
{
    public string Name { get; set; }
    public int ID { get; set; }

    protected Equipment(string name, int id)
    {
        Name = name;
        ID = id;
    }
    
}