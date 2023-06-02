using System;

using R5T.T0178;


namespace R5T.L0045.T000
{
    /// <summary>
    /// Strongly-types a string as an unadjusted solution name.
    /// </summary>
    [StrongTypeMarker]
    public interface IUnadjustedSolutionName : IStrongTypeMarker,
        L0043.T000.IUnadjustedName
    {
    }
}