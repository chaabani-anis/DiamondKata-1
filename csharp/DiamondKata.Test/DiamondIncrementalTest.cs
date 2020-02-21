using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiamondKata.Test
{
    /**
     * These test cases can be used to test-drive a solution to the diamond kata, in an incremental manner.
     *
     * Instructions:
     * 1. Make the first test case for Diamond A pass
     * 2. remove the 'Ignore' and enable the next test case.
     * 3. Uncomment the one line of the test case. Make it pass. Repeat until all lines are uncommented
     * 4. When all the lines of code in the test case are passing, enable the next test case.
     * 5. When all the test cases in this file are uncommented and passing, you should have a full working solution.
     */
    [TestClass]
    public class DiamondIncrementalTest
    {

        [TestMethod]
        public void DiamondA_has_one_line_containing_A()
        {
            Assert.AreEqual("A", Diamond.Print('A'));
        }

        [TestMethod]
        [Ignore]
        public void LetterSequence_is_list_of_letters_on_each_line_of_the_diamond()
        {
            //AssertCharacterSequence(new Diamond('A').GetLetterSequence(), new char[] {'A'});
            //AssertCharacterSequence(new Diamond('B').GetLetterSequence(), new char[] {'A', 'B', 'A'});
            //AssertCharacterSequence(new Diamond('C').GetLetterSequence(), new char[] {'A', 'B', 'C', 'B', 'A'});
            //AssertCharacterSequence(new Diamond('D').GetLetterSequence(), new char[] {'A', 'B', 'C', 'D', 'C', 'B', 'A'});
        }

        [TestMethod]
        [Ignore]
        public void IndentationSequence_is_a_list_of_indents_for_each_line_of_the_diamond()
        {
            //AssertIntegerSequence(new Diamond('A').GetIndentationSequence(), new int[] {0});
            //AssertIntegerSequence(new Diamond('B').GetIndentationSequence(), new int[] {1,0,1});
            //AssertIntegerSequence(new Diamond('C').GetIndentationSequence(), new int[] {2,1,0,1,2});
            //AssertIntegerSequence(new Diamond('D').GetIndentationSequence(), new int[] {3,2,1,0,1,2,3});
        }

        [TestMethod]
        [Ignore]
        public void BetweenSequence_is_a_list_of_how_many_spaces_there_are_between_repeated_letters_on_each_line_of_the_diamond()
        {
            //AssertIntegerSequence(new Diamond('A').GetBetweenSequence(), new int[] {0});
            //AssertIntegerSequence(new Diamond('B').GetBetweenSequence(), new int[] {0,1,0});
            //AssertIntegerSequence(new Diamond('C').GetBetweenSequence(), new int[] {0,1,3,1,0});
            //AssertIntegerSequence(new Diamond('D').GetBetweenSequence(), new int[] {0,1,3,5,3,1,0});
        }

        [TestMethod]
        [Ignore]
        public void OneRow_is_a_list_of_chars_in_one_diamond_row()
        {
            //AssertCharacterSequence(new Diamond('A').GetOneRow('A', 0, 0), new char[] {'A'});
            //AssertCharacterSequence(new Diamond('B').GetOneRow('A', 1, 0), new char[] {' ', 'A'});
            //AssertCharacterSequence(new Diamond('B').GetOneRow('B', 0, 1), new char[] {'B', ' ', 'B'});
            //AssertCharacterSequence(new Diamond('D').GetOneRow('C', 1, 3), new char[] {' ', 'C', ' ', ' ', ' ', 'C'});
        }

        [TestMethod]
        [Ignore]
        public void Rows_is_a_list_of_diamond_rows()
        {
            List<List<char>> rows = new Diamond('B').GetRows();
            AssertCharacterSequence(rows[0], new char[] {' ', 'A'});
            AssertCharacterSequence(rows[1], new char[] {'B', ' ', 'B'});
            AssertCharacterSequence(rows[2], new char[] {' ', 'A'});
        }

        [TestMethod]
        [Ignore]
        public void print_DiamondC()
        {
            Assert.AreEqual("  A\n" +
                             " B B\n" +
                             "C   C\n" +
                             " B B\n" +
                             "  A", Diamond.Print('C'));
        }

        [TestMethod]
        [Ignore]
        public void print_DiamondD()
        {
            Assert.AreEqual("   A\n" +
                             "  B B\n" +
                             " C   C\n" +
                             "D     D\n" +
                             " C   C\n" +
                             "  B B\n" +
                             "   A", Diamond.Print('D'));
        }


        public void AssertCharacterSequence(List<char> sequence, char[] expectedChars)
        {
            Assert.AreEqual(expectedChars, sequence.ToArray());
        }

        public void AssertIntegerSequence(List<int> sequence, int[] expectedInts)
        {
            Assert.AreEqual(expectedInts, sequence.ToArray());
        }
    }
}
