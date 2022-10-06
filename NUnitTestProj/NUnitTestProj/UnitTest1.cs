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
        public void AddNewTest2() {
            Console.WriteLine("Test for branch2");
            Assert.Pass();
        }
        [Test]
        public void AddNewTest3()
        { Console.WriteLine("New commit on branch2");
            Console.WriteLine("New2 commit on branch2");
        }
        [Test]
        public void AddNewTest3a()
        {
            { Console.WriteLine("stashing and reflog"); }
        }


    }
}