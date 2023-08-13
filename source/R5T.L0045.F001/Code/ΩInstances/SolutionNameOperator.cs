using System;


namespace R5T.L0045.F001
{
    public class SolutionNameOperator : ISolutionNameOperator
    {
        #region Infrastructure

        public static ISolutionNameOperator Instance { get; } = new SolutionNameOperator();


        private SolutionNameOperator()
        {
        }

        #endregion
    }
}
