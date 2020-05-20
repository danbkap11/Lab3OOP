using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mined_Out;

namespace Lab3
{
    internal class Map
    {
        public Map()
        {
            initializeMatrix();
        }
        public Cell[,] Matrix = new Cell[15, 15];

        private List<(int, int)> mines = new List<(int, int)>()
            {(1, 12), (2, 5), (3, 2), (4, 8), (6, 12), (7, 5), (8, 2), (11, 2), (11, 8), (12, 12)};
        private List<(int, int)> addpts = new List<(int, int)>()
            {(2, 7), (6, 2), (7, 10)};
        private List<(int, int)> antipts = new List<(int, int)>()
            {(8, 6), (9, 12), (12, 3)};
        private List<(int, int)> coins = new List<(int, int)>()
            {(3, 11), (6, 8), (10, 5)};
        private List<(int, int)> traps = new List<(int, int)>()
            {(5, 7), (12, 5)};
        private List<(int, int)> addlife = new List<(int, int)>()
            {(2, 9), (4, 6)};
        private List<(int, int)> antilife = new List<(int, int)>()
            {(5, 10), (9, 3)};
        private List<(int, int)> teleports = new List<(int, int)>()
            {(5, 3), (10, 10)};
        private List<(int, int)> wincells = new List<(int, int)>()
            {(0, 6), (0, 7), (0, 8)};
        public void initializeMatrix()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (wincells.Contains((i, j)))
                    {
                        Matrix[i, j] = new WinCell(j, i);
                    }
                    else if (i == 0 || i == 14 || j == 0 || j == 14)
                    {
                        Matrix[i, j] = new Wall(j, i);
                    }

                    else if (mines.Contains((i, j)))
                    {
                        Matrix[i, j] = new Mine(j, i);
                    }
                    else if (addpts.Contains((i, j)))
                    {
                        Matrix[i, j] = new AddPts(j, i);
                    }
                    else if (antipts.Contains((i, j)))
                    {
                        Matrix[i, j] = new AntiPts(j, i);
                    }
                    else if (coins.Contains((i, j)))
                    {
                        Matrix[i, j] = new Coin(j, i);
                    }
                    else if (traps.Contains((i, j)))
                    {
                        Matrix[i, j] = new Trap(j, i);
                    }
                    else if (addlife.Contains((i, j)))
                    {
                        Matrix[i, j] = new AddLife(j, i);
                    }
                    else if (antilife.Contains((i, j)))
                    {
                        Matrix[i, j] = new AntiLife(j, i);
                    }
                    else if (teleports.Contains((i, j)))
                    {
                        Matrix[i, j] = new Teleport(j, i);
                    }
                    else if (wincells.Contains((i, j)))
                    {
                        Matrix[i, j] = new WinCell(j, i);
                    }
                    else if (i == 13 && j == 7)
                    {
                        Matrix[i, j] = new Player(j,i);
                    }
                    else
                    {
                        Matrix[i, j] = new EmptyCell(j, i);
                    }
                }
            }
        }

        public (int, int) Find(string type)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (Matrix[i, j].GetType().Name == type)
                    {
                        return (i, j);
                    }
                }
            }

            return (22, 22);
        }
        public void print(Graphics g)
        {
            for (int y = 0; y < 15; y++)
            {
                for (int x = 0; x < 15; x++)
                {
                    g.DrawImage(Matrix[y, x].Img, new Rectangle(x * 35, y * 35, 35, 35));

                }
            }
        }



    }
}
