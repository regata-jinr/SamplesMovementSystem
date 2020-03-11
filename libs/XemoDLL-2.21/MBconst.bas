'  Bits im Systemstatus
' -------------------------------
Public Const STATE_F0 = &H01
Public Const STATE_F1 = &H02
Public Const STATE_F2 = &H04
Public Const STATE_ERR = &H08
Public Const STATE_MS = &H10
Public Const STATE_OR0 = &H20
Public Const STATE_RUN = &H40

Public Const PSTATE_PSTATE = &H07
Public Const PSTATE_ERROR = &H08
Public Const PSTATE_ONERROR = &H10
Public Const PSTATE_DEBUG = &H40

Public Const STATE_FIFO = &H03
Public Const STATE_FIFO_EMPTY = 0
Public Const STATE_FIFO_LOW = 1
Public Const STATE_FIFO_HIGH = 2
Public Const STATE_FIFO_FULL = 3

'  Syscontrol Kommandos	
Public Const m_Reset = 1		'  System Reset
Public Const m_Break = 2		'  MotionBasic Programm unterbrechen
Public Const m_Halt = 3		'  MotionBasic Programm anhalten

Public Const m_PrgQuit = 100		'  MotionBasic Programm benden
Public Const m_DebugShell = 101		'  Zur Debug-Shell wechseln
Public Const m_OnlineShell = 102		'  Zur Online-Shell wechseln

'  SetFifo FifoStatus
' -------------------------------
Public Const m_FfDisable = 1
Public Const m_FfEnable = 2
Public Const m_FfClear = 3
Public Const m_FfOffline = 4	'  Vorläufige Implementation
Public Const m_FfOnline = 5	'  Alle eingehende Zeichen werden ignoriert


'  Tastatur-Codes
Public Const m_Key_F1 = &H13b
Public Const m_Key_F2 = &H13c
Public Const m_Key_F3 = &H13d
Public Const m_Key_F4 = &H13e
Public Const m_Key_F5 = &H13f	'  neu für OT240
Public Const m_Key_F6 = &H140	'  neu für OT240
Public Const m_Key_F7 = &H141	'  neu für OT240
Public Const m_Key_F8 = &H142	'  neu für OT240
Public Const m_Key_Bs = &H08
Public Const m_Key_Enter = &H0d
Public Const m_Key_Up = &H148
Public Const m_Key_Down = &H150
Public Const m_Key_Right = &H14d
Public Const m_Key_Left = &H14b

'  KeyLed-Codes
' -------------------------------
Public Const m_LedOff = 0
Public Const m_LedOn = 1
Public Const m_LedBlink = 10
Public Const m_LedFlash = 11

'  Die Achsbezeichner
' -------------------------------
Public Const m_X = 0
Public Const m_Y = 1
Public Const m_Z = 2
Public Const m_A = 3
Public Const m_XALL = 255		'  Alle Achsen / Achsparameter
Public Const m_ALL = 254		'  Alle Achs- und Bahnparameter

'  Seriell IO
Public Const m_COM1 = 1
Public Const m_BD9600 = 5
Public Const m_BD19200 = 6
Public Const m_BD28800 = 7
Public Const m_BD38400 = 8
Public Const m_BD57600 = 9

'  USB
Public Const USB_OFF = 0
Public Const USB_AUTO = 1
Public Const USB_ONLY = 2

'  Diverse
Public Const m_Off = 0

'  Systemparameter
Public Const BOT_SPARM_NO = 1000

Public Const m_State = 1000
Public Const m_Version = 1004
Public Const m_Release = 1005
Public Const m_ComRelease = 1006
Public Const m_Extent = 1007
Public Const m_Clock = 1008

Public Const m_ErrNo = 1010
Public Const m_ErrState = 1011
Public Const m_ErrLine = 1012
Public Const m_ErrAxis = 1013
Public Const m_ErrParam = 1014
Public Const m_SubError = 1015

Public Const m_EnaOptCode = 1017
Public Const m_ErrCount = 1018
Public Const m_RecentErr = 1019

