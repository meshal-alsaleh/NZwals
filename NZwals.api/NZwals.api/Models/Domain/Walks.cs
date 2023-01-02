namespace NZwals.api.Models.Domain
{
    public class Walks
    {
        public Guid id { get; set; }
        public String Name { get; set; }
        public double Length { get; set; }
        public Guid Regionid { get; set; }
        public Guid WalkDifucultyID { get; set; }
        //navigation proprty , or connetions between entites 
        public Regions Region { get; set; }
        public WalkDifuclty walkDifuclty { get; set; }

    }
}
