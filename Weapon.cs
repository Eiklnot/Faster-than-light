

public class Weapon
{
    private string Name;
    private int Health;
    private int CurrentHealth;
    private int Damage;
    private int RegenTime;
    private bool Regenerating = false;
    private int RegenStatus = 0;
    private int ReloadTime;
    private bool Reloading = false;
    private int ReloadStatus = 0;

    public Weapon()
    {
        Name = "Unknown";
        Health = 1;
        CurrentHealth = 1;
        Damage = 0;
    }

    public Weapon(string pfName, int pfHealth, int pfDamage, int pfReloadTime, int pfRegenTime)
    {
        Name = pfName;
        Health = pfHealth;
        CurrentHealth = pfHealth;
        Damage = pfDamage;
        ReloadTime = pfReloadTime;
        RegenTime = pfRegenTime;
    }
    
    public Weapon(Weapon pfWeapon)
    {
        Name = pfWeapon.Name;
        Health = pfWeapon.Health;
        CurrentHealth = pfWeapon.CurrentHealth;
        Damage = pfWeapon.Damage;
        ReloadTime = pfWeapon.ReloadTime;
        RegenTime = pfWeapon.RegenTime;
    }

    public void RemoveHealth(int pfDamageTaken)
    {
        if (CurrentHealth - pfDamageTaken <= 0)
        {
            CurrentHealth = 0;
            Regenerating = true;
        }
        else
        {
            CurrentHealth -= pfDamageTaken;
        }
    }

    public bool Fire()
    {
        if (Reloading)
        {
            return false;
        }
        Reloading = true;
        return true;
    }

    public int Regenerate()
    {
        if (Regenerating)
        {
            RegenStatus++;
            if (RegenStatus == RegenTime)
            {
                Regenerating = false;
                RegenStatus = 0;
                CurrentHealth = Health;
            }
        }
        return RegenStatus;
    }
    
    public int Reload()
    {
        if (Reloading)
        {
            ReloadStatus++;
            if (ReloadStatus == ReloadTime)
            {
                Reloading = false;
                ReloadStatus = 0;
            }
        }
        return ReloadStatus;
    }

    public bool IsRegenerating()
    {
        return Regenerating;
    }
    
    public bool IsReloading()
    {
        return Reloading;
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public int GetDamage()
    {
        return Damage;
    }
    
    public int GetHealth()
    {
        return Health;
    }
    
    public int GetCurrentHealth()
    {
        return CurrentHealth;
    }
    
    public int GetRegenTime()
    {
        return RegenTime;
    }
    
    public int GetReloadTime()
    {
        return ReloadTime;
    }
}