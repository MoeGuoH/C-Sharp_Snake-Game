using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Full_Project
{
    public partial class frmGameStart : Form
    {
        public frmGameStart()
        {
            InitializeComponent();
        }
        static GDI_Computing_Method.Snake_Info Snake;
        static GDI_Computing_Method.Food_Info Food;
        static GDI_Computing_Method.Game_Info Game_info;
        static GDI_Computing_Method.Obstacle_Info Oe_info;

        //窗口第一次显示
        private void frmGameStart_Shown(object sender, EventArgs e)
        {
            int total = GDI_Computing_Method.M_x * GDI_Computing_Method.M_y;
            tbrTree.Maximum = (int)(total * 0.10);
            tbrGreen.Maximum = (int)((total / 25) * 0.3);
            tbrSP.Maximum = (int)((total / 5) * 0.1);
            tbrSea.Maximum = (int)(GDI_Computing_Method.M_x / 2);
            tbrFood.Minimum = 1;
            tbrFood.Maximum = (int)(total * 0.025);
            tbrSpeed.Minimum = 20;
            tbrSpeed.Maximum = 3000;
            lb_Update();
            gbDiy.Enabled = false;
            Snake = new GDI_Computing_Method.Snake_Info(100, 4, 0);
            Food = new GDI_Computing_Method.Food_Info(1, 100);
            Game_info = new GDI_Computing_Method.Game_Info(Keys.Right, (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready, 150, 1000 * 60 * 2, 25);
            Oe_info = new GDI_Computing_Method.Obstacle_Info(1, 2, 5, false, 10, 10, 10, 10, 300, 301, 302, 303);

        }
        private void tbr_Scroll(object sender, EventArgs e)
        {
            lb_Update();

        }
        private void lb_Update()
        {
                try
            {
                System.Convert.ToInt32(txbScore.Text);
                System.Convert.ToInt32(txbTime.Text);
            }
            catch (Exception ex)
            {
                txbScore.Text = "0";
                txbTime.Text = "0";
            }

            Snake = new GDI_Computing_Method.Snake_Info(100, 4, 0);
            Food = new GDI_Computing_Method.Food_Info(tbrFood.Value, 100);
            Game_info = new GDI_Computing_Method.Game_Info(Keys.Right, (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready, tbrSpeed.Value,1000*60*System .Convert .ToInt32(txbTime .Text ) ,System .Convert .ToInt32 (txbScore.Text ));
            uint Around = (uint)tbrSea.Value;
            Oe_info = new GDI_Computing_Method.Obstacle_Info((uint)tbrGreen.Value, (uint)tbrSP.Value, (uint)tbrTree.Value, false, Around, Around, Around, Around, 300, 301, 302, 303);
            lbTree.Text = tbrTree.Value.ToString();
            lbGreen.Text = tbrGreen.Value.ToString();
            lbSP.Text = tbrSP.Value.ToString();
            lbSea.Text = tbrSea.Value.ToString();
            lbFood.Text = tbrFood.Value.ToString();
            lbSpeed.Text = string.Format("{0}ms", tbrSpeed.Value);
        }
        private void rbCN_CheckedChanged(object sender, EventArgs e)
        {
            gbDiy.Enabled = false;
            Snake = new GDI_Computing_Method.Snake_Info(100, 4, 0);
            Food = new GDI_Computing_Method.Food_Info(3, 100);
            Game_info = new GDI_Computing_Method.Game_Info(Keys.Right, (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready,500, 1000 * 60 *5,15);
            Oe_info = new GDI_Computing_Method.Obstacle_Info(0, 1, 5, false, 0, 0, 0, 0, 300, 301, 302, 303);

        }
        private void rbJD_CheckedChanged(object sender, EventArgs e)
        {
            gbDiy.Enabled = false;
            Snake = new GDI_Computing_Method.Snake_Info(100, 4, 0);
            Food = new GDI_Computing_Method.Food_Info(2, 100);
            Game_info = new GDI_Computing_Method.Game_Info(Keys.Right, (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready, 250, 1000 * 60 *3,20);
            Oe_info = new GDI_Computing_Method.Obstacle_Info(0, 2, 5, false, 5, 0, 0, 5, 300, 301, 302, 303);
        }

        private void rbPT_CheckedChanged(object sender, EventArgs e)
        {
            gbDiy.Enabled = false;
            Snake = new GDI_Computing_Method.Snake_Info(100, 4, 0);
            Food = new GDI_Computing_Method.Food_Info(1, 100);
            Game_info = new GDI_Computing_Method.Game_Info(Keys.Right, (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready, 150, 1000 * 60 *2,25);
            Oe_info = new GDI_Computing_Method.Obstacle_Info(1, 2, 5, false, 10,10 ,10 , 10, 300, 301, 302, 303);
        }

        private void rbKN_CheckedChanged(object sender, EventArgs e)
        {
            gbDiy.Enabled = false;
            Snake = new GDI_Computing_Method.Snake_Info(100, 4, 0);
            Food = new GDI_Computing_Method.Food_Info(1, 100);
            Game_info = new GDI_Computing_Method.Game_Info(Keys.Right, (int)GDI_Computing_Method.Game_Info.game_state_enum.Ready, 50,1000 * 60 *1,30);
            Oe_info = new GDI_Computing_Method.Obstacle_Info(1, 2, 5, true , 5, 5, 5, 5, 300, 301, 302, 303);
        }

        private void rbDIY_CheckedChanged(object sender, EventArgs e)
        {
            gbDiy.Enabled = true;
            lb_Update();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Game_info.Game_time<=0||Game_info.Game_way_mark <=0)
            {
                MessageBox.Show("参数不对,游戏时间和游戏达到的分数必须大于0");
                return ;
            }
            frmSnake.Snake = Snake;
            frmSnake.food = Food;
            frmSnake.game_info = Game_info;
            frmSnake.oe_info = Oe_info;
            this.Dispose();
            this.Close();


        }

        private void txbScore_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("请输入数字");
            }
            else
            {
     
               lb_Update();
            }
        }
    }
}
