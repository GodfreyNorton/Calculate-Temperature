Console.WriteLine("Welcome to the Temperature Converter! \nPick what you need.");

Console.WriteLine("1. Convert Celsius to Fahrenheit \n2. Convert Fahrenheit to Celsius \n3. Exit");

string goon = " ";
int counter = 1;
int answer = 0;

while (goon == " ")
{
    //Console.WriteLine(/*score +*/ " " + counter);
    counter++;
    answer = int.Parse(Console.ReadLine()); // allow eternity loop untill user pick 3 option

    if (answer == 1)
    {
        Console.WriteLine("Enter your degree");
        string degree = Console.ReadLine();
        int celsius = Convert.ToInt32(degree);
        int result = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C is equal to {result}°F");

    }

    if (answer == 2)
    {
        Console.WriteLine("Enter your degree");
        string degree = Console.ReadLine(); // input useds number for degree
        int fahrenheit = Convert.ToInt32(degree); // converting to Int
        int result = (fahrenheit - 32) * 5 / 9; // mathematical solution
        Console.WriteLine($"{fahrenheit}°F is equal to {result}°C");  // exlude mathematical solution 

    }

    if (answer == 3)
    {
        Console.WriteLine("Goodbye! Exiting the Temperature Converter.");
        Console.ReadLine();
        Console.Clear();
        break; // close the app 
        
    }
}