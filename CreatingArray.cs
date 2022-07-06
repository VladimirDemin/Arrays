using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return new int[0];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static bool[] CreateEmptyArrayOfBooleans()
        {
            bool[] array = { };
            return array;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static string[] CreateEmptyArrayOfStrings()
        {
            return new string[] { };
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static char[] CreateEmptyArrayOfCharacters()
        {
            return new char[] { };
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            return new int[10];
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            return new bool[20];
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            return new string[5];
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            return new char[15];
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            return new double[18];
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            return new float[100];
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            return new decimal[1000];
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            var a = new[] { 123456 };
            return a;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            var a = new[] { 1111111, 9999999 };
            return a;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            var a = new[] { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
            return a;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            bool[] array = { true };
            return array;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            bool[] array = { true, false, true, false, true };
            return array;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            bool[] array = { false, true, true, false, true, true, false };
            return array;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            return new string[1] { "one" };
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            return new string[3] { "one", "two", "three" };
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            return new string[6] { "one", "two", "three", "four", "five", "six" };
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            return new char[1] { 'a' };
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            return new char[3] { 'a', 'b', 'c' };
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            return new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            return new double[1] { 1.12 };
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            return new double[5] { 1.12, 2.23, 3.34, 4.45, 5.56 };
        }

        public static double[] CreateDoubleWithNineElements()
        {
            return new double[9] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            return new float[1] { 123_456_789.123456F };
        }

        public static float[] CreateFloatWithThreeElements()
        {
            return new float[3] { 1_000_000.123456F, 2_223_334_444.123456F, 9_999.999999F };
        }

        public static float[] CreateFloatWithFiveElements()
        {
            return new float[5] { 1.0123F, 20.012345F, 300.01234567F, 4_000.01234567F, 500_000.01234567F };
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            return new decimal[1] { 10_000.123456M };
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            return new decimal[5] { 1_000.1234M, 100_000.2345M, 100_000.3456M, 1_000_000.456789M, 10_000_000.5678901M };
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            return new decimal[9] { 10.122112M, 200.233223M, 3_000.344334M, 40_000.455445M, 500_000.566556M, 6_000_000.677667M, 70_000_000.788778M, 800_000_000.899889M, 9_000_000_000.911991M };
        }
    }
}
