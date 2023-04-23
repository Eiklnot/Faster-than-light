using Project_CS.Lists;
using System;


public class Player
{
    private Ship Ship = new Ship("Player's Ship", 28, 0,0,0,0);
    private int Scrap;
    private int EngineChargeTime;
    private bool EngineCharging = true;
    private int EngineStatus = 0;
    
    private Player() {}

    private static Player _instance;

    private static readonly object _lock = new object();

    public static Player GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Player();
                    _instance.Scrap = 10;
                    _instance.EngineChargeTime = 8;
                }
            }
        }

        return _instance;
    }

    public bool IsAlive()
    {
        return Ship.GetCurrentHullIntegrity() != 0;
    }

    public int EngineCharge()
    {
        if (EngineCharging)
        {
            EngineStatus++;
            if (EngineStatus == EngineChargeTime)
            {
                EngineCharging = false;
                EngineStatus = 0;
            }
        }
        return EngineStatus;
    }

    public bool IsEngineCharging()
    {
        return EngineCharging;
    }
    
    public Ship GetShip()
    {
        return Ship;
    }

    public void CheckEverything()
    {
        if (Ship.GetShield().IsRegenerating())
        {
            var regen = Ship.GetShield().Regenerate();
            if (Ship.GetShield().IsRegenerating())
            {
                Console.WriteLine("Shield Regenerating status: " + regen + "/" + Ship.GetShield().GetRegenTime());
            }
            Console.WriteLine("Shield is now fully Regenerated and operational for next turn!");
        }
        if (Ship.GetShield().IsReloading())
        {
            var reload =Ship.GetShield().Reload();
            if (Ship.GetShield().IsReloading())
            {
                Console.WriteLine("Shield Reloading status: " + reload + "/" + Ship.GetShield().GetReloadTime());
            }
            Console.WriteLine("Shield is now fully Reloaded and operational for next turn!");
        }
        
        if (Ship.getWeapon(Position.left).IsRegenerating())
        {
            var regen = Ship.getWeapon(Position.left).Regenerate();
            if (Ship.getWeapon(Position.left).IsRegenerating())
            {
                Console.WriteLine("Left Weapon Regenerating status: " + regen + "/" + Ship.getWeapon(Position.left).GetRegenTime());
            }
            Console.WriteLine("Left Weapon is now fully Regenerated and operational for next turn!");
        }
        if (Ship.getWeapon(Position.left).IsReloading())
        {
            var reload =Ship.getWeapon(Position.left).Reload();
            if (Ship.getWeapon(Position.left).IsReloading())
            {
                Console.WriteLine("Left Weapon Reloading status: " + reload + "/" + Ship.getWeapon(Position.left).GetReloadTime());
            }
            Console.WriteLine("Left Weapon is now fully Reloaded and operational for next turn!");
        }
        
        if (Ship.getWeapon(Position.middle).IsRegenerating())
        {
            var regen = Ship.getWeapon(Position.middle).Regenerate();
            if (Ship.getWeapon(Position.middle).IsRegenerating())
            {
                Console.WriteLine("Middle Weapon Regenerating status: " + regen + "/" + Ship.getWeapon(Position.middle).GetRegenTime());
            }
            Console.WriteLine("Middle Weapon is now fully Regenerated and operational for next turn!");
        }
        if (Ship.getWeapon(Position.middle).IsReloading())
        {
            var reload =Ship.getWeapon(Position.middle).Reload();
            if (Ship.getWeapon(Position.middle).IsReloading())
            {
                Console.WriteLine("Middle Weapon Reloading status: " + reload + "/" + Ship.getWeapon(Position.middle).GetReloadTime());
            }
            Console.WriteLine("Middle Weapon is now fully Reloaded and operational for next turn!");
        }
        
        if (Ship.getWeapon(Position.right).IsRegenerating())
        {
            var regen = Ship.getWeapon(Position.right).Regenerate();
            if (Ship.getWeapon(Position.right).IsRegenerating())
            {
                Console.WriteLine("Right Weapon Regenerating status: " + regen + "/" + Ship.getWeapon(Position.right).GetRegenTime());
            }
            Console.WriteLine("Right Weapon is now fully Regenerated and operational for next turn!");
        }
        if (Ship.getWeapon(Position.right).IsReloading())
        {
            var reload =Ship.getWeapon(Position.right).Reload();
            if (Ship.getWeapon(Position.right).IsReloading())
            {
                Console.WriteLine("Right Weapon Reloading status: " + reload + "/" + Ship.getWeapon(Position.right).GetReloadTime());
            }
            Console.WriteLine("Right Weapon is now fully Reloaded and operational for next turn!");
        }
    }
}