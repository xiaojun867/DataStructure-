using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Maze
{
    /// <summary>
    /// 栈实现迷宫
    /// </summary>
    public class MazeByStack
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
            box.di = -1;

            StackType st = new StackType();
            st.top = -1;
            st.top++;
            st.data[st.top] = box;

            mg[xi, yi] = -1;
            int i, j, di, find = 0;
            while (st.top > -1)
            {
                i = st.data[st.top].i;
                j = st.data[st.top].j;
                di = st.data[st.top].di;
                if (i == xe && j == ye)
                {
                    Console.WriteLine("迷宫路径如下：");

                    for (int k = 0; k <= st.top; k++)
                    {
                        Console.Write($"[{st.data[k].i},{st.data[k].j}]");
                        if ((k + 1) % 5 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    break;
                }

                find = 0;
                while (di < 4 && find == 0)
                {
                    di++;
                    switch (di)
                    {
                        case 0:
                            i = st.data[st.top].i - 1;
                            j = st.data[st.top].j;
                            break;
                        case 1:
                            i = st.data[st.top].i;
                            j = st.data[st.top].j + 1;
                            break;
                        case 2:
                            i = st.data[st.top].i + 1;
                            j = st.data[st.top].j;
                            break;
                        case 3:
                            i = st.data[st.top].i;
                            j = st.data[st.top].j - 1;
                            break;
                    }
                    if (mg[i, j] == 0)
                    {
                        find = 1;
                    }
                }

                if (find == 1)
                {
                    st.data[st.top].di = di;
                    st.top++;

                    box = new Box();
                    box.i = i;
                    box.j = j;
                    box.di = -1;
                    st.data[st.top] = box;

                    mg[i, j] = -1;
                }
                else
                {
                    mg[st.data[st.top].i, st.data[st.top].j] = 0;
                    st.top--;
                }
            }

        }
        public class Box
        {
            public int i { get; set; }
            public int j { get; set; }
            public int di { get; set; }
        }
        public class StackType
        {
            public Box[] data { get; set; }
            public int top { get; set; }

            public StackType()
            {
                data = new Box[10];
            }
        }
    }
   
}
