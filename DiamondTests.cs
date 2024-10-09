using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.IO;

[TestFixture]
public class DiamondTests
{
    private StringWriter consoleOutput;

    [SetUp]
    public void SetUp()
    {
        consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
    }

    [TearDown]
    public void TearDown()
    {
        consoleOutput.Dispose();
    }

    [Test]
    public void TestPrintDiamondWithA()
    {
        Program.PrintDiamond('A');
        string expectedOutput = "A\r\n"; // Output with trailing underscores for visualization
        ClassicAssert.AreEqual(expectedOutput, consoleOutput.ToString());
    }

    [Test]
    public void TestPrintDiamondWithB()
    {
        Program.PrintDiamond('B');
        string expectedOutput = "_A_\r\nB_B\r\n_A_\r\n";
        ClassicAssert.AreEqual(expectedOutput, consoleOutput.ToString());
    }

    [Test]
    public void TestPrintDiamondWithC()
    {
        Program.PrintDiamond('C');
        string expectedOutput = "__A__\r\n_B_B_\r\nC___C\r\n_B_B_\r\n__A__\r\n";
        ClassicAssert.AreEqual(expectedOutput, consoleOutput.ToString());
    }

    [Test]
    public void TestPrintDiamondWithB_Failing() // Deliberate failed
    {
        // Intentionally provide an incorrect expected output
        Program.PrintDiamond('B');
        string expectedOutput = "_A__\r\nB B\r\n_A__\r\n"; // Missing underscores to visualize spaces correctly
        ClassicAssert.AreNotEqual(expectedOutput, consoleOutput.ToString());
    }

}
