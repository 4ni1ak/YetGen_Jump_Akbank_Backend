using _002._02_OOPExercise;
using _002._02_OOPExercise.ComputerComponents;
using _002._02_OOPExercise.Entities;
using _002._02_OOPExercise.Enums;
using _002._02_OOPExercise.ValueObjects;
using System.Runtime.Intrinsics.X86;

#region Student
Student student1 = new Student(269, "Fatma Özlem", "Acar");
Student student2= new Student(2569, "Aygün", "Bayram");

Console.WriteLine($"Name:{student1.Name} Surname:{student1.Surname}");
Console.WriteLine($"Name:{student2.Name} Surname:{student2.Surname}");
#endregion

#region Computer
Storage storage3 = new Storage("WD Blue",new Capacity(512,CapacitySizeType.GB));
RAM memory1 = new RAM("Corsair", new Capacity(16,CapacitySizeType.GB));
Computer computer3 = new Computer("Apple","MacBook","Intel Pentium",memory1,storage3);
#endregion