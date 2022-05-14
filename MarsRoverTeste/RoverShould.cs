using System;
using Xunit;
using MarsRover;

namespace MarsRoverTeste
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            Rover rover = new Rover("1 2 N");
            rover.SpinLeft();            
            Assert.Equal("w", rover.direction);
        }
        [Fact]
        public void SpinRight()
        {
            Rover rover = new Rover("1 2 N");

            rover.SpinRight();
            Console.WriteLine(rover.direction);
            Assert.Equal("E", rover.direction);
        }
        [Fact]
        public void StepForward()
        {
            Rover rover = new Rover("1 2 S");

            rover.StepForward();
            Console.WriteLine(rover.direction);
            Assert.Equal(3, rover.y);
        }
        [Fact]
        public void Move()
        {
            Rover rover = new Rover("3 3 E");

            rover.Move("LMLMLMLMM ");
            Console.WriteLine(rover.direction);
            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}