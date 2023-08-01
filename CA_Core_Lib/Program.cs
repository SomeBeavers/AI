// See https://aka.ms/new-console-template for more information

using CA_Core_Lib.ExplainForMethod;

var comments = new List<Comment>
{
    new() { Link = "Jane Doe" },
    new() { Link = "John Doe" },
    new() { Link = "Alice" },
    new() { Link = "Bob" },
};
new Use().CreateComments(comments, 1);
