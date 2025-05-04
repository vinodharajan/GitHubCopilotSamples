namespace SampleAPI
{
    public class ProjectDetails
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        
        public ClientDetails Client { get; set; }
    }
}
