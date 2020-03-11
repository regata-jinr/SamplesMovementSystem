
Public Const XEMO_DLL_VESRION = "2.18"







' ----------------------------------------------------------------------
'  Initialisierungs Funktionen
' ----------------------------------------------------------------------
Public Declare Sub ML_TimeOut Lib "XemoDll.dll" Alias "_ML_TimeOut@16" (ByVal ComTimeout As double, ByVal FifoTimeout As double)
Public Declare Sub ML_FifoIdle Lib "XemoDll.dll" Alias "_ML_FifoIdle@4" (ByVal FifoIdle As Long)
Public Declare Function ML_IniCom Lib "XemoDll.dll" Alias "_ML_IniCom@8" (ByVal ComNo As Integer, ByVal Baud As long) As Integer
Public Declare Function ML_IniUsb Lib "XemoDll.dll" Alias "_ML_IniUsb@8" (ByVal ComNo As Integer, ByVal SerialNo As  String) As Integer
Public Declare Sub ML_DeIniCom Lib "XemoDll.dll" Alias "_ML_DeIniCom@0" ()
Public Declare Sub ML_DeIniComPort Lib "XemoDll.dll" Alias "_ML_DeIniComPort@4" (ByVal ComNo As Integer)

Public Declare Sub ML_ComSelect Lib "XemoDll.dll" Alias "_ML_ComSelect@4" (ByVal ComNo As Integer)
Public Declare Sub ML_CsumMode Lib "XemoDll.dll" Alias "_ML_CsumMode@4" (ByVal mode As Integer)


Public Declare Sub ML_GetDllVersion Lib "XemoDll.dll" Alias "_ML_GetDllVersion@8" (ByVal Version As  String, ByVal MaxLen As Integer)

' ----------------------------------------------------------------------
'  Fehlerbehandlung
' ----------------------------------------------------------------------
Public Declare Sub ML_ErrorCallBack Lib "XemoDll.dll" Alias "_ML_ErrorCallBack@4" (ByVal ErrorFunc As Long)
Public Declare Sub ML_RunErrCallBack Lib "XemoDll.dll" Alias "_ML_RunErrCallBack@4" (ByVal ErrorFunc As Long)
Public Declare Function ML_GetErrCode Lib "XemoDll.dll" Alias "_ML_GetErrCode@0" () As Integer
Public Declare Function ML_GetErrState Lib "XemoDll.dll" Alias "_ML_GetErrState@0" () As Integer
Public Declare Sub ML_SetErrState Lib "XemoDll.dll" Alias "_ML_SetErrState@4" (ByVal State As Integer)
Public Declare Function ML_LastRunErr Lib "XemoDll.dll" Alias "_ML_LastRunErr@0" () As Integer



Public Declare Sub ML_GetComErrText Lib "XemoDll.dll" Alias "_ML_GetComErrText@12" (ByVal ErrCode As Integer, ByVal ErrTxt As  String, ByVal MaxLen As Integer)

' ----------------------------------------------------------------------
'  Datenübertragung
' ----------------------------------------------------------------------
Public Declare Function ML_FifoFull Lib "XemoDll.dll" Alias "_ML_FifoFull@0" () As Integer
Public Declare Sub ML_FifoBreak Lib "XemoDll.dll" Alias "_ML_FifoBreak@0" ()
Public Declare Sub ML_DoEvents Lib "XemoDll.dll" Alias "_ML_DoEvents@0" ()

Public Declare Sub ML_PutChar Lib "XemoDll.dll" Alias "_ML_PutChar@4" (ByVal TrmChar As Integer)
Public Declare Sub ML_PutWord Lib "XemoDll.dll" Alias "_ML_PutWord@4" (ByVal TrmWord As Integer)
Public Declare Sub ML_PutLong Lib "XemoDll.dll" Alias "_ML_PutLong@4" (ByVal TrmLong As long)
Public Declare Sub ML_PutData Lib "XemoDll.dll" Alias "_ML_PutData@8" (ByRef TrmData As Any, ByVal Size As Integer)

Public Declare Function ML_GetRcvState Lib "XemoDll.dll" Alias "_ML_GetRcvState@0" () As Integer
Public Declare Function ML_GetChar Lib "XemoDll.dll" Alias "_ML_GetChar@0" () As Integer
Public Declare Function ML_GetWord Lib "XemoDll.dll" Alias "_ML_GetWord@0" () As Integer
Public Declare Function ML_GetLong Lib "XemoDll.dll" Alias "_ML_GetLong@0" () As long
Public Declare Sub ML_GetData Lib "XemoDll.dll" Alias "_ML_GetData@8" (ByRef RcvData As Any, ByVal Size As Integer)

