using System;


namespace R5T.L0045.T000.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToSolutionName(string)"/>
        public static ISolutionName ToSolutionName(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSolutionNamePart(string)"/>
        public static ISolutionNamePart ToSolutionNamePart(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionNamePart(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSolutionNameToken(string)"/>
        public static ISolutionNameToken ToSolutionNameToken(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionNameToken(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSolutionNameTokenSeparator(string)"/>
        public static ISolutionNameTokenSeparator ToSolutionNameTokenSeparator(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionNameTokenSeparator(value);
        }

        /// <inheritdoc cref="IStringOperator.ToUnadjustedSolutionName(string)"/>
        public static IUnadjustedSolutionName ToUnadjustedSolutionName(this string value)
        {
            return Instances.StringOperator_Extensions.ToUnadjustedSolutionName(value);
        }
    }
}
