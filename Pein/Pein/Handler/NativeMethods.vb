Imports System.Runtime.InteropServices
Imports System


Friend Module NativeMethods
    <DllImport("dwmapi.dll")>
    Friend Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer

    End Function
    <DllImport("dwmapi.dll")>
    Friend Function DwmIsCompositionEnabled(<Out> ByRef pfEnabled As Boolean) As Integer

    End Function
    <DllImport("dwmapi.dll")>
    Friend Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal dwAttribute As DWMWINDOWATTRIBUTE, ByRef pvAttribute As Integer, ByVal cbAttribute As Integer) As Integer

    End Function
    Friend Structure MARGINS
        Friend cxLeftWidth As Integer
        Friend cxRightWidth As Integer
        Friend cyTopHeight As Integer
        Friend cyBottomHeight As Integer
    End Structure
    Friend Enum DWMWINDOWATTRIBUTE
        DWMWA_NCRENDERING_ENABLED = 1
        DWMWA_NCRENDERING_POLICY
        DWMWA_TRANSITIONS_FORCEDISABLED
        DWMWA_ALLOW_NCPAINT
        DWMWA_CAPTION_BUTTON_BOUNDS
        DWMWA_NONCLIENT_RTL_LAYOUT
        DWMWA_FORCE_ICONIC_REPRESENTATION
        DWMWA_FLIP3D_POLICY
        DWMWA_EXTENDED_FRAME_BOUNDS
        DWMWA_HAS_ICONIC_BITMAP
        DWMWA_DISALLOW_PEEK
        DWMWA_EXCLUDED_FROM_PEEK
        DWMWA_CLOAK
        DWMWA_CLOAKED
        DWMWA_FREEZE_REPRESENTATION
        DWMWA_LAST
    End Enum
    <Flags>
    Friend Enum WindowsMessages
        CS_DROPSHADOW = &H20000
        NULL = &H0
        WM_NCPAINT = &H85
        WM_NCACTIVATE = &H86
    End Enum
End Module
