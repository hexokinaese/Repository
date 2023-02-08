Console.WriteLine("Enter login: ");
string login = Console.ReadLine();

string pass = (login == "user" || login == "admin") ? "Enter password: " : "Wrong user!";
Console.WriteLine(pass);
string password = Console.ReadLine();
string pass1 = (password != "secretpass") ? "Password is not correct!" : "Welcome!";
Console.WriteLine(pass1);