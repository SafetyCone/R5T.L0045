using System;


namespace R5T.L0045.S000
{
    public static class Instances
    {
        public static Library.IOperations Operations => Library.Operations.Instance;
        public static O001.ISolutionNameOperations SolutionNameOperations => O001.SolutionNameOperations.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}