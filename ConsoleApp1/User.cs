namespace ConsoleApp1;

public abstract class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string ID  { get; set; }
    
    protected User(String name, string surname)
        {
        Name = name;
        Surname = surname;
        }
    public override string ToString()
    {
        return $"{base.ToString()} | {Name} | {Surname}";
    }
}