namespace UserManagementSolution;

public class AdminUser : User
{
    public AdminUser (int ID, string name, string email, string role) 
                    : base (ID, name, email, role) {}
    List<User> AdminUsers = new List<User>();
    
    public override void DisplayInfo(){
        foreach (var item in AdminUsers)
        {
            System.Console.WriteLine($"ID: {item.UserID}, Name: {item.Name}, Email: {item.Email}, User role: {item.Role}");
        }
    }

}
