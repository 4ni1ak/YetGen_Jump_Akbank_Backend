using _002._02_OOPExercise;
using _002._02_OOPExercise.Entities;
using _002._02_OOPExercise.Enums;
using System.Runtime.Intrinsics.X86;

#region Student
Student student1 = new Student(269, "Fatma Özlem", "Acar");
Student student2= new Student(2569, "Aygün", "Bayram");

Console.WriteLine($"Name:{student1.Name} Surname:{student1.Surname}");
Console.WriteLine($"Name:{student2.Name} Surname:{student2.Surname}");
#endregion

Computer computer1 = new Computer("Apple","MacBook","Inteli7","Corsair 16GB","WD Blue",256,CapacitySizeType.GB);
Computer computer2= new Computer("Apple","MacBook","Inteli7","Corsair 16GB","WD Blue",256,CapacitySizeType.TB);
Computer computer3 = new Computer("Apple","MacBook","Intel Pentium","Samsung 2GB","WD Blue",512,CapacitySizeType.MB);
