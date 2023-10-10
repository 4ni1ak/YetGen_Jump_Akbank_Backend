using _005._01_FreelancerApp.Constants;
using _005._01_FreelancerApp.Entities;
using _005._01_FreelancerApp.Sevice;

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),          
    CreatedOn = DateTime.Now,     
    FirstName = "Bob",
    LastName = "Smith",
    PhoneNumber = "555-123-4567"  
};



NotepadService notepadService = new();
notepadService.SaveToNotepad(anotherCustomerInstance);

string customerData = notepadService.GetOnNotepad($"{FileLocations.ProjectFolder}\\Database\\Customers.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}