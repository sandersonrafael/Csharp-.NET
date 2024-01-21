Console.WriteLine("Enter the number of people and his individual heights");
Console.Write("People quantity: ");
int peopleNumber = int.Parse(Console.ReadLine() ?? "0");
double[] heights = new double[peopleNumber];
double heightSum = 0.0;

for (int i = 0; i < peopleNumber; i++) {
    Console.Write($"Height of person {i + 1}: ");
    heights[i] = double.Parse(Console.ReadLine() ?? "0.0");
    heightSum += heights[i];
}

double average = heightSum / peopleNumber;

Console.WriteLine($"The people average height is: {average:F2}");
