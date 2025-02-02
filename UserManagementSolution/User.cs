namespace UserManagementSolution;

public class User
{
    public int UserID;
    public string Name;
    public string Email;
    public string Role;

    public User (int ID, string name, string email, string role)
    {
        UserID = ID;
        Name = name;
        Email = email;
        Role = role;
    }

    public virtual void DisplayInfo(){
        System.Console.WriteLine($"ID: {UserID}, Name: {Name}, Email: {Email}, User role: {Role}");
    }
}
