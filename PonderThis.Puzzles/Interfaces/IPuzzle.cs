namespace PonderThis.Puzzles.Interfaces;

public interface IPuzzle
{
    DateTime PuzzleDate { get; }
    string Description { get; }
    string? ComputedAnswer { get; }
    string? CorrectAnswer { get; }
    string? AnswerDescription { get; }

    void Solve();
}
