using System;

using R5T.L0043.T000;
using R5T.L0045.T000;

using IExternalSolutionName = R5T.T0187.ISolutionName;


namespace R5T.L0045.X000
{
    public static class ISolutionNameExtensions
    {
        public static IExternalSolutionName As_ExternalSolutionName(this ISolutionName solutionName)
        {
            return Instances.SolutionNameTypeConverter.As_ExternalSolutionName(solutionName);
        }

        public static IExternalSolutionName As_ExternalSolutionName(this IName name)
        {
            return Instances.SolutionNameTypeConverter.As_ExternalSolutionName(name);
        }

        public static ISolutionName As_InternalSolutionName(this IExternalSolutionName externalSolutionName)
        {
            return Instances.SolutionNameTypeConverter.As_InternalSolutionName(externalSolutionName);
        }
    }
}
