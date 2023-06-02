using System;


namespace R5T.L0045.X000
{
    public class SolutionNameTypeConverter : ISolutionNameTypeConverter
    {
        #region Infrastructure

        public static ISolutionNameTypeConverter Instance { get; } = new SolutionNameTypeConverter();


        private SolutionNameTypeConverter()
        {
        }

        #endregion
    }
}
