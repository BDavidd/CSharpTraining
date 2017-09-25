using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            RoadTrip chores = new RoadTrip();
            RoadTrip vacation = new RoadTrip();

            chores.Miles = 10.3;
            chores.GallonsUsed = 0.5;
            chores.HoursElapsed = 1;

            vacation.Miles = 200;
            vacation.GallonsUsed = 20;
            vacation.HoursElapsed = 4;

            Console.WriteLine("For the chore: miles: {0}, gallons: {1}, hours: {2}", chores.Miles, chores.GallonsUsed, chores.HoursElapsed);
            Console.WriteLine("For the chore: vacation: {0}, gallons: {1}, hours: {2}", vacation.Miles, vacation.GallonsUsed, vacation.HoursElapsed);
        }
    }
}
