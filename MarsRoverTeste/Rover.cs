﻿using System;


namespace MarsRover
{
    public class Rover
    {
        public int x;
        public int y;
        public string direction;
        public Rover(string location)
        {
            Int32.TryParse(location.Split("")[0], out x);
            Int32.TryParse(location.Split("")[1], out y);
            direction = location.Split("")[2];
        }
        public void SpinLeft()
        {            
            switch(direction)
            {
                case "N": direction = "w";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "w":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void SpinRight()
        {            
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "w";
                    break;
                case "w":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void StepForward()
        {            
            switch (direction)
            {
                case "N":
                    y+=1;
                    break;
                case "E":
                    x+=1;
                    break;
                case "S":
                    y-=1;
                    break;
                case "w":
                    x-=1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void Move(string roverCommand)
        {            
            char[] instructions = roverCommand.ToCharArray();

            for(int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;                    
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
