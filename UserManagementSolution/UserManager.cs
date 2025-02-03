namespace UserManagementSolution;
interface IUserActions
{
    public void CreateUser();
    public void DeleteUser();
    public void ChangeRole();
}
public class UserManager
{
    public List<User> list = new List<User>();

    public void AddUsers(User user)
    {
        list.Add(user);
        System.Console.WriteLine("User is added successefully.");
    }
    public void RemoveUsers(int ID)
    {
        bool found = false;
        foreach (var item in list)
        {
            if (item.UserID == ID)
            {
                list.Remove(item);
                found = true;
                System.Console.WriteLine("User is removed successefully.");
                break;
            }

            if (!found)
            {
                System.Console.WriteLine("User is not found.");
            }
        }
    }
    public void ChangeRoleOfUser(int ID, string role)
    {
        bool found = false;
        foreach (var item in list)
        {
            if (item.UserID == ID)
            {
                item.Role = role;
                found = true;
                System.Console.WriteLine("User's role has been changed successefully.");
                break;
            }
        }
        if (!found)
        {
            System.Console.WriteLine("User is not found.");
        }
    }

    public void ShowAllUsers()
    {
        foreach (var item in list)
        {
            item.DisplayInfo();
        }
    }

}
