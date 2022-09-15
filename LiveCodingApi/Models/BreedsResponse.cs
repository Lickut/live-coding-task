namespace LiveCodingApi.Models
{
    public class BreedsResponse
    {
        public int CurrentPage { get; set; }
        public BreedModel[] Data { get; set; }
        public string FirstPageUrl { get; set; }
        public int From { get; set; }

        public int LastPage{ get; set; }

        public string LastPageUrl { get; set; }
        public int Total { get; set; }

        public string Per_Page { get; set; }
    }
}
