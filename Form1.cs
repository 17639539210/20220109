using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _20220109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<大漠多线程信息> 大漠多线程信息 = new List<大漠多线程信息>();

        private void Form1_Load(object sender, EventArgs e)
        {
            全局变量.全局大漠 = new 大漠中文版("17639539210.dll");
            Console.WriteLine(全局变量.全局大漠.取插件版本号());

            创建显示列表();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
            Application.Exit();
        }

        #region 界面空间创建
        private void 创建显示列表()
        {
            //设置整行选中
            显示列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //创建选择框
            DataGridViewCheckBoxColumn ck = new DataGridViewCheckBoxColumn();
            ck.Name = "选中";
            显示列表.Columns.Add(ck);
            //添加全局变量里面的配置信息
            for (int i = 0; i < 全局变量.显示信息标题.Count; i++)
            {
                显示列表.Columns.Add(全局变量.显示信息标题[i], 全局变量.显示信息标题[i]);
            }
            for (int i = 0; i < 全局变量.行数; i++)
            {
                显示列表.Rows.Add();
            }


            显示列表.AllowUserToAddRows = false;

        }
        #endregion
        #region 控件事件
        //菜单事件
        private void 启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //0启动 1停止 2暂停 3恢复
           菜单.Items[0].Enabled = false;
            菜单.Items[1].Enabled = true;
            菜单.Items[2].Enabled = true;
            菜单.Items[3].Enabled = false;
            Console.WriteLine("启动");
            显示列表.AllowUserToAddRows = false;
            显示列表.ReadOnly = true;
            //开始启动线程
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {
                大漠多线程信息.Add(new global::大漠多线程信息(全局变量.全局大漠, $"这是第{i}个线程"));
                if (Convert.ToBoolean(显示列表.Rows[i].Cells["选中"].Value))
                {
                    大漠多线程信息[i].线程状态 = global::大漠多线程信息.状态.运行中; 
                    大漠多线程信息[i].thread = new System.Threading.Thread(任务入口);
                    大漠多线程信息[i].thread.IsBackground = true;
                    大漠多线程信息[i].thread.Name = 大漠多线程信息[i].线程名字;
                    大漠多线程信息[i].thread.Start(i);
                }
            }

        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //0启动 1停止 2暂停 3恢复
            菜单.Items[0].Enabled = true;
            菜单.Items[1].Enabled = false;
            菜单.Items[2].Enabled = false;
            菜单.Items[3].Enabled = false;
            显示列表.AllowUserToAddRows = true;
            显示列表.ReadOnly = false;
            for (int i = 0; i < 大漠多线程信息.Count; i++)
            {
                if (大漠多线程信息[i].thread==null)
                {
                    continue;
                }
                大漠多线程信息[i].线程状态 = global::大漠多线程信息.状态.结束;
                Console.WriteLine($"{大漠多线程信息[i].线程名字}停止");
             
                
            }
        }

        [Obsolete]
        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {  //0启动 1停止 2暂停 3恢复
            菜单.Items[0].Enabled = false;
            菜单.Items[1].Enabled = true;
            菜单.Items[2].Enabled = false;
            菜单.Items[3].Enabled = true;
            for (int i = 0; i < 大漠多线程信息.Count; i++)
            {
                if (大漠多线程信息[i].thread == null)
                {
                    continue;
                }
                大漠多线程信息[i].thread.Suspend();
                大漠多线程信息[i].线程状态 = global::大漠多线程信息.状态.暂停;
            }
            Console.WriteLine("暂停");
        }

        [Obsolete]
        private void 恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {//0启动 1停止 2暂停 3恢复
            菜单.Items[0].Enabled = false;
            菜单.Items[1].Enabled = true;
            菜单.Items[2].Enabled = true;
            菜单.Items[3].Enabled = false;
            Console.WriteLine("恢复");
            for (int i = 0; i < 大漠多线程信息.Count; i++)
            {
                if (大漠多线程信息[i].thread == null)
                {
                    continue;
                }
                大漠多线程信息[i].thread.Resume();
                大漠多线程信息[i].线程状态 = global::大漠多线程信息.状态.运行中;
            }

        }
        //按钮事件


        private void 显示列表_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {
                if (显示列表.Rows[i].Selected == true)
                {
                    DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.显示列表.Rows[i].Cells["选中"]);
                    if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                    {
                        dgvCheck.Value = false;
                    }
                    else
                    {
                        dgvCheck.Value = true;
                    }
                    Console.WriteLine($"{i}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {

                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.显示列表.Rows[i].Cells["选中"]);
                dgvCheck.Value = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {

                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.显示列表.Rows[i].Cells["选中"]);
                dgvCheck.Value = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.显示列表.Rows[i].Cells["选中"]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    dgvCheck.Value = false;
                }
                else
                {
                    dgvCheck.Value = true;
                }
                Console.WriteLine($"{i}");

            }
        }

        #endregion

        private void 任务入口(object i)
        {
            int i1 = (int)i;
            int m = 0;

            while (大漠多线程信息[i1].线程状态 != global::大漠多线程信息.状态.结束)
            {
                Random Random = new Random();
                Console.WriteLine($"当前线程的名字是{大漠多线程信息[Convert.ToInt32(i)].线程名字}，当前线程状态是{大漠多线程信息[Convert.ToInt32(i)].线程状态}");
                m++;
                大漠多线程信息[Convert.ToInt32(i)].大漠.延时_VIP(100, 2000);
                Thread.Sleep(Random.Next(1, 1000));
            }

        }







    }
}
