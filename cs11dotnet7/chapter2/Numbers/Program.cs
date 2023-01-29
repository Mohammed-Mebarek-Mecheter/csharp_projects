/*// three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; 
int hexadecimalNotation = 0x_001E_8480;
// check the three variables have the same value
// both statements output true 
Console.WriteLine($"{decimalNotation == binaryNotation}"); 
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");*/

/*Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}."); 
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}."); 
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");*/

Console.WriteLine("Using doubles:"); 
double a = 0.1;
double b = 0.2;
double c = a + b;
Console.WriteLine($"{a} + {b} equals {c}");