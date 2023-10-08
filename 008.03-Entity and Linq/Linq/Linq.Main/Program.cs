using Linq.Main.Enums;
using Linq.Main.Entities;

#region All




List<int> numbers = new() { 100, 150, 160, 45 };


bool allItemsGrater = numbers.All(number => number > 50);

//bool allItemsGrater=true;
//foreach (var number in numbers)
//{
//    if (number <= 50)
//    {
//        allItemsGrater = false;break;

//    }

//}
Console.WriteLine(allItemsGrater);

#endregion
# region Linq Methods(Any)
List<User> userList = new List<User>
{
    new User("TravelExplorer_", 100),
    new User("FoodieAdventures", 10),
    new User("FitnessFreak101", 170),
    new User("ArtisticSoul_", 300),
    new User("FashionistaStyle", 1800)
};
Console.WriteLine(userList.Any(x => x.Follower >= 1000 && x.Nickname.Contains("Style")));


#endregion
#region where
List<Person> people = new List<Person> 
{ 
    new Person { FirstName = "Bob", LastName = "Johnson", Age = 25, Gender = Gender.Male },
    new Person { FirstName = "Charlie", LastName = "Brown", Age=40, Gender = Gender.Male },
    new Person { FirstName = "David", LastName = "Wilson", Age = 28, Gender =Gender.Male },
    new Person { FirstName = "Emma", LastName = "Lee", Age = 35, Gender=     Gender.Female },
    new Person { FirstName = "Frank", LastName = "Davis", Age = 45, Gender = Gender.Male },
    new Person { FirstName = "Grace", LastName = "Taylor", Age = 22, Gender = Gender.Female },
    new Person { FirstName = "Hannah", LastName = "White", Age = 32, Gender= Gender.Female },
    new Person { FirstName = "Isaac", LastName = "Clark", Age = 27, Gender = Gender.Male },
    new Person { FirstName = "Jack", LastName = "Hall", Age = 38, Gender =  Gender.Male },
};
bool filterResult = people.Where(x => x.Age > 40).Any(x => x.Gender == Gender.Female);
Console.WriteLine(filterResult);


#endregion