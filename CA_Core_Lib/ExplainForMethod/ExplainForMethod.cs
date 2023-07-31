using System.Net.Http;
using System.Text.RegularExpressions;

namespace CA_Core_Lib.ExplainForMethod;

public class ExplainForMethod<T> where T : new()
{
    private const string PathToFile = "path to file";
    private readonly HttpClient _httpClient = new HttpClient();
    public async Task<T> GetAsync(string link)
    {
        var html = await _httpClient.GetStringAsync(link);

        return await Delay(html, PathToFile); // Return default value of T
    }

    private async Task<string> GetStringAsync(string httpsDotnetfoundationOrg)
    {
        throw new NotImplementedException();
    }

    private async Task<T> Delay(string html, string filePath)
    {
        await using (StreamWriter writer = new StreamWriter(filePath))
        {
            await writer.WriteAsync(html);
        }
        return new T();
    }
}

public class UseExplainForMethod
{
    public async Task Test(Comment comment)
    {
        var explainForMethod = new ExplainForMethod<Comment>();
        var result = await explainForMethod.GetAsync(comment.Link);
    }
}

public class Comment
{
    public string Link { get; set; }

    public override string ToString()
    {
        return $"Link: {Link}";
    }
}