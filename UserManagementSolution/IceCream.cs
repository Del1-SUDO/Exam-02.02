namespace UserManagementSolution;

public class IceCream
{
    public Dictionary<String, int> New = new Dictionary<string, int>()
    {
        {"Flavour", 0}
    };
    public Dictionary<String, int> Sweetness = new Dictionary<string, int>()
    {
        {"Plain", 0},
        {"Vanilla", 5},
        {"ChocolateChip", 5},
        {"Strawberry", 10},
        {"Chocolate", 10}
    };

    public void Flavors (){
        int Sweetest = 0;
        foreach (var item in Sweetness)
        {
            if (item.Value > Sweetest)
            {
                New["Flavour"]=item.Value;
            }
        }
        foreach (var most in New)
        {
            System.Console.Write($"Value of the sweetest ice cream is: {most.Value}");
        }
    }
}
