namespace Multi
{

    public class Multi1
    {
        const string testRootPath = "/src/to/test/root";

        public void MyMethod(int t)
        {
            string testWholeFilePath = $"{testRootPath}/MyMethod.md";
        }
#if !NETCOREAPP



        public void MyMethodForNetCoreOnly()
        {
 string testWholeFilePath = $"{testRootPath}/MyMethodForNetCoreOnly.md";
            // Your .NET Core specific implementation
        }
#endif
    }
}