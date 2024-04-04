/*
 * Convert fahrenheit to celsius
 */
int fahrenheit = 94;
float celsius = (fahrenheit - 32) * 5 / (float)9;

// show result
// use fixed point format:
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
Console.WriteLine($"The temperature is {celsius:F2} Celsius.");
