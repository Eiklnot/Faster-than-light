namespace Project_CS.Lists;

public class WeaponList
{
    private static List<Weapon> list = new List<Weapon>
    {
        new Weapon("Example Weapon", 5, 2,2,3)
    };

    public static Weapon GetWeaponById(int id)
    {
        if (id >= 0 && id < list.Count)
        {
            return list[id];
        }
        return null;
    }
    
    public static Weapon GetWeaponByName(string name)
    {
        return list.Find(s => s.GetName() == name);
    }
    
    public static int GetWeaponListLenght()
    {
        return list.Count;
    }
}