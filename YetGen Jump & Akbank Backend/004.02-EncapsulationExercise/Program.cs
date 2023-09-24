using _004._02_EncapsulationExercise.Entities;

Account account1 = new("Anil", "Akpinar");
account1.Balance -= 100;
account1.Balance += 10000000;
Console.WriteLine($"Current value {account1.Balance}");
