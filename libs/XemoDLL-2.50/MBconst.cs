using System;
using Microsoft.VisualBasic.CompilerServices;

namespace vbConvert
{
  // Token: 0x02000002 RID: 2
  [global::Microsoft.VisualBasic.CompilerServices.StandardModule]
  internal sealed class MBconst
  {
    // Token: 0x04000001 RID: 1
    public const int STATE_F0 = 1;

    // Token: 0x04000002 RID: 2
    public const int STATE_F1 = 2;

    // Token: 0x04000003 RID: 3
    public const int STATE_F2 = 4;

    // Token: 0x04000004 RID: 4
    public const int STATE_ERR = 8;

    // Token: 0x04000005 RID: 5
    public const int STATE_MS = 16;

    // Token: 0x04000006 RID: 6
    public const int STATE_OR0 = 32;

    // Token: 0x04000007 RID: 7
    public const int STATE_RUN = 64;

    // Token: 0x04000008 RID: 8
    public const int PSTATE_PSTATE = 7;

    // Token: 0x04000009 RID: 9
    public const int PSTATE_ERROR = 8;

    // Token: 0x0400000A RID: 10
    public const int PSTATE_ONERROR = 16;

    // Token: 0x0400000B RID: 11
    public const int PSTATE_DEBUG = 64;

    // Token: 0x0400000C RID: 12
    public const int STATE_FIFO = 3;

    // Token: 0x0400000D RID: 13
    public const short STATE_FIFO_EMPTY = 0;

    // Token: 0x0400000E RID: 14
    public const short STATE_FIFO_LOW = 1;

    // Token: 0x0400000F RID: 15
    public const short STATE_FIFO_HIGH = 2;

    // Token: 0x04000010 RID: 16
    public const short STATE_FIFO_FULL = 3;

    // Token: 0x04000011 RID: 17
    public const short m_Reset = 1;

    // Token: 0x04000012 RID: 18
    public const short m_Break = 2;

    // Token: 0x04000013 RID: 19
    public const short m_Halt = 3;

    // Token: 0x04000014 RID: 20
    public const short m_PrgQuit = 100;

    // Token: 0x04000015 RID: 21
    public const short m_DebugShell = 101;

    // Token: 0x04000016 RID: 22
    public const short m_OnlineShell = 102;

    // Token: 0x04000017 RID: 23
    public const short m_FfDisable = 1;

    // Token: 0x04000018 RID: 24
    public const short m_FfEnable = 2;

    // Token: 0x04000019 RID: 25
    public const short m_FfClear = 3;

    // Token: 0x0400001A RID: 26
    public const int m_Key_F1 = 315;

    // Token: 0x0400001B RID: 27
    public const int m_Key_F2 = 316;

    // Token: 0x0400001C RID: 28
    public const int m_Key_F3 = 317;

    // Token: 0x0400001D RID: 29
    public const int m_Key_F4 = 318;

    // Token: 0x0400001E RID: 30
    public const int m_Key_Bs = 8;

    // Token: 0x0400001F RID: 31
    public const int m_Key_Enter = 13;

    // Token: 0x04000020 RID: 32
    public const int m_Key_Up = 328;

    // Token: 0x04000021 RID: 33
    public const int m_Key_Down = 336;

    // Token: 0x04000022 RID: 34
    public const int m_Key_Right = 333;

    // Token: 0x04000023 RID: 35
    public const int m_Key_Left = 331;

    // Token: 0x04000024 RID: 36
    public const short m_LedOff = 0;

    // Token: 0x04000025 RID: 37
    public const short m_LedOn = 1;

    // Token: 0x04000026 RID: 38
    public const short m_LedBlink = 10;

    // Token: 0x04000027 RID: 39
    public const short m_LedFlash = 11;

    // Token: 0x04000028 RID: 40
    public const short m_X = 0;

    // Token: 0x04000029 RID: 41
    public const short m_Y = 1;

    // Token: 0x0400002A RID: 42
    public const short m_Z = 2;

    // Token: 0x0400002B RID: 43
    public const short m_A = 3;

    // Token: 0x0400002C RID: 44
    public const short m_XALL = 255;

    // Token: 0x0400002D RID: 45
    public const short m_ALL = 254;

