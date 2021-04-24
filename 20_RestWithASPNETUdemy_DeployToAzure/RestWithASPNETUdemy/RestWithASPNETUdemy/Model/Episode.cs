namespace RestWithASPNETUdemy.Model
{
    public class Episode
    {
        public string id { get; set; }
        public string title { get; set; }
        public string members { get; set; }
        public string published_at { get; set; }
        public string thumbnail { get; set; }
        public string description { get; set; }
        public File file { get; set; }
    }
}
