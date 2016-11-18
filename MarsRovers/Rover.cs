using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{

    // The class for our rovers
    class Rover
    {

        int X;                  // Rover's X coord
        int Y;                  // Rover's Y coord
        char dir;               // Rover's facing direction
        int upperLimitX;        // The X coord of the upper right limit of the plateau
        int upperLimitY;        // The Y coord of the upper right limit of the plateau
        String controlString;   // Rover's control string


        //Rover's Constructor 
        public Rover(int X, int Y, char dir, int upperLimitX, int upperLimitY)
        {

            this.X = X;
            this.Y = Y;
            this.dir = dir;
            this.upperLimitX = upperLimitX;
            this.upperLimitY = upperLimitY;

        }

        //Vira à esquerda
        public void turnLeft()
        {

            if (this.dir == 'N')
            {
                this.dir = 'W';
            }
            else if (this.dir == 'W')
            {
                this.dir = 'S';
            }
            else if (this.dir == 'S')
            {
                this.dir = 'E';
            }
            else if (this.dir == 'E')
            {
                this.dir = 'N';
            }
        }

        // Vira à direita
        public void turnRight()
        {

            if (this.dir == 'N')
            {
                this.dir = 'E';
            }
            else if (this.dir == 'E')
            {
                this.dir = 'S';
            }
            else if (this.dir == 'S')
            {
                this.dir = 'W';
            }
            else if (this.dir == 'W')
            {
                this.dir = 'N';
            }
        }

        // Move à frente caso condições necessárias forem atendidas
        public void moveFwrd()
        {
            if ((this.dir == 'N') && (this.Y < upperLimitY))
            {
                this.Y++;
            }
            else if ((this.dir == 'W') && (this.X > 0))
            {
                this.X--;
            }
            else if ((this.dir == 'S') && (this.Y > 0)) {
                this.Y--;
            }
            else if ((this.dir == 'E') && (this.X < upperLimitX)){
                this.X++;
            }


        }

        // Recebe a String de instruções e movimenta o Rover
        public void executeCtrl()
        {

            for (int i = 0; i < this.controlString.Length; i++)
            {

                if (controlString[i] == 'L')
                {
                    turnLeft();
                }
                else if (controlString[i] == 'R')
                {
                    turnRight();
                }
                else if (controlString[i] == 'M')
                {
                    moveFwrd();
                }
   
            }

            printPosition();
        }

        public void printPosition() {
           
            Console.WriteLine(this.X + " " + this.Y + " " + this.dir);
        }


        public void setCtrlString(String ctrlString)
        {
            this.controlString = ctrlString;
        }

        // Get methods to use in debugging

        public String getCtrlString()
        {
            return this.controlString;
        }

        public int getX()
        {
            return this.X;
        }

        public int getY()
        {
            return this.Y;
        }

        public char getDir()
        {
            return this.dir;
        }
    }
}
