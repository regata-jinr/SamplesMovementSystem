// Bits im Systemstatus
//-------------------------------
#define	STATE_F0		0x01
#define	STATE_F1		0x02
#define	STATE_F2		0x04
#define	STATE_ERR		0x08
#define	STATE_MS		0x10
#define	STATE_OR0		0x20
#define	STATE_RUN		0x40

#define	PSTATE_PSTATE	0x07
#define	PSTATE_ERROR	0x08
#define PSTATE_ONERROR	0x10
#define	PSTATE_DEBUG	0x40

#define	STATE_FIFO			0x03
#define	STATE_FIFO_EMPTY	0
#define	STATE_FIFO_LOW		1
#define	STATE_FIFO_HIGH		2
#define	STATE_FIFO_FULL		3

// Syscontrol Kommandos	
#define	_Reset  		1		// System Reset
#define	_Break			2		// MotionBasic Programm unterbrechen
#define	_Halt		  	3		// MotionBasic Programm anhalten

#define	_PrgQuit		100		// MotionBasic Programm benden
#define	_DebugShell		101		// Zur Debug-Shell wechseln
#define	_OnlineShell	102		// Zur Online-Shell wechseln

// SetFifo FifoStatus
//-------------------------------
#define	_FfDisable		1
#define	_FfEnable		2
#define	_FfClear		3
#define _FfOffline		4	// Vorläufige Implementation
#define _FfOnline		5	// Alle eingehende Zeichen werden ignoriert


// Tastatur-Codes
#define	_Key_F1			0x13b
#define	_Key_F2			0x13c
#define	_Key_F3	  		0x13d
#define	_Key_F4	  		0x13e
#define _Key_F5			0x13f	// neu für OT240
#define _Key_F6			0x140	// neu für OT240
#define _Key_F7			0x141	// neu für OT240
#define _Key_F8			0x142	// neu für OT240
#define	_Key_Bs			0x08
#define	_Key_Enter		0x0d
#define	_Key_Up			0x148
#define	_Key_Down	 	0x150
#define	_Key_Right		0x14d
#define	_Key_Left	 	0x14b

// KeyLed-Codes
//-------------------------------
#define	_LedOff			0
#define	_LedOn			1
#define	_LedBlink		10
#define	_LedFlash		11

// Die Achsbezeichner
//-------------------------------
#define	_X		0
#define	_Y		1
#define	_Z		2
#define	_A		3
#define _XALL	255		// Alle Achsen / Achsparameter
#define _ALL	254		// Alle Achs- und Bahnparameter

// Seriell IO
#define	_COM1			1
#define _BD9600			5
#define _BD19200		6
#define _BD28800		7
#define _BD38400		8
#define _BD57600		9

// USB
#define USB_OFF			0
#define	USB_AUTO		1
#define	USB_ONLY		2

// Diverse
#define _Off			0

// Systemparameter
#define	BOT_SPARM_NO	1000

#define	_State			1000
#define	_Version		1004
#define	_Release		1005
#define	_ComRelease		1006
#define	_Extent			1007
#define _Clock			1008

#define	_ErrNo  		1010
#define	_ErrState	  	1011
#define	_ErrLine		1012
#define	_ErrAxis		1013
#define	_ErrParam		1014
#define	_SubError		1015

#define _EnaOptCode		1017
#define _ErrCount		1018
#define _RecentErr		1019

#define	_FifoSize		1021
#define	_FifoLevel		1022
#define	_FifoLeft		1023
#define	_FifoMarker		1024
#define	_FifoLow		1025

#define _Mode1			1030
#define _ModeUsb		1033
#define _CanMode		1034
#define _OtSelect		1035
#define _Can2Mode		1036
#define _Can1Device		1038
#define _Can2Device		1039

#define _IpGroup		1040
#define _H1Trans		1041
#define _H2Trans		1042
#define	_IpSyncClk		1043

#define	_BkPwmCycle		1050
#define	_BkPwmDuty		1051

#define	_AnlIn			1060
#define _AnlOut			1061
#define _OvrIn			1062
#define	_JoyX			1063
#define	_JoyY			1064

#define _HandWheel		1070
#define	_Encoder		1071
#define	_EncIdx			1072
#define	_EncIpr			1073
#define _EncCpStat		1074

#define	_Ovride			1075
#define	_Omode			1076
#define _OvScale		1077

#define _SAnlIn0		1080
#define _SAnlIn1		1081
#define _SAnlIn2		1082

#define	_VoMode			1090
#define	_VoScale		1091
#define	_VoOffs			1092
#define	_VoMin			1093
#define	_VoMax			1094

#define _AnlFSel 		1100
#define	_AFType			1101
#define	_AFSTime		1102
#define	_AFSpread		1103
#define _AFHyster		1104
#define	_AFTrack		1105
#define _AFAverage		1106

#define _IsoLineNr		1110
#define _IsoGScale		1111
#define _IsoFScale		1112
#define _IsoSScale		1113

#define	_IdxFunc		1120
#define	_IdxFcMode		1121

