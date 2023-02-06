namespace NZWalksWebAPI.Models.Domain
{
    public class Walk
    {

        public Guid ID { get; set; }

        public string Fullname { get; set; }

        public double Length { get; set; }

        public Guid RegionID { get; set; }

        public Guid WalkDifficultID { get; set; }

        //navigation propertry

        public Region Region { get; set; }

        public WalkDifficulty walkDifficulty { get; set; }

    }
}
