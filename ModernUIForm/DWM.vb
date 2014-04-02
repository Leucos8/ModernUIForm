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
Imports System.Drawing

Friend Class DWM
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/bb773244%28v=vs.85%29.aspx
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure MARGINS
        Friend cxLeftWidth As Integer
        Friend cxRightWidth As Integer
        Friend cyTopHeight As Integer
        Friend cyBottomHeight As Integer
        Friend Sub New(Left As Integer, Right As Integer, Top As Integer, Bottom As Integer)
            Me.cxLeftWidth = Left
            Me.cxRightWidth = Right
            Me.cyTopHeight = Top
            Me.cyBottomHeight = Bottom
        End Sub
    End Structure

    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/aa969507%28v=vs.85%29.aspx
    ''' </summary>
    ''' <param name="hwnd"></param>
    ''' <param name="msg"></param>
    ''' <param name="wParam"></param>
    ''' <param name="lParam"></param>
    ''' <param name="plResult"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DllImport("dwmapi.dll")> _
    Friend Shared Function DwmDefWindowProc(<[In]> ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr, <Out> ByRef plResult As IntPtr) As <MarshalAs(UnmanagedType.I1)> Boolean
    End Function

    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/aa969512%28v=vs.85%29.aspx
    ''' </summary>
    ''' <param name="hWnd"></param>
    ''' <param name="marInset"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DllImport("dwmapi.dll")> _
    Friend Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, <[In]> ByRef marInset As MARGINS) As Integer
    End Function
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/aa969518%28v=vs.85%29.aspx
    ''' </summary>
    ''' <param name="pfEnabled"></param>
    ''' <returns></returns>
    <DllImport("dwmapi.dll")> _
    Friend Shared Function DwmIsCompositionEnabled(<MarshalAs(UnmanagedType.I1)> <Out> ByRef pfEnabled As Boolean) As Integer
    End Function

    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms632634%28v=vs.85%29.aspx
    ''' </summary>
    Friend Const WM_NCCALCSIZE As Integer = &H83
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms645618%28v=vs.85%29.aspx
    ''' </summary>
    ''' <remarks></remarks>
    Friend Const WM_NCHITTEST As Integer = &H84
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms632606%28v=vs.85%29.aspx
    ''' </summary>
    Friend Structure NCCALCSIZE_PARAMS
        Friend rect0 As RECT
        Friend rect1 As RECT
        Friend rect2 As RECT
        Friend lppos As WINDOWPOS
    End Structure
    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/dd162897%28v=vs.85%29.aspx
    ''' </summary>
    ''' <remarks></remarks>
    Friend Structure RECT
        Friend left As Long
        Friend top As Long
        Friend right As Long
        Friend bottom As Long
    End Structure

    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/ms632612%28v=vs.85%29.aspx
    ''' </summary>
    Friend Structure WINDOWPOS
        Friend hwnd As IntPtr
        Friend hwndInsertAfter As IntPtr
        Friend x As Integer
        Friend y As Integer
        Friend cx As Integer
        Friend cy As Integer
        Friend flags As UInteger
    End Structure
End Class
