using System;
using UserManagementSolution;
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < i; j++)
    {
        System.Console.Write(i + " ");
    }
    System.Console.WriteLine();
}

int n = 6;
for (int i = 4; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        System.Console.Write(n + " ");
    }
    n++;
    System.Console.WriteLine();
}

System.Console.WriteLine();
IceCream iceCream = new IceCream();
iceCream.Flavors();

UserManager manager = new UserManager();
System.Console.WriteLine();
for (;;)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Choose an option: ");
    System.Console.WriteLine("1. Add user.");
    System.Console.WriteLine("2. Remove user.");
    System.Console.WriteLine("3. Change user's role.");
    System.Console.WriteLine("4. Display users and their permissions.");
    System.Console.WriteLine("0. Exit.");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        User user = new User(1, "John", "John@gmail.com", "Waiter");
        User user2 = new User(2, "Jack", "Jack@gmail.com", "Client");
        User user3 = new User(3, "Anton", "Anton@gmail.com", "Client");
        manager.AddUsers(user);
        manager.AddUsers(user2);
        manager.AddUsers(user3);
        System.Console.WriteLine("Users are added successefully.");
    }
    if (choice == "2")
    {
        System.Console.WriteLine("Removing a user...");
        manager.RemoveUsers(1);
    }
    if (choice == "3")
    {
        System.Console.WriteLine("Changing user's role: ");
        manager.ChangeRoleOfUser(2, "Admin");
    }
    if (choice == "4")
    {
        System.Console.WriteLine("List of all users: ");
        manager.ShowAllUsers();
    }
    if (choice == "0")
    {
        System.Console.WriteLine("Exiting, bye.");
        break;
    }
}