using System;
namespace Project_CS
{
    public class Map
    {
        public static void mapDisplay()
        {
            
            string [,] mp1={
                       { "      ","      ","S4   ","      ","S9    ","       ","S15    ","      "},
                       { "      ","S2    ","     ","S7    ","S10   ","S13    ","       ","      "},
                       { "S1    ","      ","S5   ","      ","      ","       ","S16    ","S18   "},
                       { "      ","S3    ","     ","S8    ","S11   ","S14    ","       ","      "},
                       { "      ","      ","S6   ","      ","S12   ","       ","S17    ","      "}
           };


            string [,] mp2={
                       { "      ","      ","S4    ","S8    ","      ","S13   ","      ","      "},
                       { "      ","S2    ","S5    ","      ","S11   ","      ","S16   ","      "},
                       { "S1    ","      ","      ","S9    ","      ","S14   ","      ","S18   "},
                       { "      ","S3    ","S6    ","      ","S12   ","      ","S17   ","      "},
                       { "      ","      ","S7    ","S10   ","      ","S15   ","      ","      "}
           };



            string [,] mp3={
                       { "      ","      ","S4    ","      ","S10   ","      ","S16   ","      "},
                       { "      ","S2    ","S5    ","S8    ","S11   ","S14   ","      ","      "},
                       { "S1    ","      ","      ","      ","      ","      ","S17   ","S19   "},
                       { "      ","S3    ","S6    ","S9    ","S12   ","S15   ","      ","      "},
                       { "      ","      ","S7    ","      ","S13   ","      ","S18   ","      "}
           };


           
            string[] firstAct={"S2", "S3"};
            int[] resultS1={1,2};
            Event eventS1 = new Event(
            "Base of operation",
            1 ,
            "The base in sector 1 is under attack leave and inform our allies in Krypton that is in sector 18" ,
            firstAct,
            resultS1);
           
            string[] secondAct={"S4","S5"};
            int[] resultS2={3,4};
            Event eventS2 = new Event(
                "independent System", 
                2 ,
                "npc",
                secondAct,
                resultS2);
            string[] thirdAct={"S5","S6"};
            int[] resultS3={4,5};
            Event eventS3 = new Event(
                "independent system", 
                3 , 
                "shop",
                thirdAct,
                resultS3);
            string[] fourthAct={"S7"};
            int[] resultS4={6};
            Event eventS4 = new Event(
                "Abandoned system", 
                4 , 
                "fight",
                fourthAct,
                resultS4);
            
            string[] fifthAct={"S7","S8"};
            int[] resultS5={6,7};
            Event eventS5 = new Event(
                "Abandoned system", 
                5 , 
                "npc",
                fifthAct,
                resultS5);
            string[] sixthAct={"S8"};
            int[] resultS6={7};
            Event eventS6 = new Event(
                "Abandoned system", 
                6 , 
                "fight",
                sixthAct,
                resultS6);
            string[] seventhAct={"S9","S10"};
            int[] resultS7={8,9};
            Event eventS7 = new Event(
                "Abandoned system", 
                7 , 
                "npc",
                seventhAct,
                resultS7);
            
            string[] eighthAct={"S11","S12"};
            int[] resultS8={10,11};
            Event eventS8 = new Event(
                "Abandoned system", 
                8 , 
                "npc",
                eighthAct,
                resultS8);
            string[] ninethAct={"S13"};
            int[] resultS9={12};
            Event eventS9 = new Event(
                "Abandoned system", 
                9 , 
                "shop",
                ninethAct,
                resultS9);
            
            string[] tenthAct={"S13"};
            int[] resultS10={12};
            Event eventS10 = new Event(
                "Abandoned system", 
                10 , 
                "npc",
                tenthAct,
                resultS10);
            string[] eleventhAct={"S14"};
            int[] resultS11={13};
            Event eventS11 = new Event(
                "Abandoned system", 
                11 , 
                "fight",
                eleventhAct,
                resultS11);
            string[] twelevthAct={"S14"};
            int[] resultS12={13};
            Event eventS12 = new Event(
                "Abandoned system", 
                12 , 
                "",
                twelevthAct,
                resultS12);
            
            string[] thirteenthAct={"S15","S16"};
            int[] resultS13={14,15};
            Event eventS13 = new Event(
                "Abandoned system", 
                13 , 
                "npc",
                thirteenthAct,
                resultS13);
            
            string[] fourteenthAct={"S16","S17"};
            int[] resultS14={15,16};
            Event eventS14 = new Event(
                "Abandoned system", 
                14 , 
                "npc",
                fourteenthAct,
                resultS14);
            string[] fifteenthAct={"S18"};
            int[] resultS15={17};
            Event eventS15 = new Event(
                "Abandoned system", 
                15 , 
                "shop",
                fifteenthAct,
                resultS15);
            string[] sixteenthAct={"S18"};
            int[] resultS16 ={17};
            Event eventS16 = new Event(
                "Abandoned system", 
                16 , 
                "fight",
                sixteenthAct,
                resultS16);
            string[] seventeenthAct={"S18"};
            int[] resultS17 ={17};
            Event eventS17 = new Event(
                "Abandoned system", 
                17 , 
                "",
                seventeenthAct,
                resultS17);
            
            string[] eighteenthAct={"Restart"};
            int[] resultS18 ={1,-1};
            Event eventS18 = new Event(
                "Abandoned system", 
                18 , 
                "fight",
                eighteenthAct,
                resultS18);






            //second map





            eventS1 = new Event(
            "Base of operation",
            1 ,
            "The base in sector 1 is under attack leave and inform our allies in Krypton that is in sector 18" ,
            firstAct,
            resultS1);
           
            string[] ActTwo={"S4","S5"};
            int[] result2={3,4};
            Event event2 = new Event(
                "independent System", 
                2 , 
                "npc",
                ActTwo,
                result2);

            string[] Act3={"S6","S7"};
            int[] result3={5,6};
            Event event3 = new Event(
                "Abandoned system", 
                3 , 
                "shop",
                Act3,
                result3);

            string[] Act4={"S8"};
            int[] result4={7};
            Event event4 = new Event(
                "Abandoned system", 
                4 , 
                "fight",
                Act4,
                result4);
            
            string[] Act5 = {"S8","S9"};
            int[] result5 = {7,8};
            Event event5 = new Event(
                "Abandoned system", 
                5 , 
                "npc",
                Act5,
                result5);

            string[] Act6 = {"S9","S10"};
            int[] result6 = {8 , 9};
            Event event6 = new Event(
                "Abandoned system", 
                6 , 
                "npc",
                Act6,
                result6);
            string[] Act7={"S10"};
            int[] result7={9};
            Event event7 = new Event(
                "Abandoned system", 
                7 , 
                "",
                Act7,
                result7);
            
            string[] Act8={"S11"};
            int[] result8={10};
            Event event8 = new Event(
                "Abandoned system", 
                8 , 
                "npc",
                Act8,
                result8);
            string[] Act9={"S11", "S12"};
            int[] result9={10,11};
            Event event9 = new Event(
                "Abandoned system", 
                9 , 
                "fight",
                Act9,
                result9);
            
            string[] Act10={"S12"};
            int[] result10={11};
            Event event10 = new Event(
                "Abandoned system", 
                10 , 
                "fight",
                Act10,
                result10);

            string[] Act11={"S13","S14"};
            int[] result11={12,13};
            Event event11 = new Event(
                "Abandoned system", 
                11 , 
                "shop",
                Act11,
                result11);

            string[] Act12={"S14","S15"};
            int[] result12={13,14};
            Event event12 = new Event(
                "Abandoned system", 
                12 , 
                "npc",
                Act12,
                result12);
            
            string[] Act13={"S16"};
            int[] result13={15};
            Event event13 = new Event(
                "Abandoned system", 
                13 , 
                "fight",
                Act13,
                result13);
            
            string[] Act14={"S16","S17"};
            int[] result14={15,16};
            Event event14 = new Event(
                "Abandoned system", 
                14 , 
                "fight",
                Act14,
                result14);

            string[] Act15={"S17"};
            int[] result15={16};
            Event event15 = new Event(
                "Abandoned system", 
                15 , 
                "npc",
                Act15,
                result15);
            string[] Act16={"S18"};
            int[] result16 ={17};
            Event event16 = new Event(
                "Abandoned system", 
                16 , 
                "npc",
                Act16,
                result16);
            string[] Act17={"S18"};
            int[] result17 ={17};
            Event event17 = new Event(
                "Abandoned system", 
                17 , 
                "fight",
                Act17,
                result17);
            
            string[] Act18={"Restart"};
            int[] result18 ={1,-1};
            Event event18 = new Event(
                "Abandoned system", 
                18 , 
                "fight",
                Act18,
                result18);



            //third map


            


            
            eventS1 = new Event(
            "Base of operation",
            1 ,
            "The base in sector 1 is under attack leave and inform our allies in Krypton that is in sector 18" ,
            firstAct,
            resultS1);
           
            string[] Actn2={"S4","S5"};
            int[] resultn2={3,4};
            Event eventn2 = new Event(
                "independent System", 
                2 , 
                "npc",
                Actn2,
                resultn2);

            string[] Actn3={"S6","S7"};
            int[] resultn3={5,6};
            Event eventn3 = new Event(
                "Abandoned system", 
                3 , 
                "npc",
                Actn3,
                resultn3);

            string[] Actn4={"S8"};
            int[] resultn4={7};
            Event eventn4 = new Event(
                "Abandoned system", 
                4 , 
                "fight",
                Actn4,
                resultn4);
            
            string[] Actn5 = {"S8"};
            int[] resultn5 = {7};
            Event eventn5 = new Event(
                "Abandoned system", 
                5 , 
                "shop",
                Actn5,
                resultn5);

            string[] Actn6 = {"S9"};
            int[] resultn6 = {8};
            Event eventn6 = new Event(
                "Abandoned system", 
                6 , 
                "npc",
                Actn6,
                resultn6);
            string[] Actn7={"S9"};
            int[] resultn7={8};
            Event eventn7 = new Event(
                "Abandoned system", 
                7 , 
                "shop",
                Actn7,
                resultn7);
            
            string[] Actn8={"S10","S11"};
            int[] resultn8={9,10};
            Event eventn8 = new Event(
                "Abandoned system", 
                8 , 
                "figh",
                Actn8,
                resultn8);
            string[] Actn9={"S12","S13"};
            int[] resultn9={11,12};
            Event eventn9 = new Event(
                "Abandoned system", 
                9 , 
                "fight",
                Actn9,
                resultn9);
            
            string[] Actn10={"S14"};
            int[] resultn10={13};
            Event eventn10 = new Event(
                "Abandoned system", 
                10 , 
                "npc",
                Actn10,
                resultn10);

            string[] Actn11={"S14"};
            int[] resultn11={13};
            Event eventn11 = new Event(
                "Abandoned system", 
                11 , 
                "fight",
                Actn11,
                resultn11);

            string[] Actn12={"S15"};
            int[] resultn12={14};
            Event eventn12 = new Event(
                "Abandoned system", 
                12 , 
                "npc",
                Actn12,
                resultn12);
            
            string[] Actn13={"S15"};
            int[] resultn13={14};
            Event eventn13 = new Event(
                "Abandoned system", 
                13 , 
                "npc",
                Actn13,
                resultn13);
            
            string[] Actn14={"S16","S17"};
            int[] resultn14={15,16};
            Event eventn14 = new Event(
                "Abandoned system", 
                14 , 
                "npc",
                Actn14,
                resultn14);

            string[] Actn15={"S17","S18"};
            int[] resultn15={16,17};
            Event eventn15 = new Event(
                "Abandoned system", 
                15 , 
                "fight",
                Actn15,
                resultn15);
            string[] Actn16={"S19"};
            int[] resultn16 ={18};
            Event eventn16 = new Event(
                "shop", 
                16 , 
                "shop",
                Actn16,
                resultn16);
            string[] Actn17={"S19"};
            int[] resultn17 ={18};
            Event eventn17 = new Event(
                "Abandoned system", 
                17 , 
                "shop",
                Actn17,
                resultn17);
            
            string[] Actn18={"S19"};
            int[] resultn18 ={18};
            Event eventn18 = new Event(
                "Abandoned system", 
                18 , 
                "npc",
                Actn18,
                resultn18);


            string[] Actn19={"Restart"};
            int[] resultn19 ={1,-1};
            Event eventn19 = new Event(
                "Abandoned system", 
                19 , 
                "fight",
                Actn18,
                resultn18);





            Event[] events={eventS1,eventS2,eventS3,eventS4,eventS5,
            eventS6,eventS7,eventS8,eventS9,eventS10,
            eventS11,eventS11,eventS12,eventS13,eventS14,eventS15,
            eventS16,eventS17,eventS18};

            Event[] events2={eventS1,event2,event3,event4,event5,
            event6,event7,event8,event9,event10,
            event11,event11,event12,event13,event14,event15,
            event16,event17,event18};

            Event[] events3={eventS1,eventn2,eventn3,eventn4,eventn5,
            eventn6,eventn7,eventn8,eventn9,eventn10,
            eventn11,eventn11,eventn12,eventn13,eventn14,eventn15,
            eventn16,eventn17,eventn18};

            mapExec map1 = new mapExec(mp1,events);
            mapExec map2= new mapExec(mp2,events2);
            mapExec map3= new mapExec(mp3,events3);

            mapExec[] map ={map1, map2, map3 };

            Random r = new Random();
            mapExec currentMap =map[r.Next(3)];

            int position=0;
           
           
           while(position!=-1){
            for(int i =0 ; i < currentMap.map.GetLength(0);i++){
                for(int j = 0 ; j < currentMap.map.GetLength(1); j++){
                    System.Console.Write(currentMap.map[i,j]);
                }
            System.Console.WriteLine();
           }
                position=events[position].afficher();
                
           }
        
        
        }
    }
}