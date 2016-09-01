using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Full_Project
{
    public static class GDI_Computing_Method//用于计算坐标和记录变量参数
    {
        /*参数*/
        public static int paper_x = 800, paper_y = 600;//分辨像素大小
        public static int M_Sense = 20;//地图分辨率
        public static int M_x = paper_x / M_Sense;
        public static int M_y = paper_y / M_Sense;
        public static int[,,] Coordinate_date;//用于记，第一个为类型0为地形图，1为障碍物，2为蛇，3为食物，第二三为坐标
        private static ArrayList Snake_AL = new ArrayList();//蛇信息的Arr，X_Y_K
        /*静态方法*/
        //用于初始化
        public static void Map_Initialize(int Map_Bmp_ID)//Map_Bmp_ID用于获取图片的ID
        {
            Coordinate_date = null;
            Coordinate_date = new int[4, M_x, M_y];
            for (int x = 0; x < M_x; x++)
            {
                for (int y = 0; y < M_y; y++)
                {
                    Coordinate_date[0, x, y] = Map_Bmp_ID;//初始化地图背景
                    Coordinate_date[1, x, y] = -1;//初始化障碍物
                    Coordinate_date[2, x, y] = -1;//初始化蛇
                    Coordinate_date[3, x, y] = -1;//初始化食物
                }
            }
        }
        public static void Obstacle_Initialize(Obstacle_Info oe_indo)
        {
            //bmp_id:0 dot树 1 crossbar草丛 2cross山 3around海
            //XYAround 0左上，1右上，2左下，3为右下
            Random rd = new Random();
            if (oe_indo.Around_IF == true)
            {
               
                for (int i = 0; i < M_x; i++)
                {
                    Coordinate_date[1, i, 0] = (int)oe_indo.Bmp_ID[3];
                    Coordinate_date[1,i ,M_y-1] = (int)oe_indo.Bmp_ID[3];
                }
                for (int i = 0; i < M_y; i++)
                {
                    Coordinate_date[1, 0, i] = (int)oe_indo.Bmp_ID[3];
                    Coordinate_date[1, M_x-1, i] = (int)oe_indo.Bmp_ID[3];
                }
            }
            else
            {
                for (int i = 0; i < oe_indo.XYAround[0]; i++)
                {
                    if(i<M_y)
                    {
                        Coordinate_date[1, 0, i] = (int)oe_indo.Bmp_ID[3];
                    }
                    
                    if(i<M_x )
                    {
                        Coordinate_date[1, i, 0] = (int)oe_indo.Bmp_ID[3];
                    }
                    
                }
                for (int i = 0; i < oe_indo.XYAround[1]; i++)
                {

                    if (i < M_y)
                    {
                        Coordinate_date[1, M_x - 1, i] = (int)oe_indo.Bmp_ID[3];
                    }

                    if (i < M_x)
                    {
                        Coordinate_date[1, M_x - 1 - i, 0] = (int)oe_indo.Bmp_ID[3];
                    }
                }
                for (int i = 0; i < oe_indo.XYAround[2]; i++)
                {

                    if (i < M_y)
                    {
                        Coordinate_date[1, 0, M_y - 1 - i] = (int)oe_indo.Bmp_ID[3];
                    }

                    if (i < M_x)
                    {
                        Coordinate_date[1, i, M_y - 1] = (int)oe_indo.Bmp_ID[3];
                    }
                }
                for (int i = 0; i < oe_indo.XYAround[3]; i++)
                {
                    if (i < M_y)
                    {
                        Coordinate_date[1, M_x - 1, M_y - 1 - i] = (int)oe_indo.Bmp_ID[3];
                    }

                    if (i < M_x)
                    {
                        Coordinate_date[1, M_x - 1 - i, M_y - 1] = (int)oe_indo.Bmp_ID[3];
                    }
                }
            }
            for (int i = 0; i < oe_indo.Cross_Num; i++)
            {
                int x = rd.Next(7, M_x - 7);
                int y = rd.Next(7, M_y - 7);
                for(int a=0;a<3;a++)
                {
                    
                    if(Coordinate_date[1, x + a, y] ==-1&& Coordinate_date[1, x + a+1, y] == -1)
                    {
                        Coordinate_date[1, x + a, y] = (int)oe_indo.Bmp_ID[2];
                    }
                    if (Coordinate_date[1, x, y + a]==-1 && Coordinate_date[1, x, y + a+1] == -1)
                    {
                        Coordinate_date[1, x, y + a] = (int)oe_indo.Bmp_ID[2];
                    }
                    if(Coordinate_date[1, x, y - a]==-1&& Coordinate_date[1, x, y - a-1]==-1)
                    {
                        Coordinate_date[1, x, y - a] = (int)oe_indo.Bmp_ID[2];
                    }
                   if(Coordinate_date[1, x - a, y] ==-1&& Coordinate_date[1, x - a-1, y] == -1)
                    {
                Coordinate_date[1, x - a, y] = (int)oe_indo.Bmp_ID[2];
            }
                    
                }
            }
            for (int i = 0; i < oe_indo.Cross_Bar_Num; i++)
            {
                    int x = rd.Next(7, M_x - 7);
                    int y = rd.Next(7, M_y - 7);
                int pd_flag = rd.Next(1, 1000);
                if(pd_flag <500)
                {
                    for (int a = 0; a < 5; a++)
                    {
                        if(Coordinate_date[1, x + a, y]==-1&& Coordinate_date[1, x + a+1, y] == -1)
                        {
                            Coordinate_date[1, x + a, y]= (int)oe_indo.Bmp_ID[1];
                        }
                    }
                }
                else
                {
                    for (int a = 0; a < 5; a++)
                    {
                        if (Coordinate_date[1, x , y + a] == -1 && Coordinate_date[1, x , y + a + 1] == -1)
                        {
                            Coordinate_date[1, x , y + a] = (int)oe_indo.Bmp_ID[1];
                        }
                    }
                }
            }

            for (int i = 0; i < oe_indo.Dor_Num; i++)
            {
                int x = rd.Next(7, M_x - 7);
                int y = rd.Next(7, M_y - 7);
                if (Coordinate_date[1, x, y] == -1 )
                {
                    Coordinate_date[1, x, y] = (int)oe_indo.Bmp_ID[0];
                }
            }




        }
        public static void Snake_ArrayList_Initialize(Snake_Info Snakeinfo, Game_Info info)//随机初始化蛇的位置
        {
            Snake_AL.Clear();//清除缓存
            info.Control_Key = Keys.Right;
            bool flag = true;
            Random ran = new Random();//实例一个随机
            while (flag)
            {
                X_Y_K YUAN = new X_Y_K(ran.Next(4, M_x - 4), ran.Next(4, M_y - 4), Keys.Right);
                for (int i = 0; i < Snakeinfo.Body_Long; i++)
                {
                    if (YUAN.X - i >= 0)
                    {
                        if (Coordinate_date[1, YUAN.X - i, YUAN.Y] == -1)
                        {
                            X_Y_K xyk = new X_Y_K(YUAN.X - i, YUAN.Y, Keys.Right);
                            Snake_AL.Add(xyk);
                            if(Snake_AL.Count==Snakeinfo.Body_Long)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            Snake_AL.Clear();
                        }
                    }
                    else
                    {
                        Snake_AL.Clear();
                    }
                }

            }

        }
        //用于动态刷新
        public static void Snake_ArrayList_WayKey(Game_Info info) //蛇改刷新头方向
        {
            X_Y_K xyz = (X_Y_K)Snake_AL[0];
            if (info.Control_Key == Keys.Up && xyz.Key != Keys.Up && xyz.Key != Keys.Down)
            {
                xyz.Key = info.Control_Key;
                Snake_AL[0] = xyz;
            }
            else if (info.Control_Key == Keys.Down && xyz.Key != Keys.Up && xyz.Key != Keys.Down)
            {
                xyz.Key = info.Control_Key;
                Snake_AL[0] = xyz;
            }
            else if (info.Control_Key == Keys.Left && xyz.Key != Keys.Left && xyz.Key != Keys.Right)
            {
                xyz.Key = info.Control_Key;
                Snake_AL[0] = xyz;
            }
            else if (info.Control_Key == Keys.Right && xyz.Key != Keys.Left && xyz.Key != Keys.Right)
            {
                xyz.Key = info.Control_Key;
                Snake_AL[0] = xyz;
            }
        }
        public static void Snake_ArrayList_Update(Snake_Info Snakeinfo)//蛇,刷新
        {
            X_Y_K xyz;
            int x_l;
            int y_l;
            Keys k_l;
            while (Snakeinfo.WaitAdd_Body > 0)
            {
                xyz = (X_Y_K)Snake_AL[Snake_AL.Count - 1];
                x_l = xyz.X;
                y_l = xyz.Y;
                k_l = xyz.Key;
                if (xyz.Key == Keys.Up)
                {
                    if (xyz.Y + 1 >= M_y) { y_l = 0; }
                    else { y_l++; }
                }
                else if (xyz.Key == Keys.Down)
                {
                    if (xyz.Y - 1 <= 0) { y_l = M_y; }
                    else { y_l--; }
                }
                else if (xyz.Key == Keys.Left)
                {
                    if (xyz.X - 1 >= M_x) { x_l = 0; }
                    else { x_l++; }
                }
                else if (xyz.Key == Keys.Right)
                {
                    if (xyz.X - 1 <= 0) { x_l = M_x; }
                    else { x_l--; }
                }
                X_Y_K xyk = new X_Y_K(x_l, y_l, k_l);
                Snake_AL.Add(xyk);
                Snakeinfo.WaitAdd_Body--;
            }
            Snake_AL.Reverse();
            xyz = (X_Y_K)Snake_AL[Snake_AL.Count - 1];//xyz是映射到Snake_AL[Snake_AL.Count - 1]

            int x = xyz.X;
            int y = xyz.Y;
            Keys k = xyz.Key;

            if (k == Keys.Up)
            {
                if (xyz.Y <= 0) { y = M_y - 1; }
                else { y--; }
            }
            else if (k == Keys.Down)
            {
                if (xyz.Y + 1 >= M_y) { y = 0; }
                else { y++; }
            }
            else if (k == Keys.Left)
            {
                if (xyz.X <= 0) { x = M_x - 1; }
                else { x--; }
            }
            else if (k == Keys.Right)
            {
                if (xyz.X + 1 >= M_x) { x = 0; }
                else { x++; }
            }
            X_Y_K aa = new X_Y_K(x, y, k);
            Snake_AL.Add(aa);
            Snake_AL.Reverse();
            Snake_AL.RemoveAt(Snake_AL.Count - 1);



        }
        public static void Snake_Co_MakeUp(Snake_Info snake)//蛇AL坐标化
        {
            X_Y_K xyz;
            for (int x = 0; x < M_x; x++)//初始化坐标
            {
                for (int y = 0; y < M_y; y++)
                {
                    Coordinate_date[2, x, y] = -1;
                }
            }
            for (int i = 0; i < Snake_AL.Count; i++)
            {
                xyz = (X_Y_K)Snake_AL[i];
                Coordinate_date[2, xyz.X, xyz.Y] = snake.Snake_ID;
            }
        }
        public static void Game_InFo_UpDate(Snake_Info snake, Game_Info info, Food_Info food, Obstacle_Info oe_indo)//游戏信息更新
        {
            X_Y_K xyz;
            xyz = (X_Y_K)Snake_AL[0];
            //bmp_id:0 dot树 1 crossbar草丛 2cross山 3around海
            //XYAround 0左上，1右上，2左下，3为右下
           
            if (Coordinate_date[1, xyz.X, xyz.Y] != -1) //判断是否碰到障碍物
            {
                if(Coordinate_date[1, xyz.X, xyz.Y] == (int)oe_indo.Bmp_ID[0] )
                {
                    snake.PH = snake.PH - 10;
                }
                else  if (Coordinate_date[1, xyz.X, xyz.Y] == (int)oe_indo.Bmp_ID[1])
                {
                    snake.PH = snake.PH - 20;
                }
                else if (Coordinate_date[1, xyz.X, xyz.Y] == (int)oe_indo.Bmp_ID[2])
                {
                    snake.PH = snake.PH - 15;
                }
                else if (Coordinate_date[1, xyz.X, xyz.Y] == (int)oe_indo.Bmp_ID[3])
                {
                    snake.PH = snake.PH - 30;
                }
            }
            if (Coordinate_date[2, xyz.X, xyz.Y] != -1)//判断是否碰到蛇身
            {
                snake.PH = snake.PH - 5;
            }
            if (Coordinate_date[3, xyz.X, xyz.Y] != -1) //判断是吃到食物
            {
                Coordinate_date[3, xyz.X, xyz.Y] = -1;
                food.Need_Add();
                info.Game_Mark++;
                snake.WaitAdd_Body++;
                snake.PH = snake.PH + 1;
            }
        }
        public static void Food_Co_MakeUp(Food_Info food)//食物坐标化
        {


            if (food.If_Need_AddFood())
            {
                bool flag;
                for (int i = 0; i < food.Wait_Add_Food; i++)
                {
                    flag = true;
                    Random ran = new Random();//实例一个随机
                    while (flag)
                    {
                        int x = ran.Next(0, M_x);
                        int y = ran.Next(0, M_y);
                        if (Coordinate_date[1, x, y] == -1 && Coordinate_date[2, x, y] == -1 && Coordinate_date[3, x, y] == -1)
                        {
                            Coordinate_date[3, x, y] = food.Food_ID;
                            flag = false;
                        }
                    }
                }

            }

            food.Add_NewFood_Finish();
        }
        //类
        public class X_Y_K
        {
            private int x;
            private int y;
            private Keys k;
            public X_Y_K(int X, int Y, Keys Key)
            {
                x = X;
                y = Y;
                k = Key;
            }
            public X_Y_K()
            {

            }
            public int X { get { return x; } set { x = value; } }
            public int Y { get { return y; } set { y = value; } }
            public Keys Key { get { return k; } set { k = value; } }
        }
        public class Snake_Info
        {
            private int ph, body, waitadd_body;
            int snake_id;
            public Snake_Info(int PH, int Body, int Snake_ID)
            {
                ph = PH;
                body = Body;
                waitadd_body = 0;
                snake_id = Snake_ID;
            }
            public Snake_Info(int Snake_ID)
            {
                ph = 3;
                body = 3;
                waitadd_body = 0;
                snake_id = Snake_ID;
            }
            public int PH { get { return ph; } set { if (value <= 0) { ph = 0; } else if (value >= 100) { ph = 100; } else { ph = value; } } }
            public int Body_Long { get { return body; } set { body = value; } }
            public int WaitAdd_Body { get { return waitadd_body; } set { waitadd_body = value; } }
            public int Snake_ID { get { return snake_id; } }
        }
        public class Food_Info
        {
            private int total_food, now_food, food_ID;
            public Food_Info(int Total_Food_Num, int Food_ID)
            {
                if (Total_Food_Num <= 0)
                { total_food = 1; }
                else { total_food = Total_Food_Num; }
                food_ID = Food_ID;
                now_food = 0;
            }
            public int Wait_Add_Food { get { return total_food - now_food; } }
            public int Food_ID { get { return food_ID; } set { food_ID = value; } }
            public int Total_Food { get { return total_food; } set { if (value > 0) { total_food = value; } else { total_food = 0; } } }
            public bool If_Need_AddFood()
            {
                if (now_food >= total_food)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public void Add_NewFood_Finish()
            {

                now_food = total_food;

            }
            public void Need_Add()
            {
                if (now_food - 1 >= 0)
                {
                    now_food--;
                }
            }
        }
        public class Game_Info
        {
            //记录游戏基本参数
            private Keys control_key;
            private int game_speed;
            private int game_state;
            private int game_mark;
            private int game_time;
            private int game_way_mark;
            public enum game_state_enum {UnReady=0, Ready = 1, Start = 2, Stop = 3, Win = 4, Lose = 5 };
            public Game_Info(Keys Control_Key, int Game_State,int Game_speed,int Game_time,int Game_way_mark)
            {
                control_key = Control_Key;
                game_state = Game_State;
                game_speed = Game_speed;
                game_time = Game_time;
                game_way_mark = Game_way_mark;
                game_mark = 0;
            }
            public Keys Control_Key { get { return control_key; } set { control_key = value; } }
            public int Game_State { get { return game_state; } set { game_state = value; } }
            public int Game_Mark { get { return game_mark; } set { game_mark = value; } }
            public int Game_speed { get { return game_speed; } }
            public int Game_time { get { return game_time; } set { game_time = value; } }
            public int Game_way_mark { get { return game_way_mark; } }
            public void Game_Mark_Add()
            {
                game_mark++;
            }

        }
        public class Obstacle_Info
        {
            private uint cross, cross_bar, dot;
            private uint[] x_y_around, bmp_id;//bmp_id:0 dot树 1 crossbar草丛 2cross山 3around海
            private bool around;

            public Obstacle_Info(uint Cross, uint Cross_Bar, uint Dot, bool Around, uint Dot_Bmp,uint Crossbar_Bmp,uint Cross_Bmp,uint Around_Bmp)
            {
                cross = Cross;
                cross_bar = Cross_Bar;
                dot = Dot;
                around = Around;
                x_y_around = new uint[4] { 0, 0, 0, 0 };
                bmp_id = new uint[4] { Dot_Bmp, Crossbar_Bmp, Cross_Bmp, Around_Bmp };

            }
            public Obstacle_Info(uint Cross, uint Cross_Bar, uint Dot, bool Around, uint XL_YD, uint XR_YD, uint XL_YU, uint XR_YU, uint Dot_Bmp,uint Crossbar_Bmp,uint Cross_Bmp,uint Around_Bmp)
            {
                cross = Cross;
                cross_bar = Cross_Bar;
                dot = Dot;
                around = Around;
                x_y_around = new uint[4] { XL_YD, XR_YD, XL_YU, XR_YU };
                bmp_id = new uint[4] { Dot_Bmp, Crossbar_Bmp, Cross_Bmp, Around_Bmp };
            }
            public uint Cross_Num { get { return cross; } }
            public uint Cross_Bar_Num { get { return cross_bar; } }
            public uint Dor_Num { get { return dot; } }
            public bool Around_IF { get { return around; } }
            public uint[] XYAround { get { return x_y_around; } }
            public uint[] Bmp_ID { get { return bmp_id; } }
        }

    }
}
