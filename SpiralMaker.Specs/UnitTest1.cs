using Machine.Specifications;

namespace SpiralMaker.Specs
{
    public class When_Making_A_Spiral
    {
        Establish context = () =>
        {
            input = 5;
            expect = new int[,] 
            { 
                { 1, 1, 1, 1, 1 }, 
                { 0, 0, 0, 0, 1 },
                { 1, 1, 1, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };
        };

        Because of = () => answer = Spiral.CreateSpiral(input);

        It Should_Return_A_Multi_Dimensional_Array_In_A_Spiral = () =>
        {
            for (var i = 0; i < expect.GetLength(0); i++)
            {
                for (var j = 0; j < expect.GetLength(1); j++)
                {
                    if (answer[i,j] != expect[i, j])
                    {
                        var ans = answer[i,j];
                        var exp = expect[i,j];
                    }
                    answer[i, j].ShouldEqual(expect[i,j]);
                }
            }
        };

        private static int input;
        private static int[,] expect;
        private static int[,] answer;
    }

    public class When_Making_A_Spiral_V2
    {
        Establish context = () =>
        {
            input = 5;
            expect = new int[,]
            {
                { 1, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 1 },
                { 1, 1, 1, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };
        };

        Because of = () => answer = Spiral.CreateSpiralV2(input);

        It Should_Return_A_Multi_Dimensional_Array_In_A_Spiral = () =>
        {
            for (var i = 0; i < expect.GetLength(0); i++)
            {
                for (var j = 0; j < expect.GetLength(1); j++)
                {
                    if (answer[i, j] != expect[i, j])
                    {
                        var ans = answer[i, j];
                        var exp = expect[i, j];
                    }
                    answer[i, j].ShouldEqual(expect[i, j]);
                }
            }
        };

        private static int input;
        private static int[,] expect;
        private static int[,] answer;
    }

    public class When_Using_Both_Methods
    {
        Establish context = () =>
        {
            input = new Random();
            size = input.Next(10000);
            v1 = Spiral.CreateSpiral(size);
            v2 = Spiral.CreateSpiralV2(size);
        };

        It Should_Return_The_Same_Spiral = () =>
        {
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    v1[i, j].ShouldEqual(v2[i,j]);
                }
            }
        };

        private static Random input;
        private static int size;
        private static int[,] v1;
        private static int[,] v2;
    }
}