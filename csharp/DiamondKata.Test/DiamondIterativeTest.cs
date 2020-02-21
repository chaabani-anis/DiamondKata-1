using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiamondKata.Test
{
    /**
     * These test cases can be used to test-drive a solution to the diamond kata, in an interative manner.
     * Enable only one test case for "Diamond A", one for "Diamond B" and one for "Diamond C" at any one time.
     * The idea is that you iterate towards a full solution. 
     *
     * Instructions:
     * 1. Make the first test for Diamond A (which is failing) pass
     * 2. Remove the '@Ignore' on the next test case. Make it pass too.
     * 3. Replace the '@Ignore' on that test case, (or delete it), and instead enable the following test case
     * 4. keep doing this, always having exactly one enabled test case for each diamond, (A, B, and C) until you've got to the end of the file.
     * At that point you should have a working implementation.
     */

    [TestClass]
    public class DiamondIterativeTest
    {
        [TestMethod]
        public void DiamondA_has_one_line_containing_A()
        {
            Assert.AreEqual("A", Diamond.Print('A'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB_prints_a_char_sequence_for_the_top_half()
        {
            Assert.AreEqual("AB", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB_prints_a_char_sequence_for_the_whole_diamond()
        {
            Assert.AreEqual("ABA", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondC_prints_a_char_sequence_for_the_whole_diamond()
        {
            Assert.AreEqual("ABCBA", Diamond.Print('C'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB_has_newlines()
        {
            Assert.AreEqual("A\nB\nA", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB_has_indentation_on_first_and_last_rows()
        {
            Assert.AreEqual(" A\nB\n A", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondC_has_indentation_on_all_rows_except_middle()
        {
            Assert.AreEqual("  A\n" +
                         " B\n" +
                         "C\n" +
                         " B\n" +
                         "  A", Diamond.Print('C'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB_duplicates_B_on_middle_row()
        {
            Assert.AreEqual(" A\nBB\n A", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondC_has_duplicates_on_middle_rows()
        {
            Assert.AreEqual("  A\n" +
                         " BB\n" +
                         "CC\n" +
                         " BB\n" +
                         "  A", Diamond.Print('C'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondB_has_a_space_between_the_Bs()
        {
            Assert.AreEqual(" A\nB B\n A", Diamond.Print('B'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondC_has_between_spaces_on_all_rows_except_first_and_last()
        {
            Assert.AreEqual("  A\n" +
                         " B B\n" +
                         "C   C\n" +
                         " B B\n" +
                         "  A", Diamond.Print('C'));
        }

        [TestMethod]
        [Ignore]
        public void DiamondD_is_correct_in_all_aspects()
        {
            Assert.AreEqual("   A\n" +
                         "  B B\n" +
                         " C   C\n" +
                         "D     D\n" +
                         " C   C\n" +
                         "  B B\n" +
                         "   A", Diamond.Print('D'));
        }
    }
}
