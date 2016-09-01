using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Full_Project
{
    public partial class frmSnake : Form
    {
        public frmSnake()
        {
            InitializeComponent();
            GDI_Draw.Board_GP = Snake_board.CreateGraphics();
            Pic_Up.Enabled = true;
            
        }

        public static GDI_Computing_Method.Snake_Info Snake;
        public static GDI_Computing_Method.Food_Info food;
        public static GDI_Computing_Method.Game_Info game_info =new GDI_Computing_Method.Game_Info(Keys.Right, (int)GDI_Computing_Method.Game_Info.game_state_enum.UnReady,100,1000,10000);
        public static GDI_Computing_Method.Obstacle_Info oe_info;
        void InitializeGame()
        {
            GDI_Computing_Method.Map_Initialize(200);//初始化地图与坐标
            GDI_Computing_Method.Obstacle_Initialize(oe_info); //初始化障碍物
            System.Threading.Thread.Sleep(200);
            GDI_Computing_Method.Snake_ArrayList_Initialize(Snake, game_info);
            GDI_Draw.Map_Draw_Cache();
        }
        private void 开始SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_Game();
        }
        private void Start_Game()
        {
            SYS_Update.Enabled = false;
            Check_Update.Enabled = false;
            frmGameStart frm_gamesettle = new frmGameStart();
            frm_gamesettle.ShowDialog();
            SYS_Update.Interval = game_info.Game_speed;
            InitializeGame();
            SYS_Update.Enabled = true;
        }
        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                game_info.Control_Key = e.KeyCode;
                if(game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready)
                {
                    game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.Start;
                }
            }
            else if(e.KeyCode ==Keys.Space)
            {
                if(game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Start )
                {
                    game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.Stop;
                }
                else if(game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Stop )
                {
                    game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.Start;
                }
            }


        }
        private void SYS_Update_Tick(object sender, EventArgs e)
        {
            if (Snake.PH <= 0)
            {
                game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.Lose;


            }
            if (game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Start)
            {
                GDI_Computing_Method.Snake_ArrayList_WayKey(game_info);
                GDI_Computing_Method.Snake_ArrayList_Update(Snake);
                GDI_Computing_Method.Game_InFo_UpDate(Snake, game_info, food, oe_info);
                GDI_Computing_Method.Snake_Co_MakeUp(Snake);
                GDI_Computing_Method.Food_Co_MakeUp(food);//食物丢送
                Check_Update.Enabled = true;
                GDI_Draw.Board_Draw(GDI_Draw.Board_GP, game_info, Snake);
            }
            else if(game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready)
            {
                GDI_Computing_Method.Snake_ArrayList_WayKey(game_info);
                GDI_Computing_Method.Snake_Co_MakeUp(Snake);
                GDI_Computing_Method.Food_Co_MakeUp(food);//食物丢送
                Check_Update.Enabled = false;
                GDI_Draw.Board_Draw(GDI_Draw.Board_GP, game_info, Snake);
                GDI_Draw.Board_GP.DrawImage(Properties.Resources.game_ready, 0, 0, GDI_Computing_Method.paper_x, GDI_Computing_Method.paper_y);
            }
            else if (game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Stop)
            {
                GDI_Computing_Method.Snake_ArrayList_WayKey(game_info);
                GDI_Computing_Method.Snake_Co_MakeUp(Snake);
                GDI_Computing_Method.Food_Co_MakeUp(food);//食物丢送
                Check_Update.Enabled = false;
                GDI_Draw.Board_Draw(GDI_Draw.Board_GP, game_info, Snake);
                GDI_Draw.Board_GP.DrawImage(Properties.Resources.info_stop, 0, 0, GDI_Computing_Method.paper_x, GDI_Computing_Method.paper_y);
            }
            else if (game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Win)
            {
                Check_Update.Enabled = false;
                SYS_Update.Enabled = false;
                DialogResult dr;
                dr = MessageBox.Show("你赢了,是否再来一局？", "恭喜你", MessageBoxButtons.YesNo);
                if(dr==DialogResult.Yes)
                {
                    Start_Game();
                }
                else
                {
                    game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.UnReady ;

                }
              
            }
            else if (game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.Lose )
            {
                Check_Update.Enabled = false;
                SYS_Update.Enabled = false;
                DialogResult dr;
                dr = MessageBox.Show("你输了,是否再来一局？", "十分抱歉", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Start_Game();
                }
                else
                {
                    game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.UnReady;

                }

            }
            

            
        }
        private void Check_Update_Tick(object sender, EventArgs e)
        {
            if (game_info.Game_time <= 0)
            {
                if (game_info.Game_way_mark > game_info.Game_Mark)
                {
                    game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.Lose;
                    Check_Update.Enabled = false;
                    SYS_Update.Enabled = false;
                    DialogResult dr;
                    dr = MessageBox.Show("时间到了,你输了,是否再来一局？", "十分抱歉", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Start_Game();
                    }
                    else
                    {
                        game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.UnReady;

                    }
                }
                else if (game_info.Game_way_mark <= game_info.Game_Mark)
                {
                    game_info.Game_State = (int)GDI_Computing_Method.Game_Info.game_state_enum.Win;
                }
            }
            game_info.Game_time= game_info.Game_time-1000;
        }

        private void Pic_Up_Tick(object sender, EventArgs e)
        {

            if (game_info.Game_State == (int)GDI_Computing_Method.Game_Info.game_state_enum.UnReady)
            {
                GDI_Draw.Board_GP.DrawImage(Properties.Resources.bg_info, 0, 0,GDI_Computing_Method .paper_x ,GDI_Computing_Method .paper_y);
            }
        }

        private void 版权ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout a = new frmAbout();
            a.Show();
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1)游戏操作：键盘操作控制蛇的运动方向，方向键对应向上、下、左、右移动。\n(2)游戏快捷键： Space: 暂停 / 开始。", "帮助");
        }
    }
}