Public Const m_FifoSize = 1021
Public Const m_FifoLevel = 1022
Public Const m_FifoLeft = 1023
Public Const m_FifoMarker = 1024
Public Const m_FifoLow = 1025

Public Const m_Mode1 = 1030
Public Const m_ModeUsb = 1033
Public Const m_CanMode = 1034
Public Const m_OtSelect = 1035
Public Const m_Can2Mode = 1036
Public Const m_Can1Device = 1038
Public Const m_Can2Device = 1039

Public Const m_IpGroup = 1040
Public Const m_H1Trans = 1041
Public Const m_H2Trans = 1042
Public Const m_IpSyncClk = 1043

Public Const m_BkPwmCycle = 1050
Public Const m_BkPwmDuty = 1051

Public Const m_AnlIn = 1060
Public Const m_AnlOut = 1061
Public Const m_OvrIn = 1062
Public Const m_JoyX = 1063
Public Const m_JoyY = 1064

Public Const m_HandWheel = 1070
Public Const m_Encoder = 1071
Public Const m_EncIdx = 1072
Public Const m_EncIpr = 1073
Public Const m_EncCpStat = 1074

Public Const m_Ovride = 1075
Public Const m_Omode = 1076
Public Const m_OvScale = 1077

Public Const m_SAnlIn0 = 1080
Public Const m_SAnlIn1 = 1081
Public Const m_SAnlIn2 = 1082

Public Const m_VoMode = 1090
Public Const m_VoScale = 1091
Public Const m_VoOffs = 1092
Public Const m_VoMin = 1093
Public Const m_VoMax = 1094

Public Const m_AnlFSel = 1100
Public Const m_AFType = 1101
Public Const m_AFSTime = 1102
Public Const m_AFSpread = 1103
Public Const m_AFHyster = 1104
Public Const m_AFTrack = 1105
Public Const m_AFAverage = 1106

Public Const m_IsoLineNr = 1110
Public Const m_IsoGScale = 1111
Public Const m_IsoFScale = 1112
Public Const m_IsoSScale = 1113

Public Const m_IdxFunc = 1120
Public Const m_IdxFcMode = 1121

'  ab 1200 sind zunächst nicht dokumetierte
'  Systemparameter zur Geräteüberwachung
Public Const TOP_SPARM_NO = 1250	'  Grösste Systemparameter-Nummer

'  Setup-Parameter
'  Die Setup-Parameter sind besonders schreibgeschützt
'  und können nur beschrieben werden, wenn der Hexschalter auf 0x0e steht
Public Const BOT_SUPARM_NO = 1400
Public Const m_ComPort = 1400	'  RS232 Programmier-Schnittstelle auswählen
Public Const m_Bdrate = 1401	'  Baudrate der RS232 Schnittstelle festlegen
Public Const m_DsplContr = 1402	'  Xemo Display Kontrast
Public Const m_PonComDelay = 1403	'  Power On ComPort Delay
Public Const m_USBConfig = 1404	'  USB Schnittstelle konfigurieren
Public Const m_CanTerm = 1405	'  CAN Abschlusswiderstände
Public Const m_BKType = 1406	'  Beckhoff-Koppler 5120 oder BK5100 scoe 2005-03-15
Public Const TOP_SUPARM_NO = 1406

'  Achsparameter	
Public Const BOT_XPARM_NO = 2000

Public Const m_Speed = 2000
Public Const m_Accel = 2001
Public Const m_Decel = 2002
Public Const m_Vmin = 2003
Public Const m_LDecel = 2004
Public Const m_MaxVel = 2008
Public Const m_MaxAcc = 2009
Public Const m_IpLink = 2010
Public Const m_IpAxis = 2011

Public Const m_NodeId = 2012

Public Const m_H1Speed = 2020
Public Const m_H2Speed = 2021
Public Const m_H3Speed = 2022
Public Const m_HOffset = 2023
Public Const m_HVerify = 2024
Public Const m_HMethod = 2025

