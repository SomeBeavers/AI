// See https://aka.ms/new-console-template for more information

using CA_Core_Lib.ExplainForMethod;

var comments = new List<Comment>
{
    new() { Link = "Jane Doe" },
    new() { Link = "John Doe" },
    new() { Link = "Alice" },
    new() { Link = "Bob" },
};
new Use().CreateComments(comments);

Console.WriteLine(SomeEnum.IntVal3.Equals(3));

enum SomeEnum
{
    IntVal1 = 1,
    IntVal2 = 2,
    IntVal3 = 3
}

