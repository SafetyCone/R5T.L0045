using System;

using R5T.T0141;


namespace R5T.L0045.Q000
{
    [DemonstrationsMarker]
    public partial interface ISolutionNameDemonstrations : IDemonstrationsMarker
    {
        public void Adjust_ProjectNameForPrivacy()
        {
            /// Inputs.
            var solutionName = Instances.Values.Sample_SolutionName;
            bool isPrivate = true;


            /// Run.
            var adjustedSolutionName = Instances.SolutionNameOperations.Adjust_SolutionNameForPrivacy(
                solutionName,
                isPrivate);

            Instances.Operations.Write_Adjust_SolutionNameForPrivacy_ToConsole(
                solutionName,
                isPrivate,
                adjustedSolutionName);
        }

        public void Get_ConstructionProjectName()
        {
            /// Inputs.
            var solutionName = Instances.Values.Sample_SolutionName;


            /// Run.
            var constructionSolutionName = Instances.SolutionNameOperations.Get_ConstructionSolutionName(
                solutionName);

            Instances.Operations.Write_Get_ConstructionSolutionName_ToConsole(
                solutionName,
                constructionSolutionName);
        }
    }
}
