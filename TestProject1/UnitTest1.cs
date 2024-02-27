using WebApplication1;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sayJenkins_1()
        {
            SampleClass testClass = new SampleClass();
            string result = testClass.sayJenkins(3);
            Assert.AreEqual("Jenkins Jenkins Jenkins ", result);
        }
        [Test]
        public void Test_sayJenkins_2()
        {
            SampleClass testClass = new SampleClass();
            string result = testClass.sayJenkins(1);
            Assert.AreEqual("Jenkins ", result);
        }
    }
}