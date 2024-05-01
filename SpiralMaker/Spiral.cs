using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMaker
{
    public class Spiral
    {
        public static int[,] CreateSpiral(long size)
        {
            int[,] spiral = new int[size,size];
            var horizon = false;
            var vertigo = false;
            var direction = false;
            long steps = size-1;
            var keepSpiraling = true;
            long row = 0;
            long col = size-1;
            var h = false;
            var v = false;
            for(var i = 0; i < size; i++)
            {
                spiral[0, i] = 1;
            }
            do
            {
                if (direction)
                {
                    if (horizon)
                    {
                        for(long i=0; i<steps; i++)
                        {
                            spiral[row, col++] = 1;
                        }
                    }
                    else
                    {
                        for (long i = 0; i < steps; i++)
                        {
                            spiral[row, col--] = 1;
                        }
                    }
                    horizon = !horizon;
                    h = true;
                }
                else
                {
                    if (vertigo)
                    {
                        for (long i = 0; i < steps; i++)
                        {
                            spiral[row--, col] = 1;
                        }
                    }
                    else
                    {
                        for (long i = 0; i < steps; i++)
                        {
                            spiral[row++, col] = 1;
                        }
                    }
                    vertigo = !vertigo;
                    v = true;
                }
                direction = !direction;
                if ((v && h) || steps== 1)
                {
                    steps -= 2;
                    if (steps < 1)
                    {
                        keepSpiraling = false;
                        spiral[row,col] = 1;
                    }
                    h = false;
                    v = false;
                }
            } while (keepSpiraling);

            return spiral;
        }

        public static int[,] CreateSpiralV2(int size)
        {
            int[,] spiral = new int[size, size];
            var horizontal = false;
            var vertical = false;
            var direction = false;
            var steps = size - 1;
            var row = 0;
            var col = size - 1;
            var h = false;
            var v = false;
            var keepSpiraling = true;
            for (var i = 0; i < size; i++)
            {
                spiral[0, i] = 1;
            }
            do
            {
                if (direction)
                {
                    for (var i = 0; i < steps; i++)
                    {
                        if (horizontal)
                        {
                            spiral[row, col++] = 1;
                        }
                        else
                        {
                            spiral[row, col--] = 1;
                        }
                    }
                    horizontal = !horizontal;
                    h = true;
                }
                else
                {
                    for (var i = 0; i < steps; i++)
                    {
                        if (vertical)
                        {
                            spiral[row--, col] = 1;
                        }
                        else
                        {
                            spiral[row++, col] = 1;
                        }
                    }
                    vertical = !vertical;
                    v = true;
                }
                direction = !direction;
                if ((v && h) || steps == 1)
                {
                    steps -= 2;
                    if (steps < 1)
                    {
                        keepSpiraling = false;
                        spiral[row, col] = 1;
                    }
                    h = false;
                    v = false;
                }
            } while (keepSpiraling);

            return spiral;
        }
    }
}
