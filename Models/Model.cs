namespace project2.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int MakeId { get; set; }
        public Make make { get; set; }

    }
}