    // Token: 0x0400002E RID: 46
    public const short m_COM1 = 1;

    // Token: 0x0400002F RID: 47
    public const short m_BD9600 = 5;

    // Token: 0x04000030 RID: 48
    public const short m_BD19200 = 6;

    // Token: 0x04000031 RID: 49
    public const short m_BD28800 = 7;

    // Token: 0x04000032 RID: 50
    public const short m_BD38400 = 8;

    // Token: 0x04000033 RID: 51
    public const short m_BD57600 = 9;

    // Token: 0x04000034 RID: 52
    public const short USB_OFF = 0;

    // Token: 0x04000035 RID: 53
    public const short USB_AUTO = 1;

    // Token: 0x04000036 RID: 54
    public const short USB_ONLY = 2;

    // Token: 0x04000037 RID: 55
    public const short m_Off = 0;

    // Token: 0x04000038 RID: 56
    public const short BOT_SPARM_NO = 1000;

    // Token: 0x04000039 RID: 57
    public const short m_State = 1000;

    // Token: 0x0400003A RID: 58
    public const short m_Version = 1004;

    // Token: 0x0400003B RID: 59
    public const short m_Release = 1005;

    // Token: 0x0400003C RID: 60
    public const short m_ComRelease = 1006;

    // Token: 0x0400003D RID: 61
    public const short m_Extent = 1007;

    // Token: 0x0400003E RID: 62
    public const short m_Clock = 1008;

    // Token: 0x0400003F RID: 63
    public const short m_ErrNo = 1010;

    // Token: 0x04000040 RID: 64
    public const short m_ErrState = 1011;

    // Token: 0x04000041 RID: 65
    public const short m_ErrLine = 1012;

    // Token: 0x04000042 RID: 66
    public const short m_ErrAxis = 1013;

    // Token: 0x04000043 RID: 67
    public const short m_ErrParam = 1014;

    // Token: 0x04000044 RID: 68
    public const short m_SubError = 1015;

    // Token: 0x04000045 RID: 69
    public const short m_EnaOptCode = 1017;

    // Token: 0x04000046 RID: 70
    public const short m_ErrCount = 1018;

    // Token: 0x04000047 RID: 71
    public const short m_RecentErr = 1019;

    // Token: 0x04000048 RID: 72
    public const short m_FifoSize = 1021;

    // Token: 0x04000049 RID: 73
    public const short m_FifoLevel = 1022;

    // Token: 0x0400004A RID: 74
    public const short m_FifoLeft = 1023;

    // Token: 0x0400004B RID: 75
    public const short m_FifoMarker = 1024;

    // Token: 0x0400004C RID: 76
    public const short m_Mode1 = 1030;

    // Token: 0x0400004D RID: 77
    public const short m_CanMode = 1034;

    // Token: 0x0400004E RID: 78
    public const short m_OtSelect = 1035;

    // Token: 0x0400004F RID: 79
    public const short m_Can2Mode = 1036;

    // Token: 0x04000050 RID: 80
    public const short m_Can1Device = 1038;

    // Token: 0x04000051 RID: 81
    public const short m_Can2Device = 1039;

    // Token: 0x04000052 RID: 82
    public const short m_IpGroup = 1040;

    // Token: 0x04000053 RID: 83
    public const short m_H1Trans = 1041;

    // Token: 0x04000054 RID: 84
    public const short m_H2Trans = 1042;

    // Token: 0x04000055 RID: 85
    public const short m_IpSyncClk = 1043;

    // Token: 0x04000056 RID: 86
    public const short m_BkPwmCycle = 1050;

    // Token: 0x04000057 RID: 87
    public const short m_BkPwmDuty = 1051;

    // Token: 0x04000058 RID: 88
    public const short m_AnlIn = 1060;

    // Token: 0x04000059 RID: 89
    public const short m_AnlOut = 1061;

    // Token: 0x0400005A RID: 90
    public const short m_OvrIn = 1062;

    // Token: 0x0400005B RID: 91
    public const short m_JoyX = 1063;

    // Token: 0x0400005C RID: 92
    public const short m_JoyY = 1064;

    // Token: 0x0400005D RID: 93
    public const short m_HandWheel = 1070;

