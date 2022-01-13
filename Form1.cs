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
        [Obsolete]
        public Form1()
        {
            InitializeComponent();
        }
        // public List<大漠多线程信息> 大漠多线程信息 = new List<大漠多线程信息>();

        private void Form1_Load(object sender, EventArgs e)
        {
            全局变量.全局大漠 = new 大漠中文版("17639539210.dll");
            创建显示列表();
        }


        #region 界面空间创建
        private void 创建显示列表()
        {
            //设置整行选中
            显示列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //创建选择框
            DataGridViewCheckBoxColumn ck = new DataGridViewCheckBoxColumn
            {
                Name = "选中"
            };
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
            读取任务设置();
            if (全局变量.任务列表.Count == 0)
            {
                MessageBox.Show("请选择需要执行的任务");
                return;
            }
            菜单.Items[0].Enabled = false;
            Console.WriteLine("启动");
            显示列表.AllowUserToAddRows = false;
            显示列表.ReadOnly = true;
            //开始启动线程
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {
                if (Convert.ToBoolean(显示列表.Rows[i].Cells["选中"].Value))
                {
                    全局变量.大漠多线程信息[i] = new 大漠多线程信息(全局变量.全局大漠, $"这是第{i}个线程");
                    全局变量.大漠多线程信息[i].thread = new System.Threading.Thread(任务入口)
                    {
                        IsBackground = true,
                        Name = 全局变量.大漠多线程信息[i].线程名字
                    };
                    全局变量.大漠多线程信息[i].thread.Start(i);
                }

            }

        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            菜单.Items[1].Enabled = false;
            Console.WriteLine("停止");
            显示列表.AllowUserToAddRows = true;
            显示列表.ReadOnly = false;
            for (int i = 0; i < 全局变量.大漠多线程信息.Length; i++)
            {
                if (全局变量.大漠多线程信息[i] == null)
                {
                    continue;
                }
                全局变量.大漠多线程信息[i].thread.Abort();
                全局变量.大漠多线程信息[i].线程状态 = global::大漠多线程信息.状态.结束;
            }
        }

        [Obsolete]
        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 全局变量.大漠多线程信息.Length; i++)
            {
                if (全局变量.大漠多线程信息[i] == null)
                {
                    continue;
                }
                全局变量.大漠多线程信息[i].thread.Suspend();
                全局变量.大漠多线程信息[i].线程状态 = global::大漠多线程信息.状态.暂停;
            }
            Console.WriteLine("暂停");
        }

        [Obsolete]
        private void 恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("恢复");
            for (int i = 0; i < 全局变量.大漠多线程信息.Length; i++)
            {
                if (全局变量.大漠多线程信息[i] == null)
                {
                    continue;
                }
                全局变量.大漠多线程信息[i].thread.Resume();
                全局变量.大漠多线程信息[i].线程状态 = global::大漠多线程信息.状态.运行中;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {

                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.显示列表.Rows[i].Cells["选中"]);
                dgvCheck.Value = true;

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 显示列表.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.显示列表.Rows[i].Cells["选中"]);
                dgvCheck.Value = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 任务入口
        /// </summary>
        /// <param name="i"></param>
        public void 读取任务设置()
        {
            全局变量.任务列表.Clear();
            if (checkBox_主线任务.Checked == true)
            {
                全局变量.任务列表.Add(全局变量.任务名称.主线任务);
            }
            if (checkBox支线任务1.Checked == true)
            {
                全局变量.任务列表.Add(全局变量.任务名称.支线任务1);
            }
            if (checkBox支线任务2.Checked == true)
            {
                全局变量.任务列表.Add(全局变量.任务名称.支线任务2);
            }
            if (checkBox支线任务3.Checked == true)
            {
                全局变量.任务列表.Add(全局变量.任务名称.支线任务3);
            }


            if (全局变量.全局大漠.注册VIP(全局变量.注册码, 全局变量.附加信息) == 1)
            {
                全局变量.运行权限 = true;
            }
            else
            {
                全局变量.运行权限 = true;
                return;
            }
        }

        private void 任务入口(object n)
        {
            int i = Convert.ToInt32(n);
            绑定模拟器(i);
            //判定游戏是否登录
            if (等待进入游戏(i)==false)
            {
                return;
            }
            //判断角色当前状态
            if (角色任务状态(i) == false)
            {
                //领取任务
            }
            else
            {
                //根据任务状态选择取消任务或者继续任务
            }

            
            //领取主线任务
            //寻路
            //交任务
            //领取
            for (int 计数 = 0; 计数 < 全局变量.任务列表.Count; 计数++)
            {
                switch (全局变量.任务列表[计数])
                {
                    case 全局变量.任务名称.主线任务:
                        主线任务(i);
                        break;
                    case 全局变量.任务名称.支线任务1:
                        支线任务1(i);
                        break;
                    case 全局变量.任务名称.支线任务2:
                        支线任务2(i);
                        break;
                    case 全局变量.任务名称.支线任务3:
                        支线任务2(i);
                        break;
                    default:
                        break;
                }
            }
        }


        public void 主线任务(int i)
        {
            for (int 计数 = 0; 计数 < 20; 计数++)
            {
                全局变量.大漠多线程信息[i].当前任务 = "主线任务";
                Console.WriteLine($"{i},{ 全局变量.大漠多线程信息[i].当前任务}");
                Thread.Sleep(1000);
            }

        }
        public void 支线任务1(int i)
        {
            for (int 计数 = 0; 计数 < 20; 计数++)
            {
                全局变量.大漠多线程信息[i].当前任务 = "支线任务1";
                Console.WriteLine($"{i},{ 全局变量.大漠多线程信息[i].当前任务}");
                Thread.Sleep(1000);
            }

        }
        public void 支线任务2(int i)
        {
            for (int 计数 = 0; 计数 < 20; 计数++)
            {
                全局变量.大漠多线程信息[i].当前任务 = "支线任务2";
                Console.WriteLine($"{i},{ 全局变量.大漠多线程信息[i].当前任务}");
                Thread.Sleep(1000);
            }
        }

        public void 支线任务3(int i)
        {
            for (int 计数 = 0; 计数 < 20; 计数++)
            {
                全局变量.大漠多线程信息[i].当前任务 = "支线任务3";
                Console.WriteLine($"{i},{ 全局变量.大漠多线程信息[i].当前任务}");
                Thread.Sleep(1000);
            }
        }

        public bool 等待进入游戏(int i)
        {

            return true;
        }
        public bool 角色任务状态(int i)
        {
            return true;
        }
        #region 封装的常用函数
        public bool 绑定模拟器(int i)
        {
            全局变量.大漠多线程信息[i].窗口外句柄 = 全局变量.大漠多线程信息[i].大漠.窗口_查找EX(0, "", "");
            if (全局变量.大漠多线程信息[i].窗口外句柄 > 0)
            {
                全局变量.大漠多线程信息[i].窗口内句柄 = 全局变量.大漠多线程信息[i].大漠.窗口_查找EX(0, "", "");
                if (全局变量.大漠多线程信息[i].窗口内句柄>0)
                {
                    if (全局变量.大漠多线程信息[i].大漠.绑定Ex(全局变量.大漠多线程信息[i].窗口内句柄, "", "windows", "windows", "", 0)==1)
                    {
                        全局变量.大漠多线程信息[i].绑定状态 = true;
                    }
                    else
                    {
                        全局变量.大漠多线程信息[i].绑定状态 = false;
                    }

                }
                else
                {
                    全局变量.大漠多线程信息[i].大漠.延时_VIP(1000,2000);
                    绑定模拟器(i);

                }
                return true;
            }
            else
            {
                启动模拟器返回句柄(i);
                绑定模拟器(i);
                return false;
            }

        }

        public int 启动模拟器返回句柄(int i)
        {

            return 0;
        }

        #endregion

    }
}
