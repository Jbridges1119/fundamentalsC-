int[] numbers = new int[5];
//declare an array of numbers named numbers
//create the array with new and declare number and length int[5]


int[] numbers2 = new int[] {4,5,6,7,44,54};
string[] names = new string[] { "eddie", "alex", "Mike"};

foreach (string name in names)
{
  Console.WriteLine(name);
}

string zig = "You can get what you want out of life if you help other people get what they want.";

//declare an array of characters
char[] charArray = zig.ToCharArray();
//revers array
Array.Reverse(charArray);
Console.Write(charArray);
//iterate through reversed array
foreach (char item in charArray)
{
  Console.Write(item);
}