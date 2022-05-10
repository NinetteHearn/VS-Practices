// See https://aka.ms/new-console-template for more information

/* E22 //1
Console.WriteLine("Please enter an Integer:");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((Num > 79 && Num < 121) || (Num > 179 && Num < 221));
*/

/* E23 //2
Console.WriteLine("Please enter a sentance:");
Console.WriteLine(Console.ReadLine().ToLower());
*/

/* E24* //3
Console.WriteLine("Please enter a sentance:");
string Sen = Console.ReadLine() + " ";
int Len = Sen.Length;
string Word = " ";
string Max = " ";
char Cha;
int p, max1 = 0;


for (int i = 0; i < Len; i++)
{
    Cha = Sen[i];
    if (Cha != ' ')
    {
        Word = Word + Cha ;
    }
    else
    {
        p = Word.Length - 1;
        if (p > max1)
        {
            max1 = p;
            Max = Word;
        }
        Word = " ";
    }


}

Console.WriteLine($"The longest word is {Max} with a total of {max1} letters.");

//their answer:

string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
                    string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
                        string word = "";
                        int ctr = 0;
                        foreach (String s in words)
                        {
                            if (s.Length > ctr)
                            {
                                word = s;
                                ctr = s.Length;
                            }
                        }

*/

/* E25 //4
for (int i = 0; i < 101; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }   
}
*/

/* E26 *** //5
Console.WriteLine("\nSum of the first 500 prime numbers: ");
long sum = 0;
int ctr = 0;
int n = 2;
while (ctr < 500)
{
if (isPrime(n))
{
sum += n;
ctr++;
}
n++;
}

Console.WriteLine(sum.ToString());
                    
    }
     public static bool isPrime(int n)
{
    int x = (int)Math.Floor(Math.Sqrt(n));

    if (n == 1) return false;
    if (n == 2) return true;

    for (int i = 2; i <= x; ++i)
    {
        if (n % i == 0) return false;
    }

    return true;

*/

/* E27* //6
Console.WriteLine("Please enter Integer: ");
char[] Numbers = Console.ReadLine().ToCharArray();
int x = Numbers.Length;
int Sum = 0;
string Single = "";

for (int z = 0; z<x; z++)
{
    Single = Convert.ToString(Numbers[z]);
    Sum = Sum + Convert.ToInt32(Single);
}

Console.WriteLine($"Sum of the digits of the said integer: {Sum}");
*/

/* E28 //7
Console.WriteLine("Please enter a Sentance: ");
String Sentance = Console.ReadLine() + " ";
String[] Words = Sentance.Split(' ');
String Reverse = "";

foreach (string word in Words)
{
    Reverse = word + " " + Reverse;
}

Console.WriteLine($"Reverse string: {Reverse}");
*/

/* E29* //8
var Imp = @"C:\Users\Nina\Desktop\TTRPG\Saphy\Saphy.pdf";
long length = new System.IO.FileInfo(Imp).Length;
Console.WriteLine($"File -  {Imp}  - is {length} bytes large.");
*/

/* E30* //9
Console.WriteLine("Please enter HEX Value:");
var Hex = Console.ReadLine();
Hex = Hex.ToUpper();
Console.WriteLine($"Hexadecimal number: {Hex}");
Console.WriteLine($"Convert to-");
Console.WriteLine($"Decimal number: {Convert.ToInt32(Hex, 16)}");
*/

/* E31 //10
int[] Ar1 = { 1, 3, -5, 4 };
int[] Ar2 = { 1, 4, -5, -2 };
int i = 0;

foreach (int num in Ar1)
{
    Console.Write(num * Ar2[i] + " ");
    i++;
}

*/

/* E32 //11

Console.WriteLine("Please enter a sentence: ");
string Sen = Console.ReadLine();
string newSen = "";
int idex = Sen.Length - 4;


if (idex <= 4)
{
    Console.WriteLine(Sen);
}
else
{
    newSen = Sen.Substring(idex);
    Console.WriteLine(newSen + newSen + newSen + newSen);
}

*/

/* E33 //12

Console.WriteLine("Please enter intiger: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((num % 3 == 0) || (num % 7 == 0));

*/







































































































































































































Console.ReadKey();
