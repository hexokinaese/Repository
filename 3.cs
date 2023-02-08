Console.WriteLine("Enter login: ");
string login = Console.ReadLine();

string pass = (login == "") ? "Hello Anonymous" : "Hello user";
Console.WriteLine(pass);
