using Project_CS.Lists;
using System;



public class Enemy
{
    private Random rnd = new Random();
    private Ship Ship;
    private int loot;

    public Enemy()
    {
        Ship = new Ship("Ennemy Ship",
            rnd.Next(12, 22),
            rnd.Next(WeaponList.GetWeaponListLenght() - 1),
            rnd.Next(WeaponList.GetWeaponListLenght() - 1),
            rnd.Next(WeaponList.GetWeaponListLenght() - 1),
            rnd.Next(ShieldList.GetShieldListLenght() - 1));
        loot = rnd.Next(5, 15);
    }
    
    public void WeaponFire(Weapon pfWeapon, Player pfPlayer)
    {
        var damage = pfPlayer.GetShip().GetShield().ShieldProtect(pfWeapon.GetDamage());
        if (!pfPlayer.GetShip().GetShield().IsReloading() && !pfPlayer.GetShip().GetShield().IsRegenerating())
        {
            pfPlayer.GetShip().GetShield().RemoveHealth(damage);
            Console.WriteLine("Enemy " + Ship.GetName() + "Dealt " + damage + " to your Shields");
            Console.WriteLine("Your Shield's life: " + pfPlayer.GetShip().GetShield().GetCurrentHealth()
                                                     +"/"+pfPlayer.GetShip().GetShield().GetHealth());
            Console.WriteLine("You have " + pfPlayer.GetShip().GetShield().GetCurrentUnits() 
                                          + "/" + pfPlayer.GetShip().GetShield().GetUnits()
                                          + " Shields Units remaining");
            return;
        }
        pfPlayer.GetShip().RemoveHealth(damage);
        Console.WriteLine("Enemy " + Ship.GetName() + "Dealt " + damage + " to your Hull");
        Console.WriteLine("Your Ship Hull's life: " + pfPlayer.GetShip().GetShield().GetCurrentHealth() 
                                                    +"/"+pfPlayer.GetShip().GetShield().GetHealth());
        Console.WriteLine("You have " + pfPlayer.GetShip().GetShield().GetCurrentUnits() 
                                      + "/" + pfPlayer.GetShip().GetShield().GetUnits()
                                      + " Shields Units remaining");
    }
    
    public bool IsAlive()
    {
        return Ship.GetCurrentHullIntegrity() != 0;
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
                Console.WriteLine("Enemy's Shield Regenerating status: " + regen + "/" + Ship.GetShield().GetRegenTime());
            }
            Console.WriteLine("Enemy's Shield is now fully Regenerated and operational for next turn!");
        }
        if (Ship.GetShield().IsReloading())
        {
            var reload =Ship.GetShield().Reload();
            if (Ship.GetShield().IsReloading())
            {
                Console.WriteLine("Enemy's Shield Reloading status: " + reload + "/" + Ship.GetShield().GetReloadTime());
            }
            Console.WriteLine("Enemy's Shield is now fully Reloaded and operational for next turn!");
        }
        
        if (Ship.getWeapon(Position.left).IsRegenerating())
        {
            var regen = Ship.getWeapon(Position.left).Regenerate();
            if (Ship.getWeapon(Position.left).IsRegenerating())
            {
                Console.WriteLine("Enemy's Left Weapon Regenerating status: " + regen + "/" + Ship.getWeapon(Position.left).GetRegenTime());
            }
            Console.WriteLine("Enemy's Left Weapon is now fully Regenerated and operational for next turn!");
        }
        if (Ship.getWeapon(Position.left).IsReloading())
        {
            var reload =Ship.getWeapon(Position.left).Reload();
            if (Ship.getWeapon(Position.left).IsReloading())
            {
                Console.WriteLine("Enemy's Left Weapon Reloading status: " + reload + "/" + Ship.getWeapon(Position.left).GetReloadTime());
            }
            Console.WriteLine("Enemy's Left Weapon is now fully Reloaded and operational for next turn!");
        }
        
        if (Ship.getWeapon(Position.middle).IsRegenerating())
        {
            var regen = Ship.getWeapon(Position.middle).Regenerate();
            if (Ship.getWeapon(Position.middle).IsRegenerating())
            {
                Console.WriteLine("Enemy's Middle Weapon Regenerating status: " + regen + "/" + Ship.getWeapon(Position.middle).GetRegenTime());
            }
            Console.WriteLine("Enemy's Middle Weapon is now fully Regenerated and operational for next turn!");
        }
        if (Ship.getWeapon(Position.middle).IsReloading())
        {
            var reload =Ship.getWeapon(Position.middle).Reload();
            if (Ship.getWeapon(Position.middle).IsReloading())
            {
                Console.WriteLine("Enemy's Middle Weapon Reloading status: " + reload + "/" + Ship.getWeapon(Position.middle).GetReloadTime());
            }
            Console.WriteLine("Enemy's Middle Weapon is now fully Reloaded and operational for next turn!");
        }
        
        if (Ship.getWeapon(Position.right).IsRegenerating())
        {
            var regen = Ship.getWeapon(Position.right).Regenerate();
            if (Ship.getWeapon(Position.right).IsRegenerating())
            {
                Console.WriteLine("Enemy's Right Weapon Regenerating status: " + regen + "/" + Ship.getWeapon(Position.right).GetRegenTime());
            }
            Console.WriteLine("Enemy's Right Weapon is now fully Regenerated and operational for next turn!");
        }
        if (Ship.getWeapon(Position.right).IsReloading())
        {
            var reload =Ship.getWeapon(Position.right).Reload();
            if (Ship.getWeapon(Position.right).IsReloading())
            {
                Console.WriteLine("Enemy's Right Weapon Reloading status: " + reload + "/" + Ship.getWeapon(Position.right).GetReloadTime());
            }
            Console.WriteLine("Enemy's Right Weapon is now fully Reloaded and operational for next turn!");
        }
    }
}