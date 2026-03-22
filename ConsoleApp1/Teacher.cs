namespace ConsoleApp1;

public class Teacher : User
{
    public int MaxRentalAmount = 4;

    public Teacher(string name, string surname, int maxRentalAmount) : base(name, surname) {}

    public override string ToString()
    {
        return $"{base.ToString()} | {Name} | {Surname}";
    }
}