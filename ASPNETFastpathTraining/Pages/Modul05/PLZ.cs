namespace ASPNETFastpathTraining.Pages.Modul05
{
    public class PLZ
    {


        public string postalCode { get; set; }
        public string name { get; set; }
        public Municipality municipality { get; set; }
        public District district { get; set; }
        public Federalstate federalState { get; set; }
    }

    public class Municipality
    {
        public string key { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class District
    {
        public string key { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Federalstate
    {
        public string key { get; set; }
        public string name { get; set; }
    }

}
