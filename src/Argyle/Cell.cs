using System.Diagnostics.CodeAnalysis;

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
    public Cell(long index, object? value) =>
        (Index, Value) = (index, value);

    /// <summary>
    /// Gets or sets the index of the cell.
    /// </summary>
    public long Index { get; init; }

    /// <summary>
    /// Gets or sets the value of the cell.
    /// </summary>
    public object? Value { get; set; }

    /// <summary>
    /// Gets the hash code for the <see cref="Cell"/>.
    /// </summary>
    /// <returns>The hash code for the <see cref="Cell"/>.</returns>
    public override int GetHashCode() =>
        base.GetHashCode();

    /// <summary>
    /// Determines whether the specified object is equal to the current <see cref="Cell"/>.
    /// </summary>
    /// <param name="obj">The object to compare with the current <see cref="Cell"/>.</param>
    /// <returns><see langword="true"/> if the specified object is equal to the current <see cref="Cell"/>; otherwise, <see langword="false"/>.</returns>
    public override bool Equals([NotNullWhen(true)] object? obj) =>
        obj is Cell cell && cell.Index == Index;

    /// <summary>
    /// Determines if two <see cref="Cell"/> instances are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Cell"/> to compare.</param>
    /// <param name="right">The second <see cref="Cell"/> to compare.</param>
    /// <returns><see langword="true"/> if the two <see cref="Cell"/> instances are equal; otherwise, <see langword="false"/>.</returns>
    public static bool operator ==(Cell left, Cell right) =>
        left.Equals(right);

    /// <summary>
    /// Determines if two <see cref="Cell"/> instances are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Cell"/> to compare.</param>
    /// <param name="right">The second <see cref="Cell"/> to compare.</param>
    /// <returns><see langword="true"/> if the two <see cref="Cell"/> instances are not equal; otherwise, <see langword="false"/>.</returns>
    public static bool operator !=(Cell left, Cell right) =>
        !(left == right);
}