' ----------------------------------------------------------------------
'  MotionBasic-Funktionen
' ----------------------------------------------------------------------
'  Systemkontrolle
Public Declare Sub MB_SysControl Lib "XemoDll.dll" Alias "_MB_SysControl@4" (ByVal Control As Integer)
Public Declare Function MB_GetState Lib "XemoDll.dll" Alias "_MB_GetState@0" () As Integer
Public Declare Sub MB_SetFifo Lib "XemoDll.dll" Alias "_MB_SetFifo@4" (ByVal State As Integer)
Public Declare Sub MB_ResErr Lib "XemoDll.dll" Alias "_MB_ResErr@0" ()
Public Declare Sub MB_Call Lib "XemoDll.dll" Alias "_MB_Call@4" (ByVal ProgNr As Integer)

'  Systemparameter
Public Declare Sub MB_Set Lib "XemoDll.dll" Alias "_MB_Set@8" (ByVal Parameter As Integer, ByVal Wert As long)
Public Declare Sub MB_ASet Lib "XemoDll.dll" Alias "_MB_ASet@12" (ByVal Achse As Integer, ByVal Parameter As Integer, ByVal Wert As long)
Public Declare Sub MB_IoSet Lib "XemoDll.dll" Alias "_MB_IoSet@20" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer, ByVal Parameter As Integer, ByVal Wert As Integer)

Public Declare Sub MB_Seti Lib "XemoDll.dll" Alias "_MB_Seti@8" (ByVal Parameter As Integer, ByVal Wert As long)
Public Declare Sub MB_ASeti Lib "XemoDll.dll" Alias "_MB_ASeti@12" (ByVal Achse As Integer, ByVal Parameter As Integer, ByVal Wert As long)
Public Declare Sub MB_IoSeti Lib "XemoDll.dll" Alias "_MB_IoSeti@20" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer, ByVal Parameter As Integer, ByVal Wert As Integer)

Public Declare Function MB_Get Lib "XemoDll.dll" Alias "_MB_Get@4" (ByVal Parameter As Integer) As long
Public Declare Function MB_AGet Lib "XemoDll.dll" Alias "_MB_AGet@8" (ByVal Achse As Integer, ByVal Parameter As Integer) As long
Public Declare Function MB_IoGet Lib "XemoDll.dll" Alias "_MB_IoGet@16" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer, ByVal Parameter As Integer) As Integer

'  Steuerung einzelner Achsen
Public Declare Sub MB_Jog Lib "XemoDll.dll" Alias "_MB_Jog@8" (ByVal Achse As Integer, ByVal Geschwindigkeit As long)
Public Declare Sub MB_Amove Lib "XemoDll.dll" Alias "_MB_Amove@8" (ByVal Achse As Integer, ByVal Zielposition As long)
Public Declare Sub MB_Rmove Lib "XemoDll.dll" Alias "_MB_Rmove@8" (ByVal Achse As Integer, ByVal Verfahrweg As long)
Public Declare Sub MB_Home Lib "XemoDll.dll" Alias "_MB_Home@4" (ByVal Achse As Integer)
Public Declare Sub MB_Stop Lib "XemoDll.dll" Alias "_MB_Stop@4" (ByVal Achse As Integer)
Public Declare Function MB_Busy Lib "XemoDll.dll" Alias "_MB_Busy@4" (ByVal Achse As Integer) As Integer

'  Bahnsteuerung
Public Declare Sub MB_Lin Lib "XemoDll.dll" Alias "_MB_Lin@8" (ByVal C_Mask As Integer, ByRef Coordinate As long)
Public Declare Sub MB_Lin0 Lib "XemoDll.dll" Alias "_MB_Lin0@8" (ByVal C_Mask As Integer, ByRef Coordinate As long)
Public Declare Sub MB_Lin1 Lib "XemoDll.dll" Alias "_MB_Lin1@8" (ByVal C_Mask As Integer, ByRef Coordinate As long)
Public Declare Sub MB_Circle Lib "XemoDll.dll" Alias "_MB_Circle@12" (ByVal Radius As long, ByVal Anfangswinkel As long, ByVal Endwinkel As long)
Public Declare Sub MB_Arc Lib "XemoDll.dll" Alias "_MB_Arc@12" (ByVal C_Mask As Integer, ByVal Radius As long, ByRef Coordinate As long)
Public Declare Sub MB_Arcc Lib "XemoDll.dll" Alias "_MB_Arcc@16" (ByVal C_Mask As Integer, ByVal Mx As long, ByVal My As long, ByRef Coordinate As long)
Public Declare Sub MB_Arcw Lib "XemoDll.dll" Alias "_MB_Arcw@16" (ByVal C_Mask As Integer, ByVal Mx As long, ByVal My As long, ByRef Coordinate As long)

