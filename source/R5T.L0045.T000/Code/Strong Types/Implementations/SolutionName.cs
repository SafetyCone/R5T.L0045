using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0045.T000
{
    /// <inheritdoc cref="ISolutionName"/>
    [StrongTypeImplementationMarker]
    public class SolutionName : TypedBase<string>, IStrongTypeMarker,
        ISolutionName
    {
        public SolutionName(string value)
            : base(value)
        {
        }
    }
}