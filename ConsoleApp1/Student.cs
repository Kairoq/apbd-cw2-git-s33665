namespace ConsoleApp1;

public class Student : User
{
    public override int MaxRentalAmount => 2;

    public Student(string name, string surname) : base(name, surname) {}

    public override string ToString()
    {
        return $"{base.ToString()} | {Name} | {Surname}";
    }
}