using System.Linq;

using PonderThis.Puzzles.Interfaces;

namespace PonderThis;

public static class Program
{
    public static void Main()
    {
        var puzzleBase = typeof(IPuzzle);
        var puzzleTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .Where(type => puzzleBase.IsAssignableFrom(type) && !type.IsInterface)
            .ToList();

        var puzzles = new List<IPuzzle>();

        foreach(var puzzleType in puzzleTypes)
        {
            IPuzzle? puzzle = Activator.CreateInstance(puzzleType) as IPuzzle;

            if(puzzle != null)
            {
                puzzles.Add(puzzle);
            }            
        }

        puzzles = puzzles.OrderBy(p => p.PuzzleDate).ToList();

        foreach (var puzzle in puzzles)
        {
            Console.WriteLine($"Solving \"Ponder This\" released on {puzzle.PuzzleDate.ToString("yyyy-MM")}{Environment.NewLine}");
            Console.WriteLine($"{puzzle.Description}{Environment.NewLine}");
            puzzle.Solve();
            Console.WriteLine($"Computed answer: {puzzle.ComputedAnswer}");
            Console.WriteLine($"Correct answer:  {puzzle.CorrectAnswer}{Environment.NewLine}");
        }
    }
}
