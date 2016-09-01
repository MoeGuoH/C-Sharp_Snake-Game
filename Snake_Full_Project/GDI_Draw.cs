using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Snake_Full_Project
{
    public static class GDI_Draw//用于绘图的方法
    {
        //绘图缓冲
        private static Bitmap Map_Cache;//地图缓存
        private static bool Map_Cache_Flag;//确定地图缓存是否已经创建
        public static Graphics Board_GP;

        //地图参数
        //资源
        public static Bitmap GetBmp_Map(int id)//获取图片资源
        {
            switch (id)
            {
                case 0: return Properties.Resources.snake_bw;//黑白蛇
                case 100: return Properties.Resources.food_orange;//食物橙子
                case 200: return Properties.Resources.map_green;//基础地图


                case 300: return Properties.Resources.obstacle_tree; //树
                case 302: return Properties.Resources.obstacle_green; //草丛
                case 301: return Properties.Resources.obstacle_mountain; //山
                case 303: return Properties.Resources.obstacle_beach; //海
            }
            return Properties.Resources.other_null;
        }

        //绘制地图
        public static void Map_Draw_Cache()
        {

            Map_Cache_Flag = false;
            Map_Cache = null;
            Map_Cache = new Bitmap(GDI_Computing_Method.paper_x, GDI_Computing_Method.paper_y);
            Graphics g = Graphics.FromImage(Map_Cache);
            for (int x = 0; x < GDI_Computing_Method.M_x; x++)
            {
                for (int y = 0; y < GDI_Computing_Method.M_y; y++)
                {
                    g.DrawImage(GetBmp_Map(GDI_Computing_Method.Coordinate_date[0, x, y]), x * GDI_Computing_Method.M_Sense, y * GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense);
                    if (GDI_Computing_Method.Coordinate_date[1, x, y] != -1)
                    {
                        g.DrawImage(GetBmp_Map(GDI_Computing_Method.Coordinate_date[1, x, y]), x * GDI_Computing_Method.M_Sense, y * GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense);
                    }
                }
            }
            g.Dispose();
            Map_Cache_Flag = true;
        }
        public static void Board_Draw(Graphics GP,GDI_Computing_Method .Game_Info gameinfo,GDI_Computing_Method .Snake_Info snake)
        {
            Bitmap Board_Cache = new Bitmap(GDI_Computing_Method.paper_x, GDI_Computing_Method.paper_y);
            Graphics g = Graphics.FromImage(Board_Cache);
            g.DrawImage(Map_Cache, 0, 0);
            if (Map_Cache_Flag == true)//确认地图是否已经绘制好
            {
                
                for (int x = 0; x < GDI_Computing_Method.M_x; x++)
                {
                    for (int y = 0; y < GDI_Computing_Method.M_y; y++)
                    {

                        if (GDI_Computing_Method.Coordinate_date[2, x, y] != -1)
                        {
                            g.DrawImage(GetBmp_Map(GDI_Computing_Method.Coordinate_date[2, x, y]), x * GDI_Computing_Method.M_Sense, y * GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense);
                        }
                        if (GDI_Computing_Method.Coordinate_date[3, x, y] != -1)
                        {
                            g.DrawImage(GetBmp_Map(GDI_Computing_Method.Coordinate_date[3, x, y]), x * GDI_Computing_Method.M_Sense, y * GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense, GDI_Computing_Method.M_Sense);
                        }
                    }
                }
                g.DrawImage(Properties.Resources.pic_info, GDI_Computing_Method .paper_x-170,GDI_Computing_Method .paper_y-90);
                Pen pen = new Pen(Color.FromArgb(255, Color.Red));
                g.DrawRectangle(pen, GDI_Computing_Method.paper_x - 155, GDI_Computing_Method.paper_y - 25, 100, 10);
                pen = new Pen(Color.FromArgb(50 + snake.PH, Color.Red));
               
                pen.Width = 10;
                Font newFont = new Font("宋体", 10);
                Brush foreBrush = Brushes.Black;
                g.DrawString(string.Format("目标分：{0}", gameinfo.Game_way_mark), newFont, foreBrush, GDI_Computing_Method.paper_x - 160, GDI_Computing_Method.paper_y - 85);
                g.DrawString(string.Format("剩余时间：{0} Min", ((float)((float)gameinfo.Game_time)/1000/60).ToString("F2")), newFont, foreBrush, GDI_Computing_Method.paper_x - 160, GDI_Computing_Method.paper_y - 70);
                g.DrawString(string.Format("总得分：{0}", gameinfo.Game_Mark), newFont, foreBrush, GDI_Computing_Method.paper_x - 160, GDI_Computing_Method.paper_y - 55);
                g.DrawString(string.Format("生命值：{0}", snake .PH), newFont, foreBrush, GDI_Computing_Method.paper_x - 160, GDI_Computing_Method.paper_y - 40);
                
                g.DrawLine(pen, GDI_Computing_Method.paper_x - 155, GDI_Computing_Method.paper_y -20 , GDI_Computing_Method.paper_x - 155+ snake .PH, GDI_Computing_Method.paper_y - 20);
                GP.DrawImage(Board_Cache, 0, 0);
                g.Dispose();
                pen.Dispose();
                Board_Cache.Dispose();
            }


        }
    }
}
