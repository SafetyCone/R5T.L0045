using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0045.T000
{
    /// <inheritdoc cref="ISolutionNameToken"/>
    [StrongTypeImplementationMarker]
    public class SolutionNameToken : TypedBase<string>, IStrongTypeMarker,
        ISolutionNameToken
    {
        public SolutionNameToken(string value)
            : base(value)
        {
        }
    }
}