    // Token: 0x0400005E RID: 94
    public const short m_Encoder = 1071;

    // Token: 0x0400005F RID: 95
    public const short m_EncIdx = 1072;

    // Token: 0x04000060 RID: 96
    public const short m_EncIpr = 1073;

    // Token: 0x04000061 RID: 97
    public const short m_Ovride = 1075;

    // Token: 0x04000062 RID: 98
    public const short m_Omode = 1076;

    // Token: 0x04000063 RID: 99
    public const short m_OvScale = 1077;

    // Token: 0x04000064 RID: 100
    public const short m_SAnlIn0 = 1080;

    // Token: 0x04000065 RID: 101
    public const short m_SAnlIn1 = 1081;

    // Token: 0x04000066 RID: 102
    public const short m_SAnlIn2 = 1082;

    // Token: 0x04000067 RID: 103
    public const short m_VoMode = 1090;

    // Token: 0x04000068 RID: 104
    public const short m_VoScale = 1091;

    // Token: 0x04000069 RID: 105
    public const short m_VoOffs = 1092;

    // Token: 0x0400006A RID: 106
    public const short m_VoMin = 1093;

    // Token: 0x0400006B RID: 107
    public const short m_VoMax = 1094;

    // Token: 0x0400006C RID: 108
    public const short m_AnlFSel = 1100;

    // Token: 0x0400006D RID: 109
    public const short m_AFType = 1101;

    // Token: 0x0400006E RID: 110
    public const short m_AFSTime = 1102;

    // Token: 0x0400006F RID: 111
    public const short m_AFSpread = 1103;

    // Token: 0x04000070 RID: 112
    public const short m_AFHyster = 1104;

    // Token: 0x04000071 RID: 113
    public const short m_AFTrack = 1105;

    // Token: 0x04000072 RID: 114
    public const short m_AFAverage = 1106;

    // Token: 0x04000073 RID: 115
    public const short TOP_SPARM_NO = 1250;

    // Token: 0x04000074 RID: 116
    public const short BOT_SUPARM_NO = 1400;

    // Token: 0x04000075 RID: 117
    public const short m_ComPort = 1400;

    // Token: 0x04000076 RID: 118
    public const short m_Bdrate = 1401;

    // Token: 0x04000077 RID: 119
    public const short m_DsplContr = 1402;

    // Token: 0x04000078 RID: 120
    public const short m_PonComDelay = 1403;

    // Token: 0x04000079 RID: 121
    public const short m_USBConfig = 1404;

    // Token: 0x0400007A RID: 122
    public const short m_CanTerm = 1405;

    // Token: 0x0400007B RID: 123
    public const short m_BKType = 1406;

    // Token: 0x0400007C RID: 124
    public const short TOP_SUPARM_NO = 1406;

    // Token: 0x0400007D RID: 125
    public const short BOT_XPARM_NO = 2000;

    // Token: 0x0400007E RID: 126
    public const short m_Speed = 2000;

    // Token: 0x0400007F RID: 127
    public const short m_Accel = 2001;

    // Token: 0x04000080 RID: 128
    public const short m_Decel = 2002;

    // Token: 0x04000081 RID: 129
    public const short m_Vmin = 2003;

    // Token: 0x04000082 RID: 130
    public const short m_LDecel = 2004;

    // Token: 0x04000083 RID: 131
    public const short m_MaxVel = 2008;

    // Token: 0x04000084 RID: 132
    public const short m_MaxAcc = 2009;

    // Token: 0x04000085 RID: 133
    public const short m_IpLink = 2010;

    // Token: 0x04000086 RID: 134
    public const short m_IpAxis = 2011;

    // Token: 0x04000087 RID: 135
    public const short m_NodeId = 2012;

    // Token: 0x04000088 RID: 136
    public const short m_H1Speed = 2020;

    // Token: 0x04000089 RID: 137
    public const short m_H2Speed = 2021;

    // Token: 0x0400008A RID: 138
    public const short m_H3Speed = 2022;

    // Token: 0x0400008B RID: 139
    public const short m_HOffset = 2023;

    // Token: 0x0400008C RID: 140
    public const short m_HVerify = 2024;

