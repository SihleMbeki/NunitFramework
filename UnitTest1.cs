namespace Nunit_Project;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
        Console.WriteLine("Hello, World");
    }
}