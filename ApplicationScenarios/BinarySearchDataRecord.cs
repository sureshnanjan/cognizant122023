namespace ApplicationScenarios
{
    /// <summary>
    /// 
    /// </summary>
    public class BinarySearchDataRecord
    {
        int[] inputs;
        int search;
        int expected;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="searc"></param>
        /// <param name="expected"></param>
        public BinarySearchDataRecord(int[] inputs, int searc, int expected)
        {
            this.Inputs = inputs;
            this.Search = searc;
            this.Expected = expected;
        }
        /// <summary>
        /// 
        /// </summary>
        public int[] Inputs { get => inputs; set => inputs = value; }
        /// <summary>
        /// 
        /// </summary>
        public int Search { get => search; set => search = value; }
        /// <summary>
        /// 
        /// </summary>
        public int Expected { get => expected; set => expected = value; }
    }
}