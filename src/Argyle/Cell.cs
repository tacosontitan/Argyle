namespace Argyle;

/// <summary>
/// Represents a cell in memory.
/// </summary>
public struct Cell
{
    /// <summary>
    /// Creates a new <see cref="Cell"/> instance.
    /// </summary>
    /// <param name="index">The index of the cell in memory.</param>
    /// <param name="value">The value of the cell.</param>
    public Cell(long index, object value) =>
        (Index, Value) = (index, value);

    /// <summary>
    /// Gets or sets the index of the cell.
    /// </summary>
    public long Index { get; init; }

    /// <summary>
    /// Gets or sets the value of the cell.
    /// </summary>
    public object Value { get; set; }
}
