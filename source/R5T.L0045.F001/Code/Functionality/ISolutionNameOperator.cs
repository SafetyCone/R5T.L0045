using System;

using R5T.T0132;
using R5T.T0187;
using R5T.T0187.Extensions;


namespace R5T.L0045.F001
{
    [FunctionalityMarker]
    public partial interface ISolutionNameOperator : IFunctionalityMarker
    {
        public ISolutionName AdjustRepositoryName_ForPrivacy(
            ISolutionName solutionName,
            bool isPrivate)
        {
            var output = Instances.NameOperator.Adjust_ForPrivacy(
                solutionName.Value,
                isPrivate,
                x => x.ToSolutionName());

            return output;
        }
    }
}
