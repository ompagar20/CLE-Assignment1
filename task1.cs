public static void Main(string[] args)
{   
  string stringForFloat = "0.85";
  float floatNumber = float.Parse(stringForFloat); 

  string stringForInt = "12345";
  int intNumber = int.Parse(stringForInt); 

 
  Console.WriteLine("Parsed float: " + floatNumber);
  Console.WriteLine("Parsed int: " + intNumber);
}
