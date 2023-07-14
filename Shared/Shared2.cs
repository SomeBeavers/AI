namespace Core_Lib_net7.Shared
{
    public class Shared2
    {
#if NET7_0
        public void Test()
        {
        }
#else
        public void Test2()
        {
new Shared2();
        }
#endif

#if NETCOREAPP
        public bool IsNameNotNull(string? name)
        {
            return name != null;
        }

#endif

    }
}