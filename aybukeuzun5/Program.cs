string username, password;

Console.WriteLine("enter your username:");
username = Console.ReadLine();
Console.WriteLine("enter your password:");
password = Console.ReadLine();

//if (username == "admin" && password == "admin1234")
//{
//    Console.WriteLine("welcome");
//}
//else
//{
//    Console.WriteLine("invalid data");
//}


if (username != "admin" |   | password != "admin1234")
{
    Console.WriteLine("invalid");
}
else
{
    Console.WriteLine("welcome");
}
