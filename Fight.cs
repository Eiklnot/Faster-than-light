using System;

namespace Project_CS{

    public static class Fight{

        public static void scena(){

            string [] msgs ={"As you arrive to the first planet, you here a voice in the comms",
            "\"Stop right there rebel if you surender no harm will come to you, resist and we’ll have no choice but to destroy your ship and you with it\"",
            "1 Fight","2 Flee"};


            string [] msgs1 ={"You have been roaming the emptiness of space for hours, and suddenly you see a ship aproaching you rapidly",
            "\"What do we have here, rebels just out of the base.\"", "\"Give us all you have and we ll let you go\"",
            "1 Fight","2 Flee"};
            
            string[][] messages={msgs,msgs1};
            Random rand = new Random();
            string[] currentmsg = messages[rand.Next(2)];
            
            for(int i = 0 ; i < currentmsg.GetLength(0) ; i++){
                System.Console.WriteLine(currentmsg[i]);
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1){
                Combat.CombatSystem(Player.GetInstance());
            }
        }

    }

}