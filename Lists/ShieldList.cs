namespace Project_CS.Lists;


public class ShieldList
{
    private static List<Shield> list = new List<Shield>
    {
        new Shield("Example Shield", 5, 6,2,3)
    };

    public static Shield GetShieldById(int id)
    {
        if (id >= 0 && id < list.Count)
        {
            return list[id];
        }
        return null;
    }
    
    public static Shield GetShieldByName(string name)
    {
        return list.Find(s => s.GetName() == name);
    }
    
    public static int GetShieldListLenght()
    {
        return list.Count;
    }
}