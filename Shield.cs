
public class Shield
{
    private string Name;
    private int Health;
    private int CurrentHealth;
    private int Units;
    private int CurrentUnits;
    private int RegenTime;
    private bool Regenerating = false;
    private int RegenStatus = 0;
    private int ReloadTime;
    private bool Reloading = false;
    private int ReloadStatus = 0;

    public Shield()
    {
        Name = "Unknown";
        Health = 1;
        CurrentHealth = 1;
        Units = 0;
        CurrentUnits = 1;
    }
    
    public Shield(Shield pfShield)
    {
        Name = pfShield.Name;
        Health = pfShield.Health;
        CurrentHealth = pfShield.CurrentHealth;
        Units = pfShield.Units;
        CurrentUnits = pfShield.CurrentUnits;
        ReloadTime = pfShield.ReloadTime;
        RegenTime = pfShield.RegenTime;
    }

    public Shield(string pfName, int pfHealth, int pfUnits, int pfReloadTime, int pfRegenTime)
    {
        Name = pfName;
        Health = pfHealth;
        CurrentHealth = pfHealth;
        Units = pfUnits;
        CurrentUnits = pfUnits;
        ReloadTime = pfReloadTime;
        RegenTime = pfRegenTime;
    }
    
    public void RemoveHealth(int pfDamageTaken)
    {
        if (CurrentHealth - pfDamageTaken <= 0)
        {
            CurrentHealth = 0;
            Regenerating = false;
        }
        else
        {
            CurrentHealth -= pfDamageTaken;
        }
    }

    public int ShieldProtect(int pfDamageTaken)
    {
        var tempUnit = CurrentUnits;
        if (Regenerating)
        {
            return pfDamageTaken;
        }
        if (Reloading)
        {
            return pfDamageTaken;
        }
        if (tempUnit - pfDamageTaken <= 0)
        {
            CurrentUnits = 0;
            Reloading = false;
            return pfDamageTaken - CurrentUnits;
        }
        CurrentUnits = tempUnit - pfDamageTaken;
        return 0;
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
    
    public int GetUnits()
    {
        return Units;
    }

    public int GetHealth()
    {
        return Health;
    }
    
    public int GetCurrentHealth()
    {
        return CurrentHealth;
    }
    
    public int GetCurrentUnits()
    {
        return CurrentUnits;
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