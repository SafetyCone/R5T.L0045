using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0045.T000
{
    /// <inheritdoc cref="ISolutionNamePart"/>
    [StrongTypeImplementationMarker]
    public class SolutionNamePart : TypedBase<string>, IStrongTypeMarker,
        ISolutionNamePart
    {
        public SolutionNamePart(string value)
            : base(value)
        {
        }
    }
}