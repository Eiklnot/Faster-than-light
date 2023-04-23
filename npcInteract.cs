using System;

namespace Project_CS{

    public class npcInteract{

        public static void scena(){

            
            string[] opt = {"1 Continue"};
            string[] res = {"Where do you want to go?"};
            
            Message message1= new Message("You arrive to system full of planets, but your radar doesn't catch anything, no station no sign of civilization.",
                                        " As you roam this system, you notice you haven't seen any ship.\nA system that has been abandoned due to the hostile environment. ",
                                        opt, res);

            string [] msgs ={"You arrive to full of planets, but your radar doesn't catch anything, no station no sign of civilization.",
                            "As you roam this system, you notice you haven't seen any ship.",
                            "A system that has been abandoned due to the hostile environment.","1 Continue"};


            string[] opt2= {"1 Listen", "2 Ignore"};
            string[] res2= {"The empire's fleet was here and destroyed evrything. \nAnd the survivors were then attacked by badits and looters","Where do you want to go?"};
            Message message2= new Message("You see in the comms that there is a broadcast","",opt2, res2);


            string [] msgs1 ={"You see in the comms that there is a broadcast",
                                "1 Start conversation", "2 Ignore"};

            string[][] messages={msgs,msgs1};
            Random rand = new Random();
            string[] currentmsg = messages[rand.Next(2)];
            
            for(int i = 0 ; i < currentmsg.GetLength(0) ; i++){
                System.Console.WriteLine(currentmsg[i]);
            }
        }
    }
    public class Message{
        public string initmsg;
        public string followUp;
        public string[] choice;
        public string[] resultat;


        public Message(string initmsg, string followUp,string[] choice, string[] resultat){
            this.initmsg=initmsg;
            this.followUp=followUp;
            this.resultat=resultat;
            this.choice=choice;

        }



    }
}