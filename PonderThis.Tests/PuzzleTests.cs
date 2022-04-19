using PonderThis.Puzzles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PonderThis.Tests
{
    public class PuzzleTests
    {
        [Fact]
        public void TestAll()
        {
            var puzzleBase = typeof(IPuzzle);
            var puzzleTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(type => puzzleBase.IsAssignableFrom(type) && !type.IsInterface)
                .ToList();

            var puzzles = new List<IPuzzle>();

            foreach (var puzzleType in puzzleTypes)
            {
                IPuzzle? puzzle = Activator.CreateInstance(puzzleType) as IPuzzle;

                if (puzzle != null)
                {
                    puzzles.Add(puzzle);
                }
            }

            puzzles = puzzles.OrderBy(p => p.PuzzleDate).ToList();

            foreach (var puzzle in puzzles)
            {
                Console.WriteLine($"Solving \"Ponder This\" release for {puzzle.PuzzleDate.ToString("yyyy-MM")}{Environment.NewLine}");
                Console.WriteLine($"{puzzle.Description}{Environment.NewLine}");
                puzzle.Solve();
                Assert.Equal(puzzle.CorrectAnswer, puzzle.ComputedAnswer);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
