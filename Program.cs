

class RoomCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Ali’s Room Detail Generator!");

        // Asking user for width and length
        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        //area and perimeter
        double area = length * width;
        double perimeter = 2 * (length + width);

        // area and perimeter for user
        Console.WriteLine($"Area: {area} square feet");
        Console.WriteLine($"Perimeter: {perimeter} feet");

        // Size of the room S M L 
        string roomSize;
        if (area <= 250)
            roomSize = "small";
        else if (area > 250 && area < 650)
            roomSize = "medium";
        else
            roomSize = "large";

        Console.WriteLine($"The room is a {roomSize} sized room.");

        // Extra volume and surface area (" Multiply the length by the width to get the area, and add twice the length to twice the width to get the perimeter.")
        double height = 10; 
        double volume = area * height;
        double surfaceArea = 2 * (length * height + width * height) + area;

        Console.WriteLine($"Volume of the room: {volume} cubic feet");
        Console.WriteLine($"Surface area of the room: {surfaceArea} square feet");
        // Goodbye message
        Console.WriteLine("Thank you for using the Room Detail Generator!");

    }
}