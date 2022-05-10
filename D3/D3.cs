// See https://aka.ms/new-console-template for more information

/* E34* //1
Console.WriteLine("Please enter a sentence: ");
string Sentence = Console.ReadLine();
int Len = Sentence.Length;
string Word = "";
char Cha;


for (int i = 0; i < Len; i++)
{
    Cha = Sentence[i];
    if (Cha != ' ')
    {
        Word = Word + Cha;
            }
    else i = Len;
}

Console.WriteLine(Word == "Hello");

//Console.WriteLine((Sentence.Length < 6 && Sentence.Equals("Hello")) || (Sentence.StartsWith("Hello") && Sentence[5] == ' '));

*/

/* E35 //2

Console.WriteLine("Input first number (<100):");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number (>200):");
int Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Num1 < 100 && Num2 > 200);
*/

/* E36 //3

Console.WriteLine("Input first number:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((Num1 <= 10 && Num1 >= -10) || (Num2 <= 10 && Num2 >= -10));

*/

/* E37* //4

Console.WriteLine("Please input sentence:");
string Sen = Console.ReadLine();
string NewSen = "";
char C1 = Sen[1];
char C2 = Sen[2];

if ((Sen.Length <= 2) || (C1 != 'H') && (C2 != 'P'))
{
    NewSen = Sen;
}
else NewSen = Sen.Remove(1, 2);

Console.WriteLine(NewSen);

//Console.WriteLine((Sen.Substring(1, 2).Equals("HP") ? Sen.Remove(1, 2) : Sen));
*/

/* E38* //5

Console.WriteLine("Please input sentence:");
string Sen = Console.ReadLine();
int i = Sen.Length;
Console.WriteLine((i >= 2) && ((Sen[0] == 'P') && (Sen[1] == 'H')) ? "PH" : "") ;
*/

/* E39* //6

int[] Num = new int[3];

Console.WriteLine("Please enter 1st amount:");
Num[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter 2nd amount:");
Num[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter 3rd amount:");
Num[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Maximum Val: {Num.Max()}");
Console.WriteLine($"Minimum Val: {Num.Min()}");

//Console.WriteLine("Largest of three: "+Math.Max(x, Math.Max(y, z)));
//Console.WriteLine("Lowest of three: "+Math.Min(x, Math.Min(y, z)));

*/

/* E40* //7

Console.WriteLine("Please enter first number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
int Dif1, Dif2;

Dif1 = (Num1 >= 20) ? Num1 - 20 : 20 - Num1;
Dif2 = (Num2 >= 20) ? Num2 - 20 : 20 - Num2;

//var val1 = Math.Abs(x - n);
//var val2 = Math.Abs(y - n);

Console.WriteLine((Dif1 > Dif2) ? Num2 : Num1);

*/

/* E41 //8

Console.WriteLine("Please enter a sentence:");
string Sen = Console.ReadLine().ToUpper();

if (Sen.Length > 4)
{
    Console.WriteLine(Sen.Substring(0, 4).ToLower() + Sen.Substring(4));
}
else
{
    Console.WriteLine(Sen);
}

*/

/* E42 //9

Console.WriteLine("Please enter a sentence:");
string Sen = Console.ReadLine();

Console.WriteLine((Sen[0] == 'w')&&((Sen[1] == 'w')&&(Sen[2] == 'w')));

*/

/* E44 //10

Console.WriteLine("Please enter a sentence:");
string Sen = Console.ReadLine();
int Len = Sen.Length;
string NewSen = "";
for (int i = 0; i < Len; i += 2)
{
    NewSen = NewSen + Sen[i];
}

Console.WriteLine(NewSen);

*/

/* E45* //11 

Console.WriteLine("Please enter an interger");
int Req = Convert.ToInt32(Console.ReadLine());
int[] Numbers = { 5, 189, 1, 916, 61, 3, 1, 8549, 6, 31, 96, 49, 6, 1, 15, 41, 16, 5, 4189, 64, 1, 8, 7, 3, 4};
int count = 0;

foreach (int Num in Numbers)
{
    if (Num == Req)
    {
        count++;
    }
}

Console.WriteLine($"Nummber of {Req}'s in the array is {count}.");

//Console.WriteLine("Number of " + Req + " present in the said array:");
//Console.WriteLine(Numbers.Count(n => n == Req));

*/

/* E46 //12

Console.WriteLine("Please enter an interger");
int Req = Convert.ToInt32(Console.ReadLine());
int[] Numbers = { 5, 189, 1, 916, 61, 3, 1, 8549, 6, 31, 96, 49, 6, 1, 15, 41, 16, 5, 4189, 64, 1, 8, 7, 3, 4 };

Console.WriteLine((Numbers.First() == Req) || (Numbers[Numbers.Length - 1] == Req));

*/


/* E47 //13

int[] Numbers = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
Console.WriteLine("Sum: " + Numbers.Sum());

*/


/* E48 //14

int[] Numbers = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
Console.WriteLine((Numbers.First() == Numbers[Numbers.Length - 1]) && (Numbers.Length >= 1));

*/

/* E49 //15

int[] Num1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
int[] Num2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

Console.WriteLine((Num1.First() == Num2.First()) || (Num1[Num1.Length - 1] == Num2[Num2.Length - 1]));

//Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
*/

/* E50* //16

int[] Num1 = { 1, 2, 8 };
int first = Num1[0];
int i = 0;

foreach (int num in Num1)
{
    try
    {
        Num1[i] = Num1[i + 1];
    }
    catch (IndexOutOfRangeException)
    {
        Num1[i] = first;
    }
    finally { i++; }

    Console.Write($"{Num1[i-1]}, ");
}

*/

/* E51 //17

int[] Num1 = { 1, 2, 5, 7, 8 };
Console.WriteLine(Num1.Max());

*/

/* E52* //18

int[] Num1 = { 1, 2, 5 };
Console.WriteLine($"Array 1: {string.Join(", ", Num1)} ");
int[] Num2 = { 0, 3, 8 };
Console.WriteLine($"Array 2: {string.Join(", ", Num2)} ");
int[] Num3 = {-1, 0, 2};
Console.WriteLine($"Array 3: {string.Join(", ", Num3)} ");
int[] NewNum = { Num1[1], Num2[1], Num3[1]};
Console.WriteLine($"New Array: {string.Join(", ", NewNum)} ");

*/






















































































































































































































Console.ReadKey();


