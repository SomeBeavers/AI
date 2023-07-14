namespace Multi
{

    public class Multi1
    {
        const string testRootPath = "/src/to/test/root";

        public void MyMethod(int t)
        {
            string testWholeFilePath = $"{testRootPath}/README.md";
        }
#if !NETCOREAPP



        public void MyMethodForNetCoreOnly()
        {
            // Your .NET Core specific implementation
        }
#endif
    }
}