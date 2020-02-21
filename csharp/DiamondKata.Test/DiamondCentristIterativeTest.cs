using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiamondKata.Test
{
    [TestClass]
    public class DiamondCentristIterativeTest
    {

        [TestMethod]
        public void DiamondA()
        {
            Assert.AreEqual("A", Diamond.Print('A'));
        }

        [TestMethod]
        [Ignore]
        public void with_only_spaces()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList(' '))
                    , Diamond.diamond('A'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' '))
                    , Diamond.diamond('B'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '))
                    , Diamond.diamond('C'));
        }

        [TestMethod]
        [Ignore]
        public void with_center_marked_with_a_Z()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList('Z'))
                    , Diamond.diamond('A'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', 'Z', ' '),
                    Arrays.AsList(' ', ' ', ' '))
                    , Diamond.diamond('B'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'Z', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '))
                    , Diamond.diamond('C'));
        }

        [TestMethod]
        [Ignore]
        public void with_1_0_coordinates_marked_with_a_Z()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList(' '))
                    , Diamond.diamond('A'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'Z'),
                    Arrays.AsList(' ', ' ', ' '))
                    , Diamond.diamond('B'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', 'Z', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '))
                    , Diamond.diamond('C'));
        }

        [TestMethod]
        [Ignore]
        public void with_0_1_coordinates_marked_with_a_Z()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList(' '))
                    , Diamond.diamond('A'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', 'Z', ' '),
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' '))
                    , Diamond.diamond('B'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'Z', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '))
                    , Diamond.diamond('C'));
        }

        [TestMethod]
        [Ignore]
        public void with_minus2_1_coordinates_marked_with_a_Z()
        {
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', 'Z'),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '))
                    , Diamond.diamond('C'));
        }

        [TestMethod]
        [Ignore]
        public void plotA()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList('A'))
                    , Diamond.diamond('A'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', 'A', ' '),
                    Arrays.AsList(' ', ' ', ' '),
                    Arrays.AsList(' ', 'A', ' '))
                    , Diamond.diamond('B'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', 'A', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'A', ' ', ' '))
                    , Diamond.diamond('C'));
        }

        [TestMethod]
        [Ignore]
        public void plot_A_and_middle_letter()
        {
            Assert.AreEqual(Arrays.AsList(Arrays.AsList('A'))
                    , Diamond.diamond('A'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', 'A', ' '),
                    Arrays.AsList('B', ' ', 'B'),
                    Arrays.AsList(' ', 'A', ' '))
                    , Diamond.diamond('B'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', 'A', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList('C', ' ', ' ', ' ', 'C'),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'A', ' ', ' '))
                    , Diamond.diamond('C'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', 'A', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList('D', ' ', ' ', ' ', ' ', ' ', 'D'),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', ' ', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', 'A', ' ', ' ', ' '))
                    , Diamond.diamond('D'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB()
        {
            Assert.AreEqual(" A \nB B\n A ", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void plot_all_letters()
        {
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', 'A', ' ', ' '),
                    Arrays.AsList(' ', 'B', ' ', 'B', ' '),
                    Arrays.AsList('C', ' ', ' ', ' ', 'C'),
                    Arrays.AsList(' ', 'B', ' ', 'B', ' '),
                    Arrays.AsList(' ', ' ', 'A', ' ', ' '))
                    , Diamond.diamond('C'));
            Assert.AreEqual(Arrays.AsList(
                    Arrays.AsList(' ', ' ', ' ', 'A', ' ', ' ', ' '),
                    Arrays.AsList(' ', ' ', 'B', ' ', 'B', ' ', ' '),
                    Arrays.AsList(' ', 'C', ' ', ' ', ' ', 'C', ' '),
                    Arrays.AsList('D', ' ', ' ', ' ', ' ', ' ', 'D'),
                    Arrays.AsList(' ', 'C', ' ', ' ', ' ', 'C', ' '),
                    Arrays.AsList(' ', ' ', 'B', ' ', 'B', ' ', ' '),
                    Arrays.AsList(' ', ' ', ' ', 'A', ' ', ' ', ' '))
                    , Diamond.diamond('D'));
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