    // Token: 0x0400008D RID: 141
    public const short m_HMethod = 2025;

    // Token: 0x0400008E RID: 142
    public const short m_OpMode = 2030;

    // Token: 0x0400008F RID: 143
    public const short m_Current = 2031;

    // Token: 0x04000090 RID: 144
    public const short m_FErrWin = 2032;

    // Token: 0x04000091 RID: 145
    public const short m_TPosWin = 2033;

    // Token: 0x04000092 RID: 146
    public const short m_TPosTime = 2034;

    // Token: 0x04000093 RID: 147
    public const short m_BrakeOutp = 2035;

    // Token: 0x04000094 RID: 148
    public const short m_BrkDelay1 = 2036;

    // Token: 0x04000095 RID: 149
    public const short m_BrkDelay2 = 2037;

    // Token: 0x04000096 RID: 150
    public const short m_Uscale = 2040;

    // Token: 0x04000097 RID: 151
    public const short m_Iscale = 2041;

    // Token: 0x04000098 RID: 152
    public const short m_Zero = 2042;

    // Token: 0x04000099 RID: 153
    public const short m_Origin = 2043;

    // Token: 0x0400009A RID: 154
    public const short m_Refp = 2044;

    // Token: 0x0400009B RID: 155
    public const short m_SlLimit = 2045;

    // Token: 0x0400009C RID: 156
    public const short m_SrLimit = 2046;

    // Token: 0x0400009D RID: 157
    public const short m_Pmode = 2047;

    // Token: 0x0400009E RID: 158
    public const short m_BLash = 2048;

    // Token: 0x0400009F RID: 159
    public const short m_Gantry = 2049;

    // Token: 0x040000A0 RID: 160
    public const short m_Micro = 2050;

    // Token: 0x040000A1 RID: 161
    public const short m_MPhi = 2051;

    // Token: 0x040000A2 RID: 162
    public const short m_StopCurr = 2052;

    // Token: 0x040000A3 RID: 163
    public const short m_APos = 2061;

    // Token: 0x040000A4 RID: 164
    public const short m_RPos = 2062;

    // Token: 0x040000A5 RID: 165
    public const short m_RVelo = 2063;

    // Token: 0x040000A6 RID: 166
    public const short m_XEncoder = 2064;

    // Token: 0x040000A7 RID: 167
    public const short m_XOvr = 2075;

    // Token: 0x040000A8 RID: 168
    public const short m_XOmode = 2076;

    // Token: 0x040000A9 RID: 169
    public const short m_EgState = 2090;

    // Token: 0x040000AA RID: 170
    public const short m_EgMode = 2092;

    // Token: 0x040000AB RID: 171
    public const short m_EgSource = 2093;

    // Token: 0x040000AC RID: 172
    public const short m_EgMult = 2094;

    // Token: 0x040000AD RID: 173
    public const short TOP_XPARM_NO = 2094;

    // Token: 0x040000AE RID: 174
    public const short BOT_IPARM_NO = 3000;

    // Token: 0x040000AF RID: 175
    public const short m_IpSpeed = 3000;

    // Token: 0x040000B0 RID: 176
    public const short m_IpAccel = 3001;

    // Token: 0x040000B1 RID: 177
    public const short m_IpDecel = 3002;

    // Token: 0x040000B2 RID: 178
    public const short m_IpVmin = 3003;

    // Token: 0x040000B3 RID: 179
    public const short m_IpLDecel = 3004;

    // Token: 0x040000B4 RID: 180
    public const short m_IpVend = 3005;

    // Token: 0x040000B5 RID: 181
    public const short m_IpFeed = 3006;

    // Token: 0x040000B6 RID: 182
    public const short m_IpMaxVel = 3008;

    // Token: 0x040000B7 RID: 183
    public const short m_IpMaxAcc = 3009;

    // Token: 0x040000B8 RID: 184
    public const short m_IpDim = 3010;

    // Token: 0x040000B9 RID: 185
    public const short m_IpUnit = 3011;

    // Token: 0x040000BA RID: 186
    public const short m_IpLaFact = 3013;

    // Token: 0x040000BB RID: 187
    public const short m_IpLaCvFact = 3014;

