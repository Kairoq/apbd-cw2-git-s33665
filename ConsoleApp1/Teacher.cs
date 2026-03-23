namespace ConsoleApp1;

public class Teacher : User
{
    public override int MaxRentalAmount => 5;

    public Teacher(string name, string surname) : base(name, surname) {}

    public override string ToString()
    {
        return $"{base.ToString()} | {Name} | {Surname}";
    }
}