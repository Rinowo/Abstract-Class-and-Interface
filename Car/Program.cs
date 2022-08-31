namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Red", "Orange");
            ICar porsche = new Porsche("Taycan", "Red", 2);
            Console.WriteLine(seat.ToString());
            Console.WriteLine(porsche.ToString());
        }
    }
}