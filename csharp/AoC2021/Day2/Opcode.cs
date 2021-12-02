namespace Day2
{
    /// <summary>
    ///     Codes for driving the submarine.
    /// </summary>
    public enum Opcode
    {
        /// <summary>
        ///     Move forwards.
        /// </summary>
        Forward,

        /// <summary>
        ///     Move up (negative depth).
        /// </summary>
        Up,

        /// <summary>
        ///     Move down (positive depth).
        /// </summary>
        Down
    }
}