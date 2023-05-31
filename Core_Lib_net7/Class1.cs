namespace Core_Lib_net7
{
    /// <summary>
    /// Represents a record struct with a Name property and an Age field.
    /// </summary>
    public record struct Class1(int Age)
    {
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
}