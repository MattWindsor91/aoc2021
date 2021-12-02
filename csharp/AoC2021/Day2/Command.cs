namespace Day2
{
    /// <summary>
    ///     A submarine command.
    /// </summary>
    /// <param name="Code">The code of the command.</param>
    /// <param name="Amount">The amount of movement.</param>
    public record Command(Opcode Code, int Amount);
}