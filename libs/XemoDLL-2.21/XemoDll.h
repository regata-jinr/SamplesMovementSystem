
#define XEMO_DLL_VESRION		"2.18"

#ifdef XEMODLL_EXPORTS
#define MB4_API extern "C"  __declspec(dllexport)
#else
#define MB4_API extern "C"  __declspec(dllimport) 
#endif

//----------------------------------------------------------------------
// Initialisierungs Funktionen
//----------------------------------------------------------------------
MB4_API void  __stdcall ML_TimeOut		( double ComTimeout, double FifoTimeout);
MB4_API void  __stdcall ML_FifoIdle		( void (*FifoIdle)(void) );
MB4_API short __stdcall ML_IniCom		( short ComNo, long Baud );
MB4_API short __stdcall ML_IniUsb		( short ComNo, const char * SerialNo);
MB4_API void  __stdcall ML_DeIniCom		( void );
MB4_API void  __stdcall ML_DeIniComPort ( short ComNo);

MB4_API void  __stdcall ML_ComSelect	( short ComNo);
MB4_API void  __stdcall ML_CsumMode		( short mode);

MB4_API const char *  __stdcall ML_DllVersion	(void);
MB4_API void __stdcall	ML_GetDllVersion		(char * Version, short MaxLen);

//----------------------------------------------------------------------
// Fehlerbehandlung
//----------------------------------------------------------------------
MB4_API void  __stdcall ML_ErrorCallBack ( short (*ErrorFunc)(short ErrorCode));
MB4_API void  __stdcall ML_RunErrCallBack( short (*ErrorFunc)());
MB4_API short __stdcall ML_GetErrCode    ( void );
MB4_API short __stdcall ML_GetErrState	 ( void );
MB4_API void  __stdcall ML_SetErrState   ( short State);
MB4_API short __stdcall ML_LastRunErr	 ( void );

MB4_API const char *  
              __stdcall ML_ComErrText    ( short ErrCode);
MB4_API void  __stdcall ML_GetComErrText ( short ErrCode, char * ErrTxt, short MaxLen);

//----------------------------------------------------------------------
// Datenübertragung
//----------------------------------------------------------------------
MB4_API short __stdcall ML_FifoFull		( void );
MB4_API void  __stdcall	ML_FifoBreak	( void );
MB4_API void  __stdcall	ML_DoEvents		( void );

MB4_API void  __stdcall ML_PutChar		( short TrmChar );
MB4_API void  __stdcall ML_PutWord		( short TrmWord );
MB4_API void  __stdcall ML_PutLong		( long  TrmLong );
MB4_API void  __stdcall ML_PutData		( void *TrmData, short Size);

MB4_API short __stdcall ML_GetRcvState	( void );
MB4_API short __stdcall ML_GetChar		( void );
MB4_API short __stdcall ML_GetWord		( void );
MB4_API long  __stdcall ML_GetLong		( void );
MB4_API void  __stdcall ML_GetData		( void *RcvData, short Size);

//----------------------------------------------------------------------
// MotionBasic-Funktionen
//----------------------------------------------------------------------
// Systemkontrolle
MB4_API void  __stdcall MB_SysControl  ( short Control );
MB4_API short __stdcall MB_GetState    ( void );
MB4_API void  __stdcall MB_SetFifo     ( short State );
MB4_API void  __stdcall MB_ResErr      ();
MB4_API void  __stdcall MB_Call        ( unsigned short ProgNr );

// Systemparameter
MB4_API void  __stdcall MB_Set         ( short Parameter, long Wert );
MB4_API void  __stdcall MB_ASet        ( short Achse, short Parameter, long Wert );
MB4_API void  __stdcall MB_IoSet       ( short ByteNr, short BitNr1, short BitNr2, short Parameter, short Wert);

MB4_API void  __stdcall MB_Seti        ( short Parameter, long Wert );
MB4_API void  __stdcall MB_ASeti       ( short Achse, short Parameter, long Wert );
MB4_API void  __stdcall MB_IoSeti      ( short ByteNr, short BitNr1, short BitNr2, short Parameter, short Wert);

