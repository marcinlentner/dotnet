namespace Gradebook.tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {

            // arrange
            var book = new Book("");
            book.AddGrade(12.1);
            book.AddGrade(13.7);
            book.AddGrade(14.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(13.4, result.Average, 1);
            Assert.Equal(14.3, result.High, 1);
            Assert.Equal(12.1, result.Low, 1);

        }
    }
}