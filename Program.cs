
internal class Program
{
    // References :
    // https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0

    // Try out Console Read/Write etc
    // attach / start processes
    // debug / non-debug
    // standrad / non-standard input / output streams
    private static void Main(string[] args)
    {
        try
        {
            //Console.Write("Hello ");
            //Console.WriteLine("World!");

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Good day, ");
            //Console.Write(name);

            //Console.WriteLine("!");

            // https://www.w3schools.com/cs/cs_properties.php

            Person myObj = new Person();
            myObj.Name = "Steve";
            myObj.Surname = "Sutton";
            Console.WriteLine(myObj.Name + " " + myObj.Surname);
        }
        catch (Exception e)
        { 
            Console.WriteLine(e.ToString());
        }
        finally 
	    {
            Console.Write("\n\nPress any to continue ...");
            Console.ReadLine();
        }
    }
    
class Person
{
  private string name; // field
private string sutton; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
public string Surname   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
}


