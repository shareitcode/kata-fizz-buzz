namespace Katas.MarsRover.Business;

public readonly record struct RoverCommand
{
    public static RoverCommand Forward => new(Command.Forward);
    public static RoverCommand TurnRight => new(Command.TurnRight);
    public static RoverCommand TurnLeft => new(Command.TurnLeft);

    public Command Command { get; }

    private RoverCommand(Command command)
    {
        Command = command;
    }
}