Public Const m_OpMode = 2030
Public Const m_Current = 2031
Public Const m_FErrWin = 2032
Public Const m_TPosWin = 2033
Public Const m_TPosTime = 2034
Public Const m_BrakeOutp = 2035
Public Const m_BrkDelay1 = 2036
Public Const m_BrkDelay2 = 2037

Public Const m_Uscale = 2040
Public Const m_Iscale = 2041

Public Const m_Zero = 2042
Public Const m_Origin = 2043
Public Const m_Refp = 2044
Public Const m_SlLimit = 2045
Public Const m_SrLimit = 2046
Public Const m_Pmode = 2047
Public Const m_BLash = 2048
Public Const m_Gantry = 2049

Public Const m_Micro = 2050
Public Const m_MPhi = 2051
Public Const m_StopCurr = 2052
Public Const m_PulsMode = 2053

Public Const m_APos = 2061
Public Const m_RPos = 2062
Public Const m_RVelo = 2063
Public Const m_XEncoder = 2064

Public Const m_XOvr = 2075
Public Const m_XOmode = 2076

Public Const m_EgState = 2090
Public Const m_EgMode = 2092
Public Const m_EgSource = 2093
Public Const m_EgMult = 2094

Public Const TOP_XPARM_NO = 2094

'  Bahnparameter
Public Const BOT_IPARM_NO = 3000

Public Const m_IpSpeed = 3000
Public Const m_IpAccel = 3001
Public Const m_IpDecel = 3002
Public Const m_IpVmin = 3003
Public Const m_IpLDecel = 3004
Public Const m_IpVend = 3005
Public Const m_IpFeed = 3006
Public Const m_IpMaxVel = 3008
Public Const m_IpMaxAcc = 3009
Public Const m_IpDim = 3010
Public Const m_IpUnit = 3011
Public Const m_IpLeft = 3012

Public Const m_IpLaFact = 3013
Public Const m_IpLaCvFact = 3014
Public Const m_IpLaTprof = 3015

Public Const m_IpTrigger = 3017
Public Const m_IpTrgTime = 3018
Public Const m_IpTrgOutp = 3019

Public Const m_IpVelo = 3063

Public Const m_IpOvr = 3075
Public Const m_IpOmode = 3076

Public Const TOP_IPARM_NO = 3076

'  EA-Parameter
Public Const BOT_IOPARM_NO = 4000
Public Const m_InPolarity = 4000
Public Const m_OutPolarity = 4001
Public Const TOP_IOPARM_NO = 4003


'  Xemo_DLL Koordinaten-Bezeichner
' -------------------------------
Public Const C_X = &H01
Public Const C_Y = &H02
Public Const C_XY = &H03
Public Const C_Z = &H04
Public Const C_XZ = &H05
Public Const C_YZ = &H06
Public Const C_XYZ = &H07
Public Const C_A = &H08
Public Const C_XA = &H09
Public Const C_YA = &H0A
Public Const C_XYA = &H0B
Public Const C_ZA = &H0C
Public Const C_XZA = &H0D
Public Const C_YZA = &H0E
Public Const C_XYZA = &H0F

'  Xemo_DLL Error-Codes
' -------------------------------
Public Const ERR_XEMO = 1
Public Const ERR_COM_PORT = 2
Public Const ERR_RCV_OVERFLOW = 3
Public Const ERR_RCV_TIMEOUT = 4
Public Const ERR_FIFO_TIMEOUT = 5
Public Const ERR_GETSTATE = 6
Public Const ERR_RCV_CMD = 7
Public Const ERR_TRM_TIMEOUT = 8
Public Const ERR_CHECKSUM = 9
Public Const ERR_COM_SELECT = 10
Public Const ERR_MAX_THREADS = 11
Public Const ERR_GET_THREAD_COM = 12

'  Xemo_DLL Error-Status
' -------------------------------
Public Const ERR_LEFT = -1
Public Const NO_ERR = 0
Public Const ERR_XEMO_PENDING = 1
Public Const ERR_COM_PENDING = 2
Public Const ERR_RETRY = 3
Public Const ERR_CANCEL = 4
Public Const ERR_COM_DEINI = 5
