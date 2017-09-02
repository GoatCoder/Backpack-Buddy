using System.Collections.Generic;

namespace Backpack_Buddy.Entities
{
    class Meal
    {
        enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        enum Meal
        {
          Breakfast,
          Lunch,
          Dinner
        }

        String Name;
        Day Day;
        Meal Meal;
        List<FoodItem> Ingredients;
        LinkedList<string> Steps;
    }
}
