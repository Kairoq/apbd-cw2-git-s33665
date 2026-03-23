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

    public IEnumerable<Equipment> GetEquipment()
    {
        return _equipment;
    }

    public IEnumerable<Equipment> GetAvailableEquipment()
    {
        return _equipment.Where(e => e.IsAvailable);
    }
    
    public IEnumerable<Rental> GetActiveRentalsForUser(User user)
    {
        return _rentals.Where(r => r.User == user && !r.IsReturned);
    }

}