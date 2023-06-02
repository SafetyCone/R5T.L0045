using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0045.T000
{
    /// <inheritdoc cref="ISolutionNameTokenSeparator"/>
    [StrongTypeImplementationMarker]
    public class SolutionNameTokenSeparator : TypedBase<string>, IStrongTypeMarker,
        ISolutionNameTokenSeparator
    {
        public SolutionNameTokenSeparator(string value)
            : base(value)
        {
        }
    }
}