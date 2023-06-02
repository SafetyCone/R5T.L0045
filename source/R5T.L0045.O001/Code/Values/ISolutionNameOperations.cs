using System;

using R5T.T0131;

using R5T.L0045.X000;

using IExternalSolutionName = R5T.T0187.ISolutionName;


namespace R5T.L0045.O001
{
    [ValuesMarker]
    public partial interface ISolutionNameOperations : IValuesMarker
    {
        public IExternalSolutionName Adjust_SolutionNameForPrivacy(
            IExternalSolutionName solutionName,
            bool isPrivate)
        {
            var internalSolutionName = solutionName.As_InternalSolutionName();

            var adjustedSolutionName = Instances.NameOperations.Adjust_ForPrivacy(
                internalSolutionName,
                isPrivate)
                .As_ExternalSolutionName();

            return adjustedSolutionName;
        }

        public IExternalSolutionName Get_ConstructionSolutionName(
            IExternalSolutionName solutionName)
        {
            var internalSolutionName = solutionName.As_InternalSolutionName();

            var constructionSolutionName = Instances.NameGenerationOperations.Get_ConstructionName(
                internalSolutionName)
                .As_ExternalSolutionName();

            return constructionSolutionName;
        }
    }
}
