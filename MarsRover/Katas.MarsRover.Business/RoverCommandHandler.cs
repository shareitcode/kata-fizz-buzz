using Katas.MarsRover.Business.Models;

namespace Katas.MarsRover.Business;

public static class RoverCommandHandler
{
    public static Rover Handles(Rover rover, params RoverCommand[] commands)
    {
        Rover roverUpdated = rover with { };
        if (commands.Length == 0)
            return roverUpdated;

        Command firstCommand = commands.First().Command;
        roverUpdated = HandleRoverCommand(rover, firstCommand);

        IEnumerable<RoverCommand> nextCommands = commands.Skip(1);
        foreach (RoverCommand command in nextCommands)
            roverUpdated = HandleRoverCommand(roverUpdated, command.Command);

        return roverUpdated;
    }

    private static Rover HandleRoverCommand(Rover rover, Command command)
    {
        Rover roverUpdated = rover with { };
        if (command.Equals(Command.Forward))
            roverUpdated = PositonCommand(roverUpdated, command);

        if (command.Equals(Command.TurnLeft)
            || command.Equals(Command.TurnRight))
            roverUpdated = FacingCommand(roverUpdated, command);
        return roverUpdated;
    }

    private static Rover PositonCommand(Rover rover, Command command)
    {
        if (command.Equals(Command.Forward) && rover.Facing.Equals(Facing.North))
            return rover with { Position = rover.Position with { Y = rover.Position.Y + 1 } };

        if (command.Equals(Command.Forward) && rover.Facing.Equals(Facing.East))
            return rover with { Position = rover.Position with { X = rover.Position.X + 1 } };

        if (command.Equals(Command.Forward) && rover.Facing.Equals(Facing.South))
            return rover with { Position = rover.Position with { Y = rover.Position.Y - 1 } };

        if (command.Equals(Command.Forward) && rover.Facing.Equals(Facing.West))
            return rover with { Position = rover.Position with { X = rover.Position.X - 1 } };

        return rover;
    }

    private static Rover FacingCommand(Rover rover, Command command)
    {
        if (command.Equals(Command.TurnLeft))
            return rover with { Facing = Facing.West };

        if (command.Equals(Command.TurnRight))
            return rover with { Facing = Facing.East };

        return rover;
    }
}