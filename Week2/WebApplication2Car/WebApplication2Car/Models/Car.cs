namespace WebApplication2Car.Models
{
    public class Car
    {

        public Guid ID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DOM { get; set; }   

        public string Fuel { get; set; }
        
    }
}