// ab 1200 sind zunächst nicht dokumetierte
// Systemparameter zur Geräteüberwachung
#define	TOP_SPARM_NO	1250	// Grösste Systemparameter-Nummer

// Setup-Parameter
// Die Setup-Parameter sind besonders schreibgeschützt
// und können nur beschrieben werden, wenn der Hexschalter auf 0x0e steht
#define	BOT_SUPARM_NO	1400	
#define _ComPort		1400	// RS232 Programmier-Schnittstelle auswählen
#define _Bdrate			1401	// Baudrate der RS232 Schnittstelle festlegen
#define	_DsplContr		1402	// Xemo Display Kontrast
#define _PonComDelay	1403	// Power On ComPort Delay
#define _USBConfig		1404	// USB Schnittstelle konfigurieren
#define _CanTerm		1405	// CAN Abschlusswiderstände
#define _BKType			1406	// Beckhoff-Koppler 5120 oder BK5100 scoe 2005-03-15
#define	TOP_SUPARM_NO	1406	

// Achsparameter	
#define	BOT_XPARM_NO	2000

#define	_Speed			2000
#define	_Accel			2001
#define	_Decel			2002
#define	_Vmin			2003
#define	_LDecel			2004
#define	_MaxVel			2008
#define	_MaxAcc			2009
#define	_IpLink			2010
#define	_IpAxis			2011

#define _NodeId			2012

#define	_H1Speed		2020
#define	_H2Speed		2021
#define	_H3Speed		2022
#define	_HOffset		2023
#define	_HVerify		2024
#define	_HMethod		2025

#define	_OpMode			2030
#define	_Current		2031
#define _FErrWin		2032
#define _TPosWin		2033
#define _TPosTime		2034
#define	_BrakeOutp		2035
#define _BrkDelay1		2036
#define	_BrkDelay2		2037

#define	_Uscale			2040
#define	_Iscale			2041

#define	_Zero			2042
#define	_Origin			2043
#define	_Refp			2044
#define	_SlLimit		2045
#define	_SrLimit		2046
#define _Pmode			2047
#define _BLash			2048
#define	_Gantry			2049

#define	_Micro			2050
#define _MPhi			2051
#define	_StopCurr		2052
#define _PulsMode		2053

#define	_APos			2061
#define	_RPos			2062
#define	_RVelo			2063
#define _XEncoder		2064

#define	_XOvr			2075
#define	_XOmode			2076

#define	_EgState		2090
#define	_EgMode			2092
#define _EgSource		2093
#define _EgMult			2094

#define	TOP_XPARM_NO	2094	

// Bahnparameter
#define	BOT_IPARM_NO	3000	

#define	_IpSpeed		3000
#define	_IpAccel		3001
#define	_IpDecel		3002
#define	_IpVmin			3003
#define	_IpLDecel		3004
#define	_IpVend			3005
#define	_IpFeed			3006
#define	_IpMaxVel		3008
#define	_IpMaxAcc		3009
#define	_IpDim			3010
#define	_IpUnit			3011
#define _IpLeft			3012

#define	_IpLaFact		3013
#define	_IpLaCvFact		3014
#define	_IpLaTprof		3015

#define _IpTrigger		3017
#define _IpTrgTime		3018
#define _IpTrgOutp		3019

#define	_IpVelo			3063

#define	_IpOvr			3075
#define	_IpOmode		3076

#define	TOP_IPARM_NO	3076

// EA-Parameter
#define	BOT_IOPARM_NO	4000
#define	_InPolarity		4000
#define	_OutPolarity	4001
#define	TOP_IOPARM_NO	4003


// Xemo_DLL Koordinaten-Bezeichner
//-------------------------------
#define	C_X  		0x01
#define	C_Y			0x02
#define	C_XY		0x03
#define	C_Z			0x04
#define	C_XZ		0x05
#define	C_YZ		0x06
#define	C_XYZ		0x07
#define	C_A			0x08
#define	C_XA		0x09
#define	C_YA		0x0A
#define	C_XYA		0x0B
#define	C_ZA		0x0C
#define	C_XZA		0x0D
#define	C_YZA		0x0E
#define	C_XYZA		0x0F

// Xemo_DLL Error-Codes
//-------------------------------
#define	ERR_XEMO			1
#define	ERR_COM_PORT		2
#define	ERR_RCV_OVERFLOW	3
#define	ERR_RCV_TIMEOUT		4
#define	ERR_FIFO_TIMEOUT	5
#define	ERR_GETSTATE		6
#define	ERR_RCV_CMD			7
#define ERR_TRM_TIMEOUT		8
#define ERR_CHECKSUM		9
#define ERR_COM_SELECT		10
#define	ERR_MAX_THREADS		11
#define ERR_GET_THREAD_COM	12

// Xemo_DLL Error-Status
//-------------------------------
#define ERR_LEFT			-1
#define	NO_ERR				0
#define	ERR_XEMO_PENDING	1
#define	ERR_COM_PENDING		2
#define	ERR_RETRY			3
#define	ERR_CANCEL			4
#define	ERR_COM_DEINI		5