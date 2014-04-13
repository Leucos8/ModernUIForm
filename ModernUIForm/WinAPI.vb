'   ModernUIForm - Small class library for creating borderless windows
'   Copyright (C) 2014 - Leucos
'
'   ModernUIForm is free software: you can redistribute it and/or modify it under
'   the terms of the GNU Lesser General Public License as published by the Free
'   Software Foundation, either version 3 of the License, or (at your option) any
'   later version.
'
'   ModernUIForm is distributed in the hope that it will be useful, but WITHOUT ANY
'   WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
'   PARTICULAR PURPOSE. See the GNU General Public License for more details.
'
'   You should have received a copy of the GNU General Public License along with 
'   ModernUIForm. If not, see <http://www.gnu.org/licenses/>.

Imports System.Runtime.InteropServices

Friend Class WinAPI
#Region "Structures"
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/bb773244%28v=vs.85%29.aspx
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure MARGINS
        Friend cxLeftWidth As Integer
        Friend cxRightWidth As Integer
        Friend cyTopHeight As Integer
        Friend cyBottomHeight As Integer
        Friend Sub New(Left As Integer, Top As Integer, Right As Integer, Bottom As Integer)
            cxLeftWidth = Left
            cxRightWidth = Right
            cyTopHeight = Top
            cyBottomHeight = Bottom
        End Sub
    End Structure
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms632606%28v=vs.85%29.aspx
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure NCCALCSIZE_PARAMS
        Friend rect0 As RECT
        Friend rect1 As RECT
        Friend rect2 As RECT
        Friend lppos As WINDOWPOS
    End Structure
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/dd162897%28v=vs.85%29.aspx
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure RECT
        Friend left As Long
        Friend top As Long
        Friend right As Long
        Friend bottom As Long
    End Structure
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms632612%28v=vs.85%29.aspx
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure WINDOWPOS
        Friend hwnd As IntPtr
        Friend hwndInsertAfter As IntPtr
        Friend x As Integer
        Friend y As Integer
        Friend cx As Integer
        Friend cy As Integer
        Friend flags As UInteger
    End Structure
#End Region

#Region "Enums"
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms644927%28v=vs.85%29.aspx#system_defined
    ''' </summary>
    Friend Enum Win32Messages As Integer
        ''' <summary>
        ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms647592%28v=vs.85%29.aspx
        ''' </summary>
        WM_CONTEXTMENU = &H7B
        ''' <summary>
        ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms632634%28v=vs.85%29.aspx
        ''' </summary>
        WM_NCCALCSIZE = &H83
        ''' <summary>
        ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms645618%28v=vs.85%29.aspx
        ''' </summary>
        WM_NCHITTEST = &H84
        ''' <summary>
        ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms645620%28v=vs.85%29.aspx
        ''' </summary>
        WM_NCLBUTTONDOWN = &HA1
        ''' <summary>
        ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms645619%28v=vs.85%29.aspx
        ''' </summary>
        WM_NCLBUTTONDBLCLK = &HA3
        ''' <summary>
        ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms645629%28v=vs.85%29.aspx
        ''' </summary>
        WM_NCRBUTTONDOWN = &HA4
        ''' <summary>
        ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms645630%28v=vs.85%29.aspx
        ''' </summary>
        WM_NCRBUTTONUP = &HA5
    End Enum
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms645618%28v=vs.85%29.aspx
    ''' </summary>
    Enum HitTest As Integer
        HTERROR = -2
        HTTRANSPARENT = -1
        HTNOWHERE = 0
        HTCLIENT = 1
        HTCAPTION = 2
        HTSYSMENU = 3
        HTGROWBOX = 4
        HTSIZE = 4
        HTMENU = 5
        HTHSCROLL = 6
        HTVSCROLL = 7
        HTMINBUTTON = 8
        HTMAXBUTTON = 9
        HTLEFT = 10
        HTRIGHT = 11
        HTTOP = 12
        HTTOPLEFT = 13
        HTTOPRIGHT = 14
        HTBOTTOM = 15
        HTBOTTOMLEFT = 16
        HTBOTTOMRIGHT = 17
        HTBORDER = 18
        HTCLOSE = 20
        HTHELP = 21
    End Enum
#End Region

#Region "Functions"
    ''' <summary>
    ''' Sends the specified message to a window or windows.
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms644950%28v=vs.85%29.aspx
    ''' </summary>
    ''' <param name="hWnd">Handle to the window that will receive the message.</param>
    ''' <param name="Msg">The message to be sent.</param>
    ''' <param name="wParam">Additional message-specific information.</param>
    ''' <param name="lParam">Additional message-specific information.</param>
    ''' <returns>Return value depends on Msg.</returns>
    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(<[In]> ByVal hWnd As IntPtr, <[In]> ByVal Msg As Integer, <[In]> ByVal wParam As IntPtr, <[In]> ByVal lParam As IntPtr) As IntPtr
    End Function
    ''' <summary>
    ''' Releases the mouse capture. 
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms646261%28v=vs.85%29.aspx
    ''' </summary>
    ''' <returns>Zero if the function fails, non-zero if the fuction succedes.</returns>
    <DllImport("user32.dll")> _
    Public Shared Function ReleaseCapture() As Integer
    End Function
#End Region

End Class
