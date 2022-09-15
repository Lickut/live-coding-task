using NUnit.Framework;
using LiveCodingApi.Utils;
using LiveCodingApi.Models;
using Newtonsoft.Json;

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
            int breedLimit = 2;

            //act
            //get cat breeds with limits = 2
            var response = await _client.GetBreeds(breedLimit);
            string[] actualBreeds = response.Data.Select(d => d.Breed).ToArray();

            //assert
            /* add next verifications:
                - verify total field in response
                - verify per_page field in response
                - verify that data collection in response contains next breeds: "Abyssinian" and "Aegean"
             */

            Assert.That(response, Is.Not.Null);
            Assert.That(response.Data.Length, Is.EqualTo(breedLimit));
            Assert.That(response.Total, Is.EqualTo(98));
            Assert.That(response.Per_Page, Is.EqualTo("2"));
            Assert.That(actualBreeds, Does.Contain("Abyssinian").And.Contain("Aegean"));
        }
    }
}