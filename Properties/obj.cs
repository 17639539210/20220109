using System;
using System.Reflection;
using System.Runtime.InteropServices;

public class dmsoft
{
    private Type obj = null;
    private object obj_object = null;
    [DllImport("DmReg.dll", EntryPoint = "cattgRAsUIXLx")] //必需的代码

   
    static extern IntPtr cattgRAsUIXLx(string path, int mode);
    
    public dmsoft()
    {
        obj = Type.GetTypeFromProgID("han.mysoft");
        obj_object = Activator.CreateInstance(obj);
    }
    public dmsoft(string path )
    {
        cattgRAsUIXLx(path, 1);
        obj = Type.GetTypeFromProgID("han.mysoft");
        obj_object = Activator.CreateInstance(obj);
    }

    // 调用此接口进行com对象释放
    public void ReleaseObj()
    {
        if (obj_object != null)
        {
            Marshal.ReleaseComObject(obj_object);
            obj_object = null;
        }
    }

    ~dmsoft()
    {
        ReleaseObj();
    }

    public string FindDouble(int hwnd,string addr_range,double double_value_min,double double_value_max)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = double_value_min;
        args[3] = double_value_max;

        result = obj.InvokeMember("VxSVenzS", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string MoveToEx(int x,int y,int w,int h)
    {
        object[] args = new object[4];
        object result;
        args[0] = x;
        args[1] = y;
        args[2] = w;
        args[3] = h;

        result = obj.InvokeMember("tYsdMlwCr", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string ExecuteCmd(string cmd,string current_dir,int time_out)
    {
        object[] args = new object[3];
        object result;
        args[0] = cmd;
        args[1] = current_dir;
        args[2] = time_out;

        result = obj.InvokeMember("TXNas", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetClientSize(int hwnd,out int width,out int height)
    {
        object[] args = new object[3];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(3);
        mods[0][1] = true;
        mods[0][2] = true;

        args[0] = hwnd;

        result = obj.InvokeMember("uvvXGHGStrPCiV", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        width = (int)args[1];
        height = (int)args[2];
        return (int)result;
    }

    public int FindMultiColor(int x1,int y1,int x2,int y2,string first_color,string offset_color,double sim,int dir,out int x,out int y)
    {
        object[] args = new object[10];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(10);
        mods[0][8] = true;
        mods[0][9] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = first_color;
        args[5] = offset_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("ydWpKeg", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[8];
        y = (int)args[9];
        return (int)result;
    }

    public int KeyPressStr(string key_str,int delay)
    {
        object[] args = new object[2];
        object result;
        args[0] = key_str;
        args[1] = delay;

        result = obj.InvokeMember("QqCkPtQauImA", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int WriteDouble(int hwnd,string addr,double v)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = v;

        result = obj.InvokeMember("xJkqAWa", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int WriteDataAddrFromBin(int hwnd,long addr,int data,int length)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = data;
        args[3] = length;

        result = obj.InvokeMember("qQAGThIqMllZ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SaveDict(int index,string file_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = index;
        args[1] = file_name;

        result = obj.InvokeMember("GSqiHcVjsP", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableRealMouse(int en,int mousedelay,int mousestep)
    {
        object[] args = new object[3];
        object result;
        args[0] = en;
        args[1] = mousedelay;
        args[2] = mousestep;

        result = obj.InvokeMember("LfmUZxMw", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int RegEx(string code,string ver,string ip)
    {
        object[] args = new object[3];
        object result;
        args[0] = code;
        args[1] = ver;
        args[2] = ip;

        result = obj.InvokeMember("tAnaCeCKDscPvY", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string EnumIniKey(string section,string file_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = section;
        args[1] = file_name;

        result = obj.InvokeMember("VdwJTYmo", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetExportDict(int index,string dict_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = index;
        args[1] = dict_name;

        result = obj.InvokeMember("TTIhFBdRQ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetClientSize(int hwnd,int width,int height)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = width;
        args[2] = height;

        result = obj.InvokeMember("xETZdFhkDfupG", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FindColorBlock(int x1,int y1,int x2,int y2,string color,double sim,int count,int width,int height,out int x,out int y)
    {
        object[] args = new object[11];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(11);
        mods[0][9] = true;
        mods[0][10] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;
        args[6] = count;
        args[7] = width;
        args[8] = height;

        result = obj.InvokeMember("VHQeqYeL", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[9];
        y = (int)args[10];
        return (int)result;
    }

    public int DisableScreenSave()
    {
        object result;
        result = obj.InvokeMember("vRUxYMVTcPd", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int SetDisplayAcceler(int level)
    {
        object[] args = new object[1];
        object result;
        args[0] = level;

        result = obj.InvokeMember("yUssUKLVZMGaEVo", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string Md5(string str)
    {
        object[] args = new object[1];
        object result;
        args[0] = str;

        result = obj.InvokeMember("YUXRKrSJeuJJV", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetDict(int index,int font_index)
    {
        object[] args = new object[2];
        object result;
        args[0] = index;
        args[1] = font_index;

        result = obj.InvokeMember("yDwPVf", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FindStrFastS(int x1,int y1,int x2,int y2,string str,string color,double sim,out int x,out int y)
    {
        object[] args = new object[9];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(9);
        mods[0][7] = true;
        mods[0][8] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("ZBBqISySUyK", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[7];
        y = (int)args[8];
        return result.ToString();
    }

    public int IsFileExist(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("jCGrrU", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int LeftDoubleClick()
    {
        object result;
        result = obj.InvokeMember("hYAdaItvBY", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int WriteData(int hwnd,string addr,string data)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = data;

        result = obj.InvokeMember("lThiE", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindShapeEx(int x1,int y1,int x2,int y2,string offset_color,double sim,int dir)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = offset_color;
        args[5] = sim;
        args[6] = dir;

        result = obj.InvokeMember("gehEHLfuUR", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetDiskModel(int index)
    {
        object[] args = new object[1];
        object result;
        args[0] = index;

        result = obj.InvokeMember("hQXGp", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int WriteDataFromBin(int hwnd,string addr,int data,int length)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = data;
        args[3] = length;

        result = obj.InvokeMember("iUbkqVUWjZ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FindPic(int x1,int y1,int x2,int y2,string pic_name,string delta_color,double sim,int dir,out int x,out int y)
    {
        object[] args = new object[10];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(10);
        mods[0][8] = true;
        mods[0][9] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_name;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("qEYoPbUtRBQJp", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[8];
        y = (int)args[9];
        return (int)result;
    }

    public int FaqCaptureString(string str)
    {
        object[] args = new object[1];
        object result;
        args[0] = str;

        result = obj.InvokeMember("zPevmbpIYUNla", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindColorEx(int x1,int y1,int x2,int y2,string color,double sim,int dir)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;
        args[6] = dir;

        result = obj.InvokeMember("zHvRjQw", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FindFloat(int hwnd,string addr_range,float float_value_min,float float_value_max)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = float_value_min;
        args[3] = float_value_max;

        result = obj.InvokeMember("HADodkQqF", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int WriteFloat(int hwnd,string addr,float v)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = v;

        result = obj.InvokeMember("cIHkWsUdGrnh", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FoobarTextPrintDir(int hwnd,int dir)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = dir;

        result = obj.InvokeMember("Rvzrloj", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int Delay(int mis)
    {
        object[] args = new object[1];
        object result;
        args[0] = mis;

        result = obj.InvokeMember("kBzyvXBTPX", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetLastError()
    {
        object result;
        result = obj.InvokeMember("CDPlyByuB", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int GetWindowRect(int hwnd,out int x1,out int y1,out int x2,out int y2)
    {
        object[] args = new object[5];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(5);
        mods[0][1] = true;
        mods[0][2] = true;
        mods[0][3] = true;
        mods[0][4] = true;

        args[0] = hwnd;

        result = obj.InvokeMember("fNpIxGJBQ", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x1 = (int)args[1];
        y1 = (int)args[2];
        x2 = (int)args[3];
        y2 = (int)args[4];
        return (int)result;
    }

    public string ReadIniPwd(string section,string key,string file_name,string pwd)
    {
        object[] args = new object[4];
        object result;
        args[0] = section;
        args[1] = key;
        args[2] = file_name;
        args[3] = pwd;

        result = obj.InvokeMember("mloGewCIvZwyqA", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int LeaveCri()
    {
        object result;
        result = obj.InvokeMember("dHEz", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string GetNetTimeSafe()
    {
        object result;
        result = obj.InvokeMember("zZKYYQFb", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int FoobarUnlock(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("wdmKhf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetWordResultCount(string str)
    {
        object[] args = new object[1];
        object result;
        args[0] = str;

        result = obj.InvokeMember("RmvYU", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetWindowTransparent(int hwnd,int v)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = v;

        result = obj.InvokeMember("soXFrISbqDVTqo", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindInt(int hwnd,string addr_range,long int_value_min,long int_value_max,int tpe)
    {
        object[] args = new object[5];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = int_value_min;
        args[3] = int_value_max;
        args[4] = tpe;

        result = obj.InvokeMember("KQYFuDB", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FindStrFast(int x1,int y1,int x2,int y2,string str,string color,double sim,out int x,out int y)
    {
        object[] args = new object[9];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(9);
        mods[0][7] = true;
        mods[0][8] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("siWCGtfwUiVbSK", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[7];
        y = (int)args[8];
        return (int)result;
    }

    public string MatchPicName(string pic_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = pic_name;

        result = obj.InvokeMember("xtjbGAEcH", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetColGapNoDict(int col_gap)
    {
        object[] args = new object[1];
        object result;
        args[0] = col_gap;

        result = obj.InvokeMember("xZbDdqF", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public long AsmCallEx(int hwnd,int mode,string base_addr)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = mode;
        args[2] = base_addr;

        result = obj.InvokeMember("zsPVfFNwdg", BindingFlags.InvokeMethod, null, obj_object, args);
        return Convert.ToInt64(result);
    }

    public string FindStrFastE(int x1,int y1,int x2,int y2,string str,string color,double sim)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("mQbNYycCyE", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int EnableFindPicMultithread(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("vKvl", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetWindowState(int hwnd,int flag)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = flag;

        result = obj.InvokeMember("wDQdpwFadZBf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetWindowState(int hwnd,int flag)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = flag;

        result = obj.InvokeMember("IqxPYFhxeyWr", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetMac()
    {
        object result;
        result = obj.InvokeMember("TRGkvBglg", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public string ReadDataAddr(int hwnd,long addr,int length)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = length;

        result = obj.InvokeMember("vFyohP", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int TerminateProcess(int pid)
    {
        object[] args = new object[1];
        object result;
        args[0] = pid;

        result = obj.InvokeMember("sRCWs", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int LoadPic(string pic_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = pic_name;

        result = obj.InvokeMember("DWxYmzxqRRInC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string EnumWindowByProcess(string process_name,string title,string class_name,int filter)
    {
        object[] args = new object[4];
        object result;
        args[0] = process_name;
        args[1] = title;
        args[2] = class_name;
        args[3] = filter;

        result = obj.InvokeMember("warhW", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FaqCapture(int x1,int y1,int x2,int y2,int quality,int delay,int time)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = quality;
        args[5] = delay;
        args[6] = time;

        result = obj.InvokeMember("gMIBlh", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableDisplayDebug(int enable_debug)
    {
        object[] args = new object[1];
        object result;
        args[0] = enable_debug;

        result = obj.InvokeMember("sKMZojJzPXFarWg", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public long ReadInt(int hwnd,string addr,int tpe)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;

        result = obj.InvokeMember("XeorgjFtcWW", BindingFlags.InvokeMethod, null, obj_object, args);
        return Convert.ToInt64(result);
    }

    public string GetCursorShapeEx(int tpe)
    {
        object[] args = new object[1];
        object result;
        args[0] = tpe;

        result = obj.InvokeMember("xHVwzM", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FoobarTextRect(int hwnd,int x,int y,int w,int h)
    {
        object[] args = new object[5];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = w;
        args[4] = h;

        result = obj.InvokeMember("hckSM", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FoobarTextLineGap(int hwnd,int gap)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = gap;

        result = obj.InvokeMember("uFTDVauGVdJeX", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int Capture(int x1,int y1,int x2,int y2,string file_name)
    {
        object[] args = new object[5];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = file_name;

        result = obj.InvokeMember("zbPrrCfrIljB", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindStringEx(int hwnd,string addr_range,string string_value,int tpe,int steps,int multi_thread,int mode)
    {
        object[] args = new object[7];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = string_value;
        args[3] = tpe;
        args[4] = steps;
        args[5] = multi_thread;
        args[6] = mode;

        result = obj.InvokeMember("HDBpxnpXti", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetShowErrorMsg(int show)
    {
        object[] args = new object[1];
        object result;
        args[0] = show;

        result = obj.InvokeMember("aJvKdATkIRVnTE", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string RGB2BGR(string rgb_color)
    {
        object[] args = new object[1];
        object result;
        args[0] = rgb_color;

        result = obj.InvokeMember("doWnMXgFhqHSsEy", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FloatToData(float float_value)
    {
        object[] args = new object[1];
        object result;
        args[0] = float_value;

        result = obj.InvokeMember("gDTlJ", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int RegNoMac(string code,string ver)
    {
        object[] args = new object[2];
        object result;
        args[0] = code;
        args[1] = ver;

        result = obj.InvokeMember("fKmwx", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int OpenProcess(int pid)
    {
        object[] args = new object[1];
        object result;
        args[0] = pid;

        result = obj.InvokeMember("RVEbLbIEtqqott", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public float ReadFloatAddr(int hwnd,long addr)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = addr;

        result = obj.InvokeMember("rZjhSQP", BindingFlags.InvokeMethod, null, obj_object, args);
        return (float)result;
    }

    public string GetDiskReversion(int index)
    {
        object[] args = new object[1];
        object result;
        args[0] = index;

        result = obj.InvokeMember("FNlN", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int WriteIntAddr(int hwnd,long addr,int tpe,long v)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;
        args[3] = v;

        result = obj.InvokeMember("sdvFvwRfMp", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int Stop(int id)
    {
        object[] args = new object[1];
        object result;
        args[0] = id;

        result = obj.InvokeMember("eFngtjVZLdInC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int ShowTaskBarIcon(int hwnd,int is_show)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = is_show;

        result = obj.InvokeMember("vIbqf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetDictInfo(string str,string font_name,int font_size,int flag)
    {
        object[] args = new object[4];
        object result;
        args[0] = str;
        args[1] = font_name;
        args[2] = font_size;
        args[3] = flag;

        result = obj.InvokeMember("eLIsrKSYDWv", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public long ReadIntAddr(int hwnd,long addr,int tpe)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;

        result = obj.InvokeMember("BxVGuQmipnbNFlL", BindingFlags.InvokeMethod, null, obj_object, args);
        return Convert.ToInt64(result);
    }

    public string FindStrEx(int x1,int y1,int x2,int y2,string str,string color,double sim)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("erWRWURppltR", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int RightUp()
    {
        object result;
        result = obj.InvokeMember("YBdSKwuusSmWM", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int AsmSetTimeout(int time_out,int param)
    {
        object[] args = new object[2];
        object result;
        args[0] = time_out;
        args[1] = param;

        result = obj.InvokeMember("HzMRlGUpwSkpi", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EncodeFile(string file_name,string pwd)
    {
        object[] args = new object[2];
        object result;
        args[0] = file_name;
        args[1] = pwd;

        result = obj.InvokeMember("mmZdeAnlR", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string StringToData(string string_value,int tpe)
    {
        object[] args = new object[2];
        object result;
        args[0] = string_value;
        args[1] = tpe;

        result = obj.InvokeMember("fqTJhLBsMuN", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetWindow(int hwnd,int flag)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = flag;

        result = obj.InvokeMember("IiHRTz", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetID()
    {
        object result;
        result = obj.InvokeMember("EDlDrYhTKY", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int FoobarUpdate(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("hFPNyyuXdkudw", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindPicE(int x1,int y1,int x2,int y2,string pic_name,string delta_color,double sim,int dir)
    {
        object[] args = new object[8];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_name;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("GDaJnQRaLisD", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetResultCount(string str)
    {
        object[] args = new object[1];
        object result;
        args[0] = str;

        result = obj.InvokeMember("tlLpFFf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableKeypadPatch(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("PcJzWFdeAh", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int UseDict(int index)
    {
        object[] args = new object[1];
        object result;
        args[0] = index;

        result = obj.InvokeMember("QHhwSNfnBnC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetColor(int x,int y)
    {
        object[] args = new object[2];
        object result;
        args[0] = x;
        args[1] = y;

        result = obj.InvokeMember("qqXaqkVa", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetSimMode(int mode)
    {
        object[] args = new object[1];
        object result;
        args[0] = mode;

        result = obj.InvokeMember("PbJersQiUzi", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetScreen(int width,int height,int depth)
    {
        object[] args = new object[3];
        object result;
        args[0] = width;
        args[1] = height;
        args[2] = depth;

        result = obj.InvokeMember("dJWoLozFc", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int DmGuard(int en,string tpe)
    {
        object[] args = new object[2];
        object result;
        args[0] = en;
        args[1] = tpe;

        result = obj.InvokeMember("deIjDbLDP", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetDmCount()
    {
        object result;
        result = obj.InvokeMember("PHyyiIIAk", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int EnableFakeActive(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("RajqSSZezD", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string EnumWindowByProcessId(int pid,string title,string class_name,int filter)
    {
        object[] args = new object[4];
        object result;
        args[0] = pid;
        args[1] = title;
        args[2] = class_name;
        args[3] = filter;

        result = obj.InvokeMember("TfRMv", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int DecodeFile(string file_name,string pwd)
    {
        object[] args = new object[2];
        object result;
        args[0] = file_name;
        args[1] = pwd;

        result = obj.InvokeMember("xvrZACmDBchqqM", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindDoubleEx(int hwnd,string addr_range,double double_value_min,double double_value_max,int steps,int multi_thread,int mode)
    {
        object[] args = new object[7];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = double_value_min;
        args[3] = double_value_max;
        args[4] = steps;
        args[5] = multi_thread;
        args[6] = mode;

        result = obj.InvokeMember("XcuaPuMYJZ", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FindWindowByProcess(string process_name,string class_name,string title_name)
    {
        object[] args = new object[3];
        object result;
        args[0] = process_name;
        args[1] = class_name;
        args[2] = title_name;

        result = obj.InvokeMember("ZpAC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetWindowText(int hwnd,string text)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = text;

        result = obj.InvokeMember("sYlgBDbbNXCMrq", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindData(int hwnd,string addr_range,string data)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = data;

        result = obj.InvokeMember("rLpvHWegtyKYBek", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SendString2(int hwnd,string str)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = str;

        result = obj.InvokeMember("myozw", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetWordLineHeightNoDict(int line_height)
    {
        object[] args = new object[1];
        object result;
        args[0] = line_height;

        result = obj.InvokeMember("MtjrrQbyAEnro", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetForegroundWindow()
    {
        object result;
        result = obj.InvokeMember("AniZZlUacmD", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string GetRealPath(string path)
    {
        object[] args = new object[1];
        object result;
        args[0] = path;

        result = obj.InvokeMember("ItbPJ", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FindInputMethod(string id)
    {
        object[] args = new object[1];
        object result;
        args[0] = id;

        result = obj.InvokeMember("AIeCSueGiINQT", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string ReadStringAddr(int hwnd,long addr,int tpe,int length)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;
        args[3] = length;

        result = obj.InvokeMember("vcRXGu", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FindPicEx(int x1,int y1,int x2,int y2,string pic_name,string delta_color,double sim,int dir)
    {
        object[] args = new object[8];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_name;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("flchvgwvTjgxSya", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetDictMem(int index,int addr,int size)
    {
        object[] args = new object[3];
        object result;
        args[0] = index;
        args[1] = addr;
        args[2] = size;

        result = obj.InvokeMember("YReLEJv", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetKeyState(int vk)
    {
        object[] args = new object[1];
        object result;
        args[0] = vk;

        result = obj.InvokeMember("koYeDuiv", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FreeProcessMemory(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("xJgZk", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int IsDisplayDead(int x1,int y1,int x2,int y2,int t)
    {
        object[] args = new object[5];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = t;

        result = obj.InvokeMember("xwtNcGAIvAKLTj", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SendPaste(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("GFQDeYGZXDIyPbS", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetWindowClass(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("dohSHwuKYy", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetWindowTitle(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("VXUJINPhxX", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int EnablePicCache(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("jtUDjQKNtHlQl", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string ExcludePos(string all_pos,int tpe,int x1,int y1,int x2,int y2)
    {
        object[] args = new object[6];
        object result;
        args[0] = all_pos;
        args[1] = tpe;
        args[2] = x1;
        args[3] = y1;
        args[4] = x2;
        args[5] = y2;

        result = obj.InvokeMember("ImimQGGPqAVniD", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string IntToData(long int_value,int tpe)
    {
        object[] args = new object[2];
        object result;
        args[0] = int_value;
        args[1] = tpe;

        result = obj.InvokeMember("PEHdwTPNyrPfLw", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetAveHSV(int x1,int y1,int x2,int y2)
    {
        object[] args = new object[4];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;

        result = obj.InvokeMember("RAFumloV", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int Beep(int fre,int delay)
    {
        object[] args = new object[2];
        object result;
        args[0] = fre;
        args[1] = delay;

        result = obj.InvokeMember("NUyzWrcKq", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SendString(int hwnd,string str)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = str;

        result = obj.InvokeMember("hMXMDwJqtGQDsb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableKeypadMsg(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("rCMINDuxc", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetScreenDepth()
    {
        object result;
        result = obj.InvokeMember("WjAm", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int FindWindowEx(int parent,string class_name,string title_name)
    {
        object[] args = new object[3];
        object result;
        args[0] = parent;
        args[1] = class_name;
        args[2] = title_name;

        result = obj.InvokeMember("nkzSGqgvZj", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int ActiveInputMethod(int hwnd,string id)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = id;

        result = obj.InvokeMember("HPxKYkoAoeazvq", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int LockMouseRect(int x1,int y1,int x2,int y2)
    {
        object[] args = new object[4];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;

        result = obj.InvokeMember("ydkYMCmJsX", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public long VirtualAllocEx(int hwnd,long addr,int size,int tpe)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = size;
        args[3] = tpe;

        result = obj.InvokeMember("fGHwYUCveHWXScq", BindingFlags.InvokeMethod, null, obj_object, args);
        return Convert.ToInt64(result);
    }

    public int LockDisplay(int locks)
    {
        object[] args = new object[1];
        object result;
        args[0] = locks;

        result = obj.InvokeMember("eUclQoVfEMBhZfS", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableRealKeypad(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("ocmAXtGtGmJE", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int WheelDown()
    {
        object result;
        result = obj.InvokeMember("BgGoJzuA", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string GetWindowProcessPath(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("jMbnivuYmsiFai", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetScreenHeight()
    {
        object result;
        result = obj.InvokeMember("VDcf", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int FoobarFillRect(int hwnd,int x1,int y1,int x2,int y2,string color)
    {
        object[] args = new object[6];
        object result;
        args[0] = hwnd;
        args[1] = x1;
        args[2] = y1;
        args[3] = x2;
        args[4] = y2;
        args[5] = color;

        result = obj.InvokeMember("RNopKZYRhvaZ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FindShape(int x1,int y1,int x2,int y2,string offset_color,double sim,int dir,out int x,out int y)
    {
        object[] args = new object[9];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(9);
        mods[0][7] = true;
        mods[0][8] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = offset_color;
        args[5] = sim;
        args[6] = dir;

        result = obj.InvokeMember("ummFZdhTuN", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[7];
        y = (int)args[8];
        return (int)result;
    }

    public string OcrInFile(int x1,int y1,int x2,int y2,string pic_name,string color,double sim)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_name;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("CebVYE", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string Hex32(int v)
    {
        object[] args = new object[1];
        object result;
        args[0] = v;

        result = obj.InvokeMember("nPCR", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetNetTimeByIp(string ip)
    {
        object[] args = new object[1];
        object result;
        args[0] = ip;

        result = obj.InvokeMember("jZjDT", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetLocale()
    {
        object result;
        result = obj.InvokeMember("AUSHuVZ", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int AddDict(int index,string dict_info)
    {
        object[] args = new object[2];
        object result;
        args[0] = index;
        args[1] = dict_info;

        result = obj.InvokeMember("MmnchxtbBqowAZL", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetOsBuildNumber()
    {
        object result;
        result = obj.InvokeMember("PcpxzqxoqX", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int AsmAdd(string asm_ins)
    {
        object[] args = new object[1];
        object result;
        args[0] = asm_ins;

        result = obj.InvokeMember("WDZwg", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetFps()
    {
        object result;
        result = obj.InvokeMember("yMkMlnzWGw", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int BindWindowEx(int hwnd,string display,string mouse,string keypad,string public_desc,int mode)
    {
        object[] args = new object[6];
        object result;
        args[0] = hwnd;
        args[1] = display;
        args[2] = mouse;
        args[3] = keypad;
        args[4] = public_desc;
        args[5] = mode;

        result = obj.InvokeMember("PDhEwRSLeLmPm", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int VirtualFreeEx(int hwnd,long addr)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = addr;

        result = obj.InvokeMember("LaJB", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetWordLineHeight(int line_height)
    {
        object[] args = new object[1];
        object result;
        args[0] = line_height;

        result = obj.InvokeMember("Rvypdpb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetSpecialWindow(int flag)
    {
        object[] args = new object[1];
        object result;
        args[0] = flag;

        result = obj.InvokeMember("BhjwbpVQq", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int MiddleDown()
    {
        object result;
        result = obj.InvokeMember("XENQQCukwKrIE", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public long AsmCall(int hwnd,int mode)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = mode;

        result = obj.InvokeMember("XnUl", BindingFlags.InvokeMethod, null, obj_object, args);
        return Convert.ToInt64(result);
    }

    public string FindPicExS(int x1,int y1,int x2,int y2,string pic_name,string delta_color,double sim,int dir)
    {
        object[] args = new object[8];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_name;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("EcINmTpdUdE", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string DisAssemble(string asm_code,long base_addr,int is_64bit)
    {
        object[] args = new object[3];
        object result;
        args[0] = asm_code;
        args[1] = base_addr;
        args[2] = is_64bit;

        result = obj.InvokeMember("ivLozLcsGqFWylT", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetUAC(int uac)
    {
        object[] args = new object[1];
        object result;
        args[0] = uac;

        result = obj.InvokeMember("hNjQcziAQxRbH", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableMouseAccuracy(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("DIpQDMCrcfMB", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int KeyDown(int vk)
    {
        object[] args = new object[1];
        object result;
        args[0] = vk;

        result = obj.InvokeMember("BqqBaBIiZbvl", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetNetTime()
    {
        object result;
        result = obj.InvokeMember("SmtlJJXdikBobi", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int WriteDataAddr(int hwnd,long addr,string data)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = data;

        result = obj.InvokeMember("GinxSAEtyUwacJM", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FindColor(int x1,int y1,int x2,int y2,string color,double sim,int dir,out int x,out int y)
    {
        object[] args = new object[9];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(9);
        mods[0][7] = true;
        mods[0][8] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;
        args[6] = dir;

        result = obj.InvokeMember("qgnlftuCtEbCpJ", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[7];
        y = (int)args[8];
        return (int)result;
    }

    public string OcrEx(int x1,int y1,int x2,int y2,string color,double sim)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;

        result = obj.InvokeMember("GelVjgyCTuG", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int Is64Bit()
    {
        object result;
        result = obj.InvokeMember("ZFUpxJLRYqTEjTL", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int FaqPost(string server,int handle,int request_type,int time_out)
    {
        object[] args = new object[4];
        object result;
        args[0] = server;
        args[1] = handle;
        args[2] = request_type;
        args[3] = time_out;

        result = obj.InvokeMember("CyKpyNsE", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetCursorPos(out int x,out int y)
    {
        object[] args = new object[2];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(2);
        mods[0][0] = true;
        mods[0][1] = true;


        result = obj.InvokeMember("XpxmI", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[0];
        y = (int)args[1];
        return (int)result;
    }

    public string GetColorBGR(int x,int y)
    {
        object[] args = new object[2];
        object result;
        args[0] = x;
        args[1] = y;

        result = obj.InvokeMember("nBIlvkdWYVDh", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetColorHSV(int x,int y)
    {
        object[] args = new object[2];
        object result;
        args[0] = x;
        args[1] = y;

        result = obj.InvokeMember("MMPSbY", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int KeyUpChar(string key_str)
    {
        object[] args = new object[1];
        object result;
        args[0] = key_str;

        result = obj.InvokeMember("YokZa", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetCursorShape()
    {
        object result;
        result = obj.InvokeMember("pNJkknDcb", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int FindStrWithFont(int x1,int y1,int x2,int y2,string str,string color,double sim,string font_name,int font_size,int flag,out int x,out int y)
    {
        object[] args = new object[12];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(12);
        mods[0][10] = true;
        mods[0][11] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;
        args[7] = font_name;
        args[8] = font_size;
        args[9] = flag;

        result = obj.InvokeMember("HrfuyWnXiMzzb", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[10];
        y = (int)args[11];
        return (int)result;
    }

    public int SendStringIme2(int hwnd,string str,int mode)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = str;
        args[2] = mode;

        result = obj.InvokeMember("PyHN", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindStrFastExS(int x1,int y1,int x2,int y2,string str,string color,double sim)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("bIDFKk", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int WriteFile(string file_name,string content)
    {
        object[] args = new object[2];
        object result;
        args[0] = file_name;
        args[1] = content;

        result = obj.InvokeMember("oQFgYcFsJuuIHof", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int InitCri()
    {
        object result;
        result = obj.InvokeMember("mTlXycrhA", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int MoveFile(string src_file,string dst_file)
    {
        object[] args = new object[2];
        object result;
        args[0] = src_file;
        args[1] = dst_file;

        result = obj.InvokeMember("EAXM", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FetchWord(int x1,int y1,int x2,int y2,string color,string word)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = word;

        result = obj.InvokeMember("veHBCGSvwK", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FindStrS(int x1,int y1,int x2,int y2,string str,string color,double sim,out int x,out int y)
    {
        object[] args = new object[9];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(9);
        mods[0][7] = true;
        mods[0][8] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("ESfpuVeDPFCKRi", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[7];
        y = (int)args[8];
        return result.ToString();
    }

    public int ImageToBmp(string pic_name,string bmp_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = pic_name;
        args[1] = bmp_name;

        result = obj.InvokeMember("CdGEnUWcQ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindStrWithFontEx(int x1,int y1,int x2,int y2,string str,string color,double sim,string font_name,int font_size,int flag)
    {
        object[] args = new object[10];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;
        args[7] = font_name;
        args[8] = font_size;
        args[9] = flag;

        result = obj.InvokeMember("FGykrQBfTMF", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string ReadIni(string section,string key,string file_name)
    {
        object[] args = new object[3];
        object result;
        args[0] = section;
        args[1] = key;
        args[2] = file_name;

        result = obj.InvokeMember("XNPxsRWinE", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int EnableIme(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("QRjjBrKe", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int KeyPressChar(string key_str)
    {
        object[] args = new object[1];
        object result;
        args[0] = key_str;

        result = obj.InvokeMember("QSyTWP", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetWordsNoDict(int x1,int y1,int x2,int y2,string color)
    {
        object[] args = new object[5];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;

        result = obj.InvokeMember("duSDj", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int IsFolderExist(string folder)
    {
        object[] args = new object[1];
        object result;
        args[0] = folder;

        result = obj.InvokeMember("rtYXscrSXV", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int MoveWindow(int hwnd,int x,int y)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;

        result = obj.InvokeMember("jRuqst", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetDictCount(int index)
    {
        object[] args = new object[1];
        object result;
        args[0] = index;

        result = obj.InvokeMember("jbnshIMIebtJcXX", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindMultiColorEx(int x1,int y1,int x2,int y2,string first_color,string offset_color,double sim,int dir)
    {
        object[] args = new object[8];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = first_color;
        args[5] = offset_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("XrGdAHxIrSe", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string BGR2RGB(string bgr_color)
    {
        object[] args = new object[1];
        object result;
        args[0] = bgr_color;

        result = obj.InvokeMember("kgjdxvShxyW", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetMousePointWindow()
    {
        object result;
        result = obj.InvokeMember("RjrwlXog", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int WriteIniPwd(string section,string key,string v,string file_name,string pwd)
    {
        object[] args = new object[5];
        object result;
        args[0] = section;
        args[1] = key;
        args[2] = v;
        args[3] = file_name;
        args[4] = pwd;

        result = obj.InvokeMember("TldB", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindShapeE(int x1,int y1,int x2,int y2,string offset_color,double sim,int dir)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = offset_color;
        args[5] = sim;
        args[6] = dir;

        result = obj.InvokeMember("oyMqw", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string OcrExOne(int x1,int y1,int x2,int y2,string color,double sim)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;

        result = obj.InvokeMember("XohsqmEpz", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int EnableBind(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("MbIJZctFUsdFFhC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int DisableFontSmooth()
    {
        object result;
        result = obj.InvokeMember("UqGK", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int GetOsType()
    {
        object result;
        result = obj.InvokeMember("YrStnUMxsn", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int SetParam64ToPointer()
    {
        object result;
        result = obj.InvokeMember("JARHx", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string FindStrFastEx(int x1,int y1,int x2,int y2,string str,string color,double sim)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("BwqCcjsnwN", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int VirtualProtectEx(int hwnd,long addr,int size,int tpe,int old_protect)
    {
        object[] args = new object[5];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = size;
        args[3] = tpe;
        args[4] = old_protect;

        result = obj.InvokeMember("cThtq", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindStrWithFontE(int x1,int y1,int x2,int y2,string str,string color,double sim,string font_name,int font_size,int flag)
    {
        object[] args = new object[10];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;
        args[7] = font_name;
        args[8] = font_size;
        args[9] = flag;

        result = obj.InvokeMember("uUYdbTbfr", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string ReadFile(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("svfiVxYin", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetEnumWindowDelay(int delay)
    {
        object[] args = new object[1];
        object result;
        args[0] = delay;

        result = obj.InvokeMember("Gsdh", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FindPicMem(int x1,int y1,int x2,int y2,string pic_info,string delta_color,double sim,int dir,out int x,out int y)
    {
        object[] args = new object[10];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(10);
        mods[0][8] = true;
        mods[0][9] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_info;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("jQVVv", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[8];
        y = (int)args[9];
        return (int)result;
    }

    public string Ocr(int x1,int y1,int x2,int y2,string color,double sim)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;

        result = obj.InvokeMember("JwnpTXaQFr", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FindStr(int x1,int y1,int x2,int y2,string str,string color,double sim,out int x,out int y)
    {
        object[] args = new object[9];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(9);
        mods[0][7] = true;
        mods[0][8] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("DpfzF", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[7];
        y = (int)args[8];
        return (int)result;
    }

    public string GetBasePath()
    {
        object result;
        result = obj.InvokeMember("lzQrvlLV", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int ReadDataToBin(int hwnd,string addr,int length)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = length;

        result = obj.InvokeMember("fKclcRHdZ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindIntEx(int hwnd,string addr_range,long int_value_min,long int_value_max,int tpe,int steps,int multi_thread,int mode)
    {
        object[] args = new object[8];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = int_value_min;
        args[3] = int_value_max;
        args[4] = tpe;
        args[5] = steps;
        args[6] = multi_thread;
        args[7] = mode;

        result = obj.InvokeMember("LFbGVMTj", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int CaptureGif(int x1,int y1,int x2,int y2,string file_name,int delay,int time)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = file_name;
        args[5] = delay;
        args[6] = time;

        result = obj.InvokeMember("BvUez", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string SortPosDistance(string all_pos,int tpe,int x,int y)
    {
        object[] args = new object[4];
        object result;
        args[0] = all_pos;
        args[1] = tpe;
        args[2] = x;
        args[3] = y;

        result = obj.InvokeMember("YDmiYYAUycuj", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FindWindow(string class_name,string title_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = class_name;
        args[1] = title_name;

        result = obj.InvokeMember("JWUqnUhQsD", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetMinRowGap(int row_gap)
    {
        object[] args = new object[1];
        object result;
        args[0] = row_gap;

        result = obj.InvokeMember("fzkGQCIUXHjPqe", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FindMulColor(int x1,int y1,int x2,int y2,string color,double sim)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;

        result = obj.InvokeMember("sDzYQ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetPath()
    {
        object result;
        result = obj.InvokeMember("nJnNZGcPXTrC", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public string EnumWindow(int parent,string title,string class_name,int filter)
    {
        object[] args = new object[4];
        object result;
        args[0] = parent;
        args[1] = title;
        args[2] = class_name;
        args[3] = filter;

        result = obj.InvokeMember("FrbKWLMHfLzJX", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FoobarClose(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("RTrtsHEPtYuF", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int CreateFoobarRect(int hwnd,int x,int y,int w,int h)
    {
        object[] args = new object[5];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = w;
        args[4] = h;

        result = obj.InvokeMember("wvHUIK", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int DisablePowerSave()
    {
        object result;
        result = obj.InvokeMember("dSvJsbjLNjLpE", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int MoveTo(int x,int y)
    {
        object[] args = new object[2];
        object result;
        args[0] = x;
        args[1] = y;

        result = obj.InvokeMember("ssIH", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FoobarStartGif(int hwnd,int x,int y,string pic_name,int repeat_limit,int delay)
    {
        object[] args = new object[6];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = pic_name;
        args[4] = repeat_limit;
        args[5] = delay;

        result = obj.InvokeMember("iKClPqiaVvvwhAd", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public long GetRemoteApiAddress(int hwnd,long base_addr,string fun_name)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = base_addr;
        args[2] = fun_name;

        result = obj.InvokeMember("rkeclLxswqFXd", BindingFlags.InvokeMethod, null, obj_object, args);
        return Convert.ToInt64(result);
    }

    public int RegExNoMac(string code,string ver,string ip)
    {
        object[] args = new object[3];
        object result;
        args[0] = code;
        args[1] = ver;
        args[2] = ip;

        result = obj.InvokeMember("CePJfDzJZhn", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string EnumIniKeyPwd(string section,string file_name,string pwd)
    {
        object[] args = new object[3];
        object result;
        args[0] = section;
        args[1] = file_name;
        args[2] = pwd;

        result = obj.InvokeMember("cjUWWpM", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetCursorSpot()
    {
        object result;
        result = obj.InvokeMember("dwaVKzriLp", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public string EnumWindowSuper(string spec1,int flag1,int type1,string spec2,int flag2,int type2,int sort)
    {
        object[] args = new object[7];
        object result;
        args[0] = spec1;
        args[1] = flag1;
        args[2] = type1;
        args[3] = spec2;
        args[4] = flag2;
        args[5] = type2;
        args[6] = sort;

        result = obj.InvokeMember("TDMxX", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int CopyFile(string src_file,string dst_file,int over)
    {
        object[] args = new object[3];
        object result;
        args[0] = src_file;
        args[1] = dst_file;
        args[2] = over;

        result = obj.InvokeMember("FHZega", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableMouseMsg(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("bpFeCoQuloJr", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int IsBind(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("TAYJoYVujrRylP", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetCpuUsage()
    {
        object result;
        result = obj.InvokeMember("qNhLxpng", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int EnableSpeedDx(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("dpYNtFngEmU", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetPicPwd(string pwd)
    {
        object[] args = new object[1];
        object result;
        args[0] = pwd;

        result = obj.InvokeMember("XYphsPILRIrr", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int Delays(int min_s,int max_s)
    {
        object[] args = new object[2];
        object result;
        args[0] = min_s;
        args[1] = max_s;

        result = obj.InvokeMember("gTbH", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int ExitOs(int tpe)
    {
        object[] args = new object[1];
        object result;
        args[0] = tpe;

        result = obj.InvokeMember("qAZHliLrM", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetClipboard()
    {
        object result;
        result = obj.InvokeMember("yTQo", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int WaitKey(int key_code,int time_out)
    {
        object[] args = new object[2];
        object result;
        args[0] = key_code;
        args[1] = time_out;

        result = obj.InvokeMember("dgSAkaoiIXTv", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetMemoryFindResultToFile(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("NjaHxpnNRgcny", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetBindWindow()
    {
        object result;
        result = obj.InvokeMember("SAaRocZJfxV", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int Reg(string code,string ver)
    {
        object[] args = new object[2];
        object result;
        args[0] = code;
        args[1] = ver;

        result = obj.InvokeMember("kgCQba", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FoobarStopGif(int hwnd,int x,int y,string pic_name)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = pic_name;

        result = obj.InvokeMember("iZiFr", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int CreateFoobarRoundRect(int hwnd,int x,int y,int w,int h,int rw,int rh)
    {
        object[] args = new object[7];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = w;
        args[4] = h;
        args[5] = rw;
        args[6] = rh;

        result = obj.InvokeMember("PHovkqXTskTbHCX", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetScreenWidth()
    {
        object result;
        result = obj.InvokeMember("cPJtLUulxLpoG", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int SetDictPwd(string pwd)
    {
        object[] args = new object[1];
        object result;
        args[0] = pwd;

        result = obj.InvokeMember("FoKyhpFe", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetClientRect(int hwnd,out int x1,out int y1,out int x2,out int y2)
    {
        object[] args = new object[5];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(5);
        mods[0][1] = true;
        mods[0][2] = true;
        mods[0][3] = true;
        mods[0][4] = true;

        args[0] = hwnd;

        result = obj.InvokeMember("pbUdF", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x1 = (int)args[1];
        y1 = (int)args[2];
        x2 = (int)args[3];
        y2 = (int)args[4];
        return (int)result;
    }

    public double ReadDoubleAddr(int hwnd,long addr)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = addr;

        result = obj.InvokeMember("dPDIjWaFWQKxoph", BindingFlags.InvokeMethod, null, obj_object, args);
        return (double)result;
    }

    public int FoobarPrintText(int hwnd,string text,string color)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = text;
        args[2] = color;

        result = obj.InvokeMember("lPhqteb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetAero(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("iQJA", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetWordResultPos(string str,int index,out int x,out int y)
    {
        object[] args = new object[4];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(4);
        mods[0][2] = true;
        mods[0][3] = true;

        args[0] = str;
        args[1] = index;

        result = obj.InvokeMember("oWicgLawHzltGSC", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[2];
        y = (int)args[3];
        return (int)result;
    }

    public int FoobarDrawText(int hwnd,int x,int y,int w,int h,string text,string color,int align)
    {
        object[] args = new object[8];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = w;
        args[4] = h;
        args[5] = text;
        args[6] = color;
        args[7] = align;

        result = obj.InvokeMember("dMkveKwJo", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int CreateFolder(string folder_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = folder_name;

        result = obj.InvokeMember("LNJj", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string Hex64(long v)
    {
        object[] args = new object[1];
        object result;
        args[0] = v;

        result = obj.InvokeMember("qvMnmIrHLSXNL", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int DeleteFolder(string folder_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = folder_name;

        result = obj.InvokeMember("hZyAEhxvQSxJ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SendStringIme(string str)
    {
        object[] args = new object[1];
        object result;
        args[0] = str;

        result = obj.InvokeMember("AdSkZJGAvsQJW", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int RightDown()
    {
        object result;
        result = obj.InvokeMember("VnwCeagc", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int SetKeypadDelay(string tpe,int delay)
    {
        object[] args = new object[2];
        object result;
        args[0] = tpe;
        args[1] = delay;

        result = obj.InvokeMember("gFXlfozHnBTP", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableKeypadSync(int en,int time_out)
    {
        object[] args = new object[2];
        object result;
        args[0] = en;
        args[1] = time_out;

        result = obj.InvokeMember("qEoPFAqNyb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindPicMemE(int x1,int y1,int x2,int y2,string pic_info,string delta_color,double sim,int dir)
    {
        object[] args = new object[8];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_info;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("VznPvyoF", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FindWindowByProcessId(int process_id,string class_name,string title_name)
    {
        object[] args = new object[3];
        object result;
        args[0] = process_id;
        args[1] = class_name;
        args[2] = title_name;

        result = obj.InvokeMember("YtMfdtxxwkJZgH", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string EnumIniSection(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("PshIsf", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int WriteStringAddr(int hwnd,long addr,int tpe,string v)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;
        args[3] = v;

        result = obj.InvokeMember("jeguRB", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int DeleteIniPwd(string section,string key,string file_name,string pwd)
    {
        object[] args = new object[4];
        object result;
        args[0] = section;
        args[1] = key;
        args[2] = file_name;
        args[3] = pwd;

        result = obj.InvokeMember("LKHAMGK", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FreePic(string pic_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = pic_name;

        result = obj.InvokeMember("riqHDXiFvNpir", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetDisplayRefreshDelay(int t)
    {
        object[] args = new object[1];
        object result;
        args[0] = t;

        result = obj.InvokeMember("ezKgoqVFR", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetPointWindow(int x,int y)
    {
        object[] args = new object[2];
        object result;
        args[0] = x;
        args[1] = y;

        result = obj.InvokeMember("xxBb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int MiddleUp()
    {
        object result;
        result = obj.InvokeMember("TzQUsVhSTPjQfj", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string FindStrE(int x1,int y1,int x2,int y2,string str,string color,double sim)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("hGfpaTMc", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetMachineCode()
    {
        object result;
        result = obj.InvokeMember("IEXkRSKsTcgEZL", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public string EnumIniSectionPwd(string file_name,string pwd)
    {
        object[] args = new object[2];
        object result;
        args[0] = file_name;
        args[1] = pwd;

        result = obj.InvokeMember("msJbnf", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetDPI()
    {
        object result;
        result = obj.InvokeMember("jMnJfgMvH", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string GetPicSize(string pic_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = pic_name;

        result = obj.InvokeMember("KeTDDRpU", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int DeleteFile(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("inKIBbfcxFe", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FaqCancel()
    {
        object result;
        result = obj.InvokeMember("lMjmQXWkKIY", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string FindPicMemEx(int x1,int y1,int x2,int y2,string pic_info,string delta_color,double sim,int dir)
    {
        object[] args = new object[8];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_info;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("vNbtyMokd", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FindFloatEx(int hwnd,string addr_range,float float_value_min,float float_value_max,int steps,int multi_thread,int mode)
    {
        object[] args = new object[7];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = float_value_min;
        args[3] = float_value_max;
        args[4] = steps;
        args[5] = multi_thread;
        args[6] = mode;

        result = obj.InvokeMember("NDQeaqDJjkMFX", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FindWindowSuper(string spec1,int flag1,int type1,string spec2,int flag2,int type2)
    {
        object[] args = new object[6];
        object result;
        args[0] = spec1;
        args[1] = flag1;
        args[2] = type1;
        args[3] = spec2;
        args[4] = flag2;
        args[5] = type2;

        result = obj.InvokeMember("GFrJU", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetMouseSpeed()
    {
        object result;
        result = obj.InvokeMember("SZRFgdzQz", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int KeyUp(int vk)
    {
        object[] args = new object[1];
        object result;
        args[0] = vk;

        result = obj.InvokeMember("ISkewBbvH", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetScreenDataBmp(int x1,int y1,int x2,int y2,out int data,out int size)
    {
        object[] args = new object[6];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(6);
        mods[0][4] = true;
        mods[0][5] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;

        result = obj.InvokeMember("TwXSyLUjBtKoXda", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        data = (int)args[4];
        size = (int)args[5];
        return (int)result;
    }

    public int FaqGetSize(int handle)
    {
        object[] args = new object[1];
        object result;
        args[0] = handle;

        result = obj.InvokeMember("RWpRWQIv", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetRowGapNoDict(int row_gap)
    {
        object[] args = new object[1];
        object result;
        args[0] = row_gap;

        result = obj.InvokeMember("lLrGnaomYusNmp", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string SelectFile()
    {
        object result;
        result = obj.InvokeMember("cKlnpnbNogsGV", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int SetMinColGap(int col_gap)
    {
        object[] args = new object[1];
        object result;
        args[0] = col_gap;

        result = obj.InvokeMember("mPgmfPBkqriFN", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SwitchBindWindow(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("BNdnNDMkoXa", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetDiskSerial(int index)
    {
        object[] args = new object[1];
        object result;
        args[0] = index;

        result = obj.InvokeMember("QEAM", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetWordGapNoDict(int word_gap)
    {
        object[] args = new object[1];
        object result;
        args[0] = word_gap;

        result = obj.InvokeMember("BDKtKQTbJ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetMemoryHwndAsProcessId(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("RyNcayWSBEZhP", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetExcludeRegion(int tpe,string info)
    {
        object[] args = new object[2];
        object result;
        args[0] = tpe;
        args[1] = info;

        result = obj.InvokeMember("KbspS", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int UnBindWindow()
    {
        object result;
        result = obj.InvokeMember("xfkDZ", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int CheckUAC()
    {
        object result;
        result = obj.InvokeMember("dSjm", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int ShowScrMsg(int x1,int y1,int x2,int y2,string msg,string color)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = msg;
        args[5] = color;

        result = obj.InvokeMember("LlVLYobRJsH", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int KeyDownChar(string key_str)
    {
        object[] args = new object[1];
        object result;
        args[0] = key_str;

        result = obj.InvokeMember("GAcsMHZhK", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string ReadData(int hwnd,string addr,int length)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = length;

        result = obj.InvokeMember("PYtbwzf", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int EnterCri()
    {
        object result;
        result = obj.InvokeMember("MJkYHlBLNtUv", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int DownloadFile(string url,string save_file,int timeout)
    {
        object[] args = new object[3];
        object result;
        args[0] = url;
        args[1] = save_file;
        args[2] = timeout;

        result = obj.InvokeMember("CyegAHotaU", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int Int64ToInt32(long v)
    {
        object[] args = new object[1];
        object result;
        args[0] = v;

        result = obj.InvokeMember("EFshkRRw", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int CmpColor(int x,int y,string color,double sim)
    {
        object[] args = new object[4];
        object result;
        args[0] = x;
        args[1] = y;
        args[2] = color;
        args[3] = sim;

        result = obj.InvokeMember("RCpRzJHSSBBKN", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetNowDict()
    {
        object result;
        result = obj.InvokeMember("gdCiLm", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string FindString(int hwnd,string addr_range,string string_value,int tpe)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = string_value;
        args[3] = tpe;

        result = obj.InvokeMember("dcRlNihouWxISMX", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FoobarSetSave(int hwnd,string file_name,int en,string header)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = file_name;
        args[2] = en;
        args[3] = header;

        result = obj.InvokeMember("raRFBRaWVTClxA", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string Ver()
    {
        object result;
        result = obj.InvokeMember("kyxvCS", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int SetDisplayInput(string mode)
    {
        object[] args = new object[1];
        object result;
        args[0] = mode;

        result = obj.InvokeMember("BNQRvsyUoJBASNC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableFontSmooth()
    {
        object result;
        result = obj.InvokeMember("pKnYklBcXVdmf", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int RunApp(string path,int mode)
    {
        object[] args = new object[2];
        object result;
        args[0] = path;
        args[1] = mode;

        result = obj.InvokeMember("fLLFCemSKLBzt", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int MiddleClick()
    {
        object result;
        result = obj.InvokeMember("oUDQuzWNwyaK", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string FindColorE(int x1,int y1,int x2,int y2,string color,double sim,int dir)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;
        args[6] = dir;

        result = obj.InvokeMember("LzpmE", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int CheckInputMethod(int hwnd,string id)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = id;

        result = obj.InvokeMember("eVzlJC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindColorBlockEx(int x1,int y1,int x2,int y2,string color,double sim,int count,int width,int height)
    {
        object[] args = new object[9];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;
        args[6] = count;
        args[7] = width;
        args[8] = height;

        result = obj.InvokeMember("ibgXFfyjvar", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int BindWindow(int hwnd,string display,string mouse,string keypad,int mode)
    {
        object[] args = new object[5];
        object result;
        args[0] = hwnd;
        args[1] = display;
        args[2] = mouse;
        args[3] = keypad;
        args[4] = mode;

        result = obj.InvokeMember("ILtI", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public long GetModuleBaseAddr(int hwnd,string module_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = module_name;

        result = obj.InvokeMember("vLsTklMgbMHUH", BindingFlags.InvokeMethod, null, obj_object, args);
        return Convert.ToInt64(result);
    }

    public int LeftDown()
    {
        object result;
        result = obj.InvokeMember("vrBtMhzcDTACtBn", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int EnableGetColorByCapture(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("DCUZAhUIR", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetPath(string path)
    {
        object[] args = new object[1];
        object result;
        args[0] = path;

        result = obj.InvokeMember("vPINpyWYY", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindPicS(int x1,int y1,int x2,int y2,string pic_name,string delta_color,double sim,int dir,out int x,out int y)
    {
        object[] args = new object[10];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(10);
        mods[0][8] = true;
        mods[0][9] = true;

        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = pic_name;
        args[5] = delta_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("NICFZazMlZy", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[8];
        y = (int)args[9];
        return result.ToString();
    }

    public int FoobarDrawPic(int hwnd,int x,int y,string pic,string trans_color)
    {
        object[] args = new object[5];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = pic;
        args[4] = trans_color;

        result = obj.InvokeMember("FrYnWBC", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int CaptureJpg(int x1,int y1,int x2,int y2,string file_name,int quality)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = file_name;
        args[5] = quality;

        result = obj.InvokeMember("aszGbvZIZTu", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetDisplayDelay(int t)
    {
        object[] args = new object[1];
        object result;
        args[0] = t;

        result = obj.InvokeMember("AUYNZgofHR", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int CapturePre(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("clbvsn", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int LeftClick()
    {
        object result;
        result = obj.InvokeMember("LtiMFKUrG", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int AsmClear()
    {
        object result;
        result = obj.InvokeMember("vCyvlezm", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int CheckFontSmooth()
    {
        object result;
        result = obj.InvokeMember("oNlgxYVo", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string GetDir(int tpe)
    {
        object[] args = new object[1];
        object result;
        args[0] = tpe;

        result = obj.InvokeMember("jxSEDUs", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetColorNum(int x1,int y1,int x2,int y2,string color,double sim)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;

        result = obj.InvokeMember("XasnTVxxvA", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string EnumProcess(string name)
    {
        object[] args = new object[1];
        object result;
        args[0] = name;

        result = obj.InvokeMember("JMaYkCP", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int WriteFloatAddr(int hwnd,long addr,float v)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = v;

        result = obj.InvokeMember("JVtb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetWordGap(int word_gap)
    {
        object[] args = new object[1];
        object result;
        args[0] = word_gap;

        result = obj.InvokeMember("iCFqal", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int CreateFoobarCustom(int hwnd,int x,int y,string pic,string trans_color,double sim)
    {
        object[] args = new object[6];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = pic;
        args[4] = trans_color;
        args[5] = sim;

        result = obj.InvokeMember("MtBrv", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int KeyPress(int vk)
    {
        object[] args = new object[1];
        object result;
        args[0] = vk;

        result = obj.InvokeMember("pXMWcIFtCbAxf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetClipboard(string data)
    {
        object[] args = new object[1];
        object result;
        args[0] = data;

        result = obj.InvokeMember("iuCyLhwoPsJn", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableMouseSync(int en,int time_out)
    {
        object[] args = new object[2];
        object result;
        args[0] = en;
        args[1] = time_out;

        result = obj.InvokeMember("ITUI", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindMultiColorE(int x1,int y1,int x2,int y2,string first_color,string offset_color,double sim,int dir)
    {
        object[] args = new object[8];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = first_color;
        args[5] = offset_color;
        args[6] = sim;
        args[7] = dir;

        result = obj.InvokeMember("HgczjoXfJ", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FaqFetch()
    {
        object result;
        result = obj.InvokeMember("tlLKqDGnT", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int WriteInt(int hwnd,string addr,int tpe,long v)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;
        args[3] = v;

        result = obj.InvokeMember("hRXb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int HackSpeed(double rate)
    {
        object[] args = new object[1];
        object result;
        args[0] = rate;

        result = obj.InvokeMember("stFmArkJjY", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int WriteIni(string section,string key,string v,string file_name)
    {
        object[] args = new object[4];
        object result;
        args[0] = section;
        args[1] = key;
        args[2] = v;
        args[3] = file_name;

        result = obj.InvokeMember("MfItCmcS", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetResultPos(string str,int index,out int x,out int y)
    {
        object[] args = new object[4];
        object result;
        ParameterModifier[] mods = new ParameterModifier[1];

        mods[0] = new ParameterModifier(4);
        mods[0][2] = true;
        mods[0][3] = true;

        args[0] = str;
        args[1] = index;

        result = obj.InvokeMember("IfZibwUergMIDkp", BindingFlags.InvokeMethod, null, obj_object, args, mods, null, null);
        x = (int)args[2];
        y = (int)args[3];
        return (int)result;
    }

    public int FoobarLock(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("qdckZrdDacCWf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetModuleSize(int hwnd,string module_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = module_name;

        result = obj.InvokeMember("rsDwWd", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetMachineCodeNoMac()
    {
        object result;
        result = obj.InvokeMember("WDkLj", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int GetMemoryUsage()
    {
        object result;
        result = obj.InvokeMember("mTude", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int CapturePng(int x1,int y1,int x2,int y2,string file_name)
    {
        object[] args = new object[5];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = file_name;

        result = obj.InvokeMember("gnsvKG", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int EnableShareDict(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("gptDkpGvwRKjNhl", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int UnLoadDriver()
    {
        object result;
        result = obj.InvokeMember("gWVJMSVRTNHy", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string ReadString(int hwnd,string addr,int tpe,int length)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;
        args[3] = length;

        result = obj.InvokeMember("eupAckFt", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int ClearDict(int index)
    {
        object[] args = new object[1];
        object result;
        args[0] = index;

        result = obj.InvokeMember("mUQj", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int DownCpu(int rate)
    {
        object[] args = new object[1];
        object result;
        args[0] = rate;

        result = obj.InvokeMember("kqZpXuzb", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetWordResultStr(string str,int index)
    {
        object[] args = new object[2];
        object result;
        args[0] = str;
        args[1] = index;

        result = obj.InvokeMember("UoVcNbtyL", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetCpuType()
    {
        object result;
        result = obj.InvokeMember("pTibUPpWBbZFX", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public double ReadDouble(int hwnd,string addr)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = addr;

        result = obj.InvokeMember("klxiWJbLg", BindingFlags.InvokeMethod, null, obj_object, args);
        return (double)result;
    }

    public float ReadFloat(int hwnd,string addr)
    {
        object[] args = new object[2];
        object result;
        args[0] = hwnd;
        args[1] = addr;

        result = obj.InvokeMember("ypRFgLpiVdVRxxA", BindingFlags.InvokeMethod, null, obj_object, args);
        return (float)result;
    }

    public string FindNearestPos(string all_pos,int tpe,int x,int y)
    {
        object[] args = new object[4];
        object result;
        args[0] = all_pos;
        args[1] = tpe;
        args[2] = x;
        args[3] = y;

        result = obj.InvokeMember("acVqBAGZu", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int FoobarSetFont(int hwnd,string font_name,int size,int flag)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = font_name;
        args[2] = size;
        args[3] = flag;

        result = obj.InvokeMember("APdtWdmzw", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int WriteDoubleAddr(int hwnd,long addr,double v)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = v;

        result = obj.InvokeMember("qIznIxud", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FaqSend(string server,int handle,int request_type,int time_out)
    {
        object[] args = new object[4];
        object result;
        args[0] = server;
        args[1] = handle;
        args[2] = request_type;
        args[3] = time_out;

        result = obj.InvokeMember("DoMyPsSAFl", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int WriteString(int hwnd,string addr,int tpe,string v)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = tpe;
        args[3] = v;

        result = obj.InvokeMember("aEqxuo", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int ForceUnBindWindow(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("lPsZnsoIHnGZg", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int GetWindowProcessId(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("WTLEsXaR", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int DisableCloseDisplayAndSleep()
    {
        object result;
        result = obj.InvokeMember("GTBjx", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string GetCommandLine(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("gUmnXS", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int IsSurrpotVt()
    {
        object result;
        result = obj.InvokeMember("rQWhBbgK", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int GetForegroundFocus()
    {
        object result;
        result = obj.InvokeMember("jqHTPBprzvHG", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int MoveR(int rx,int ry)
    {
        object[] args = new object[2];
        object result;
        args[0] = rx;
        args[1] = ry;

        result = obj.InvokeMember("LkRrXoNWdvDFwn", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetWords(int x1,int y1,int x2,int y2,string color,double sim)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = color;
        args[5] = sim;

        result = obj.InvokeMember("lwXxPKrXwcvsQo", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetScreenData(int x1,int y1,int x2,int y2)
    {
        object[] args = new object[4];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;

        result = obj.InvokeMember("JzVoMelkWeTumF", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int LoadPicByte(int addr,int size,string name)
    {
        object[] args = new object[3];
        object result;
        args[0] = addr;
        args[1] = size;
        args[2] = name;

        result = obj.InvokeMember("QUZPQeZyBadYN", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetExitThread(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("CZstDtIL", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SpeedNormalGraphic(int en)
    {
        object[] args = new object[1];
        object result;
        args[0] = en;

        result = obj.InvokeMember("rCXR", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int LeftUp()
    {
        object result;
        result = obj.InvokeMember("cmymRDuxUh", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string SelectDirectory()
    {
        object result;
        result = obj.InvokeMember("ZYxAwvgce", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int SetExactOcr(int exact_ocr)
    {
        object[] args = new object[1];
        object result;
        args[0] = exact_ocr;

        result = obj.InvokeMember("UMslJUMzxgBjXl", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int DeleteIni(string section,string key,string file_name)
    {
        object[] args = new object[3];
        object result;
        args[0] = section;
        args[1] = key;
        args[2] = file_name;

        result = obj.InvokeMember("LpVnwqIYc", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string Assemble(long base_addr,int is_64bit)
    {
        object[] args = new object[2];
        object result;
        args[0] = base_addr;
        args[1] = is_64bit;

        result = obj.InvokeMember("sncupXjHzgijn", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string FindStrExS(int x1,int y1,int x2,int y2,string str,string color,double sim)
    {
        object[] args = new object[7];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = str;
        args[5] = color;
        args[6] = sim;

        result = obj.InvokeMember("mSHSSEPBXRY", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetFileLength(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("BtoaHhip", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int MoveDD(int dx,int dy)
    {
        object[] args = new object[2];
        object result;
        args[0] = dx;
        args[1] = dy;

        result = obj.InvokeMember("RbzmidUYrnjI", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string FindDataEx(int hwnd,string addr_range,string data,int steps,int multi_thread,int mode)
    {
        object[] args = new object[6];
        object result;
        args[0] = hwnd;
        args[1] = addr_range;
        args[2] = data;
        args[3] = steps;
        args[4] = multi_thread;
        args[5] = mode;

        result = obj.InvokeMember("cSwfbGXEsYNETjT", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int SetLocale()
    {
        object result;
        result = obj.InvokeMember("kDLFLjmDC", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int FaqIsPosted()
    {
        object result;
        result = obj.InvokeMember("EdCF", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int FoobarSetTrans(int hwnd,int trans,string color,double sim)
    {
        object[] args = new object[4];
        object result;
        args[0] = hwnd;
        args[1] = trans;
        args[2] = color;
        args[3] = sim;

        result = obj.InvokeMember("sztfxDZmjxbAwdf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int RightClick()
    {
        object result;
        result = obj.InvokeMember("dwkYnFSCCDA", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public string DmGuardParams(string cmd,string sub_cmd,string param)
    {
        object[] args = new object[3];
        object result;
        args[0] = cmd;
        args[1] = sub_cmd;
        args[2] = param;

        result = obj.InvokeMember("xsJJFI", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string AppendPicAddr(string pic_info,int addr,int size)
    {
        object[] args = new object[3];
        object result;
        args[0] = pic_info;
        args[1] = addr;
        args[2] = size;

        result = obj.InvokeMember("kHgHQPfYTHulu", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int CreateFoobarEllipse(int hwnd,int x,int y,int w,int h)
    {
        object[] args = new object[5];
        object result;
        args[0] = hwnd;
        args[1] = x;
        args[2] = y;
        args[3] = w;
        args[4] = h;

        result = obj.InvokeMember("ZbFgDh", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string VirtualQueryEx(int hwnd,long addr,int pmbi)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = pmbi;

        result = obj.InvokeMember("DXELaFTuXMBnCk", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string GetDisplayInfo()
    {
        object result;
        result = obj.InvokeMember("FSMmXmCMyIGCQLu", BindingFlags.InvokeMethod, null, obj_object, null);
        return result.ToString();
    }

    public int SetWindowSize(int hwnd,int width,int height)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = width;
        args[2] = height;

        result = obj.InvokeMember("FLkCpsMAQPi", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FoobarClearText(int hwnd)
    {
        object[] args = new object[1];
        object result;
        args[0] = hwnd;

        result = obj.InvokeMember("stCKL", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetMouseSpeed(int speed)
    {
        object[] args = new object[1];
        object result;
        args[0] = speed;

        result = obj.InvokeMember("YCQiIYdrAaQ", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetAveRGB(int x1,int y1,int x2,int y2)
    {
        object[] args = new object[4];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;

        result = obj.InvokeMember("LfYPyo", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int Play(string file_name)
    {
        object[] args = new object[1];
        object result;
        args[0] = file_name;

        result = obj.InvokeMember("CqLLQqFaxzL", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetDict(int index,string dict_name)
    {
        object[] args = new object[2];
        object result;
        args[0] = index;
        args[1] = dict_name;

        result = obj.InvokeMember("NAdyCzcJwDXTB", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int WheelUp()
    {
        object result;
        result = obj.InvokeMember("ngKqemLWGCRpZ", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int FoobarDrawLine(int hwnd,int x1,int y1,int x2,int y2,string color,int style,int width)
    {
        object[] args = new object[8];
        object result;
        args[0] = hwnd;
        args[1] = x1;
        args[2] = y1;
        args[3] = x2;
        args[4] = y2;
        args[5] = color;
        args[6] = style;
        args[7] = width;

        result = obj.InvokeMember("arLjnkvp", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int LockInput(int locks)
    {
        object[] args = new object[1];
        object result;
        args[0] = locks;

        result = obj.InvokeMember("KzSxtZQcuTVPK", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int SetMouseDelay(string tpe,int delay)
    {
        object[] args = new object[2];
        object result;
        args[0] = tpe;
        args[1] = delay;

        result = obj.InvokeMember("wBCNZPfj", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public int FaqCaptureFromFile(int x1,int y1,int x2,int y2,string file_name,int quality)
    {
        object[] args = new object[6];
        object result;
        args[0] = x1;
        args[1] = y1;
        args[2] = x2;
        args[3] = y2;
        args[4] = file_name;
        args[5] = quality;

        result = obj.InvokeMember("giXzPhyvPiwi", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string GetProcessInfo(int pid)
    {
        object[] args = new object[1];
        object result;
        args[0] = pid;

        result = obj.InvokeMember("JzxvJvYtGKmpqV", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int ReleaseRef()
    {
        object result;
        result = obj.InvokeMember("rftIpKLKAsK", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

    public int ReadDataAddrToBin(int hwnd,long addr,int length)
    {
        object[] args = new object[3];
        object result;
        args[0] = hwnd;
        args[1] = addr;
        args[2] = length;

        result = obj.InvokeMember("DUUswvf", BindingFlags.InvokeMethod, null, obj_object, args);
        return (int)result;
    }

    public string DoubleToData(double double_value)
    {
        object[] args = new object[1];
        object result;
        args[0] = double_value;

        result = obj.InvokeMember("LAZk", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public string ReadFileData(string file_name,int start_pos,int end_pos)
    {
        object[] args = new object[3];
        object result;
        args[0] = file_name;
        args[1] = start_pos;
        args[2] = end_pos;

        result = obj.InvokeMember("DdbYnjTcFZADX", BindingFlags.InvokeMethod, null, obj_object, args);
        return result.ToString();
    }

    public int GetTime()
    {
        object result;
        result = obj.InvokeMember("SmAdlQpX", BindingFlags.InvokeMethod, null, obj_object, null);
        return (int)result;
    }

}
