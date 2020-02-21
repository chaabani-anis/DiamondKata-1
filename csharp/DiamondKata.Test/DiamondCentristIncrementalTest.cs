using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiamondKata.Test
{
    [TestClass]
    public class DiamondCentristIncrementalTest
    {

        [TestMethod]
        public void DiamondA()
        {
            Assert.AreEqual("A", Diamond.Print('A'));
        }

        [TestMethod]
        [Ignore]
        public void size()
        {
            Assert.AreEqual(1, new Diamond('A').Size());
            Assert.AreEqual(3, new Diamond('B').Size());
            Assert.AreEqual(5, new Diamond('C').Size());
            Assert.AreEqual(7, new Diamond('D').Size());
        }

        [TestMethod]
        [Ignore]
        public void spaceArray()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList(' ')), new Diamond('A').SpaceArray());
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ')),
                    new Diamond('B').SpaceArray());
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' ')),
                    new Diamond('C').SpaceArray());
        }

        [TestMethod]
        [Ignore]
        public void centerCoordinate()
        {
            Assert.AreEqual(new Point(0, 0), new Diamond('A').CenterCoordinate());
            Assert.AreEqual(new Point(1, 1), new Diamond('B').CenterCoordinate());
            Assert.AreEqual(new Point(2, 2), new Diamond('C').CenterCoordinate());
            Assert.AreEqual(new Point(3, 3), new Diamond('D').CenterCoordinate());
        }

        [TestMethod]
        [Ignore]
        public void place_letter_center()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList('A'))
                    , Diamond.PlaceLetter(new Diamond('A').SpaceArray(), new Point(0, 0), 'Z'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', 'Z', ' '),
                    Arrays.AsList(' ', ' ', ' '))
                    , Diamond.PlaceLetter(new Diamond('B').SpaceArray(), new Point(0, 0), 'Z'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'Z', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '))
                    , Diamond.PlaceLetter(new Diamond('C').SpaceArray(), new Point(0, 0), 'Z'));
        }

        [TestMethod]
        [Ignore]
        public void place_letter_at_other_coordinates()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList(' '))
                    , Diamond.PlaceLetter(new Diamond('A').SpaceArray(), new Point(1, 0), 'Z'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'Z'),
                    Arrays.AsList(' ', ' ', ' '))
                    , Diamond.PlaceLetter(new Diamond('B').SpaceArray(), new Point(1, 0), 'Z'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', 'Z', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '))
                    , Diamond.PlaceLetter(new Diamond('C').SpaceArray(), new Point(-1, 0), 'Z'));
        }

        [TestMethod]
        [Ignore]
        public void coordinatesOfA()
        {
            Assert.AreEqual(Arrays.AsList(new Point(0, 0)),
                    new Diamond('A').Coordinates('A'));
            Assert.AreEqual(Arrays.AsList(new Point(0, 1), new Point(0, -1)),
                    new Diamond('B').Coordinates('A'));
            Assert.AreEqual(Arrays.AsList(new Point(0, 2), new Point(0, -2)),
                    new Diamond('C').Coordinates('A'));
            Assert.AreEqual(Arrays.AsList(new Point(0, 3), new Point(0, -3)),
                    new Diamond('D').Coordinates('A'));
        }

        [TestMethod]
        [Ignore]
        public void coordinatesOfMiddleLetter()
        {
            Assert.AreEqual(Arrays.AsList(new Point(-1, 0), new Point(1, 0)),
                    new Diamond('B').Coordinates('B'));
            Assert.AreEqual(Arrays.AsList(new Point(-2, 0), new Point(2, 0)),
                    new Diamond('C').Coordinates('C'));
            Assert.AreEqual(Arrays.AsList(new Point(-3, 0), new Point(3, 0)),
                    new Diamond('D').Coordinates('D'));
        }

        [TestMethod]
        [Ignore]
        public void coordinatesOfB()
        {
            Assert.AreEqual(Arrays.AsList(new Point(-1, 1), new Point(-1, -1),
                    new Point(1, 1), new Point(1, -1)),
                    new Diamond('C').Coordinates('B'));
            Assert.AreEqual(Arrays.AsList(new Point(-1, 2), new Point(-1, -2),
                    new Point(1, 2), new Point(1, -2)),
                    new Diamond('D').Coordinates('B'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB()
        {
            Assert.AreEqual(" A \nB B\n A ", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void coordinatesOfC()
        {
            Assert.AreEqual(Arrays.AsList(new Point(-2, 1), new Point(-2, -1),
                    new Point(2, 1), new Point(2, -1)),
                    new Diamond('D').Coordinates('C'));
        }

        [TestMethod]
        [Ignore]
        public void print_DiamondC()
        {
            Assert.AreEqual(
                    "  A  \n" +
                    " B B \n" +
                    "C   C\n" +
                    " B B \n" +
                    "  A  ", Diamond.Print('C'));
        }

        [TestMethod]
        [Ignore]
        public void print_DiamondD()
        {
            Assert.AreEqual(
                    "   A   \n" +
                    "  B B  \n" +
                    " C   C \n" +
                    "D     D\n" +
                    " C   C \n" +
                    "  B B  \n" +
                    "   A   ", Diamond.Print('D'));
        }
    }
}