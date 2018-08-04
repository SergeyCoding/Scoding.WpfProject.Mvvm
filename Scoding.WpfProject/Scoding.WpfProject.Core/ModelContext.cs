namespace Scoding.WpfProject.Core
{
    /// <summary>
    /// C=A+B
    /// </summary>
    public class ModelContext
    {
        public int A { get; set; }
        public int B { get; set; }

        public Values Value { get; } = new Values();

        public class Values
        {
            public int C { get; set; }
        }
    }
}
