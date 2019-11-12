using System;
using Xunit;

using System.IO;
using System.Text.RegularExpressions;

using UgeSeddel2;

namespace automatiskTest
{
    public class UnitTest1
    {
        StringWriter output;
        StringReader input;

        String pattern;
        Regex regex;

        public UnitTest1()
        {
            output = new StringWriter();
            Console.SetOut(output);

            input = new StringReader("");
            Console.SetIn(input);
        }

        [Fact]
        public void Dialog1()
        {
            Program.Main(new String[] { });

            string resultat = this.output.ToString();

            Assert.Contains(
                "Navn     :", resultat
            );

            Assert.Contains(
                "Timeløn  :", resultat
            );

            Assert.Contains(
                "Timer    :", resultat
            );
        }

        [Fact]
        public void Dialog2()
        {
            input = new StringReader("Søren\n200\n40\n");
            Console.SetIn(input);

            Program.Main(new String[] { });

            string resultat = this.output.ToString();

            Assert.Contains(
                "Navn     :", resultat
            );

            Assert.Contains(
                "Timeløn  :", resultat
            );

            Assert.Contains(
                "Timer    :", resultat
            );

            Assert.Contains(
                "FOR Søren", resultat
            );
        }
    }
}
