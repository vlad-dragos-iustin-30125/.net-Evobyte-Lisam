namespace WebApplicationCarApi.Models
{
    public class Car
    {
        public Guid Id { get; set; }    

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DOM { get; set; }
        public  string Fuel { get; set; }   

    }
}
