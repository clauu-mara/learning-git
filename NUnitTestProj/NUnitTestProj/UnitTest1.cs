namespace NUnitTestProj
{
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
        }
        [Test]
        public void AddNewTest()
        {
            Assert.Fail();  
        }
        [Test]
        public void AddNewTest1()
        {
            Console.WriteLine("Test1");
        }
        [Test]
        public void AddNewTest2() { }
    }
}