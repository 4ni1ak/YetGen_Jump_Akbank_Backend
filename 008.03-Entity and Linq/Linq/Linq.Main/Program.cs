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

#region First FirstOrDefault
List<Book> books = new List<Book>
{
new Book("To Kill a Mockingbird", "Harper Lee", "978-0987654321", new DateTime (1960, 7, 11), 14.95, Genre.Fiction),
new Book("1984", "George Orwell", "978-5678901234", new DateTime (1949, 6, 8), 9.99, Genre.ScienceFiction),
new Book("The Hobbit", "J.R.R. Tolkien", "978-9876543210", new DateTime (1937, 9, 21), 13.75, Genre.Fantasy),
new Book("Animal Farm", "George Orwell", "978-9876543211", new DateTime(1945, 8, 17), 10.99, Genre. Fiction),
};
var book = books.Where(x => x.Genre == Genre.History).FirstOrDefault();
Console.WriteLine();
#endregion

#region Single SingleOrDefault

var boo1 = books.Where(x => x.ISBN == "978-5678901234").SingleOrDefault();
Console.WriteLine(boo1);
#endregion

#region OrderBy Thenby
List<PersonOB> people2 = new List<PersonOB>
        {
            new PersonOB("Bob", "Johnson", 25, Gender.Male),
            new PersonOB("Charlie", "Brown", 40, Gender.Male),
            new PersonOB("David", "Wilson", 28, Gender.Male),
            new PersonOB("Emma", "Lee", 35, Gender.Female),
            new PersonOB("Frank", "Davis", 45, Gender.Male),
            new PersonOB("Grace", "Taylor", 22, Gender.Female),
            new PersonOB("Hannah", "White", 32, Gender.Female),
            new PersonOB("Isaac", "Clark", 27, Gender.Male),
            new PersonOB("Jack", "Hall", 38, Gender.Male)
        };

var sortedPeople = people2.OrderBy(p => p.LastName).ThenBy(p => p.FirstName);

foreach (var person in sortedPeople)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

#endregion

#region Skip
var skippedPeople = people2.Skip(4);
foreach (var person in skippedPeople)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}
#endregion

#region Take
List<int> numbers1 = new List<int> { 10, 20, 30, 40, 50, 60, 70 };

var firstThreeNumbers = numbers1.Take(3);

foreach (var number in firstThreeNumbers)
{
    Console.WriteLine(number);
}
#endregion

#region Avarage
numbers.Average();

#endregion 

#region Concat
List<int> numbers2 = new List<int> { 11, 21, 31, 41, 51, 61, 71 };
var mergedList = numbers1.Concat(numbers2);
#endregion

#region Max min 
var minNumber = numbers1.Min();
var maxNumber = numbers2.Max();
Console.WriteLine(minNumber);
Console.WriteLine(maxNumber);

#endregion


