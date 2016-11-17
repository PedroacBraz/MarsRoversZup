#define DEBUG
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

            //Lista para armazenar os rovers criados
            //List<Rover> myRovers = new List<Rover>();

            Rover myRover;

            String coords;
            String roverCoords;
            int upperLimitX, upperLimitY;

            Char delimiter = ' ';

            // Recebe as coordenadas delimitantes
            Console.WriteLine("Inform the upper right coords of the plateau (Example format: 4 7): ");

            coords = Console.ReadLine();

            String[] substrings = coords.Split(delimiter);

            upperLimitX = int.Parse(substrings[0]);
            upperLimitY = int.Parse(substrings[1]);

            //Start roover setup

           while (true) {

                Console.WriteLine("Insert the Rover's position and orientation (use position -1 -1 to finish rover input)");
                roverCoords = Console.ReadLine();
                //Divide a linha recebida e converte as substrings nos tipos necessários durante a criação do novo Rover
                //adicionando-o na lista de Rovers criados
                substrings = roverCoords.Split(delimiter);
                //myRovers.Add(new Rover(int.Parse(substrings[0]), int.Parse(substrings[1]), char.Parse(substrings[2])));
                myRover = new Rover(int.Parse(substrings[0]), int.Parse(substrings[1]), char.Parse(substrings[2]), upperLimitX, upperLimitY);

#if DEBUG       
                /*
                Console.WriteLine("New rover in position " + myRovers[myRovers.Count - 1].getX() 
                    + " " + myRovers[myRovers.Count - 1].getY()
                    + " " + myRovers[myRovers.Count - 1].getDir());

                */

                Console.WriteLine("New rover in position " + myRover.getX()
                    + " " + myRover.getY()
                    + " " + myRover.getDir());

#endif


                Console.WriteLine("Please inform the rover's control string: ");
                myRover.setCtrlString (Console.ReadLine());
                myRover.executeCtrl();
                

            }



            Console.ReadLine();
            return;
        }
    }
}
