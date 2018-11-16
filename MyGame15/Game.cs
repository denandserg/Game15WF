using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame15
{   
    
    class Game
    {
        private int userID_time;
        private int size;
        public int[,] map;
        private int space_X;
        private int space_Y;
        Random random = new Random();

        public int UserID_time { get => userID_time; set => userID_time = value; }

        public Game(int size)
        {
            if (size < 2) size = 2;
            if (size > 5) size = 5;
            this.size = size;

            map = new int [size, size];

        }

        public void Start()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    map[x, y] = Coordinate_to_position(x, y) + 1;
                }
            }

            space_X = size - 1;
            space_Y = size - 1;
            map[space_X, space_Y] = 0;

        }

        public bool Check_numbers()
        {
            if (!(space_X == size - 1 && space_Y == size - 1)) return false;
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if(!(x==size - 1 && y == size -1))
                        if (map[x, y] != Coordinate_to_position(x, y) + 1)
                            return false;

                }
            }

            return true;
        }

        public int Get_Number(int position)
        {
            int x, y;
            Position_to_coordinate(position, out x, out y);
            if (x < 0 || x > size) return 0;
            if (y < 0 || y > size) return 0;
            return map[x, y];
        }
        private int Coordinate_to_position(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) x = 0;
            if (y > size - 1) y = size - 1;

            return y * size + x;
        }

        private void Position_to_coordinate(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
        }
        public void Shift(int position)
        {
            int x, y;
            Position_to_coordinate(position, out x, out y);
            if (Math.Abs(space_X - x) + Math.Abs(space_Y - y) != 1) return;
            map[space_X, space_Y] = map[x, y];
            map[x, y] = 0;
            space_X = x;
            space_Y = y;
        }

        public void Shuffle()
        {
           //for (int p = size - 1; p >= 1; p--)
            //{
            //    for (int i = size - 1; i >= 1; i--)
            //    {
            //        int j = random.Next(i + 1);
            //        int k= random.Next(p + 1);
            //        int tmp = map[j,k];
            //        map[j,k] = map[p,i];
            //        map[p,i] = tmp;
            //    }
            //}

            int a = random.Next(0, 4);
            int x = space_X;
            int y = space_Y;
            switch (a)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 2: y--; break;
                case 3: y++; break;
            }

            Shift(Coordinate_to_position(x, y));
        }

    }
}
