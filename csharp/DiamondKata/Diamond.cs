using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DiamondKata
{
    public class Diamond
    {
        private char _middleLetter;

        public Diamond(char middleLetter)
        {
            _middleLetter = middleLetter;
        }

        public List<List<char>> GetRows()
        {
            return new List<List<char>>();
        }

        public static List<List<char>> diamond(char middleLetter)
        {
            Diamond diamond = new Diamond(middleLetter);
            return diamond.GetRows();
        }

        public static string Print(char middleLetter)
        {
            Diamond diamond = new Diamond(middleLetter);
            StringBuilder result = new StringBuilder();
            foreach (List<char> chars in diamond.GetRows())
            {
                foreach (char c in chars)
                {
                    result.Append(c);
                }
                result.Append("\n");
            }
            return result.ToString();
        }

        public int Size()
        {
            return 0;
        }

        public IList<IList<char>> SpaceArray()
        {
            return null;
        }

        public Point CenterCoordinate()
        {
            return new Point();
        }

        public static IList<IList<char>> PlaceLetter(IList<IList<char>> spaceArray, Point point, char letter)
        {
            return spaceArray;
        }

        public IList<Point> Coordinates(char letter)
        {
            return null;
        }
    }
}