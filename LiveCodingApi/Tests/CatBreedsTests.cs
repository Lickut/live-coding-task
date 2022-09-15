using NUnit.Framework;
using LiveCodingApi.Utils;

namespace LiveCodingApi.Tests
{
    public class CatBreedsTests
    {
        private CatFactApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new CatFactApiClient("https://catfact.ninja");
        }

        [Test]
        public async Task GetCatBreedsWithPositiveLimit()
        {
            //arrange
            int limit = 2;
            int totalBreeds = 98;            
            
            //act
            var response = await _client.GetBreeds(limit);

            //assert
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Data[0].Breed, Is.EqualTo("Abyssinian"));
            Assert.That(response.Data[1].Breed, Is.EqualTo("Aegean"));
            Assert.That(response.Total, Is.EqualTo(totalBreeds));
            Assert.That(response.Per_Page, Is.EqualTo("2"));
        }
    }
}