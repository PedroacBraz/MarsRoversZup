//#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class MarsRovers
    {

        static void Main(string[] args)
        {

            Rover myRover;

            String coords = "";
            String roverCoords;
            String roverCmd;
            String[] substrings = null;
            int upperLimitX = -1, upperLimitY = -1;
            bool createRover;
       

            Char delimiter = ' ';

            // Recebe as coordenadas delimitantes

            while (upperLimitX < 0 || upperLimitY < 0)
            {
                Console.WriteLine("Inform the upper right coords of the plateau (Example format: 4 7): ");
                coords = Console.ReadLine();
                substrings = coords.Split(delimiter);
                upperLimitX = int.Parse(substrings[0]);
                upperLimitY = int.Parse(substrings[1]);
            }


            //Start roover setup

            while (true)
            {

                createRover = true;
                Console.WriteLine("Insert the Rover's position (X Y) and orientation (N, W, S or E),  (Ex.: 3 2 W), or type EXIT finish rover input");
                roverCoords = Console.ReadLine();

                if (roverCoords == "EXIT")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                //Divide a linha recebida e converte as substrings nos tipos necessários durante a criação do novo Rover
                //adicionando-o na lista de Rovers criados
                substrings = roverCoords.Split(delimiter);


                if ((int.Parse(substrings[0]) > upperLimitX) || (int.Parse(substrings[1]) > upperLimitY))
                {
                    Console.WriteLine("Invalid Coordinates");
                    createRover = false;
                }


                if ((substrings[2] != "N") && (substrings[2] != "W") && (substrings[2] != "S") && (substrings[2] != "E"))
                {
                    Console.WriteLine("Ivalid Orientetion");
                    createRover = false;
                }

                if (createRover)
                {
                    myRover = new Rover(int.Parse(substrings[0]), int.Parse(substrings[1]), char.Parse(substrings[2]), upperLimitX, upperLimitY);

#if DEBUG
                    Console.WriteLine("New rover in position " + myRover.getX()
                        + " " + myRover.getY()
                        + " " + myRover.getDir());

#endif
                    Console.WriteLine("Please inform the rover's control string, using L to turn Left, R to turn Right and M to move foward: (Ex.: LRMMMRLMRL)");
                    roverCmd = Console.ReadLine().ToUpper();
                    myRover.setCtrlString(roverCmd);
                    myRover.executeCtrl();
                }
            }


            Console.ReadLine();
            return;
        }
    }
}
