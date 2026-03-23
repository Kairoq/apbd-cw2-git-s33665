namespace ConsoleApp1;

public abstract class User
{
    private static int _NextID = 1;
    public string Name { get; set; }
    public string Surname { get; set; }
    public int ID  { get; private set; }
    
    protected User(String name, string surname)
    {
        ID = _NextID++;
        Name = name;
        Surname = surname;
        }
    public abstract int MaxRentalAmount { get; }
    public override string ToString()
    {
        return $"{base.ToString()} | {Name} | {Surname}";
    }
}