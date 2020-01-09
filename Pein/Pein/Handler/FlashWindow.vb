Imports System.Runtime.InteropServices

Public Class FlashWindow
    <DllImport("user32.dll")>
    Private Shared Function FlashWindowEx(ByRef pwfi As FLASHWINFO) As <MarshalAs(UnmanagedType.Bool)> Boolean


    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure FLASHWINFO
        Public cbSize As UInteger
        Public hwnd As IntPtr
        Public dwFlags As UInteger
        Public uCount As UInteger
        Public dwTimeout As UInteger
    End Structure

    Public Const FLASHW_STOP As UInteger = 0
    Public Const FLASHW_CAPTION As UInteger = 1
    Public Const FLASHW_TRAY As UInteger = 2
    Public Const FLASHW_ALL As UInteger = 3
    Public Const FLASHW_TIMER As UInteger = 4
    Public Const FLASHW_TIMERNOFG As UInteger = 12

    Public Shared Function Flash(ByVal form As System.Windows.Forms.Form) As Boolean
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_ALL Or FLASHW_TIMERNOFG, UInteger.MaxValue, 0)
            Return FlashWindowEx(fi)
        End If

        Return False
    End Function

    Private Shared Function Create_FLASHWINFO(ByVal handle As IntPtr, ByVal flags As UInteger, ByVal count As UInteger, ByVal timeout As UInteger) As FLASHWINFO
        Dim fi As FLASHWINFO = New FLASHWINFO()
        fi.cbSize = Convert.ToUInt32(Marshal.SizeOf(fi))
        fi.hwnd = handle
        fi.dwFlags = flags
        fi.uCount = count
        fi.dwTimeout = timeout
        Return fi
    End Function

    Public Shared Function Flash(ByVal form As System.Windows.Forms.Form, ByVal count As UInteger) As Boolean
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_ALL, count, 0)
            Return FlashWindowEx(fi)
        End If

        Return False
    End Function

    Public Shared Function Start(ByVal form As System.Windows.Forms.Form) As Boolean
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_ALL, UInteger.MaxValue, 0)
            Return FlashWindowEx(fi)
        End If

        Return False
    End Function

    Public Shared Function [Stop](ByVal form As System.Windows.Forms.Form) As Boolean
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_STOP, UInteger.MaxValue, 0)
            Return FlashWindowEx(fi)
        End If

        Return False
    End Function

    Private Shared ReadOnly Property Win2000OrLater As Boolean
        Get
            Return System.Environment.OSVersion.Version.Major >= 5
        End Get
    End Property
End Class
