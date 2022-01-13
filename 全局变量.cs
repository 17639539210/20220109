using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


public static class 全局变量
{
    public static bool 运行权限;
    public static 大漠中文版 全局大漠;
    public static int 行数 = 10;
    public static List<string> 显示信息标题 = new List<string>() { "模拟器索引", "账号", "密码", "任务", "开始时间", "" };
    public static 大漠多线程信息[] 大漠多线程信息 = new 大漠多线程信息[99];
    public static List<全局变量.任务名称> 任务列表 = new List<全局变量.任务名称>();
    public static string 注册码 = "";
    public static string 附加信息 = "";
    public enum 操作方式
    {
        不点击, 精准点击左上角, 范围内点击, 长按,滑动
    }
    public  enum 任务名称
    {
        主线任务,支线任务1, 支线任务2, 支线任务3
    }
}
public class 大漠多线程信息
{
    public 大漠中文版 大漠;
    public long 窗口外句柄;
    public int 窗口内句柄;
    public Int64 线程句柄;
    public string 线程名字;
    public 状态 线程状态;
    public string 当前任务;
    public bool 绑定状态;

    public 大漠多线程信息(大漠中文版 大漠,string name="")
    {
        this.大漠 = 大漠;
        this.线程名字=name;
        
    }
    public Thread thread;

    public enum 状态
    {
        运行中,暂停,结束,未启用
    }

}

