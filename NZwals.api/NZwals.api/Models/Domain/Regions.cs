namespace NZwals.api.Models.Domain
{
    public class Regions
    {
        public Guid id { get; set; }  
        public string Code { get; set; }


        public String Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }
        // navigation property
        public IEnumerable<Walks> Walks { get; set; } // means one region can have many walks , true
    }
}
