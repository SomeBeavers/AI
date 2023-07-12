using System.Collections;

namespace Core_Lib_net7
{
    /// <summary>
    /// Represents a record struct with a Name property and an Age field.
    /// </summary>
    public record struct Class1(int Age)
    {
        public const string myRootPath2 = "VALUE";

        private const string myRootPath = "VALUE";
        public const string a =  $"{myRootPath}/README.md";


        public class File1
        {
            public string Name { get; set; }
        }

        public bool Test(List<File1> files, string bafFileName, string pcfFileName)
        {
            foreach (var file in files)
            {
                var fileName = file.Name;

                if ((fileName.Contains(bafFileName) || fileName.Contains(pcfFileName)) && !IsFileAvailable(file))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsFileAvailable(File1 file)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets the name of this <see cref="Class1"/> instance.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gets the name of this <see cref="Class1"/> instance.
        /// </summary>
        public string Name2 { get; }
        /// <summary>
        /// Gets the name of this <see cref="Class1"/> instance.
        /// </summary>
        public string Name3 { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> struct.
        /// </summary>
        /// <param name="name">The name of the person represented by this instance.</param>
        /// <param name="age">The Age of the person represented by this instance.</param>
        public Class1(string name, int age) : this(age)
        {
            Name = name;
        }
    }



    public class Class1Test
    {
    }
}