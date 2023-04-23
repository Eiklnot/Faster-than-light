
using System;
public class Combat
{
    public static void CombatSystem(Player pfPlayer)
        {
            var opponent = new Enemy();
            Console.WriteLine("Encounter with enemy " + opponent.GetShip().GetName());
            while (opponent.IsAlive())
            {
                Console.WriteLine("Enemy's health: " + opponent.GetShip().GetCurrentHullIntegrity() 
                                                     + "/" + opponent.GetShip().GetHullIntegrity());
                Console.WriteLine("Enemy's shield: " + opponent.GetShip().GetShield().GetName()
                                                     + " Health " + opponent.GetShip().GetShield().GetCurrentHealth()
                                                     + "/" + opponent.GetShip().GetShield().GetHealth()
                                                     + " Untis " + opponent.GetShip().GetShield().GetCurrentUnits()
                                                     + "/" + opponent.GetShip().GetShield().GetUnits());
                Console.WriteLine("Enemy's Left Weapon: " + opponent.GetShip().getWeapon(Position.left).GetName() 
                                                          + " Health " + opponent.GetShip().getWeapon(Position.left).GetCurrentHealth() 
                                                          + "/" + opponent.GetShip().getWeapon(Position.left).GetHealth() 
                                                          + " Damage " + opponent.GetShip().getWeapon(Position.left).GetDamage());
                Console.WriteLine("Enemy's Middle Weapon: " + opponent.GetShip().getWeapon(Position.middle).GetName() 
                                                            + " Health " + opponent.GetShip().getWeapon(Position.middle).GetCurrentHealth() 
                                                            + "/" + opponent.GetShip().getWeapon(Position.middle).GetHealth() 
                                                            + " Damage " + opponent.GetShip().getWeapon(Position.middle).GetDamage());
                Console.WriteLine("Enemy's Right Weapon: " + opponent.GetShip().getWeapon(Position.right).GetName() 
                                                           + " Health " + opponent.GetShip().getWeapon(Position.right).GetCurrentHealth() 
                                                           + "/" + opponent.GetShip().getWeapon(Position.right).GetHealth() 
                                                           + " Damage " + opponent.GetShip().getWeapon(Position.right).GetDamage());
                Console.WriteLine("");
                Console.WriteLine("Your health: " + pfPlayer.GetShip().GetCurrentHullIntegrity()
                                                  + "/" + pfPlayer.GetShip().GetHullIntegrity());
                Console.WriteLine("Your shield: " + pfPlayer.GetShip().GetShield().GetName()
                                                  + " Health " + pfPlayer.GetShip().GetShield().GetCurrentHealth()
                                                  + "/" + pfPlayer.GetShip().GetShield().GetHealth()
                                                  + " Untis " + pfPlayer.GetShip().GetShield().GetCurrentUnits()
                                                  + "/" + pfPlayer.GetShip().GetShield().GetUnits());
                Console.WriteLine("Your Left Weapon: " + pfPlayer.GetShip().getWeapon(Position.left).GetName() 
                                                       + " Health " + pfPlayer.GetShip().getWeapon(Position.left).GetCurrentHealth() 
                                                       + "/" + pfPlayer.GetShip().getWeapon(Position.left).GetHealth() 
                                                       + " Damage " + pfPlayer.GetShip().getWeapon(Position.left).GetDamage());
                Console.WriteLine("Your Middle Weapon: " + pfPlayer.GetShip().getWeapon(Position.middle).GetName() 
                                                         + " Health " + pfPlayer.GetShip().getWeapon(Position.middle).GetCurrentHealth() 
                                                         + "/" + pfPlayer.GetShip().getWeapon(Position.middle).GetHealth() 
                                                         + " Damage " + pfPlayer.GetShip().getWeapon(Position.middle).GetDamage());
                Console.WriteLine("Your Right Weapon: " + pfPlayer.GetShip().getWeapon(Position.right).GetName() 
                                                        + " Health " + pfPlayer.GetShip().getWeapon(Position.right).GetCurrentHealth() 
                                                        + "/" + pfPlayer.GetShip().getWeapon(Position.right).GetHealth() 
                                                        + " Damage " + pfPlayer.GetShip().getWeapon(Position.right).GetDamage());
                Console.WriteLine("");
                Console.WriteLine("LEFT WEAPON");
                FireOnEnemy(opponent,pfPlayer.GetShip().getWeapon(Position.left));
                if (!opponent.IsAlive()) break;
                Console.WriteLine("MIDDLE WEAPON");
                FireOnEnemy(opponent,pfPlayer.GetShip().getWeapon(Position.middle));
                if (!opponent.IsAlive()) break;
                Console.WriteLine("RIGHT WEAPON");
                FireOnEnemy(opponent,pfPlayer.GetShip().getWeapon(Position.right));
                
                opponent.WeaponFire(opponent.GetShip().getWeapon(Position.left),pfPlayer);
                if (!pfPlayer.IsAlive()) break;
                opponent.WeaponFire(opponent.GetShip().getWeapon(Position.middle),pfPlayer);
                if (!pfPlayer.IsAlive()) break;
                opponent.WeaponFire(opponent.GetShip().getWeapon(Position.right),pfPlayer);
                
                pfPlayer.CheckEverything();
                opponent.CheckEverything();
            }

            if (!opponent.IsAlive())
            {
                Console.WriteLine("Enemy " + opponent.GetShip().GetName() + " have been destroyed!");
                Console.WriteLine();
            }
        }

