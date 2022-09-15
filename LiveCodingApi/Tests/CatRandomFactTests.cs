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
        public async Task GetRandomFactWithPositiveLength()
        {
            //arrange
            int maxLength = 100;

            //act
            var response = await _client.GetRandomFact(maxLength);

            //assert
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Fact, Is.Not.Null.Or.Null);
            Assert.That(response.Length, Is.LessThanOrEqualTo(maxLength));
            Assert.That(response.Fact.Count(), Is.EqualTo(response.Length));

        }
    }
}