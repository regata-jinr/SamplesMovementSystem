using System.Runtime.InteropServices;

namespace SamplesMovementSystem.Core
{
  // Token: 0x02000004 RID: 4
  internal sealed class XemoDll
  {
    // Token: 0x06000002 RID: 2
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_TimeOut(double ComTimeout, double FifoTimeout);

    // Token: 0x06000003 RID: 3
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_FifoIdle(int FifoIdle);

    // Token: 0x06000004 RID: 4
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_IniCom(short ComNo, int Baud);

    // Token: 0x06000005 RID: 5
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_IniUsb(short ComNo, string SerialNo);

    // Token: 0x06000006 RID: 6
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_IniTCP(string IpAddr, int Port);

    // Token: 0x06000007 RID: 7
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_DeIniCom();

    // Token: 0x06000008 RID: 8
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_DeIniComPort(short ComNo);

    // Token: 0x06000009 RID: 9
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_ComSelect(short ComNo);

    // Token: 0x0600000A RID: 10
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_CsumMode(short mode);

    // Token: 0x0600000B RID: 11
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_GetDllVersion(global::System.Text.StringBuilder Version, short MaxLen);

    // Token: 0x0600000C RID: 12
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_ErrorCallBack(int ErrorFunc);

    // Token: 0x0600000D RID: 13
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_RunErrCallBack(int ErrorFunc);

    // Token: 0x0600000E RID: 14
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_GetErrCode();

    // Token: 0x0600000F RID: 15
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_GetErrState();

    // Token: 0x06000010 RID: 16
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_SetErrState(short State);

    // Token: 0x06000011 RID: 17
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_LastRunErr();

    // Token: 0x06000012 RID: 18
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_GetComErrText(short ErrCode, global::System.Text.StringBuilder ErrTxt, short MaxLen);

    // Token: 0x06000013 RID: 19
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_FifoFull();

    // Token: 0x06000014 RID: 20
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_FifoBreak();

    // Token: 0x06000015 RID: 21
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_DoEvents();

    // Token: 0x06000016 RID: 22
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_PutChar(short TrmChar);

    // Token: 0x06000017 RID: 23
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_PutWord(short TrmWord);

    // Token: 0x06000018 RID: 24
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void ML_PutLong(int TrmLong);

    // Token: 0x06000019 RID: 25
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_GetRcvState();

    // Token: 0x0600001A RID: 26
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_GetChar();

    // Token: 0x0600001B RID: 27
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short ML_GetWord();

    // Token: 0x0600001C RID: 28
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int ML_GetLong();

    // Token: 0x0600001D RID: 29
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_SysControl(short Control);

    // Token: 0x0600001E RID: 30
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_GetState();

    // Token: 0x0600001F RID: 31
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_SetFifo(short State);

    // Token: 0x06000020 RID: 32
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "NAME")]
    public static extern void MB_ResErr();

    // Token: 0x06000021 RID: 33
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Call(short ProgNr);

    // Token: 0x06000022 RID: 34
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Set(short Parameter, int Wert);

    // Token: 0x06000023 RID: 35
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_ASet(short Achse, short Parameter, int Wert);

    // Token: 0x06000024 RID: 36
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_IoSet(short ByteNr, short BitNr1, short BitNr2, short Parameter, short Wert);

    // Token: 0x06000025 RID: 37
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int MB_Get(short Parameter);

    // Token: 0x06000026 RID: 38
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int MB_AGet(short Achse, short Parameter);

    // Token: 0x06000027 RID: 39
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_IoGet(short ByteNr, short BitNr1, short BitNr2, short Parameter);

    // Token: 0x06000028 RID: 40
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Jog(short Achse, int Geschwindigkeit);

    // Token: 0x06000029 RID: 41
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Amove(short Achse, int Zielposition);

    // Token: 0x0600002A RID: 42
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Rmove(short Achse, int Verfahrweg);

    // Token: 0x0600002B RID: 43
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "NAME")]
    public static extern void MB_Home(short Achse);

    // Token: 0x0600002C RID: 44
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Stop(short Achse);

    // Token: 0x0600002D RID: 45
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_Busy(short Achse);

    // Token: 0x0600002E RID: 46
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Lin(short C_Mask, ref int Coordinate);

    // Token: 0x0600002F RID: 47
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Lin0(short C_Mask, ref int Coordinate);

    // Token: 0x06000030 RID: 48
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Lin1(short C_Mask, ref int Coordinate);

    // Token: 0x06000031 RID: 49
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Circle(int Radius, int Anfangswinkel, int Endwinkel);

    // Token: 0x06000032 RID: 50
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Arc(short C_Mask, int Radius, ref int Coordinate);

    // Token: 0x06000033 RID: 51
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Arcc(short C_Mask, int Mx, int My_Renamed, ref int Coordinate);

    // Token: 0x06000034 RID: 52
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Arcw(short C_Mask, int Mx, int My_Renamed, ref int Coordinate);

    // Token: 0x06000035 RID: 53
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Out(short ByteNr, short BitNr1, short BitNr2, short Wert);

    // Token: 0x06000036 RID: 54
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Sout(short ByteNr, short BitNr1, short BitNr2, short Wert);

    // Token: 0x06000037 RID: 55
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_Rout(short ByteNr, short BitNr1, short BitNr2);

    // Token: 0x06000038 RID: 56
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_In(short ByteNr, short BitNr1, short BitNr2);

    // Token: 0x06000039 RID: 57
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Waitinp(short ByteNr, short BitNr1, short BitNr2, short Wert);

    // Token: 0x0600003A RID: 58
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_Inw(short ByteNr);

    // Token: 0x0600003B RID: 59
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Outw(short ByteNr, short Wert);

    // Token: 0x0600003C RID: 60
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_Routw(short ByteNr);

    // Token: 0x0600003D RID: 61
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Print(string Text);

    // Token: 0x0600003E RID: 62
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Printxy(short x, short y, string Text);

    // Token: 0x0600003F RID: 63
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Cpos(short x, short y);

    // Token: 0x06000040 RID: 64
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Ctype(short crType);

    // Token: 0x06000041 RID: 65
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_TextAttrib(short Attrib);

    // Token: 0x06000042 RID: 66
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Cls();

    // Token: 0x06000043 RID: 67
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Cleol();

    // Token: 0x06000044 RID: 68
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_KeyState();

    // Token: 0x06000045 RID: 69
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_KeyPressed();

    // Token: 0x06000046 RID: 70
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern short MB_KeyRead();

    // Token: 0x06000047 RID: 71
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_KeyClear();

    // Token: 0x06000048 RID: 72
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_KeyLed(short Key, short Onoff);

    // Token: 0x06000049 RID: 73
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Delay(int Verweilzeit);

    // Token: 0x0600004A RID: 74
    [DllImport("Xemo64.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void MB_Still(short Achse);

    // Token: 0x040000EA RID: 234
    public const string XEMO_DLL_VESRION = "2.33";
  }
}
