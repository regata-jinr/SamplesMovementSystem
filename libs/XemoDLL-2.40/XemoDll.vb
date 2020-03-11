Option Strict Off
Option Explicit On

Imports System
Imports System.Text
Imports System.Runtime.InteropServices

Module XemoDll
	Public Const XEMO_DLL_VESRION As String = "2.40"

    ' ----------------------------------------------------------------------
    '  Initialisierungs Funktionen
    ' ----------------------------------------------------------------------
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_TimeOut")> _
    Public Sub ML_TimeOut(ByVal ComTimeout As Double, ByVal FifoTimeout As Double)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_FifoIdle")> _
    Public Sub ML_FifoIdle(ByVal FifoIdle As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_IniCom")> _
    Public Function ML_IniCom(ByVal ComNo As Short, ByVal Baud As Integer) As Short
    End Function

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_IniUsb")> _
    Public Function ML_IniUsb(ByVal ComNo As Short, ByVal SerialNo As String) As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_IniTCP")> _
    Public Function ML_IniTCP(ByVal IpAddr As String, ByVal Port As Integer) As Short
    End Function

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_DeIniCom")> _
    Public Sub ML_DeIniCom()
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_DeIniComPort")> _
    Public Sub ML_DeIniComPort(ByVal ComNo As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_ComSelect")> _
    Public Sub ML_ComSelect(ByVal ComNo As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_CsumMode")> _
    Public Sub ML_CsumMode(ByVal mode As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetDllVersion")> _
    Public Sub ML_GetDllVersion(ByVal Version As StringBuilder, ByVal MaxLen As Short)
    End Sub

    ' ----------------------------------------------------------------------
    '  Fehlerbehandlung
    ' ----------------------------------------------------------------------
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_ErrorCallBack")> _
    Public Sub ML_ErrorCallBack(ByVal ErrorFunc As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_RunErrCallBack")> _
    Public Sub ML_RunErrCallBack(ByVal ErrorFunc As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetErrCode")> _
    Public Function ML_GetErrCode() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetErrState")> _
    Public Function ML_GetErrState() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_SetErrState")> _
    Public Sub ML_SetErrState(ByVal State As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_LastRunErr")> _
    Public Function ML_LastRunErr() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetComErrText")> _
    Public Sub ML_GetComErrText(ByVal ErrCode As Short, ByVal ErrTxt As StringBuilder, ByVal MaxLen As Short)
    End Sub

    ' ----------------------------------------------------------------------
    '  Datenübertragung
    ' ----------------------------------------------------------------------
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_FifoFull")> _
    Public Function ML_FifoFull() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_FifoBreak")> _
    Public Sub ML_FifoBreak()
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_DoEvents")> _
    Public Sub ML_DoEvents()
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_PutChar")> _
    Public Sub ML_PutChar(ByVal TrmChar As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_PutWord")> _
    Public Sub ML_PutWord(ByVal TrmWord As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_PutLong")> _
    Public Sub ML_PutLong(ByVal TrmLong As Integer)
    End Sub
  
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetRcvState")> _
    Public Function ML_GetRcvState() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetChar")> _
    Public Function ML_GetChar() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetWord")> _
    Public Function ML_GetWord() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="ML_GetLong")> _
    Public Function ML_GetLong() As Integer
    End Function
   
    ' ----------------------------------------------------------------------
    '  MotionBasic-Funktionen
    ' ----------------------------------------------------------------------
    '  Systemkontrolle
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_SysControl")> _
    Public Sub MB_SysControl(ByVal Control As Short)
    End Sub

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_GetState")> _
    Public Function MB_GetState() As Short
    End Function

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_SetFifo")> _
    Public Sub MB_SetFifo(ByVal State As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="NAME")> _
    Public Sub MB_ResErr()
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Call")> _
    Public Sub MB_Call(ByVal ProgNr As Short)
    End Sub

    '  Systemparameter
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Set")> _
    Public Sub MB_Set(ByVal Parameter As Short, ByVal Wert As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_ASet")> _
    Public Sub MB_ASet(ByVal Achse As Short, ByVal Parameter As Short, ByVal Wert As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_IoSet")> _
    Public Sub MB_IoSet(ByVal ByteNr As Short, ByVal BitNr1 As Short, ByVal BitNr2 As Short, ByVal Parameter As Short, ByVal Wert As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Get")> _
    Public Function MB_Get(ByVal Parameter As Short) As Integer
    End Function

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_AGet")> _
    Public Function MB_AGet(ByVal Achse As Short, ByVal Parameter As Short) As Integer
    End Function

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_IoGet")> _
    Public Function MB_IoGet(ByVal ByteNr As Short, ByVal BitNr1 As Short, ByVal BitNr2 As Short, ByVal Parameter As Short) As Short
    End Function

    '  Steuerung einzelner Achsen
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Jog")> _
    Public Sub MB_Jog(ByVal Achse As Short, ByVal Geschwindigkeit As Integer)
    End Sub

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Amove")> _
    Public Sub MB_Amove(ByVal Achse As Short, ByVal Zielposition As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Rmove")> _
    Public Sub MB_Rmove(ByVal Achse As Short, ByVal Verfahrweg As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="NAME")> _
    Public Sub MB_Home(ByVal Achse As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Stop")> _
    Public Sub MB_Stop(ByVal Achse As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Busy")> _
    Public Function MB_Busy(ByVal Achse As Short) As Short
    End Function

    '  Bahnsteuerung
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Lin")> _
    Public Sub MB_Lin(ByVal C_Mask As Short, ByRef Coordinate As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Lin0")> _
    Public Sub MB_Lin0(ByVal C_Mask As Short, ByRef Coordinate As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Lin1")> _
    Public Sub MB_Lin1(ByVal C_Mask As Short, ByRef Coordinate As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Circle")> _
    Public Sub MB_Circle(ByVal Radius As Integer, ByVal Anfangswinkel As Integer, ByVal Endwinkel As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Arc")> _
    Public Sub MB_Arc(ByVal C_Mask As Short, ByVal Radius As Integer, ByRef Coordinate As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Arcc")> _
    Public Sub MB_Arcc(ByVal C_Mask As Short, ByVal Mx As Integer, ByVal My_Renamed As Integer, ByRef Coordinate As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Arcw")> _
    Public Sub MB_Arcw(ByVal C_Mask As Short, ByVal Mx As Integer, ByVal My_Renamed As Integer, ByRef Coordinate As Integer)
    End Sub

    '  Ein- und Ausgänge
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Out")> _
    Public Sub MB_Out(ByVal ByteNr As Short, ByVal BitNr1 As Short, ByVal BitNr2 As Short, ByVal Wert As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Sout")> _
    Public Sub MB_Sout(ByVal ByteNr As Short, ByVal BitNr1 As Short, ByVal BitNr2 As Short, ByVal Wert As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Rout")> _
    Public Function MB_Rout(ByVal ByteNr As Short, ByVal BitNr1 As Short, ByVal BitNr2 As Short) As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_In")> _
    Public Function MB_In(ByVal ByteNr As Short, ByVal BitNr1 As Short, ByVal BitNr2 As Short) As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Waitinp")> _
    Public Sub MB_Waitinp(ByVal ByteNr As Short, ByVal BitNr1 As Short, ByVal BitNr2 As Short, ByVal Wert As Short)
    End Sub

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Inw")> _
    Public Function MB_Inw(ByVal ByteNr As Short) As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Outw")> _
    Public Sub MB_Outw(ByVal ByteNr As Short, ByVal Wert As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Routw")> _
    Public Function MB_Routw(ByVal ByteNr As Short) As Short
    End Function

    '  Textausgabe
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Print")> _
    Public Sub MB_Print(ByVal Text As String)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Printxy")> _
    Public Sub MB_Printxy(ByVal x As Short, ByVal y As Short, ByVal Text As String)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Cpos")> _
    Public Sub MB_Cpos(ByVal x As Short, ByVal y As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Ctype")> _
    Public Sub MB_Ctype(ByVal crType As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_TextAttrib")> _
    Public Sub MB_TextAttrib(ByVal Attrib As Short)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Cls")> _
    Public Sub MB_Cls()
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Cleol")> _
    Public Sub MB_Cleol()
    End Sub

    '  Tastatureingabe
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_KeyState")> _
    Public Function MB_KeyState() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_KeyPressed")> _
    Public Function MB_KeyPressed() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_KeyRead")> _
    Public Function MB_KeyRead() As Short
    End Function
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_KeyClear")> _
    Public Sub MB_KeyClear()
    End Sub

    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_KeyLed")> _
    Public Sub MB_KeyLed(ByVal Key As Short, ByVal Onoff As Short)
    End Sub

    '  Zeitfunktionen
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Delay")> _
    Public Sub MB_Delay(ByVal Verweilzeit As Integer)
    End Sub
    <DllImport("Xemo64.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="MB_Still")> _
    Public Sub MB_Still(ByVal Achse As Short)
    End Sub

End Module