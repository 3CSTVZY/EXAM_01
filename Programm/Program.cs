Console.Clear(); 

Console.WriteLine("How many massives are here? ");
int size = Convert.ToInt32(Console.ReadLine());

#region 
string[] arrayString = new string[size];
  for (int i=0; i<size; i++)
{
  Console.WriteLine($"Enter the {i+1} element: ");
  string element = Convert.ToString(Console.ReadLine()??"");
  arrayString[i] = element;
}
string[] arrayTotal = new string[size];
int len = 3;
int pos = 0;
  for (int j=0; j<size; j++)
{
  if (arrayString[j].Length<=len)
  {
    arrayTotal[pos] = arrayString[j]; 
    pos++;
  }
}
#endregion

Console.WriteLine("Result is: ");
 
PrintArray(arrayTotal);

void PrintArray(string[] array)
{
  for (int i=0; i<array.Length;i++)
  {
  Console.Write(array[i]);   
  }
}
