namespace Multi
{

    public class Multi1
    {
        const string myRootPath = "/src/to/my/root";

        public void MyMethod()
        {
            string myWholeFilePath = $"{myRootPath}/README.md";
        }
#if NETCOREAPP



        public void MyMethodForNetCoreOnly()
        {
            // Your .NET Core specific implementation
        }
#endif
    }
}