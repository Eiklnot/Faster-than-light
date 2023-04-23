using Project_CS.Lists;



public class Ship
{
    private string Name;
    private int HullIntegrity;
    private int CurrentHullIntegrity;
    private Weapon LeftWeapon;
    private Weapon MiddleWeapon;
    private Weapon RightWeapon;
    private Shield Shield;

    public Ship()
    {
        Name = "Unknown";
        HullIntegrity = 1;
    }

    public Ship(string pfName, int pfHullIntegrity, int pfLeftWeapon, int pfMiddleWeapon, int pfRightWeapon,
        int pfShield)
    {
        Name = pfName;
        HullIntegrity = pfHullIntegrity;
        CurrentHullIntegrity = pfHullIntegrity;
        LeftWeapon = new Weapon(WeaponList.GetWeaponById(pfLeftWeapon));
        MiddleWeapon = WeaponList.GetWeaponById(pfMiddleWeapon);
        RightWeapon = WeaponList.GetWeaponById(pfRightWeapon);
        Shield = ShieldList.GetShieldById(pfShield);
    }
    
    public Ship(string pfName, int pfHullIntegrity, string pfLeftWeapon, string pfMiddleWeapon, string pfRightWeapon,
        string pfShield)
    {
        Name = pfName;
        HullIntegrity = pfHullIntegrity;
        LeftWeapon = WeaponList.GetWeaponByName(pfLeftWeapon);
        MiddleWeapon = WeaponList.GetWeaponByName(pfMiddleWeapon);
        RightWeapon = WeaponList.GetWeaponByName(pfRightWeapon);
        Shield = ShieldList.GetShieldByName(pfShield);
    }
    
    public void RemoveHealth(int pfDamageTaken)
    {
        if (CurrentHullIntegrity - pfDamageTaken <= 0)
        {
            CurrentHullIntegrity = 0;
        }
        else
        {
            CurrentHullIntegrity -= pfDamageTaken;
        }
    }
    
    public int GetHullIntegrity()
    {
        return HullIntegrity;
    }
    public int GetCurrentHullIntegrity()
    {
        return CurrentHullIntegrity;
    }
    public string GetName()
    {
        return Name;
    }

    public Weapon getWeapon(Position position)
    {
        switch (position)
        {
            case Position.left:
                return LeftWeapon;
            case Position.middle:
                return MiddleWeapon;
            case Position.right:
                return RightWeapon;
            default:
                return null;
        }
    }
    
    public void setWeapon(Position position, Weapon pfWeapon)
    {
        switch (position)
        {
            case Position.left:
                LeftWeapon = pfWeapon;
                break;
            case Position.middle:
                MiddleWeapon = pfWeapon;
                break;
            case Position.right:
                RightWeapon = pfWeapon;
                break;
        }
    }

    public Shield GetShield()
    {
        return Shield;
    }

    public void SetShield(Shield pfShield)
    {
        Shield = pfShield;
    }
}

public enum Position {
    left,
    middle,
    right
}