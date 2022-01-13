using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using static 全局变量;

public class 大漠中文版
{
    private readonly dmsoft 大漠;
    public 大漠中文版()
    {
        dmsoft 大漠 = new dmsoft();
        this.大漠 = 大漠;
    }

    public 大漠中文版(dmsoft dm)
    {
        this.大漠 = dm;
    }
    public 大漠中文版(string path)
    {
        dmsoft 大漠 = new dmsoft(path);
        this.大漠 = 大漠;
    }

    public int 对象_取数量_VIP()
    {
        return 大漠.GetDmCount();
        //返回当前进程已经创建的dm对象个数
    }
    public int 获取当前CPU类型()
    {
        return 大漠.GetCpuType();
        //获取当前CPU类型(intel或者amd).0 : 未知 1 : Intel cpu 2 : AMD cpu
    }
    public int 关闭屏幕保护()
    {
        return 大漠.DisableScreenSave();
    }
    public int 窗口_置大小(int hwnd, int width, int height)
    {
        return 大漠.SetWindowSize(hwnd, width, height);
    }
    public int 辅助延时(int mis)
    {
        return 大漠.Delay(mis);

    }
    public string 窗口_取标题(int hwnd)
    {
        return 大漠.GetWindowTitle(hwnd);
    }
    public int 解绑()
    {
        return 大漠.UnBindWindow();
    }
    public int 运行_VIP(string path, int mode)
    {
        return 大漠.RunApp(path, mode);

    }
    public int 大漠错误提示开关(int show)
    {
        return 大漠.SetShowErrorMsg(show);
    }
    public int 键盘_模拟真实_VIP(int en)
    {
        return 大漠.EnableRealKeypad(en);
    }
    public int 鼠标_模拟真实_VIP(int en, int mousedelay, int nousestep)
    {
        return 大漠.EnableRealMouse(en, mousedelay, nousestep);
    }
    public int 进程ID用内存接口_VIP(int 内存接口)
    {
        return 大漠.SetMemoryHwndAsProcessId(内存接口);
    }
    public int 绑定_判断(int hwnd)
    {
        return 大漠.IsBind(hwnd);
    }
    public int 多点找色(int x1, int y1, int x2, int y2, string color, string color1, double sim, int dir, out int intX, out int intY)
    {
        return 大漠.FindMultiColor(x1, y1, x2, y2, color, color1, sim, dir, out intX, out intY);
    }
    public int 找图(int x1, int y1, int x2, int y2, string pic_name, string delta_color, double sim, int dir, out int intX, out int intY)
    {
        return 大漠.FindPic(x1, y1, x2, y2, pic_name, delta_color, sim, dir, out intX, out intY);
    }
    /// <summary>
    /// 找图点击
    /// </summary>
    /// <param name="pic">图片名称</param>
    /// <param name="点击">选择是否点击，长按等操作</param>
    /// <param name="x1"></param>
    /// <param name="y1"></param>
    /// <param name="x2"></param>
    /// <param name="y2"></param>
    /// <param name="clo"></param>
    /// <param name="sim"></param>
    /// <param name="dx"></param>
    /// <param name="dy"></param>
    /// <param name="delay"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public bool 找图点击(string pic, 操作方式 点击, int x1 = 0, int y1 = 0, int x2 = 2000, int y2 = 2000, string clo = "050505", double sim = 0.9, int dx = 5, int dy = 5)
    {
        if (pic is null)
        {
            throw new ArgumentNullException(nameof(pic));
        }
        bool 找图结果 = false;
        大漠.FindPic(x1, y1, x2, y2, pic, clo, sim, 0, out int x, out int y);
        if (x > 0 & y > 0)
        {
            找图结果 = true;
            switch (点击)
            {
                case 操作方式.不点击:
                    break;
                case 操作方式.精准点击左上角:
                    大漠.MoveTo(x, y);
                    大漠.Delays(50, 100);
                    大漠.LeftClick();
                    break;
                case 操作方式.范围内点击:
                    大漠.MoveToEx(x, y, dx, dy);
                    大漠.Delays(50, 100);
                    大漠.LeftClick();
                    break;
                case 操作方式.长按:
                    大漠.MoveToEx(x, y, dx, dy);
                    大漠.Delays(50, 100);
                    大漠.LeftDown();
                    大漠.Delays(500, 1000);
                    大漠.LeftUp();
                    break;
                case 操作方式.滑动:
                    break;
                default:
                    break;
            }
        }
        return 找图结果;
    }

    public string 取机器码()
    {
        return 大漠.GetMachineCode();
    }


    public int 置全局路径(string path)
    {
        return 大漠.SetPath(path);
    }
    public int 窗口_查找(string 类, string title)
    {
        return 大漠.FindWindow(类, title);
    }
    public int 窗口_查找EX(int parent, string 类, string title)
    {
        return 大漠.FindWindowEx(parent, 类, title);

    }
    public string 进程名枚举进程(string name)
    {
        return 大漠.EnumProcess(name);
    }


