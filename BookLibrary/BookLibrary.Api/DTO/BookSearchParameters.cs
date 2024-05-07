namespace BookLibrary.Api.DTO
{
    public class BookSearchParameters
    {
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Type { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
    }
}
