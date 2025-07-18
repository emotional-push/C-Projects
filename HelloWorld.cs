namespace HelloWorld
{
  class ProgramForHelloWorld
  {
    static void Call(string[] args)
    {
      OutputText(args);
    }

    static void OutputText(string[] args)
    {
      System.Console.WriteLine("Hello World!");
    }
  }
}