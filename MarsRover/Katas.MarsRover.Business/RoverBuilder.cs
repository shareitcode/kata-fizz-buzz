using Katas.MarsRover.Business.Models;

namespace Katas.MarsRover.Business;

public static class RoverBuilder
{
    public static Rover StartZeroZeroNorth => new(new Point(0, 0), Facing.North);
}