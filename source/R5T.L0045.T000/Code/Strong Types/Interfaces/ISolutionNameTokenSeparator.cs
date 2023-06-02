using System;

using R5T.T0178;


namespace R5T.L0045.T000
{
    /// <summary>
    /// Strongly-types a string as a solution name token separator.
    /// </summary>
    [StrongTypeMarker]
    public interface ISolutionNameTokenSeparator : IStrongTypeMarker,
        L0043.T000.INameTokenSeparator
    {
    }
}