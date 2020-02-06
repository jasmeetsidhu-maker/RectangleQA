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

        // test for method Get Length 
        public void CheckValueOfLengthIsNotZero()
        {
            // arrange
            var rectangle = new Rectangle();

            // act 
            int expectValue = 0;
            // assert 
            Assert.AreEqual(expectValue, rectangle.GetLength());
        }

        // 1st test for method Set length 
        [TestCase]
         
        public void CheckNegativeValueIsNotPassed()
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act 
            int expectValue = -09;
          

            // Assert 
            Assert.AreEqual(expectValue, rectangle.SetLength(1));
        }


        // 2nd test for method Set length

        [TestCase]

        public void AddedIntValueToSetLength()
        {
            // Arrange
            var rectangle = new Rectangle();


            // Act
            int result = rectangle.SetLength(5);

            //Assert
            Assert.AreEqual(5, result);
        }


        // test for method Get Width
        [Test]
        public void CheckValueOfWidthIsNotZero()
        {
            // Arrange
            var Program = new Rectangle();

            // act 
            int expectValue = 0;
            // assert 
            Assert.AreEqual(expectValue, Program.GetWidth());
        }


        // 1st test for method Set width
        public void NegativeValueIsNotPassed()
        {
            // Arrange

            var Program = new Rectangle();

            // Act 
            int expectValue = -77;

            // Assert 
            Assert.AreEqual(expectValue, Program.SetWidth(1));
        }

        // 2nd test for method Set width

        [TestCase]

        public void AddedIntValueToSetWidth()
        {
            // Arrange
            var rectangle = new Rectangle();


            // Act
            int result = rectangle.SetWidth(55);

            //Assert
            Assert.AreEqual(55, result);
        }


        


        //  test for method GetArea()
        [TestCase]

        public void ValueToGetArea()
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act
            int expectValue =   3 * 3;
            
            //Assert
            Assert.AreEqual(expectValue, rectangle.GetArea());
        }

        //  test for method GetPerimeter()

        [TestCase]

        public void AddedIntValueToGetPerimeter()
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act

            int expectValue = 55;
            //Assert
            Assert.AreEqual(expectValue, rectangle.GetPerimeter());
        }
    }
}