'  Ein- und Ausgänge
Public Declare Sub MB_Out Lib "XemoDll.dll" Alias "_MB_Out@16" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer, ByVal Wert As Integer)
Public Declare Sub MB_Sout Lib "XemoDll.dll" Alias "_MB_Sout@16" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer, ByVal Wert As Integer)
Public Declare Function MB_Rout Lib "XemoDll.dll" Alias "_MB_Rout@12" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer) As Integer
Public Declare Function MB_In Lib "XemoDll.dll" Alias "_MB_In@12" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer) As Integer
Public Declare Sub MB_Waitinp Lib "XemoDll.dll" Alias "_MB_Waitinp@16" (ByVal ByteNr As Integer, ByVal BitNr1 As Integer, ByVal BitNr2 As Integer, ByVal Wert As Integer)

Public Declare Function MB_Inw Lib "XemoDll.dll" Alias "_MB_Inw@4" (ByVal ByteNr As Integer) As Integer
Public Declare Sub MB_Outw Lib "XemoDll.dll" Alias "_MB_Outw@8" (ByVal ByteNr As Integer, ByVal Wert As Integer)
Public Declare Function MB_Routw Lib "XemoDll.dll" Alias "_MB_Routw@4" (ByVal ByteNr As Integer) As Integer

'  Textausgabe
Public Declare Sub MB_Print Lib "XemoDll.dll" Alias "_MB_Print@4" (ByVal Text As  String)
Public Declare Sub MB_Printxy Lib "XemoDll.dll" Alias "_MB_Printxy@12" (ByVal x As Integer, ByVal y As Integer, ByVal Text As  String)
Public Declare Sub MB_Cpos Lib "XemoDll.dll" Alias "_MB_Cpos@8" (ByVal x As Integer, ByVal y As Integer)
Public Declare Sub MB_Ctype Lib "XemoDll.dll" Alias "_MB_Ctype@4" (ByVal cType As Integer)
Public Declare Sub MB_TextAttrib Lib "XemoDll.dll" Alias "_MB_TextAttrib@4" (ByVal Attrib As Integer)
Public Declare Sub MB_Cls Lib "XemoDll.dll" Alias "_MB_Cls@0" ()
Public Declare Sub MB_Cleol Lib "XemoDll.dll" Alias "_MB_Cleol@0" ()

'  Tastatureingabe
Public Declare Function MB_KeyState Lib "XemoDll.dll" Alias "_MB_KeyState@0" () As Integer
Public Declare Function MB_KeyPressed Lib "XemoDll.dll" Alias "_MB_KeyPressed@0" () As Integer
Public Declare Function MB_KeyRead Lib "XemoDll.dll" Alias "_MB_KeyRead@0" () As Integer
Public Declare Sub MB_KeyClear Lib "XemoDll.dll" Alias "_MB_KeyClear@0" ()
Public Declare Sub MB_KeyLed Lib "XemoDll.dll" Alias "_MB_KeyLed@8" (ByVal Key As Integer, ByVal Onoff As Integer)

'  Zeitfunktionen
Public Declare Sub MB_Delay Lib "XemoDll.dll" Alias "_MB_Delay@4" (ByVal Verweilzeit As long)
Public Declare Sub MB_Still Lib "XemoDll.dll" Alias "_MB_Still@4" (ByVal Achse As Integer)


' ----------------------------------------------------------------------
'  Weitere nicht dokumetierte Funktionen 
' ----------------------------------------------------------------------
Public Declare Sub MB_SdoTrm Lib "XemoDll.dll" Alias "_MB_SdoTrm@16" (ByVal NodeId As Integer, ByVal Index As Integer, ByVal SubIndex As Integer, ByVal Value As long)
Public Declare Function MB_SdoRcv Lib "XemoDll.dll" Alias "_MB_SdoRcv@12" (ByVal NodeId As Integer, ByVal Index As Integer, ByVal SubIndex As Integer) As long
Public Declare Function ML_PutDataCsum Lib "XemoDll.dll" Alias "_ML_PutDataCsum@8" (ByRef TrmData As Any, ByVal Size As Integer) As Integer
