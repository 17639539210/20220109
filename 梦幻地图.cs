using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class 梦幻地图转换
{
    private int X截距;
    private double X斜率;
    private int Y截距;
    private double Y斜率;

    public 梦幻地图转换(int X截距, double X斜率, int Y截距, double Y斜率)
    {

        this.X截距 = X截距;
        this.X斜率 = X斜率;
        this.Y截距 = Y截距;
        this.Y斜率 = Y斜率;
    }

    public int[] 获取坐标(int x, int y)
    {
        int[] 坐标 = new int[2];
        坐标[0] = Convert.ToInt16(x * this.X斜率 + this.X截距);
        坐标[1] = Convert.ToInt16(y * this.Y斜率 + this.Y截距);
        return 坐标;
    }
}

public static class 地图寻路
{
    public enum 飞行方式
    {
        飞行符,红色标导旗, 黄色标导旗, 白色标导旗, 蓝色标导旗
    }
    public static void 返回酒肆(飞行方式 飞行方式)
    {
        if (飞行方式 != 飞行方式.飞行符)
        {

        }
    }

    public static void 化生寺(飞行方式 飞行方式)
    {

    }
    public static void 江南野外(飞行方式 飞行方式)
    {

    }
    public static void 大唐国境(飞行方式 飞行方式)
    {

    }
    public static void 地府(飞行方式 飞行方式)
    {

    }
    public static void 大唐郊外(飞行方式 飞行方式)
    {

    }
    public static void 朱紫国(飞行方式 飞行方式)
    {

    }
    public static void 狮驼岭(飞行方式 飞行方式)
    {

    }

    public static void 长寿村(飞行方式 飞行方式)
    {

    }
    public static void 长寿郊外(飞行方式 飞行方式)
    {

    }
    public static void 花果山(飞行方式 飞行方式)
    {

    }
    public static void 傲来国(飞行方式 飞行方式)
    {

    }
    public static void 东海湾(飞行方式 飞行方式)
    {

    }
    public static void 西凉女国(飞行方式 飞行方式)
    {

    }
    public static void 返回酒肆()
    {

    }

    public static void 化生寺()
    {

    }
    public static void 江南野外()
    {

    }
    public static void 大唐国境()
    {

    }
    public static void 地府()
    {

    }
    public static void 大唐郊外()
    {

    }
    public static void 朱紫国()
    {

    }
    public static void 狮驼岭()
    {

    }

    public static void 长寿村()
    {

    }
    public static void 长寿郊外()
    {

    }
    public static void 花果山()
    {

    }
    public static void 傲来国()
    {

    }
    public static void 东海湾()
    {

    }
    public static void 西凉女国()
    {

    }

}

