using System;

using R5T.T0131;
using R5T.T0187;


namespace R5T.L0045.S000.Library
{
    [ValuesMarker]
    public partial interface IOperations : IValuesMarker
    {
        public string Get_Adjust_SolutionNameForPrivacy_Message(
            ISolutionName solutionName,
            bool isPrivate,
            ISolutionName adjustedSolutionName)
        {
            var output = $"{adjustedSolutionName}: adjusted solution name for '{solutionName}', is private: {isPrivate}.";
            return output;
        }

        public string Get_ConstructionSolutionName_Message(
            ISolutionName solutionName,
            ISolutionName constructionSolutionName)
        {
            var output = $"{constructionSolutionName}: construction solution name for '{solutionName}'.";
            return output;
        }

        public void Write_Adjust_SolutionNameForPrivacy_ToConsole(
            ISolutionName solutionName,
            bool isPrivate,
            ISolutionName adjustedSolutionName)
        {
            var message = this.Get_Adjust_SolutionNameForPrivacy_Message(
                solutionName,
                isPrivate,
                adjustedSolutionName);

            Console.WriteLine(message);
        }

        public void Write_Get_ConstructionSolutionName_ToConsole(
            ISolutionName solutionName,
            ISolutionName constructionSolutionName)
        {
            var message = this.Get_ConstructionSolutionName_Message(
                solutionName,
                constructionSolutionName);

            Console.WriteLine(message);
        }
    }
}
