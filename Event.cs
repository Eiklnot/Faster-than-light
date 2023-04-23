using System;

namespace Project_CS
{
    public class Event
    {
        
        public string location;
        public int sectorNumber;
        
        public string[] actions;
        public int[] results;
        public string type;

        public Event(string location, int sectorNumber,string type, string[] actions, int[] results){
            this.location=location;
            this.sectorNumber=sectorNumber;
            
            this.actions=actions;
            this.results=results;
            this.type=type;
            
        }
        public int afficher(){
            
           switch(type){
                case "The base in sector 1 is under attack leave and inform our allies in Krypton that is in sector 18":
                System.Console.WriteLine("The base in sector 1 is under attack leave and inform our allies in Krypton that is in sector 18");
                break;
                case "fight":
                    Fight.scena();
                break;
                case "npc":
                    npcInteract.scena();
                break;
                case "shop":
                    Shop.scena();
                break;
                
           }
           System.Console.WriteLine("Where will you go?");
           for(int i = 0 ; i <this.actions.GetLength(0);i++){
                System.Console.WriteLine();
                System.Console.WriteLine((i+1)+" : " + this.actions[i]);
           }
           int choice =Convert.ToInt32(Console.ReadLine());
           return results[choice-1];
        }
    }
}