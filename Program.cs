#nullable disable

Console.WriteLine("Please enter your first name"); 
string firstName = Console.ReadLine(); 
Console.WriteLine("Please enter your last name"); 
string lastName = Console.ReadLine(); 

// var Nicknames = new List<string>(); 
// Nicknames.Add("Diabolical"); 
// Nicknames.Add("Darkness"); 
// Nicknames.Add("Swallower"); 
// Nicknames.Add("Cold"); 
// Nicknames.Add("Sinister"); 
var Nicknames = new List<string>{"Diabolical", "Darkness", "Swallower", "Cold", "Sinister"}; 
for (int i = 0; i < Nicknames.Count; i++) {
    Console.WriteLine(Nicknames[i]); 

    // Nicknames --->                 "0"            "1"         "2"        "3"      "4" 
    Console.WriteLine($"\nHello, your current name is {firstName} \"{Nicknames[i]}\" {lastName}."); 
}