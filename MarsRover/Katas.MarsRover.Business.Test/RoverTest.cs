using FluentAssertions;
using Katas.MarsRover.Business.Models;

namespace Katas.MarsRover.Business.Test;

/*
    https://codingdojo.org/kata/mars-rover/
    - a rover‘s starting point (x, y) and the direction (N, S, E, W) it is facing
    - a map describing the location of obstacles
    - a list of commands to move and turn the rover (⬆️ : move forward, ➡️ : turn right 90°, ⬅️ : turn left 90°)
*/

[TestClass]
public sealed class RoverTest
{
    [TestMethod]
    public void ShouldBeStartOnPointZeroZeroInNorthFacing()
    {
        Rover rover = RoverBuilder.StartZeroZeroNorth;

        Rover roverUpdated = RoverCommandHandler.Handles(rover);

        roverUpdated.Position.Should().Be(new Point(0,0));
        roverUpdated.Facing.Should().Be(Facing.North);
    }

    [TestMethod]
    public void MoveForwardShouldBeOnPointZeroOneInNorthFacing()
    {
        Rover rover = RoverBuilder.StartZeroZeroNorth;

        Rover roverUpdated = RoverCommandHandler.Handles(rover, RoverCommand.Forward);

        roverUpdated.Position.Should().Be(new Point(0, 1));
        roverUpdated.Facing.Should().Be(Facing.North);
    }

    [TestMethod]
    public void TurnLeftShouldBeOnPointZeroZeroInWestFacing()
    {
        Rover rover = RoverBuilder.StartZeroZeroNorth;

        Rover roverUpdated = RoverCommandHandler.Handles(rover, RoverCommand.TurnLeft);

        roverUpdated.Position.Should().Be(new Point(0, 0));
        roverUpdated.Facing.Should().Be(Facing.West);
    }

    [TestMethod]
    public void TurnRightShouldBeOnPointZeroZeroInEastFacing()
    {
        Rover rover = RoverBuilder.StartZeroZeroNorth;

        Rover roverUpdated = RoverCommandHandler.Handles(rover, RoverCommand.TurnRight);

        roverUpdated.Position.Should().Be(new Point(0, 0));
        roverUpdated.Facing.Should().Be(Facing.East);
    }

    [TestMethod]
    public void TurnRightAndMoveForwardShouldBeOnPointOneZeroInEastFacing()
    {
        Rover rover = RoverBuilder.StartZeroZeroNorth;

        Rover roverUpdated = RoverCommandHandler.Handles(rover, RoverCommand.TurnRight, RoverCommand.Forward);

        roverUpdated.Position.Should().Be(new Point(1, 0));
        roverUpdated.Facing.Should().Be(Facing.East);
    }

    [TestMethod]
    public void TurnRightTwiceAndMoveForwardShouldBeOnPointZeroNegativeOneInSouthFacing()
    {
        Rover rover = RoverBuilder.StartZeroZeroNorth;

        Rover roverUpdated = RoverCommandHandler.Handles(rover, RoverCommand.TurnRight, RoverCommand.TurnRight, RoverCommand.Forward);

        roverUpdated.Position.Should().Be(new Point(0, -1));
        roverUpdated.Facing.Should().Be(Facing.South);
    }
}