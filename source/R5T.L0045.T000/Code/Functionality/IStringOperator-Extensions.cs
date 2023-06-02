using System;

using R5T.T0132;


namespace R5T.L0045.T000.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ISolutionName"/>
        public ISolutionName ToSolutionName(string value)
        {
            var output = new SolutionName(value);
            return output;
        }

        /// <inheritdoc cref="ISolutionNamePart"/>
        public ISolutionNamePart ToSolutionNamePart(string value)
        {
            var output = new SolutionNamePart(value);
            return output;
        }

        /// <inheritdoc cref="ISolutionNameToken"/>
        public ISolutionNameToken ToSolutionNameToken(string value)
        {
            var output = new SolutionNameToken(value);
            return output;
        }

        /// <inheritdoc cref="ISolutionNameTokenSeparator"/>
        public ISolutionNameTokenSeparator ToSolutionNameTokenSeparator(string value)
        {
            var output = new SolutionNameTokenSeparator(value);
            return output;
        }

        /// <inheritdoc cref="IUnadjustedSolutionName"/>
        public IUnadjustedSolutionName ToUnadjustedSolutionName(string value)
        {
            var output = new UnadjustedSolutionName(value);
            return output;
        }
    }
}
