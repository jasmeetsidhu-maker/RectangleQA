using NUnit.Framework;


namespace Rectangle
{
    [TestFixture]
    public class RecatngleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestToGetIntValue()
        {
            var rectangle = new Rectangle();
            

            //int result = rectangle.GetLength();

            Assert.AreEqual( 4 , rectangle.GetLength());
        }
        [Test]

        public void TestToSetValue()
        {

            var rectangle = new Rectangle();
            

            int result = rectangle.SetLength(5);

            Assert.AreEqual(5, result);
        }




    }
}