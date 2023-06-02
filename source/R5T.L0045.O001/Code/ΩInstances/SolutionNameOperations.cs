using System;


namespace R5T.L0045.O001
{
    public class SolutionNameOperations : ISolutionNameOperations
    {
        #region Infrastructure

        public static ISolutionNameOperations Instance { get; } = new SolutionNameOperations();


        private SolutionNameOperations()
        {
        }

        #endregion
    }
}
