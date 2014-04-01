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

Public Class DWM
    <StructLayout(LayoutKind.Sequential)>
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
        Public Sub New(Left As Integer, Right As Integer, Top As Integer, Bottom As Integer)
            Me.cxLeftWidth = Left
            Me.cxRightWidth = Right
            Me.cyTopHeight = Top
            Me.cyBottomHeight = Bottom
        End Sub
    End Structure

    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hdc As IntPtr, ByRef marInset As MARGINS) As Integer
    End Function
    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Boolean) As Integer
    End Function
    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmDefWindowProc(ByVal hwnd As IntPtr, ByVal msg As UInt16, ByVal wParam As Long, ByVal lParam As Long, <Out> ByRef plResult As Integer) As Integer
    End Function

    Public Const WM_NCHITTEST As Integer = &H84
    Public Const HTCLIENT As Integer = 1
    Public Const HTCAPTION As Integer = 2

End Class
