Console.WriteLine("Enter login: ");
string login = Console.ReadLine();

string pass = (login == "admin") ? "Enter password: " : "Wrong user!";
Console.WriteLine(pass);
string password = Console.ReadLine();
string pass1 = (password == "secretpass") ? "Hello Administrator" : "Wrong password";
Console.WriteLine(pass1);