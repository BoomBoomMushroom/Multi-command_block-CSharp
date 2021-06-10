using System;

namespace minecarft_multicommand_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            String ending = "]}";
            String passengerP1 = "{id:command_block_minecart,Command:'";
            String passengerP2 = "'},";
            String FullCommand = "summon falling_block ~ ~1 ~ {Time:1,BlockState:{Name:'activator_rail'},Passengers:[";
            Console.WriteLine("Put in the Minecraft command on the next line. A blank like will generate the code");
            while(done==false){
                String commandInput = Console.ReadLine();
                if(commandInput!=null&&commandInput!=""){
                    FullCommand += "\n"+passengerP1+commandInput+passengerP2;
                } else{
                    done=true;
                    FullCommand += "\n"+passengerP1+"setblock ~0 ~0 ~ lava[level=6]"+passengerP2;
                    FullCommand += "\n"+ending;
                    Console.WriteLine(FullCommand);
                    Console.ReadKey();
                }
            }
        }
    }
}
