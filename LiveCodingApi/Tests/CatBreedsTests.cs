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
        public async Task GetCatBreedsWithNegativeLimit()
        {
            //act
            var response = await _client.GetBreeds(-1);

            //assert
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Data, Is.Null);
            //add other verification steps
        }

        [Test]
        public void GetCatBreedsWithPositiveLimit()
        {
            //act
            //get cat breeds with limits = 2

            //assert
            /* add next verifications:
                - verify total field in response
                - verify per_page field in response
                - verify that data collection in response contains next breeds: "Abyssinian" and "Aegean"
             */
            throw new NotImplementedException();
        }
    }
}