    /// <summary>
    /// 窗口_枚举句柄
    /// </summary>
    /// <param name="">获得的窗口句柄是该窗口的子窗口的窗口句柄,取0时为获得桌面句柄</param>
    /// <param name="title">窗口标题. 此参数是模糊匹配.</param>
    /// <param name="class_name">窗口类名. 此参数是模糊匹配.</param>
    /// <param name="filter">1 : 匹配窗口标题,参数title有效 匹配窗口类名,参数class_name有效. 只匹配指定父窗口的第一层孩子窗口匹配所有者窗口为0的窗口,即顶级窗口匹配可见的窗口匹配出的窗口按照窗口打开顺序依次排列这些值可以相加,比如4+8+16就是类似于任务管理器中的窗口列表</param>
    /// <returns></returns>
    public string 窗口_枚举句柄(int parent, string title, string class_name, int filter)
    {
        return 大漠.EnumWindow(parent, title, class_name, filter);

    }
    public string 取插件版本号()
    {
        return 大漠.Ver();
    }
    public int 注册VIP(string reg_code, string ver_info)
    {
        return 大漠.Reg(reg_code, ver_info);
    }
    public int 注册EX(string reg_code, string ver_info, string IP)
    {
        return 大漠.RegEx(reg_code, ver_info, IP);
    }
    public int 窗口_取屏幕位置(int hwnd, out int x1, out int y1, out int x2, out int y2)
    {
        return 大漠.GetWindowRect(hwnd, out x1, out y1, out x2, out y2);
    }
    public int 发送文本_VIP(string str)
    {
        return 大漠.SendStringIme(str);
        //向绑定的窗口发送文本数据.必须配合dx.public.input.ime属性
    }
    public int 窗口_发送文本2(int hwnd, string str)
    {
        return 大漠.SendString2(hwnd, str);

    }
    public int 窗口_发送文本(int hwnd, string str)
    {
        return 大漠.SendString(hwnd, str);

    }
    public int Move_置鼠标移动速度(int speed)
    {
        return 大漠.SetMouseSpeed(speed);
    }
    public int 键盘_置间隔(string type, int delay)
    {
        return 大漠.SetKeypadDelay(type, delay);
        //键盘类型,取值有以下 | "normal" : 对应normal键盘  默认内部延时为30ms | "windows": 对应windows 键盘 默认内部延时为10ms | "dx" :对应dx 键盘 默认内部延时为50ms
    }
    public int 鼠标_置间隔(string type, int delay)
    {
        return 大漠.SetMouseDelay(type, delay);
        // 鼠标类型,取值有以下 "normal" : 对应normal鼠标 默认内部延时为 30ms | "windows": 对应windows 鼠标 默认内部延时为 10ms | "windows": 对应windows 鼠标 默认内部延时为 10ms
    }
    public int 窗口_置状态(int hw, int fl)
    {
        return 大漠.SetWindowState(hw, fl);
        //0 : 关闭指定窗口 1 : 激活指定窗口 2 : 最小化指定窗口,但不激活 3 : 最小化指定窗口,并释放内存,但同时也会激活窗口.4 : 最大化指定窗口,同时激活窗口.5 : 恢复指定窗口 ,但不激活 6 : 隐藏指定窗口 7 : 显示指定窗口 8 : 置顶指定窗口 9 : 取消置顶指定窗口 10 : 禁止指定窗口 11 : 取消禁止指定窗口 12 : 恢复并激活指定窗口 13 : 强制结束窗口所在进程.
    }

    public int 窗口_真实输入文本(int hwnd, string str, int mode)
    {
        return 大漠.SendStringIme2(hwnd, str, mode);
        //利用真实的输入法，对指定的窗口输入文字.
    }
    public int 窗口_移动(int hwnd, int x, int y)
    {
        return 大漠.MoveWindow(hwnd, x, y);
    }
    public int 保护盾_VIP(int enable, string type)
    {
        return 大漠.DmGuard(enable, type);

    }
    public int 绑定(int hwnd, string display, string mouse, string keypad, int mode)
    {
        return 大漠.BindWindow(hwnd, display, mouse, keypad, mode);

    }
    public int 绑定Ex(int hwnd, string display, string mouse, string keypad, string 公共属性, int mode)
    {
        return 大漠.BindWindowEx(hwnd, display, mouse, keypad, 公共属性, mode);

    }
    public int 鼠标_取位置(out int x, out int y)
    {
        return 大漠.GetCursorPos(out x, out y);

    }
    public string 鼠标_取特征码_半VIP()
    {
        return 大漠.GetCursorShape();

    }
    public int 键盘_按住(int vk)
    {
        return 大漠.KeyDown(vk);

    }



