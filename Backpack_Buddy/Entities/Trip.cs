namespace Backpack_Buddy.Entities
{
    public class Trip
    {
        string Name;
        Location Location;
        Location DepartureLocation;
        Camper Organzier;
        List<Camper> Campers;
        List<Meal> Menue;
        DateTime StartDate;
        DateTime EndDate;
    }
}
