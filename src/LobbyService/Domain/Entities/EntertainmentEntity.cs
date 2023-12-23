namespace Domain.Entities
{
    public abstract record EntertainmentEntity : EntityBase
    {
        public int KinopoiskId { get; set; }
        public string ImdbId { get; set; }
        public required string NameRu { get; set; }
        public string? NameEn { get; set; }
        public string? PosterUrl { get; set; }
        public double RatingKinopoisk { get; set; }
        public double RatingImdb { get; set; }
        public string? WebUrl { get; set; }
        public int Year { get; set; }
        public int FilmLength { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public bool IsSeries { get; set; }
       /* public IList<string>? Genres { get; set; }
        public IList<string>? Countries { get; set; }*/
    }
}