        private static void FireOnEnemy(Enemy pfEnemy, Weapon pfWeapon)
        {
            Console.WriteLine("AIMING:  1.LEFT WEAPON  2.MIDDLE WEAPON  3.RIGHT WEAPON  4.SHIELD  5.HULL");
            var aimingchoice = 0;
            string aiminginput;
            var Damage = pfEnemy.GetShip().GetShield().ShieldProtect(pfWeapon.GetDamage());
            while (aimingchoice is not (1 or 2 or 3 or 4 or 5))
            {
                aiminginput = Console.ReadLine();
                switch (aiminginput)
                {
                    case "1":
                        pfEnemy.GetShip().getWeapon(Position.left).RemoveHealth(Damage);
                        Console.WriteLine(Damage + " damage have been done to the left weapon");
                        Console.WriteLine("Enemy's Left Weapon: " + pfEnemy.GetShip().getWeapon(Position.left).GetName() 
                                                                  + " Health " + pfEnemy.GetShip().getWeapon(Position.left).GetCurrentHealth() 
                                                                  + "/" + pfEnemy.GetShip().getWeapon(Position.left).GetHealth() 
                                                                  + " Damage " + pfEnemy.GetShip().getWeapon(Position.left).GetDamage());
                        aimingchoice = 1;
                        break;
                    case "2":
                        pfEnemy.GetShip().getWeapon(Position.middle).RemoveHealth(Damage);
                        Console.WriteLine(Damage + " damage have been done to the middle weapon");
                        Console.WriteLine("Enemy's Middle Weapon: " + pfEnemy.GetShip().getWeapon(Position.middle).GetName() 
                                                                    + " Health " + pfEnemy.GetShip().getWeapon(Position.middle).GetCurrentHealth() 
                                                                    + "/" + pfEnemy.GetShip().getWeapon(Position.middle).GetHealth() 
                                                                    + " Damage " + pfEnemy.GetShip().getWeapon(Position.middle).GetDamage());
                        aimingchoice = 2;
                        break;
                    case "3":
                        pfEnemy.GetShip().getWeapon(Position.right).RemoveHealth(Damage);
                        Console.WriteLine(Damage + " damage have been done to the right weapon");
                        Console.WriteLine("Enemy's Right Weapon: " + pfEnemy.GetShip().getWeapon(Position.right).GetName() 
                                                                   + " Health " + pfEnemy.GetShip().getWeapon(Position.right).GetCurrentHealth() 
                                                                   + "/" + pfEnemy.GetShip().getWeapon(Position.right).GetHealth() 
                                                                   + " Damage " + pfEnemy.GetShip().getWeapon(Position.right).GetDamage());
                        aimingchoice = 3;
                        break;
                    case "4":
                        pfEnemy.GetShip().GetShield().RemoveHealth(Damage);
                        Console.WriteLine(Damage + " damage have been done to the shield");
                        Console.WriteLine("Enemy's shield: " + pfEnemy.GetShip().GetShield().GetName()
                                                             + " Health " + pfEnemy.GetShip().GetShield().GetCurrentHealth()
                                                             + "/" + pfEnemy.GetShip().GetShield().GetHealth()
                                                             + " Untis " + pfEnemy.GetShip().GetShield().GetCurrentUnits()
                                                             + "/" + pfEnemy.GetShip().GetShield().GetUnits());
                        aimingchoice = 4;
                        break;
                    case "5":
                        pfEnemy.GetShip().RemoveHealth(Damage);
                        Console.WriteLine(Damage + " damage have been done to the hull");
                        Console.WriteLine("Enemy's health: " + pfEnemy.GetShip().GetCurrentHullIntegrity() 
                                                             + "/" + pfEnemy.GetShip().GetHullIntegrity());
                        aimingchoice = 5;
                        break;
                    default: 
                        Console.WriteLine("You didn't specified a correct number");
                        break;
                }
            }
        }
}