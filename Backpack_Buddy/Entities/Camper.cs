namespace Backpack_Buddy.Entities
{
    public class Camper
    {
        string Name;
        string PhoneNumber;
        string Email;
        int Weight;
        int Age;
        Backpack Backpack;

        public bool IsAdult(int minAge = 18) => return Age > minAge;
    }
}
