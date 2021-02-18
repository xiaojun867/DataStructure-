using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Maze
{
    public class MazeByQueue
    {
        private int[,] mg = new int[,] {
            {1,1,1,1,1,1,1,1,1,1},
            {1,0,0,1,0,0,0,1,0,1},
            {1,0,0,1,0,0,0,1,0,1},
            {1,0,0,0,0,1,1,0,0,1},
            {1,0,1,1,1,0,0,0,0,1},
            {1,0,0,0,1,0,0,0,0,1},
            {1,0,1,0,0,0,1,0,0,1},
            {1,0,1,1,1,0,1,1,0,1},
            {1,1,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1}
        };
        public void MgPath(int xi, int yi, int xe, int ye)
        {
            Box box = new Box();
            box.i = xi;
            box.j = yi;
            box.pre = -1;

            QueueType qt = new QueueType();
            qt.rear = -1;
            qt.front = -1;
            qt.rear++;
            qt.data[qt.rear] = box;
            mg[xi, yi] = -1;
            int i, j = 0;
            while (qt.front != qt.rear)
            {
                qt.front++;
                i = qt.data[qt.front].i;
                j = qt.data[qt.front].j;
                if (i == xe && j == ye)
                {
                    for (int k = qt.front; k > 0; k = qt.data[k].pre)
                    {
                        Console.Write($"[{qt.data[k].i},{qt.data[k].j}]");
                    }
                    return;
                }
                for (int di = 0; di < 4; di++)
                {
                    switch (di)
                    {
                        case 0:
                            i = qt.data[qt.front].i - 1;
                            j = qt.data[qt.front].j;
                            break;
                        case 1:
                            i = qt.data[qt.front].i;
                            j = qt.data[qt.front].j + 1;
                            break;
                        case 2:
                            i = qt.data[qt.front].i + 1;
                            j = qt.data[qt.front].j;
                            break;
                        case 3:
                            i = qt.data[qt.front].i;
                            j = qt.data[qt.front].j - 1;
                            break;
                    }
                    if (mg[i, j] == 0)
                    {
                        qt.rear++;
                        box = new Box();
                        box.i = i;
                        box.j = j;
                        box.pre = qt.front;
                        qt.data[qt.rear] = box;
                        mg[i, j] = -1;
                    }

                }

            }
        }

        public class Box
        {
            public int i { get; set; }
            public int j { get; set; }
            public int pre { get; set; }
        }
        public class QueueType
        {
            public Box[] data { get; set; }
            public int front { get; set; }
            public int rear { get; set; }

            public QueueType()
            {
                data = new Box[100];
            }
        }
    }

}
