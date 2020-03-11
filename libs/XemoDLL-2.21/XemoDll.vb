Imports System.Runtime.InteropServices

Public Class Xemo

    'Visual Basic .NET

    Public Const XEMO_DLL_VERSION = "2.17"
    ' ----------------------------------------------------------------------
    '  Initialisierungs Funktionen
    ' ----------------------------------------------------------------------
    Declare Sub ML_TimeOut Lib "XemoDll.dll" Alias "_ML_TimeOut@16" (ByVal ComTimeout As Double, ByVal FifoTimeout As Double)
    Declare Sub ML_FifoIdle Lib "XemoDll.dll" Alias "_ML_FifoIdle@4" (ByVal FifoIdle As Int32)
    Declare Function ML_IniCom Lib "XemoDll.dll" Alias "_ML_IniCom@8" (ByVal ComNo As Int16, ByVal Baud As Int32) As Int16
    Declare Function ML_IniUsb Lib "XemoDll.dll" Alias "_ML_IniUsb@8" (ByVal ComNo As Int16, ByVal SerialNo As String) As Int16
    Declare Sub ML_DeIniCom Lib "XemoDll.dll" Alias "_ML_DeIniCom@0" ()
    Declare Sub ML_DeIniComPort Lib "XemoDll.dll" Alias "_ML_DeIniComPort@4" (ByVal ComNo As Int16)

    Declare Sub ML_ComSelect Lib "XemoDll.dll" Alias "_ML_ComSelect@4" (ByVal ComNo As Int16)
    Declare Sub ML_CsumMode Lib "XemoDll.dll" Alias "_ML_CsumMode@4" (ByVal mode As Int16)


    Declare Sub ML_GetDllVersion Lib "XemoDll.dll" Alias "_ML_GetDllVersion@8" (ByVal Version As String, ByVal MaxLen As Int16)

    ' ----------------------------------------------------------------------
    '  Fehlerbehandlung
    ' ----------------------------------------------------------------------
    Declare Auto Sub ML_ErrorCallBack Lib "XemoDll.dll" Alias "_ML_ErrorCallBack@4" (ByVal ErrorFunc As Int32)
    Declare Sub ML_RunErrCallBack Lib "XemoDll.dll" Alias "_ML_RunErrCallBack@4" (ByVal ErrorFunc As Int32)
    Declare Function ML_GetErrCode Lib "XemoDll.dll" Alias "_ML_GetErrCode@0" () As Int16
    Declare Function ML_GetErrState Lib "XemoDll.dll" Alias "_ML_GetErrState@0" () As Int16
    Declare Sub ML_SetErrState Lib "XemoDll.dll" Alias "_ML_SetErrState@4" (ByVal State As Int16)
    Declare Function ML_LastRunErr Lib "XemoDll.dll" Alias "_ML_LastRunErr@0" () As Int16

    Declare Sub ML_GetComErrText Lib "XemoDll.dll" Alias "_ML_GetComErrText@12" (ByVal ErrCode As Int16, ByVal ErrTxt As String, ByVal MaxLen As Int16)

    ' ----------------------------------------------------------------------
    '  Datenübertragung
    ' ----------------------------------------------------------------------
    Declare Function ML_FifoFull Lib "XemoDll.dll" Alias "_ML_FifoFull@0" () As Int16
    Public Declare Sub ML_FifoBreak Lib "XemoDll.dll" Alias "_ML_FifoBreak@0" ()
    Public Declare Sub ML_DoEvents Lib "XemoDll.dll" Alias "_ML_DoEvents@0" ()

    Public Declare Sub ML_PutChar Lib "XemoDll.dll" Alias "_ML_PutChar@4" (ByVal TrmChar As Int16)
    Public Declare Sub ML_PutWord Lib "XemoDll.dll" Alias "_ML_PutWord@4" (ByVal TrmWord As Int16)
    Public Declare Sub ML_PutLong Lib "XemoDll.dll" Alias "_ML_PutLong@4" (ByVal TrmLong As Int32)

    Public Declare Function ML_GetRcvState Lib "XemoDll.dll" Alias "_ML_GetRcvState@0" () As Int16
    Public Declare Function ML_GetChar Lib "XemoDll.dll" Alias "_ML_GetChar@0" () As Int16
    Public Declare Function ML_GetWord Lib "XemoDll.dll" Alias "_ML_GetWord@0" () As Int16
    Public Declare Function ML_GetLong Lib "XemoDll.dll" Alias "_ML_GetLong@0" () As Int32

    Public Declare Sub MB_SdoTrm Lib "XemoDll.dll" Alias "_MB_SdoTrm@16" (ByVal NodeId As Int16, ByVal Index As Int16, ByVal SubIndex As Int16, ByVal Value As Int32)
    Public Declare Function MB_SdoRcv Lib "XemoDll.dll" Alias "_MB_SdoRcv@12" (ByVal NodeId As Int16, ByVal Index As Int16, ByVal SubIndex As Int16) As Int32

    ' ----------------------------------------------------------------------
    '  MotionBasic-Funktionen
    ' ----------------------------------------------------------------------
    '  Systemkontrolle
    Public Declare Sub MB_SysControl Lib "XemoDll.dll" Alias "_MB_SysControl@4" (ByVal Control As Int16)
    Public Declare Function MB_GetState Lib "XemoDll.dll" Alias "_MB_GetState@0" () As Int16
    Public Declare Sub MB_SetFifo Lib "XemoDll.dll" Alias "_MB_SetFifo@4" (ByVal State As Int16)
    Public Declare Sub MB_ResErr Lib "XemoDll.dll" Alias "_MB_ResErr@0" ()
    Public Declare Sub MB_Call Lib "XemoDll.dll" Alias "_MB_Call@4" (ByVal ProgNr As Int16)

    '  Systemparameter
    Public Declare Sub MB_Set Lib "XemoDll.dll" Alias "_MB_Set@8" (ByVal Parameter As Int16, ByVal Wert As Int32)
    Public Declare Sub MB_ASet Lib "XemoDll.dll" Alias "_MB_ASet@12" (ByVal Achse As Int16, ByVal Parameter As Int16, ByVal Wert As Int32)
    Public Declare Sub MB_IoSet Lib "XemoDll.dll" Alias "_MB_IoSet@20" (ByVal ByteNr As Int16, ByVal BitNr1 As Int16, ByVal BitNr2 As Int16, ByVal Parameter As Int16, ByVal Wert As Int16)
    Public Declare Function MB_Get Lib "XemoDll.dll" Alias "_MB_Get@4" (ByVal Parameter As Integer) As Int32
    Public Declare Function MB_AGet Lib "XemoDll.dll" Alias "_MB_AGet@8" (ByVal Achse As Integer, ByVal Parameter As Int16) As Int32
    Public Declare Function MB_IoGet Lib "XemoDll.dll" Alias "_MB_IoGet@16" (ByVal ByteNr As Integer, ByVal BitNr1 As Int16, ByVal BitNr2 As Int16, ByVal Parameter As Int16) As Int16

    '  Steuerung einzelner Achsen
    Public Declare Sub MB_Jog Lib "XemoDll.dll" Alias "_MB_Jog@8" (ByVal Achse As Int16, ByVal Geschwindigkeit As Int32)
    Public Declare Sub MB_Amove Lib "XemoDll.dll" Alias "_MB_Amove@8" (ByVal Achse As Int16, ByVal Zielposition As Int32)
    Public Declare Sub MB_Rmove Lib "XemoDll.dll" Alias "_MB_Rmove@8" (ByVal Achse As Int16, ByVal Verfahrweg As Int32)
    Public Declare Sub MB_Home Lib "XemoDll.dll" Alias "_MB_Home@4" (ByVal Achse As Int16)
    Public Declare Sub MB_Stop Lib "XemoDll.dll" Alias "_MB_Stop@4" (ByVal Achse As Int16)
    Public Declare Function MB_Busy Lib "XemoDll.dll" Alias "_MB_Busy@4" (ByVal Achse As Int16) As Int16

    '  Bahnsteuerung
    Public Declare Sub MB_Lin Lib "XemoDll.dll" Alias "_MB_Lin@8" (ByVal C_Mask As Int16, ByRef Coordinate As Int32)
    Public Declare Sub MB_Lin0 Lib "XemoDll.dll" Alias "_MB_Lin0@8" (ByVal C_Mask As Int16, ByRef Coordinate As Int32)
    Public Declare Sub MB_Lin1 Lib "XemoDll.dll" Alias "_MB_Lin1@8" (ByVal C_Mask As Int16, ByRef Coordinate As Int32)
    Public Declare Sub MB_Circle Lib "XemoDll.dll" Alias "_MB_Circle@12" (ByVal Radius As Int32, ByVal Anfangswinkel As Int32, ByVal Endwinkel As Int32)
    Public Declare Sub MB_Arc Lib "XemoDll.dll" Alias "_MB_Arc@12" (ByVal C_Mask As Int16, ByVal Radius As Int32, ByRef Coordinate As Int32)
    Public Declare Sub MB_Arcc Lib "XemoDll.dll" Alias "_MB_Arcc@16" (ByVal C_Mask As Int16, ByVal Mx As Int32, ByVal My As Int32, ByRef Coordinate As Int32)
    Public Declare Sub MB_Arcw Lib "XemoDll.dll" Alias "_MB_Arcw@16" (ByVal C_Mask As Int16, ByVal Mx As Int32, ByVal My As Int32, ByRef Coordinate As Int32)

    '  Ein- und Ausgänge
    Public Declare Sub MB_Out Lib "XemoDll.dll" Alias "_MB_Out@16" (ByVal ByteNr As Int16, ByVal BitNr1 As Int16, ByVal BitNr2 As Int16, ByVal Wert As Int16)
    Public Declare Sub MB_Sout Lib "XemoDll.dll" Alias "_MB_Sout@16" (ByVal ByteNr As Int16, ByVal BitNr1 As Int16, ByVal BitNr2 As Int16, ByVal Wert As Int16)
    Public Declare Function MB_Rout Lib "XemoDll.dll" Alias "_MB_Rout@12" (ByVal ByteNr As Int16, ByVal BitNr1 As Int16, ByVal BitNr2 As Int16) As Int16
    Public Declare Function MB_In Lib "XemoDll.dll" Alias "_MB_In@12" (ByVal ByteNr As Int16, ByVal BitNr1 As Int16, ByVal BitNr2 As Int16) As Int16
    Public Declare Sub MB_Waitinp Lib "XemoDll.dll" Alias "_MB_Waitinp@16" (ByVal ByteNr As Int16, ByVal BitNr1 As Int16, ByVal BitNr2 As Int16, ByVal Wert As Int16)

    Public Declare Function MB_Inw Lib "XemoDll.dll" Alias "_MB_Inw@4" (ByVal ByteNr As Int16) As Int16
    Public Declare Sub MB_Outw Lib "XemoDll.dll" Alias "_MB_Outw@8" (ByVal ByteNr As Int16, ByVal Wert As Int16)
    Public Declare Function MB_Routw Lib "XemoDll.dll" Alias "_MB_Routw@4" (ByVal ByteNr As Int16) As Int16

    '  Textausgabe
    Public Declare Sub MB_Print Lib "XemoDll.dll" Alias "_MB_Print@4" (ByVal Text As String)
    Public Declare Sub MB_Printxy Lib "XemoDll.dll" Alias "_MB_Printxy@12" (ByVal x As Int16, ByVal y As Int16, ByVal Text As String)
    Public Declare Sub MB_Cpos Lib "XemoDll.dll" Alias "_MB_Cpos@8" (ByVal x As Int16, ByVal y As Int16)
    Public Declare Sub MB_Ctype Lib "XemoDll.dll" Alias "_MB_Ctype@4" (ByVal c_Type As Int16)
    Public Declare Sub MB_TextAttrib Lib "XemoDll.dll" Alias "_MB_TextAttrib@4" (ByVal Attrib As Int16)
    Public Declare Sub MB_Cls Lib "XemoDll.dll" Alias "_MB_Cls@0" ()
    Public Declare Sub MB_Cleol Lib "XemoDll.dll" Alias "_MB_Cleol@0" ()

    '  Tastatureingabe
    Public Declare Function MB_KeyState Lib "XemoDll.dll" Alias "_MB_KeyState@0" () As Int16
    Public Declare Function MB_KeyPressed Lib "XemoDll.dll" Alias "_MB_KeyPressed@0" () As Int16
    Public Declare Function MB_KeyRead Lib "XemoDll.dll" Alias "_MB_KeyRead@0" () As Int16
    Public Declare Sub MB_KeyClear Lib "XemoDll.dll" Alias "_MB_KeyClear@0" ()
    Public Declare Sub MB_KeyLed Lib "XemoDll.dll" Alias "_MB_KeyLed@8" (ByVal Key As Int16, ByVal Onoff As Int16)

    '  Zeitfunktionen
    Public Declare Sub MB_Delay Lib "XemoDll.dll" Alias "_MB_Delay@4" (ByVal Verweilzeit As Int32)
    Public Declare Sub MB_Still Lib "XemoDll.dll" Alias "_MB_Still@4" (ByVal Achse As Int32)


End Class