    // Token: 0x040000BC RID: 188
    public const short m_IpLaTprof = 3015;

    // Token: 0x040000BD RID: 189
    public const short m_IpTrigger = 3017;

    // Token: 0x040000BE RID: 190
    public const short m_IpTrgTime = 3018;

    // Token: 0x040000BF RID: 191
    public const short m_IpTrgOutp = 3019;

    // Token: 0x040000C0 RID: 192
    public const short m_IpVelo = 3063;

    // Token: 0x040000C1 RID: 193
    public const short m_IpOvr = 3075;

    // Token: 0x040000C2 RID: 194
    public const short m_IpOmode = 3076;

    // Token: 0x040000C3 RID: 195
    public const short TOP_IPARM_NO = 3076;

    // Token: 0x040000C4 RID: 196
    public const short BOT_IOPARM_NO = 4000;

    // Token: 0x040000C5 RID: 197
    public const short m_InPolarity = 4000;

    // Token: 0x040000C6 RID: 198
    public const short m_OutPolarity = 4001;

    // Token: 0x040000C7 RID: 199
    public const short TOP_IOPARM_NO = 4003;

    // Token: 0x040000C8 RID: 200
    public const int C_X = 1;

    // Token: 0x040000C9 RID: 201
    public const int C_Y = 2;

    // Token: 0x040000CA RID: 202
    public const int C_XY = 3;

    // Token: 0x040000CB RID: 203
    public const int C_Z = 4;

    // Token: 0x040000CC RID: 204
    public const int C_XZ = 5;

    // Token: 0x040000CD RID: 205
    public const int C_YZ = 6;

    // Token: 0x040000CE RID: 206
    public const int C_XYZ = 7;

    // Token: 0x040000CF RID: 207
    public const int C_A = 8;

    // Token: 0x040000D0 RID: 208
    public const int C_XA = 9;

    // Token: 0x040000D1 RID: 209
    public const int C_YA = 10;

    // Token: 0x040000D2 RID: 210
    public const int C_XYA = 11;

    // Token: 0x040000D3 RID: 211
    public const int C_ZA = 12;

    // Token: 0x040000D4 RID: 212
    public const int C_XZA = 13;

    // Token: 0x040000D5 RID: 213
    public const int C_YZA = 14;

    // Token: 0x040000D6 RID: 214
    public const int C_XYZA = 15;

    // Token: 0x040000D7 RID: 215
    public const short ERR_XEMO = 1;

    // Token: 0x040000D8 RID: 216
    public const short ERR_COM_PORT = 2;

    // Token: 0x040000D9 RID: 217
    public const short ERR_RCV_OVERFLOW = 3;

    // Token: 0x040000DA RID: 218
    public const short ERR_RCV_TIMEOUT = 4;

    // Token: 0x040000DB RID: 219
    public const short ERR_FIFO_TIMEOUT = 5;

    // Token: 0x040000DC RID: 220
    public const short ERR_GETSTATE = 6;

    // Token: 0x040000DD RID: 221
    public const short ERR_RCV_CMD = 7;

    // Token: 0x040000DE RID: 222
    public const short ERR_TRM_TIMEOUT = 8;

    // Token: 0x040000DF RID: 223
    public const short ERR_CHECKSUM = 9;

    // Token: 0x040000E0 RID: 224
    public const short ERR_COM_SELECT = 10;

    // Token: 0x040000E1 RID: 225
    public const short ERR_MAX_THREADS = 11;

    // Token: 0x040000E2 RID: 226
    public const short ERR_GET_THREAD_COM = 12;

    // Token: 0x040000E3 RID: 227
    public const short ERR_LEFT = -1;

    // Token: 0x040000E4 RID: 228
    public const short NO_ERR = 0;

    // Token: 0x040000E5 RID: 229
    public const short ERR_XEMO_PENDING = 1;

    // Token: 0x040000E6 RID: 230
    public const short ERR_COM_PENDING = 2;

    // Token: 0x040000E7 RID: 231
    public const short ERR_RETRY = 3;

    // Token: 0x040000E8 RID: 232
    public const short ERR_CANCEL = 4;

    // Token: 0x040000E9 RID: 233
    public const short ERR_COM_DEINI = 5;
  }
}
