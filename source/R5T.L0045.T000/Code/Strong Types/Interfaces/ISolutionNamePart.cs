using System;

using R5T.T0178;


namespace R5T.L0045.T000
{
    /// <summary>
    /// Strongly-types a string as part of a solution name.
    /// </summary>
    [StrongTypeMarker]
    public interface ISolutionNamePart : IStrongTypeMarker,
        L0043.T000.INamePart
    {
    }
}