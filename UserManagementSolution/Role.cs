namespace UserManagementSolution;

public class Role
{
    public string RoleName;
    public List<string> Permissions = new List<string>();
    public string GetPermissions(){
        return "Permissions: ";
        if (Permissions.Count()==0)
        {
            return "No permissions.";
        }
        else
        {
            foreach (var item in Permissions)
            {
                return $"{item}";
            }
        }
    }
}
