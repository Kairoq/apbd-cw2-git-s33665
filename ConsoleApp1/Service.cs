namespace ConsoleApp1;

public class Service
{
    private List<User> _users = new();
    private List<Equipment> _equipment = new();
    private List<Rental> _rentals = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void AddEquipment(Equipment equipment)
    {
        _equipment.Add(equipment);
    }

    public Rental RentEquipement(User user, Equipment equipment, int days)
    {
        //Checking the amount rented by the user
        int CurrentlyRentedAmount = _rentals.Count(r => r.User == user && !r.IsReturned);
        
        if (!equipment.IsAvailable)
        {
            throw new Exception("Not available");
        }

        if (CurrentlyRentedAmount >= user.MaxRentalAmount)
        {
            throw new Exception("Exceded rental limit");
        }
        
        Rental rental = new Rental(user, equipment, DateTime.Now, DateTime.Now.AddDays(days));
        _rentals.Add(rental);
        equipment.IsAvailable = true;
        return rental;
    }

    public void ReturnEquipement(Rental rental)
    {
        rental.ReturnDate = DateTime.Now;

        if (rental.ReturnDate > rental.DueDate)
        {
            int daysLate = (rental.RentalDate.Date - rental.DueDate).Days;
            if (daysLate <= 2)
            {
                rental.Penalty= daysLate * 3;
            }
            else
            {
                rental.Penalty = daysLate * 5;
            }
        }
        rental.Equipment.IsAvailable = true;
        _rentals.Remove(rental);
    }
}