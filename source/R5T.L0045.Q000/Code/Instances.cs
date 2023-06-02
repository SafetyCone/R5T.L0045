using System;


namespace R5T.L0045.Q000
{
    public static class Instances
    {
        public static S000.Library.IOperations Operations => S000.Library.Operations.Instance;
        public static O001.ISolutionNameOperations SolutionNameOperations => O001.SolutionNameOperations.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}