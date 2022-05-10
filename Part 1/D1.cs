 // See https://aka.ms/new-console-template for more information
/* E1 //1
Console.WriteLine("Please enter your name:");
Console.Write("Hello " + Console.ReadLine());
*/

/*E2 & 3 & 7 //2,3,7
Console.WriteLine("Please enter a number:(Please use ',' for decimals)");
double Num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter a 2nd number:(Please use ',' for decimals)");
double Num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
Console.WriteLine($"{Num1} x {Num2} = {Num1 * Num2}");
Console.WriteLine($"{Num1} / {Num2} = {Math.Round(Num1 / Num2, 5)}");
Console.WriteLine($"{Num1} mod {Num2} = {Math.Round(Num1 % Num2, 5)}");
*/

/* E4 //4
Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
Console.WriteLine($"( 35+ 5 ) % 7 = {(35 + 5) % 7}");
Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
*/

/* E5 //5
Console.WriteLine("Please enter 1st number:(Please use ',' for decimals)");
double Num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter 2nd number:(Please use ',' for decimals)");
double Num2 = Convert.ToDouble(Console.ReadLine());

double Num3 = Num2;
Num2 = Num1;
Num1 = Num3;

Console.WriteLine($"It seems my system experienced a glich.");
Console.WriteLine($"Number 1's value is now {Num1}.");
Console.WriteLine($"Number 2's {Num2}.");
*/

/* E6 //6
Console.WriteLine("Please enter 1st number:(Please use ',' for decimals)");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 2nd number:(Please use ',' for decimals)");
double Num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 3rd number:(Please use ',' for decimals)");
double Num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{Num1} x {Num2} x {Num3} = {Num1*Num2*Num3}");
*/

/* E8 //8
Console.WriteLine("Please enter a number:(Please use ',' for decimals)");
double Num1 = Convert.ToDouble(Console.ReadLine());

for (int i=1; i<16; i++)
{
    Console.WriteLine($"{Num1} x {i} = {Math.Round(Num1 * i, 5)}");
}
*/

/* E9 //9
Console.WriteLine("Please enter 1st number:(Please use ',' for decimals)");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 2nd number:(Please use ',' for decimals)");
double Num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 3rd number:(Please use ',' for decimals)");
double Num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 4th number:(Please use ',' for decimals)");
double Num4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The average of {Num1}, {Num2}, {Num3} and {Num4} is: {(Num1 + Num2 + Num3 + Num4) / 4}");
*/

/* E10 //10
Console.WriteLine("Please enter 1st number:(Please use ',' for decimals)");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 2nd number:(Please use ',' for decimals)");
double Num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 3rd number:(Please use ',' for decimals)");
double Num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"({Num1}+{Num2}).{Num3} = {(Num1+Num2) * Num3}");
Console.WriteLine($"{Num1}.{Num2} + {Num2}.{Num3} = {(Num1*Num2) + (Num2*Num3)}");
*/

/* E11 //11
Console.WriteLine("How old are you? ");
Console.WriteLine($"Wow, you don't look {Console.ReadLine()}!");
*/

/* E12 //12
Console.WriteLine("Please enter a number: ");
double Num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter amount of times number should be repeated: ");
int rep = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter amount of times rows should be repeated: (please note this is a two row repeat)");
int row = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < row; i++)
{
    for(int j = 0; j < rep; j++)
    {
        Console.Write($"{Num} ");
    }
    Console.WriteLine();
    for (int l = 0; l < rep; l++)
    {
        Console.Write($"{Num}");
    }
    Console.WriteLine();
}
*/

/* E13 //13
Console.WriteLine("Please enter a number: ");
double Num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter Width of rectangle: ");
int Width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter Lenght of rectangle");
int Lenght = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < Width; j++)
{
    Console.Write($"{Num}");
}
Console.WriteLine();

for (int i = 0; i < Lenght; i++)
{
    Console.Write($"{Num}");

    for (int l = 0; l < Width-2; l++)
    {
        Console.Write(" ");
    }
    Console.WriteLine($"{Num}");
}
for (int k = 0; k < Width; k++)
{
    Console.Write($"{Num}");
}
Console.WriteLine();
*/

/* E14 //14
Console.WriteLine("Please enter Temperature (in C): ");
double Temp = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{Temp}'C in Fahrenheit is {Temp * 1.8 + 32}'F");
Console.WriteLine($"{Temp}'C in Kelvin is {Temp + 273}'K");
*/

/* E15* //15
string Test = "w3resource";

Console.WriteLine("Test word: " + Test);
Console.WriteLine(Test.Remove(1, 1));
Console.WriteLine(Test.Remove(9, 1));
Console.WriteLine(Test.Remove(0, 1));
*/

/* E16* //16
string Word1 = "w3resource";
string Word2 = "Python";

Console.WriteLine(Word1.Substring(Word1.Length - 1) + Word1.Substring(1, Word1.Length - 2) + Word1.Substring(0, 1));
Console.WriteLine(Word2.Substring(Word2.Length - 1) + Word2.Substring(1, Word2.Length - 2) + Word2.Substring(0, 1));
*/

/* E17 //17
Console.WriteLine("Please enter a sentance:");
string Word = Console.ReadLine();
Console.WriteLine(Word.Substring(0, 1) + Word + Word.Substring(0, 1));
*/

/* E18* //18
Console.WriteLine("Please enter a number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a 2nd number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Check if one is positive and one is negative: ");
Console.WriteLine(((Num1>0 && Num2<0) || (Num1<0 && Num2>0)) /*? "True" : "False");
*/

/* E19 //19
Console.WriteLine("Please enter a number: ");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter a 2nd number: ");
double Num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine((Num1 == Num2) ? (Num1 + Num2) * 3 : Num1 + Num2);
*/

/* E20 //20
Console.WriteLine("Please enter a number: ");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter a 2nd number: ");
double Num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(((Num1 > Num2) ? (Num1 - Num2) * 2 : Num2 - Num1));
*/

/* E21 //21
Console.WriteLine("Please enter a number: ");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter a 2nd number: ");
double Num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Does either of the number (or their sum) = 20?");
Console.WriteLine(((Num1 == 20) || (Num2 == 20) || ((Num1 + Num2) == 20)));
*/





































Console.ReadKey();
