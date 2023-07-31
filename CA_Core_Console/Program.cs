// See https://aka.ms/new-console-template for more information
using CA_Core_Lib.Referenced;

Console.WriteLine("Hello, World!");
int t = 1;

Console.WriteLine(t);

var libRecord = new LibRecord("1");
var isIdNull = libRecord.IsIdNull();

//public interface IProblem
//{
//    bool IsCritical { get; }
//}

//public class MyProblem : IProblem
//{
//    public bool IsCritical => true;
//}

//public static class SomeExtensions
//{
//    public static void CheckProblems(this IProblem[] problems)
//    {
//        foreach (var problem in problems.Where(problem => problem.IsCritical))
//        {
//            throw new Exception($"Critical error occured: {problem}");
//        }
//    }
//}