using System;
using System.Reflection;

public class MainClass
{
    static void Main(string[] args)
    {
        try
        {
            Assembly a = Assembly.ReflectionOnlyLoadFrom(args[0]);
            Console.WriteLine("Assembly version of file {0} = {1}", args[0], a.GetName().Version);
        }
        catch (SystemException e)
        {
            Console.WriteLine("ERROR! Message = {0}", e.Message);
        }
    }
}