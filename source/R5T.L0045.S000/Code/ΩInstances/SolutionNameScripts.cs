using System;


namespace R5T.L0045.S000
{
    public class SolutionNameScripts : ISolutionNameScripts
    {
        #region Infrastructure

        public static ISolutionNameScripts Instance { get; } = new SolutionNameScripts();


        private SolutionNameScripts()
        {
        }

        #endregion
    }
}
