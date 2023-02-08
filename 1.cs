Console.WriteLine("Enter login: ");
string login = Console.ReadLine();

string pass = (login == "user") ? "Enter password: " : "Wrong user!";
Console.WriteLine(pass);
string password = Console.ReadLine();
string pass1 = (password == "secretpass") ? "Hello user" : "Wrong password";
Console.WriteLine(pass1);