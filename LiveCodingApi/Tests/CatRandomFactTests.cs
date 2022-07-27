using LiveCodingApi.Utils;
using NUnit.Framework;

namespace LiveCodingApi.Tests
{
    public class CatRandomFactTests
    {
        private CatFactApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new CatFactApiClient("https://catfact.ninja");
        }

        [Test]
        public async Task GetRandomFactWithZeroLength()
        {
            //act
            var response = await _client.GetRandomFact(0);

            //assert
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Length, Is.Null);
            Assert.That(response.Fact, Is.Null);
        }

        [Test]
        public void GetRandomFactWithPositiveLength()
        {
            //act
            //call Get Random Fact endpoint with maximum length = 100

            //assert
            //verify that fact field is not empty and length field is less than maximum length
            throw new NotImplementedException();
        }
    }
}