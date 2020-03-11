using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace vbConvert
{
  // Token: 0x02000004 RID: 4
  [global::Microsoft.VisualBasic.CompilerServices.StandardModule]
  internal sealed class XemoDll
  {
    // Token: 0x06000002 RID: 2
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_TimeOut(double ComTimeout, double FifoTimeout);

    // Token: 0x06000003 RID: 3
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_FifoIdle(int FifoIdle);

    // Token: 0x06000004 RID: 4
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_IniCom(short ComNo, int Baud);

    // Token: 0x06000005 RID: 5
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_IniUsb(short ComNo, string SerialNo);

    // Token: 0x06000006 RID: 6
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_IniTCP(string IpAddr, int Port);

    // Token: 0x06000007 RID: 7
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_DeIniCom();

    // Token: 0x06000008 RID: 8
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_DeIniComPort(short ComNo);

    // Token: 0x06000009 RID: 9
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_ComSelect(short ComNo);

    // Token: 0x0600000A RID: 10
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_CsumMode(short mode);

    // Token: 0x0600000B RID: 11
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_GetDllVersion(global::System.Text.StringBuilder Version, short MaxLen);

    // Token: 0x0600000C RID: 12
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_ErrorCallBack(int ErrorFunc);

    // Token: 0x0600000D RID: 13
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_RunErrCallBack(int ErrorFunc);

    // Token: 0x0600000E RID: 14
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_GetErrCode();

    // Token: 0x0600000F RID: 15
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_GetErrState();

    // Token: 0x06000010 RID: 16
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_SetErrState(short State);

    // Token: 0x06000011 RID: 17
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_LastRunErr();

    // Token: 0x06000012 RID: 18
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_GetComErrText(short ErrCode, global::System.Text.StringBuilder ErrTxt, short MaxLen);

    // Token: 0x06000013 RID: 19
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_FifoFull();

    // Token: 0x06000014 RID: 20
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_FifoBreak();

    // Token: 0x06000015 RID: 21
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_DoEvents();

    // Token: 0x06000016 RID: 22
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_PutChar(short TrmChar);

    // Token: 0x06000017 RID: 23
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_PutWord(short TrmWord);

    // Token: 0x06000018 RID: 24
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void ML_PutLong(int TrmLong);

    // Token: 0x06000019 RID: 25
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_GetRcvState();

    // Token: 0x0600001A RID: 26
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_GetChar();

    // Token: 0x0600001B RID: 27
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short ML_GetWord();

    // Token: 0x0600001C RID: 28
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern int ML_GetLong();

    // Token: 0x0600001D RID: 29
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_SysControl(short Control);

    // Token: 0x0600001E RID: 30
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_GetState();

    // Token: 0x0600001F RID: 31
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_SetFifo(short State);

    // Token: 0x06000020 RID: 32
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3, EntryPoint = "NAME")]
    public static extern void MB_ResErr();

    // Token: 0x06000021 RID: 33
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Call(short ProgNr);

    // Token: 0x06000022 RID: 34
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Set(short Parameter, int Wert);

    // Token: 0x06000023 RID: 35
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_ASet(short Achse, short Parameter, int Wert);

    // Token: 0x06000024 RID: 36
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_IoSet(short ByteNr, short BitNr1, short BitNr2, short Parameter, short Wert);

    // Token: 0x06000025 RID: 37
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern int MB_Get(short Parameter);

    // Token: 0x06000026 RID: 38
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern int MB_AGet(short Achse, short Parameter);

    // Token: 0x06000027 RID: 39
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_IoGet(short ByteNr, short BitNr1, short BitNr2, short Parameter);

    // Token: 0x06000028 RID: 40
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Jog(short Achse, int Geschwindigkeit);

    // Token: 0x06000029 RID: 41
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Amove(short Achse, int Zielposition);

    // Token: 0x0600002A RID: 42
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Rmove(short Achse, int Verfahrweg);

    // Token: 0x0600002B RID: 43
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3, EntryPoint = "NAME")]
    public static extern void MB_Home(short Achse);

    // Token: 0x0600002C RID: 44
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Stop(short Achse);

    // Token: 0x0600002D RID: 45
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_Busy(short Achse);

    // Token: 0x0600002E RID: 46
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Lin(short C_Mask, ref int Coordinate);

    // Token: 0x0600002F RID: 47
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Lin0(short C_Mask, ref int Coordinate);

    // Token: 0x06000030 RID: 48
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Lin1(short C_Mask, ref int Coordinate);

    // Token: 0x06000031 RID: 49
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Circle(int Radius, int Anfangswinkel, int Endwinkel);

    // Token: 0x06000032 RID: 50
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Arc(short C_Mask, int Radius, ref int Coordinate);

    // Token: 0x06000033 RID: 51
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Arcc(short C_Mask, int Mx, int My_Renamed, ref int Coordinate);

    // Token: 0x06000034 RID: 52
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Arcw(short C_Mask, int Mx, int My_Renamed, ref int Coordinate);

    // Token: 0x06000035 RID: 53
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Out(short ByteNr, short BitNr1, short BitNr2, short Wert);

    // Token: 0x06000036 RID: 54
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Sout(short ByteNr, short BitNr1, short BitNr2, short Wert);

    // Token: 0x06000037 RID: 55
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_Rout(short ByteNr, short BitNr1, short BitNr2);

    // Token: 0x06000038 RID: 56
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_In(short ByteNr, short BitNr1, short BitNr2);

    // Token: 0x06000039 RID: 57
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Waitinp(short ByteNr, short BitNr1, short BitNr2, short Wert);

    // Token: 0x0600003A RID: 58
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_Inw(short ByteNr);

    // Token: 0x0600003B RID: 59
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Outw(short ByteNr, short Wert);

    // Token: 0x0600003C RID: 60
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_Routw(short ByteNr);

    // Token: 0x0600003D RID: 61
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Print(string Text);

    // Token: 0x0600003E RID: 62
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Printxy(short x, short y, string Text);

    // Token: 0x0600003F RID: 63
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Cpos(short x, short y);

    // Token: 0x06000040 RID: 64
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Ctype(short crType);

    // Token: 0x06000041 RID: 65
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_TextAttrib(short Attrib);

    // Token: 0x06000042 RID: 66
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Cls();

    // Token: 0x06000043 RID: 67
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Cleol();

    // Token: 0x06000044 RID: 68
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_KeyState();

    // Token: 0x06000045 RID: 69
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_KeyPressed();

    // Token: 0x06000046 RID: 70
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern short MB_KeyRead();

    // Token: 0x06000047 RID: 71
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_KeyClear();

    // Token: 0x06000048 RID: 72
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_KeyLed(short Key, short Onoff);

    // Token: 0x06000049 RID: 73
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Delay(int Verweilzeit);

    // Token: 0x0600004A RID: 74
    [global::System.Runtime.InteropServices.DllImport("Xemo64.dll", CallingConvention = 3)]
    public static extern void MB_Still(short Achse);

    // Token: 0x040000EA RID: 234
    public const string XEMO_DLL_VESRION = "2.33";
  }
}