MB4_API long  __stdcall MB_Get         ( short Parameter );
MB4_API long  __stdcall MB_AGet        ( short Achse, short Parameter );
MB4_API short __stdcall MB_IoGet       ( short ByteNr, short BitNr1, short BitNr2, short Parameter);

// Steuerung einzelner Achsen
MB4_API void  __stdcall MB_Jog         ( short Achse, long Geschwindigkeit );
MB4_API void  __stdcall MB_Amove       ( short Achse, long Zielposition );
MB4_API void  __stdcall MB_Rmove       ( short Achse, long Verfahrweg );
MB4_API void  __stdcall MB_Home        ( short Achse );
MB4_API void  __stdcall MB_Stop        ( short Achse );
MB4_API short __stdcall MB_Busy        ( short Achse );

// Bahnsteuerung
MB4_API void  __stdcall MB_Lin         ( unsigned short C_Mask, long Coordinate[] );
MB4_API void  __stdcall MB_Lin0        ( unsigned short C_Mask, long Coordinate[] );
MB4_API void  __stdcall MB_Lin1        ( unsigned short C_Mask, long Coordinate[] );
MB4_API void  __stdcall MB_Circle      ( long Radius, long Anfangswinkel, long Endwinkel );
MB4_API void  __stdcall MB_Arc         ( unsigned short C_Mask, long Radius, long Coordinate[] );
MB4_API void  __stdcall MB_Arcc        ( unsigned short C_Mask, long Mx, long My, long Coordinate[] );
MB4_API void  __stdcall MB_Arcw        ( unsigned short C_Mask, long Mx, long My, long Coordinate[] );

// Ein- und Ausgänge
MB4_API void  __stdcall MB_Out         ( short ByteNr, short BitNr1, short BitNr2, short Wert );
MB4_API void  __stdcall MB_Sout        ( short ByteNr, short BitNr1, short BitNr2, short Wert );
MB4_API short __stdcall MB_Rout        ( short ByteNr, short BitNr1, short BitNr2 );
MB4_API short __stdcall MB_In          ( short ByteNr, short BitNr1, short BitNr2 );
MB4_API void  __stdcall MB_Waitinp     ( short ByteNr, short BitNr1, short BitNr2, short Wert );

MB4_API short __stdcall MB_Inw			( short ByteNr );
MB4_API void  __stdcall MB_Outw			( short ByteNr, short Wert );
MB4_API short __stdcall MB_Routw		( short ByteNr );

// Textausgabe
MB4_API void  __stdcall MB_Print       ( char * Text );
MB4_API	void  __stdcall MB_Printxy     ( short x, short y, char * Text );
MB4_API	void  __stdcall MB_Cpos        ( short x, short y );
MB4_API	void  __stdcall MB_Ctype       ( short cType  );
MB4_API	void  __stdcall MB_TextAttrib  ( short Attrib );
MB4_API	void  __stdcall MB_Cls         ( void );
MB4_API	void  __stdcall MB_Cleol       ( void );

// Tastatureingabe
MB4_API	short __stdcall MB_KeyState    ( void );
MB4_API	short __stdcall MB_KeyPressed  ( void );
MB4_API	short __stdcall MB_KeyRead     ( void );
MB4_API	void  __stdcall MB_KeyClear    ( void );
MB4_API	void  __stdcall MB_KeyLed      ( short Key, short Onoff );

// Zeitfunktionen
MB4_API void  __stdcall MB_Delay       ( long Verweilzeit );
MB4_API void  __stdcall MB_Still       ( short Achse );


//----------------------------------------------------------------------
// Weitere nicht dokumetierte Funktionen 
//----------------------------------------------------------------------
MB4_API void  __stdcall MB_SdoTrm		(unsigned short NodeId,	unsigned short Index, short SubIndex, long Value);
MB4_API long  __stdcall MB_SdoRcv		(unsigned short NodeId, unsigned short Index, short SubIndex);
MB4_API short __stdcall ML_PutDataCsum	(void *TrmData, short Size);
