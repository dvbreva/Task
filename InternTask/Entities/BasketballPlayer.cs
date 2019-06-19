using CsvHelper.Configuration.Attributes;

namespace InternTask.Entities
{
    public class BasketballPlayer
    {
        [Name("Name")]
        public string Name { get; set; }

        [Ignore]
        public int PlayingSince { get; set; }

        [Ignore]
        public string Position { get; set; }

        [Name("Rating")]
        public int Rating { get; set; }
    }
}
