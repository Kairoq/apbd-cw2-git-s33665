namespace ConsoleApp1;

public class Rental
{
    public int ID { get; set; }
    public User User { get; set; }
    public Equipment Equipment { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public decimal Penalty { get; set; }

    public bool IsReturned => ReturnDate.HasValue;
    public bool IsOverdue => !IsReturned && DateTime.Now > DueDate;

    public Rental(User user, Equipment equipment, DateTime rentalDate, DateTime dueDate)
    {
        User = user;
        Equipment = equipment;
        RentalDate = rentalDate;
        DueDate = dueDate;
    }

    public override string ToString()
    {
        string status = IsReturned
            ? $"Returned on {ReturnDate.Value.ToShortDateString()} (Penalty: {Penalty})"
            : $"Due: {DueDate.ToShortDateString()}";

        return $"{ID}: {User.Name} {User.Surname} " +
               $"rented {Equipment.Name} " +
               $"on {RentalDate.ToShortDateString()} " +
               $"| {status}";
    }
}