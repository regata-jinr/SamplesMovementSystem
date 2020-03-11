Option Strict Off
Option Explicit On
Module MBconst
	'  Bits im Systemstatus
	' -------------------------------
	Public Const STATE_F0 As Integer = &H1
	Public Const STATE_F1 As Integer = &H2
	Public Const STATE_F2 As Integer = &H4
	Public Const STATE_ERR As Integer = &H8
	Public Const STATE_MS As Integer = &H10
	Public Const STATE_OR0 As Integer = &H20
	Public Const STATE_RUN As Integer = &H40
	
	Public Const PSTATE_PSTATE As Integer = &H7
	Public Const PSTATE_ERROR As Integer = &H8
	Public Const PSTATE_ONERROR As Integer = &H10
	Public Const PSTATE_DEBUG As Integer = &H40
	
	Public Const STATE_FIFO As Integer = &H3
	Public Const STATE_FIFO_EMPTY As Short = 0
	Public Const STATE_FIFO_LOW As Short = 1
	Public Const STATE_FIFO_HIGH As Short = 2
	Public Const STATE_FIFO_FULL As Short = 3
	
	'  Syscontrol Kommandos	
	Public Const m_Reset As Short = 1 '  System Reset
	Public Const m_Break As Short = 2 '  MotionBasic Programm unterbrechen
	Public Const m_Halt As Short = 3 '  MotionBasic Programm anhalten
	
	Public Const m_PrgQuit As Short = 100 '  MotionBasic Programm benden
	Public Const m_DebugShell As Short = 101 '  Zur Debug-Shell wechseln
	Public Const m_OnlineShell As Short = 102 '  Zur Online-Shell wechseln
	
	'  SetFifo FifoStatus
	' -------------------------------
	Public Const m_FfDisable As Short = 1
	Public Const m_FfEnable As Short = 2
	Public Const m_FfClear As Short = 3
	
	'  Tastatur-Codes
	Public Const m_Key_F1 As Integer = &H13B
	Public Const m_Key_F2 As Integer = &H13C
	Public Const m_Key_F3 As Integer = &H13D
	Public Const m_Key_F4 As Integer = &H13E
	Public Const m_Key_Bs As Integer = &H8
	Public Const m_Key_Enter As Integer = &HD
	Public Const m_Key_Up As Integer = &H148
	Public Const m_Key_Down As Integer = &H150
	Public Const m_Key_Right As Integer = &H14D
	Public Const m_Key_Left As Integer = &H14B
	
	'  KeyLed-Codes
	' -------------------------------
	Public Const m_LedOff As Short = 0
	Public Const m_LedOn As Short = 1
	Public Const m_LedBlink As Short = 10
	Public Const m_LedFlash As Short = 11
	
	'  Die Achsbezeichner
	' -------------------------------
	Public Const m_X As Short = 0
	Public Const m_Y As Short = 1
	Public Const m_Z As Short = 2
	Public Const m_A As Short = 3
	Public Const m_XALL As Short = 255 '  Alle Achsen / Achsparameter
	Public Const m_ALL As Short = 254 '  Alle Achs- und Bahnparameter
	
	'  Seriell IO
	Public Const m_COM1 As Short = 1
	Public Const m_BD9600 As Short = 5
	Public Const m_BD19200 As Short = 6
	Public Const m_BD28800 As Short = 7
	Public Const m_BD38400 As Short = 8
	Public Const m_BD57600 As Short = 9
	
	'  USB
	Public Const USB_OFF As Short = 0
	Public Const USB_AUTO As Short = 1
	Public Const USB_ONLY As Short = 2
	
	'  Diverse
	Public Const m_Off As Short = 0
	
	'  Systemparameter
	Public Const BOT_SPARM_NO As Short = 1000
	
	Public Const m_State As Short = 1000
	Public Const m_Version As Short = 1004
	Public Const m_Release As Short = 1005
	Public Const m_ComRelease As Short = 1006
	Public Const m_Extent As Short = 1007
	Public Const m_Clock As Short = 1008
	
	Public Const m_ErrNo As Short = 1010
	Public Const m_ErrState As Short = 1011
	Public Const m_ErrLine As Short = 1012
	Public Const m_ErrAxis As Short = 1013
	Public Const m_ErrParam As Short = 1014
	Public Const m_SubError As Short = 1015
	
	Public Const m_EnaOptCode As Short = 1017
	Public Const m_ErrCount As Short = 1018
	Public Const m_RecentErr As Short = 1019
	
	Public Const m_FifoSize As Short = 1021
	Public Const m_FifoLevel As Short = 1022
	Public Const m_FifoLeft As Short = 1023
	Public Const m_FifoMarker As Short = 1024
	
	Public Const m_Mode1 As Short = 1030
	
	Public Const m_CanMode As Short = 1034
	Public Const m_OtSelect As Short = 1035
	Public Const m_Can2Mode As Short = 1036
	Public Const m_Can1Device As Short = 1038
	Public Const m_Can2Device As Short = 1039
	
	Public Const m_IpGroup As Short = 1040
	Public Const m_H1Trans As Short = 1041
	Public Const m_H2Trans As Short = 1042
	Public Const m_IpSyncClk As Short = 1043
	
	Public Const m_BkPwmCycle As Short = 1050
	Public Const m_BkPwmDuty As Short = 1051
	
	Public Const m_AnlIn As Short = 1060
	Public Const m_AnlOut As Short = 1061
	Public Const m_OvrIn As Short = 1062
	Public Const m_JoyX As Short = 1063
	Public Const m_JoyY As Short = 1064
	
	Public Const m_HandWheel As Short = 1070
	Public Const m_Encoder As Short = 1071
	Public Const m_EncIdx As Short = 1072
	Public Const m_EncIpr As Short = 1073
	
	Public Const m_Ovride As Short = 1075
	Public Const m_Omode As Short = 1076
	Public Const m_OvScale As Short = 1077
	
	Public Const m_SAnlIn0 As Short = 1080
	Public Const m_SAnlIn1 As Short = 1081
	Public Const m_SAnlIn2 As Short = 1082
	
	Public Const m_VoMode As Short = 1090
	Public Const m_VoScale As Short = 1091
	Public Const m_VoOffs As Short = 1092
	Public Const m_VoMin As Short = 1093
	Public Const m_VoMax As Short = 1094
	
	Public Const m_AnlFSel As Short = 1100
	Public Const m_AFType As Short = 1101
	Public Const m_AFSTime As Short = 1102
	Public Const m_AFSpread As Short = 1103
	Public Const m_AFHyster As Short = 1104
	Public Const m_AFTrack As Short = 1105
	Public Const m_AFAverage As Short = 1106
	
	'  ab 1200 sind zunächst nicht dokumetierte
	'  Systemparameter zur Geräteüberwachung
	Public Const TOP_SPARM_NO As Short = 1250 '  Grösste Systemparameter-Nummer
	
	'  Setup-Parameter
	'  Die Setup-Parameter sind besonders schreibgeschützt
	'  und können nur beschrieben werden, wenn der Hexschalter auf 0x0e steht
	Public Const BOT_SUPARM_NO As Short = 1400
	Public Const m_ComPort As Short = 1400 '  RS232 Programmier-Schnittstelle auswählen
	Public Const m_Bdrate As Short = 1401 '  Baudrate der RS232 Schnittstelle festlegen
	Public Const m_DsplContr As Short = 1402 '  Xemo Display Kontrast
	Public Const m_PonComDelay As Short = 1403 '  Power On ComPort Delay
	Public Const m_USBConfig As Short = 1404 '  USB Schnittstelle konfigurieren
	Public Const m_CanTerm As Short = 1405 '  CAN Abschlusswiderstände
	Public Const m_BKType As Short = 1406 '  Beckhoff-Koppler 5120 oder BK5100 scoe 2005-03-15
	Public Const TOP_SUPARM_NO As Short = 1406
	
	'  Achsparameter	
	Public Const BOT_XPARM_NO As Short = 2000
	
	Public Const m_Speed As Short = 2000
	Public Const m_Accel As Short = 2001
	Public Const m_Decel As Short = 2002
	Public Const m_Vmin As Short = 2003
	Public Const m_LDecel As Short = 2004
	Public Const m_MaxVel As Short = 2008
	Public Const m_MaxAcc As Short = 2009
	Public Const m_IpLink As Short = 2010
	Public Const m_IpAxis As Short = 2011
	
	Public Const m_NodeId As Short = 2012
	
	Public Const m_H1Speed As Short = 2020
	Public Const m_H2Speed As Short = 2021
	Public Const m_H3Speed As Short = 2022
	Public Const m_HOffset As Short = 2023
	Public Const m_HVerify As Short = 2024
	Public Const m_HMethod As Short = 2025
	
	Public Const m_OpMode As Short = 2030
	Public Const m_Current As Short = 2031
	Public Const m_FErrWin As Short = 2032
	Public Const m_TPosWin As Short = 2033
	Public Const m_TPosTime As Short = 2034
	Public Const m_BrakeOutp As Short = 2035
	Public Const m_BrkDelay1 As Short = 2036
	Public Const m_BrkDelay2 As Short = 2037
	
	Public Const m_Uscale As Short = 2040
	Public Const m_Iscale As Short = 2041
	
	Public Const m_Zero As Short = 2042
	Public Const m_Origin As Short = 2043
	Public Const m_Refp As Short = 2044
	Public Const m_SlLimit As Short = 2045
	Public Const m_SrLimit As Short = 2046
	Public Const m_Pmode As Short = 2047
	Public Const m_BLash As Short = 2048
	Public Const m_Gantry As Short = 2049
	
	Public Const m_Micro As Short = 2050
	Public Const m_MPhi As Short = 2051
	Public Const m_StopCurr As Short = 2052
	
	Public Const m_APos As Short = 2061
	Public Const m_RPos As Short = 2062
	Public Const m_RVelo As Short = 2063
	Public Const m_XEncoder As Short = 2064
	
	Public Const m_XOvr As Short = 2075
	Public Const m_XOmode As Short = 2076
	
	Public Const m_EgState As Short = 2090
	Public Const m_EgMode As Short = 2092
	Public Const m_EgSource As Short = 2093
	Public Const m_EgMult As Short = 2094
	
	Public Const TOP_XPARM_NO As Short = 2094
	
	'  Bahnparameter
	Public Const BOT_IPARM_NO As Short = 3000
	
	Public Const m_IpSpeed As Short = 3000
	Public Const m_IpAccel As Short = 3001
	Public Const m_IpDecel As Short = 3002
	Public Const m_IpVmin As Short = 3003
	Public Const m_IpLDecel As Short = 3004
	Public Const m_IpVend As Short = 3005
	Public Const m_IpFeed As Short = 3006
	Public Const m_IpMaxVel As Short = 3008
	Public Const m_IpMaxAcc As Short = 3009
	Public Const m_IpDim As Short = 3010
	Public Const m_IpUnit As Short = 3011
	
	Public Const m_IpLaFact As Short = 3013
	Public Const m_IpLaCvFact As Short = 3014
	Public Const m_IpLaTprof As Short = 3015
	
	Public Const m_IpTrigger As Short = 3017
	Public Const m_IpTrgTime As Short = 3018
	Public Const m_IpTrgOutp As Short = 3019
	
	Public Const m_IpVelo As Short = 3063
	
	Public Const m_IpOvr As Short = 3075
	Public Const m_IpOmode As Short = 3076
	
	Public Const TOP_IPARM_NO As Short = 3076
	
	'  EA-Parameter
	Public Const BOT_IOPARM_NO As Short = 4000
	Public Const m_InPolarity As Short = 4000
	Public Const m_OutPolarity As Short = 4001
	Public Const TOP_IOPARM_NO As Short = 4003
	
	
	'  Xemo_DLL Koordinaten-Bezeichner
	' -------------------------------
	Public Const C_X As Integer = &H1
	Public Const C_Y As Integer = &H2
	Public Const C_XY As Integer = &H3
	Public Const C_Z As Integer = &H4
	Public Const C_XZ As Integer = &H5
	Public Const C_YZ As Integer = &H6
	Public Const C_XYZ As Integer = &H7
	Public Const C_A As Integer = &H8
	Public Const C_XA As Integer = &H9
	Public Const C_YA As Integer = &HA
	Public Const C_XYA As Integer = &HB
	Public Const C_ZA As Integer = &HC
	Public Const C_XZA As Integer = &HD
	Public Const C_YZA As Integer = &HE
	Public Const C_XYZA As Integer = &HF
	
	'  Xemo_DLL Error-Codes
	' -------------------------------
	Public Const ERR_XEMO As Short = 1
	Public Const ERR_COM_PORT As Short = 2
	Public Const ERR_RCV_OVERFLOW As Short = 3
	Public Const ERR_RCV_TIMEOUT As Short = 4
	Public Const ERR_FIFO_TIMEOUT As Short = 5
	Public Const ERR_GETSTATE As Short = 6
	Public Const ERR_RCV_CMD As Short = 7
	Public Const ERR_TRM_TIMEOUT As Short = 8
	Public Const ERR_CHECKSUM As Short = 9
	Public Const ERR_COM_SELECT As Short = 10
	Public Const ERR_MAX_THREADS As Short = 11
	Public Const ERR_GET_THREAD_COM As Short = 12
	
	'  Xemo_DLL Error-Status
	' -------------------------------
	Public Const ERR_LEFT As Short = -1
	Public Const NO_ERR As Short = 0
	Public Const ERR_XEMO_PENDING As Short = 1
	Public Const ERR_COM_PENDING As Short = 2
	Public Const ERR_RETRY As Short = 3
	Public Const ERR_CANCEL As Short = 4
	Public Const ERR_COM_DEINI As Short = 5
End Module