namespace project2.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }();
        public Make(Parameters)
        {
            Models=new Collection<Model>();
        }
    }
} 