    public int 键盘_按住(string vk)
    {
        return 大漠.KeyDownChar(vk);

    }
    public int 键盘_按键(int vk)
    {
        return 大漠.KeyPress(vk);

    }
    public int 键盘_按键(string vk)
    {
        return 大漠.KeyPressChar(vk);

    }
    public int 键盘_按键Str_VIP(string vk, int delay)
    {
        return 大漠.KeyPressStr(vk, delay);

    }
    public int 滚轮上滚()
    {

        return 大漠.WheelUp();

    }
    public int 滚轮下滚()
    {

        return 大漠.WheelDown();

    }
    public int 鼠标_左键单击()
    {
        return 大漠.LeftClick();
    }
    public int 鼠标_左键双击()
    {
        return 大漠.LeftDoubleClick();
    }
    public int 鼠标_相对移动(int x, int y)
    {
        return 大漠.MoveR(x, y);
    }

    public int 鼠标移动(int x, int y)
    {
        return 大漠.MoveTo(x, y);
    }
    public string 鼠标_范围移动(int x, int y, int w, int h)
    {
        return 大漠.MoveToEx(x, y, w, h);
    }
    public int 鼠标_右键单击()
    {
        return 大漠.RightClick();
    }

    public int 键鼠_置前台模拟方式_VIP(int mode)
    {
        return 大漠.SetSimMode(mode);
    }

    public string 颜色_BGR转RGB(string bgr_color)
    {
        return 大漠.BGR2RGB(bgr_color);
    }
    public int 截图(int x1, int y1, int x2, int y2, string file)
    {
        return 大漠.Capture(x1, y1, x2, y2, file);
    }
    public int 卡屏检测(int x1, int y1, int x2, int y2, int file)
    {
        return 大漠.IsDisplayDead(x1, y1, x2, y2, file);
    }

    public int 删除文件(string file)
    {
        return 大漠.DeleteFile(file);

    }
    public int 删除指定目录(string file)
    {
        return 大漠.DeleteFolder(file);
    }
    public int INI_节点删除(string section, string key, string file)
    {
        return 大漠.DeleteIni(section, key, file);
    }

    public int INI_节点删除_VIP(string section, string key, string file, string pwd)
    {
        return 大漠.DeleteIniPwd(section, key, file, pwd);
    }
    public int 文件_下载(string url, string save_file, int timeout)
    {
        return 大漠.DownloadFile(url, save_file, timeout);
    }
    public int 文件加密_VIP(string file, string pwd)
    {
        return 大漠.EncodeFile(file, pwd);
    }
    public string INI_枚举项(string section, string file)
    {
        return 大漠.EnumIniKey(section, file);
    }
    public string INI_读配置(string section, string key, string file)
    {
        return 大漠.ReadIni(section, key, file);
    }
    public string INI_枚举节名(string file)
    {
        return 大漠.EnumIniSection(file);
        ;
    }
    public string 文件_读取(string file)
    {
        return 大漠.ReadFile(file);

    }
    public string 对话框_选择文件()
    {
        return 大漠.SelectFile();
        ;
    }
    public int 系统_置硬件加速_VIP(int level)
    {
        return 大漠.SetDisplayAcceler(level);
    }
    public int INI_写配置(string section, string key, string value, string file)
    {
        return 大漠.WriteIni(section, key, value, file);
    }

    public int INI写_VIP(string section, string key, string value, string file, string pwd)
    {
        return 大漠.WriteIniPwd(section, key, value, file, pwd);
    }


    public int 字库_添加信息(int index, string dict_info)
    {
        return 大漠.AddDict(index, dict_info);
    }
    public string 点阵_提取(int x1, int y1, int x2, int y2, string color, string word)
    {
        return 大漠.FetchWord(x1, y1, x2, y2, color, word);
    }
    public int 找字(int x1, int y1, int x2, int y2, string str, string color_format, double sim, out int intX, out int intY)
    {
        return 大漠.FindStr(x1, y1, x2, y2, str, color_format, sim, out intX, out intY);
    }
    public string 识字(int x1, int y1, int x2, int y2, string color_format, double sim)
    {
        return 大漠.Ocr(x1, y1, x2, y2, color_format, sim);

    }
    public int 字库_置序号(int index)
    {
        return 大漠.UseDict(index);

    }
    public int 字库_置文件(int index, string file)
    {
        return 大漠.SetDict(index, file);

    }


    public int 文字_精准识别(int exact_ocr)
    {
        return 大漠.SetExactOcr(exact_ocr);

    }
    /* public int 延时_VIP(int mis)
     {
         return 大漠.Delay(mis);

     }*/
    public int 延时_VIP(int mis_min, int mis_max)
    {
        return 大漠.Delays(mis_min, mis_max);

    }
    public int 系统_关机退出(int type)
    {
        return 大漠.ExitOs(type);

    }

    public int 取屏幕高度()
    {
        return 大漠.GetScreenHeight();
    }
    public int 取屏幕宽度()
    {
        return 大漠.GetScreenWidth();
    }

}

