using System;

namespace Project_CS
{
    public class Shop{

        public string name;
        public string items;
        public float prices;
        public string [] msgs;

        
        public static void scena(){
            string [] msgs ={"You arrive to Station that is in a bad state, it seems like it is barely holding up.",
            "A voice from the comms starts talking to you :",
            "\"Hey you are from the base?\"","1 yes, we just left","2 no"};


            string [] msgs1 ={"You hear from the comms a commanding voice that can only be from an emperial officer that says to you",
            "\"Stop right there and declare yourself\"",
            "1 we are just transporting merchendise looking to sell or buy","2 You will die emperial scum (fight)"};
            
            string[][] messages={msgs,msgs1};
            Random rand = new Random();
            string[] currentmsg = messages[rand.Next(2)];
            
            for(int i = 0 ; i < currentmsg.GetLength(0) ; i++){
                System.Console.WriteLine(currentmsg[i]);
            }


        }

    }
}