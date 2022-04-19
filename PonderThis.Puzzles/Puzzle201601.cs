namespace PonderThis.Puzzles
{
    public class Puzzle201601 : IPuzzle
    {
        public DateTime PuzzleDate { get; } = DateTime.Parse("2016-01");

        public string Description { get; } =
            "As part of IBM's efforts to make a better and greener planet, " +
            "this month's challenge is to design an efficient gear system for " +
            "bicycles. The front chainrings (S_1) and back cogset (S_2) are " +
            "represented by two sets of numbers S_1 and S_2 where each gear g " +
            "is the product of two numbers, one from each set: s_1*s_2. When " +
            "designing the gears, we need sets of numbers that can produce " +
            "every gear value between 1 and N up to +/- 1, i.e., for every " +
            "number m between 1 and N there exists s_1 in S_1 and s_2 in S_2 " +
            "such that abs(m-s_1*s_2)<=1." +
            $"{Environment.NewLine}{Environment.NewLine}" +
            "So, for example, using sets of size 3, we can get to N=19 by S_1 " +
            "= { 1, 3, 6 } and S_2 = { 2, 3, 5 }." +
            $"{Environment.NewLine}{Environment.NewLine}" +
            "Your challenge is to find the values of S_1 and S_2 of size 6 " + 
            "that solve the problem for N=56 (again, using +/- 1); Earn an " +
            "asterisk for a significant increase of N.";

        public string? ComputedAnswer
        {
            get { return _computedAnswer; }
        }

        public string? CorrectAnswer
        {
            get { return _correctAnswer; }
        }

        private string? _computedAnswer = null;
        private string? _correctAnswer = null;

        public void Solve()
        {
            _computedAnswer = null;
        }
    }
}
