namespace UserManagementSolution;

public class RegularUser : User
{
    public RegularUser (int ID, string name, string email, string role) 
                    : base (ID, name, email, role) {}
    List<User> RegularUsers = new List<User>();
    
    public override void DisplayInfo(){
        foreach (var item in RegularUsers)
        {
            System.Console.WriteLine($"ID: {item.UserID}, Name: {item.Name}, Email: {item.Email}, User role: {item.Role}");
        }
    }
}
