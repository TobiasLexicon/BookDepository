using System;
using Xunit;
using BookDepository;

namespace BookDepository.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetHarvardReferenceTest()
        {
            //Arrange

            string expected = "Parment, Anders (2008). Generation Y: framtidens konsumenter och medarbetare gör entré!. 1. uppl. Malmö: Liber";

            //Act
            CatalogPost testPost = new CatalogPost(
                "Generation Y: framtidens konsumenter och medarbetare gör entré!",
                "Anders Parment", "1. uppl", "Malmö", "Liber", 2008);

            //Assert
            Assert.Equal(expected, testPost.GetHarvardReference());
        }
    }
}
