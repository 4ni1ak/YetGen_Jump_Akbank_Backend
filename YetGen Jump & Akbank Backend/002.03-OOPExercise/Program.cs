using _002._03_OOPExercise.Entities;


//Guest guest1 = new("Yeliz", "Akın", "1114442211", "0532 222 1100");
//Reservation reservation1 = new(guest1, new DateTime(2023, 8, 25, 14, 0, 0), new DateTime(2023, 8, 27));
//Reservation reservation2 = new(guest1, new DateTime(2023, 9, 10), new DateTime(2023, 9, 12)); Reservation reservation3 = new(guest1, new DateTime(2023, 10, 15), new DateTime(2023, 10, 20));
//Console.WriteLine($"Guest: {reservation1.Guest.Name}\nCheckIn Date: {reservation1.CheckInDate}\nCheckOut Date: {reservation1.CheckOutDate}");ValueObject.Guest guest1 = new("Yeliz", "Akın", "1114442211", "0532 222 1100");

_002._03_OOPExercise.ValueObject.Guest guest1 = new("Yeliz", "Akın", "1114442211", "0532 222 1100");
Reservation reservation1 = new(guest1, new DateTime(2023, 8, 25, 14, 0, 0), new DateTime(2023, 8, 27));
Reservation reservation2 = new(guest1, new DateTime(2023, 9, 10), new DateTime(2023, 9, 12)); Reservation reservation3 = new(guest1, new DateTime(2023, 10, 15), new DateTime(2023, 10, 20));
Console.WriteLine($"Guest: {reservation1.Guest.Name}\nCheckIn Date: {reservation1.CheckInDate}\nCheckOut Date: {reservation1.CheckOutDate}");