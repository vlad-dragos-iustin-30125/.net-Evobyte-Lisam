using System;
using Week1;

class Program
{
    static void Main(string[] args)
    {
        Car Car1 = new Car();
         Car1.Name = "Audi";
        Car1.Model = "A4";
        Car1.Year = 2016;
        Car1.Description = "The Petrol engine is 1998 cc . It is available with Automatic transmission. Depending upon the variant and fuel type the A4 has a mileage of . The A4 is a 5 seater 4 cylinder car and has length of 4762mm, width of 1847mm and a wheelbase of 2819mm";
        Car1.Drive();

        Street Street1 = new Street();
        Street1.Name = "Stefan cel Mare";
        Street1.SpeedLimit = 50;
        Street1.AddTrafficLight();

        Park Park1 = new Park();
        Park1.Name = "Parcul Rozelor";
        Park1.AddPlayGround();

        Building Building1 = new Building();
        Building1.Name = "UTCN";
        Building1.NumberOfFloors = 4;
        Building1.HasElevator = false;
        Building1.Year = 1985;

        School School1 = new School();
        School1.Name = "Lucian Blaga";
        School1.NumberOfStudents = 200;
        School1.hasGym = false;
        School1.NumbersOfTeachers = 50;
    }
}