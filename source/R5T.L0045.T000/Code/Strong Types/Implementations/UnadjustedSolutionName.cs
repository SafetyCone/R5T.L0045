using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0045.T000
{
    /// <inheritdoc cref="IUnadjustedSolutionName"/>
    [StrongTypeImplementationMarker]
    public class UnadjustedSolutionName : TypedBase<string>, IStrongTypeMarker,
        IUnadjustedSolutionName
    {
        public UnadjustedSolutionName(string value)
            : base(value)
        {
        }
    }
}