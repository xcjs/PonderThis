namespace PonderThis.Puzzles.Interfaces;

public interface IPuzzle
{
    DateTime PuzzleDate { get; }
    string Description { get; }
    string? CalculatedAnswer { get; }
    string? CorrectAnswer { get; }

    void Solve();
}
