

//Not sure how to do this with .net 6 - come back once I know more
console.WriteLine("Results: " + result);

ReverseString("Hello");

static void ReverseString(string message)
{
  char[] messageArray = message.ToCharArray();
  Array.Reverse(messageArray);
  foreach (char item in messageArray)
  {
   Result += item;   
  }
}