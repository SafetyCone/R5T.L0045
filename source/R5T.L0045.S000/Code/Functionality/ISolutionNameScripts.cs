using System;

using R5T.T0132;


namespace R5T.L0045.S000
{
    [FunctionalityMarker]
    public partial interface ISolutionNameScripts : IFunctionalityMarker
    {
        public void Adjust_SolutionNameForPrivacy()
        {
            /// Inputs.
            var solutionName = Instances.Values.Sample_SolutionName;
            var isPrivate =
                //false
                true
                ;


            /// Run.
            var adjustedSolutionName = Instances.SolutionNameOperations.Adjust_SolutionNameForPrivacy(
                solutionName,
                isPrivate);

            Instances.Operations.Write_Adjust_SolutionNameForPrivacy_ToConsole(
                solutionName,
                isPrivate,
                adjustedSolutionName);
        }

        public void Get_ConstructionSolutionName()
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
