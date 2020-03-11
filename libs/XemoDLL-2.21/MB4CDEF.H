
/*------------------------------
	Die Online Kommando-Bytes
--------------------------------*/

//	System-Kommandos
#define	OP_GETSTATE		1
#define OP_PRGSTATE     2
#define OP_SYSCTRL      3
#define OP_RESERR       4
#define OP_SETFIFO      5
#define OP_DELAY        6
#define OP_CALL			7


//	Paramter Set /Get
#define OP_SET          10
#define OP_GET          11
#define OP_ASET         12
#define OP_AGET         13
#define OP_IOSET        14
#define OP_IOGET        15
#define OP_SETI			16
#define OP_ASETI		17
#define OP_IOSETI		18


//	Achs- Kommandos
#define OP_JOG          20
#define OP_AMOVE        21
#define OP_RMOVE        22
#define OP_STOP         23
#define OP_STILL        24
#define OP_BUSY         25
#define	OP_HOME			26

//	EA-Kommandos
#define OP_OUT          30
#define OP_IN           31
#define OP_ROUT         32
#define	OP_WINP			33
#define	OP_SOUT			34
#define OP_OUTW			35
#define OP_INW          36
#define OP_ROUTW		37
#define OP_OUTI			38
#define OP_OUTWI		39

// 	Terminal Kommandos
#define OP_CLS          40
#define OP_CLEOL        41
#define OP_PRINT		42
#define OP_PRINTXY      43
#define OP_CPOS         44
#define OP_CTYPE        45
#define OP_TEXTATTR     46

// Tastatur-Kommandos
#define OP_KEYLED		50
#define OP_KSTATE       51
#define OP_KPRESS       52
#define OP_KREAD        53
#define OP_KCLEAR       54
#define OP_INPUT        55

// Bahn-Kommandos
#define OP_LIN0			60
#define OP_LIN1			61
#define OP_CIRCLE		62
#define OP_ARC 			63
#define OP_ARCC			64
#define OP_ARCW			65

// Online Checsum Prüfung
#define	OP_CLRCSUM		70
#define	OP_CMPCSUM		71
#define	OP_SDOTRM		72
#define	OP_SDORCV		73
#define	OP_SDOTRMP		74				// scoe 2005-05-12


