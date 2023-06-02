using System;

using R5T.T0132;

using R5T.L0043.T000;
using R5T.L0045.T000;
using R5T.L0045.T000.Extensions;

using IExternalSolutionName = R5T.T0187.ISolutionName;


namespace R5T.L0045.X000
{
    [FunctionalityMarker]
    public partial interface ISolutionNameTypeConverter : IFunctionalityMarker
    {
        public IExternalSolutionName As_ExternalSolutionName(ISolutionName solutionName)
        {
            var output = Instances.StringOperator_External.ToSolutionName(
                solutionName.Value);

            return output;
        }

        public IExternalSolutionName As_ExternalSolutionName(IName name)
        {
            var output = Instances.StringOperator_External.ToSolutionName(
                name.Value);

            return output;
        }

        public ISolutionName As_InternalSolutionName(IExternalSolutionName externalSolutionName)
        {
            var output = externalSolutionName.Value.ToSolutionName();
            return output;
        }
    }
}
