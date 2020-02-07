using NUnit.Framework;


namespace Rectangle
{
    [TestFixture]
    public class RecatngleTests
    {
        int actualValue;
        [SetUp]
        public void Setup()
        {
        }

     

        // 1st test for method Get Length 
        [Test]
        public void GetLength_Actual_99_Expect_99()
        {
            // arrange
            var rectangle = new Rectangle(99,55);
            
            // act
             actualValue =rectangle.GetLength();

            // assert 
            Assert.AreEqual(99, actualValue);
        }

        // 2nd test for method Get length 
        [Test]
         
        public void GetLength_Actual_8_Expected_8()
        {
            // Arrange
            var rectangle = new Rectangle(8,3);

            // Act 
            actualValue= rectangle.GetLength();
          

            // Assert 
            Assert.AreEqual(8,actualValue);
        }

        // 3rd test for method Get length 
        [Test]

        public void GetLength_Actual_98_Expected_98()
        {
            // Arrange
            var rectangle = new Rectangle(98, 32);

            // Act 
            actualValue = rectangle.GetLength();


            // Assert 
            Assert.AreEqual(98, actualValue);
        }



        // 1st test for method Set Length 
        [Test]
        public void SetLength_Actual_88_Expect_88()
        {
            // arrange
            var rectangle = new Rectangle();

            // act
            actualValue = rectangle.SetLength(88);

            // assert 
            Assert.AreEqual(88, actualValue);
        }

        // 2nd test for method Set length 
        [Test]

        public void SetLength_Actual_7_Expected_7()
        {
            // Arrange
            var rectangle = new Rectangle(18,55);

            // Act 
            actualValue = rectangle.SetLength(7);


            // Assert 
            Assert.AreEqual(7, actualValue);
        }

        // 3rd test for method Set length 
        [Test]

        public void GetLength_Actual_66_Expected_66()
        {
            // Arrange
            var rectangle = new Rectangle(54, 13);

            // Act 
            actualValue = rectangle.SetLength(66);


            // Assert 
            Assert.AreEqual(66, actualValue);
        }






        // 1st test for method Get Width 
        [Test]
        public void GetWidth_Actual_55_Expect_55()
        {
            // arrange
            var rectangle = new Rectangle(19, 55);

            // act
            actualValue = rectangle.GetWidth();

            // assert 
            Assert.AreEqual(55, actualValue);
        }


        // 2nd test for method Get Width 
        [Test]

        public void GetWidth_Actual_883_Expected_883()
        {
            // Arrange
            var rectangle = new Rectangle(69, 883);

            // Act 
            actualValue = rectangle.GetWidth();


            // Assert 
            Assert.AreEqual(883, actualValue);
        }

        // 3rd test for method Get Width 
        [Test]

        public void GetWidth_Actual_432_Expected_432()
        {
            // Arrange
            var rectangle = new Rectangle(498, 432);

            // Act 
            actualValue = rectangle.GetWidth();


            // Assert 
            Assert.AreEqual(432, actualValue);
        }





        // 1st test for method Set Width 
        [Test]
        public void SetWidth_Actual_2_Expect_2()
        {
            // arrange
            var rectangle = new Rectangle();

            // act
            actualValue = rectangle.SetWidth(2);

            // assert 
            Assert.AreEqual(2, actualValue);
        }

        // 2nd test for method Set Width 
        [Test]

        public void SetWidth_Actual_67_Expected_67()
        {
            // Arrange
            var rectangle = new Rectangle(227, 55);

            // Act 
            actualValue = rectangle.SetWidth(67);


            // Assert 
            Assert.AreEqual(67, actualValue);
        }

        // 3rd test for method Set Width 
        [Test]

        public void GetWidth_Actual_566_Expected_566()
        {
            // Arrange
            var rectangle = new Rectangle(524, 132);

            // Act 
            actualValue = rectangle.SetWidth(566);


            // Assert 
            Assert.AreEqual(566, actualValue);
        }






        // 1st test for method GetArea()
        [Test]

        public void GetArea_ActualValues_3_4_Expect_12  ()
        {
            // Arrange
            var rectangle = new Rectangle(3,4);

            // Act
            actualValue = rectangle.GetArea();
            
            //Assert
            Assert.AreEqual(12, actualValue);
        }


        // 2nd test for method GetArea()
        [Test]

        public void GetArea_ActualValues_34_44_Expect_1496()
        {
            // Arrange
            var rectangle = new Rectangle(34, 44);

            // Act
            actualValue = rectangle.GetArea();

            //Assert
            Assert.AreEqual(1496, actualValue);
        }


        // 3rd test for method GetArea()
        [Test]

        public void GetArea_ActualValues_5_7_Expect_35()
        {
            // Arrange
            var rectangle = new Rectangle(5, 7);

            // Act
            actualValue = rectangle.GetArea();

            //Assert
            Assert.AreEqual(35, actualValue);
        }



        // 1st test for method GetPerimeter()
        [Test]

        public void GetPerimeter_ActualValues_3_4_Expect_14()
        {
            // Arrange
            var rectangle = new Rectangle(3, 4);

            // Act
            actualValue = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(14, actualValue);
        }


        // 2nd test for method GetPerimeter()
        [Test]

        public void GetPerimeter_ActualValues_34_44_Expect_156()
        {
            // Arrange
            var rectangle = new Rectangle(34, 44);

            // Act
            actualValue = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(156, actualValue);
        }


        // 3rd test for method GetPerimeter()
        [Test]

        public void GetPerimeter_ActualValues_5_7_Expect_24()
        {
            // Arrange
            var rectangle = new Rectangle(5, 7);

            // Act
            actualValue = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(24, actualValue);
        }


    }
}