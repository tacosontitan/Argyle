namespace Argyle;

/// <summary>
/// Represents an instruction in the argyle golfing language.
/// </summary>
public abstract class Instruction
{
    /// <summary>
    /// Creates a new <see cref="Instruction"/> instance.
    /// </summary>
    /// <param name="symbol">The symbol representing the instruction.</param>
    protected Instruction(char symbol) =>
        Symbol = symbol;

    /// <summary>
    /// Gets or sets the symbol for the instruction.
    /// </summary>
    public char Symbol { get; }

    /// <summary>
    /// Invokes the instruction targeting a specified <see cref="Cell"/>.
    /// </summary>
    /// <param name="cell">The cell upon which this instruction should be invoked.</param>
    /// <returns>A task representing the state of the invocation.</returns>
    public abstract Task Invoke(ref Cell cell);
}
