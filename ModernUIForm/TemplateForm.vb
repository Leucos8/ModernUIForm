﻿'   ModernUIForm - Small class library for creating borderless windows
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

Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports ModernUIForm.WinAPI
Imports System.ComponentModel

Public Class TemplateForm
    Private _dwmNCAMargins As MARGINS
    <Description("Sets the margin of the non client area."), Category("ModernUIForm")> _
    Public Property DWMMargins() As Padding
        Get
            Return New Padding(_dwmNCAMargins.cxLeftWidth, _dwmNCAMargins.cyTopHeight, _dwmNCAMargins.cxRightWidth, _dwmNCAMargins.cyBottomHeight)
        End Get
        Set(ByVal value As Padding)
            _dwmNCAMargins = New MARGINS(value.Left, value.Top, value.Right, value.Bottom)
        End Set
    End Property

    Private _RBT As Size
    <Description("Sets the size of the resize border thickness."), Category("ModernUIForm")>
    Public Property ResizeBorderThickness() As Size
        Get
            Return _RBT
        End Get
        Set(ByVal value As Size)
            _RBT = value
        End Set
    End Property

    Private _captionHeight As Integer
    <Description("Sets a the caption height for hit testing."), Category("ModernUIForm")>
    Public Property CaptionHeight() As Integer
        Get
            Return _captionHeight
        End Get
        Set(ByVal value As Integer)
            _captionHeight = value
        End Set
    End Property

    Private _CaptionBGActive As Color
    <Description("Sets the caption color when windows is active."), Category("ModernUIForm")>
    Public Property CaptionBackColorActive() As Color
        Get
            Return _CaptionBGActive
        End Get
        Set(ByVal value As Color)
            _CaptionBGActive = value
        End Set
    End Property
    Private _CaptionBGInactive As Color
    <Description("Sets the caption color when windows is inactive."), Category("ModernUIForm")>
    Public Property CaptionBackColorInactive() As Color
        Get
            Return _CaptionBGInactive
        End Get
        Set(ByVal value As Color)
            _CaptionBGInactive = value
        End Set
    End Property

    Private _BorderBGActive As Color
    <Description("Sets the border color when windows is active."), Category("ModernUIForm")>
    Public Property BorderBackColorActive() As Color
        Get
            Return _BorderBGActive
        End Get
        Set(ByVal value As Color)
            _BorderBGActive = value
        End Set
    End Property
    Private _BorderBGInactive As Color
    <Description("Sets the border color when windows is inactive."), Category("ModernUIForm")>
    Public Property BorderBackColorInactive() As Color
        Get
            Return _BorderBGInactive
        End Get
        Set(ByVal value As Color)
            _BorderBGInactive = value
        End Set
    End Property

    Private ReadOnly Property IsResizable() As Boolean
        Get
            Select Case FormBorderStyle
                Case Windows.Forms.FormBorderStyle.Sizable, Windows.Forms.FormBorderStyle.SizableToolWindow
                    Return True
                Case Windows.Forms.FormBorderStyle.Fixed3D, Windows.Forms.FormBorderStyle.FixedDialog, _
                    Windows.Forms.FormBorderStyle.FixedSingle, Windows.Forms.FormBorderStyle.FixedToolWindow, _
                    Windows.Forms.FormBorderStyle.None
                    Return False
                Case Else
                    Return False
            End Select
        End Get
    End Property

    Private CaptionBGCurrent As Color
    Private BorderBGCurrent As Color

    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)

        ' Default property values
        _dwmNCAMargins = New MARGINS(SystemInformation.FrameBorderSize.Width, SystemInformation.FrameBorderSize.Height, _
                                     SystemInformation.FrameBorderSize.Width, SystemInformation.FrameBorderSize.Height)
        Me.Padding = Me.DWMMargins

        _captionHeight = 23
        _RBT = New Size(SystemInformation.HorizontalResizeBorderThickness, SystemInformation.VerticalResizeBorderThickness)

        _CaptionBGActive = SystemColors.ActiveCaption
        _CaptionBGInactive = SystemColors.InactiveCaption
        _BorderBGActive = SystemColors.ActiveBorder
        _BorderBGInactive = SystemColors.InactiveBorder

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        DoubleBuffered = True

    End Sub

    Protected Overrides Sub OnActivated(e As EventArgs)
        CaptionBGCurrent = _CaptionBGActive
        BorderBGCurrent = _BorderBGActive

        If DWM.IsDwmEnabled Then
            DWM.DwmExtendFrameIntoClientArea(Handle, _dwmNCAMargins)
        End If

        MyBase.OnActivated(e)
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnDeactivate(e As EventArgs)
        CaptionBGCurrent = _CaptionBGInactive
        BorderBGCurrent = _BorderBGInactive
        MyBase.OnDeactivate(e)
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim b As New SolidBrush(CaptionBGCurrent)
        e.Graphics.FillRectangle(b, _dwmNCAMargins.cxLeftWidth, _dwmNCAMargins.cyTopHeight, Width - _dwmNCAMargins.cxLeftWidth - _dwmNCAMargins.cxRightWidth, _captionHeight)
        b = New SolidBrush(BorderBGCurrent)
        e.Graphics.FillRectangle(b, 0, 0, Width, _dwmNCAMargins.cyTopHeight) 'Top border
        e.Graphics.FillRectangle(b, 0, Height - _dwmNCAMargins.cyBottomHeight, Width, _dwmNCAMargins.cyBottomHeight)  'Bottom border
        e.Graphics.FillRectangle(b, 0, 0, _dwmNCAMargins.cxLeftWidth, Height) 'Left border
        e.Graphics.FillRectangle(b, Width - _dwmNCAMargins.cxRightWidth, 0, _dwmNCAMargins.cxRightWidth, Height) 'Right border
        'e.Graphics.DrawLine(Pens.Red, 0, 0, Width, Height)
        'e.Graphics.DrawRectangle(Pens.Green, _RBT.Width, _RBT.Height, Width - _RBT.Width * 2, Height - _RBT.Height * 2)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim result As IntPtr

        If DWM.IsDwmEnabled AndAlso DWM.DwmDefWindowProc(Handle, m.Msg, m.WParam, m.LParam, result) Then
            m.Result = result
            Exit Sub
        End If

        If (m.Msg = Win32Messages.WM_NCCALCSIZE) AndAlso (CType(m.WParam, Boolean) = True) Then
            m.Result = IntPtr.Zero
        ElseIf (m.Msg = Win32Messages.WM_NCHITTEST) AndAlso (m.Result = IntPtr.Zero) Then
            m.Result = HitTestNCA(m.LParam)
        Else
            MyBase.WndProc(m)
        End If
    End Sub

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        'Override SetBoundsCore procedure that causes the windows form to grow indefinitely when minizimized and restored or in when in design mode
        'However the SystemInformation class return an incorrect value if host process is enabled in project settings, so in debug and design mode 
        'the frame resize wrongly. This happens because a compatibility shim is enabled if target framework is below or equal to .Net 4.0.
        'More info: http://support.microsoft.com/kb/2877623
        Dim tmpBorderSize As Size
        Dim tmpCaptionHeight As Integer
        Select Case FormBorderStyle
            Case Windows.Forms.FormBorderStyle.Sizable
                tmpBorderSize = SystemInformation.FrameBorderSize
                tmpCaptionHeight = SystemInformation.CaptionHeight
            Case Windows.Forms.FormBorderStyle.Fixed3D
                tmpBorderSize = SystemInformation.Border3DSize + SystemInformation.FrameBorderSize
                tmpCaptionHeight = SystemInformation.CaptionHeight
            Case Windows.Forms.FormBorderStyle.FixedDialog, Windows.Forms.FormBorderStyle.FixedSingle
                tmpBorderSize = SystemInformation.FixedFrameBorderSize
                tmpCaptionHeight = SystemInformation.CaptionHeight
            Case Windows.Forms.FormBorderStyle.SizableToolWindow
                tmpBorderSize = SystemInformation.FrameBorderSize
                tmpCaptionHeight = SystemInformation.ToolWindowCaptionHeight
            Case Windows.Forms.FormBorderStyle.FixedToolWindow
                tmpBorderSize = SystemInformation.FixedFrameBorderSize
                tmpCaptionHeight = SystemInformation.ToolWindowCaptionHeight
            Case Windows.Forms.FormBorderStyle.None
                tmpBorderSize = New Size(0, 0)
                tmpCaptionHeight = 0
        End Select

        If specified = BoundsSpecified.All Or specified = BoundsSpecified.Size Then
            width -= tmpBorderSize.Width * 2
            height -= tmpCaptionHeight + tmpBorderSize.Height * 2
        ElseIf specified = BoundsSpecified.Width Then
            width -= tmpBorderSize.Width * 2
        ElseIf specified = BoundsSpecified.Height Then
            height -= tmpCaptionHeight + tmpBorderSize.Height * 2
        End If
        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

    Private Function HitTestNCA(lParam As IntPtr) As IntPtr
        Dim p As New Point(CInt(lParam) And &HFFFF, (CInt(lParam) >> 16) And &HFFFF)
        p = p - New Size(Me.Location)
        Return HitTestNCA(p)
    End Function

    Private Function HitTestNCA(CursorPosition As Point) As IntPtr
        Dim tmpRBT As New Size(0, 0)
        If Me.IsResizable AndAlso (Me.WindowState = FormWindowState.Normal) Then
            tmpRBT = _RBT
        End If

        Dim hitRect As New Rectangle(tmpRBT.Width, tmpRBT.Height + _captionHeight, _
                                     Width - tmpRBT.Height * 2, Height - _captionHeight - tmpRBT.Width * 2)

        'Client
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTCLIENT)
        End If
        'Caption
        hitRect.Y = tmpRBT.Height
        hitRect.Height = _captionHeight
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTCAPTION)
        End If
        'Top
        hitRect.Y = 0
        hitRect.Height = tmpRBT.Width
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTTOP)
        End If
        'Bottom
        hitRect.Y = Height - tmpRBT.Width
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTBOTTOM)
        End If
        'Left
        hitRect.X = 0
        hitRect.Y = tmpRBT.Height
        hitRect.Width = tmpRBT.Width
        hitRect.Height = Height - tmpRBT.Height * 2
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTLEFT)
        End If
        'Right
        hitRect.X = Width - tmpRBT.Width
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTRIGHT)
        End If
        'TopLeft
        hitRect.X = 0
        hitRect.Y = 0
        hitRect.Width = tmpRBT.Width
        hitRect.Height = tmpRBT.Height
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTTOPLEFT)
        End If
        'TopRight
        hitRect.X = Width - tmpRBT.Width
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTTOPRIGHT)
        End If
        'BottomRight
        hitRect.Y = Height - tmpRBT.Width
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTBOTTOMRIGHT)
        End If
        'BottomLeft
        hitRect.X = 0
        If hitRect.Contains(CursorPosition) Then
            Return New IntPtr(HitTest.HTBOTTOMLEFT)
        End If

        Return New IntPtr(HitTest.HTNOWHERE)

    End Function

    Private Sub ExtendHitTest_MouseMove(sender As Object, e As MouseEventArgs)
        Try
            Dim result As IntPtr = HitTestNCA(e.Location + New Size(CType(sender, Control).Location))
            ReleaseCapture()
            If e.Button = Windows.Forms.MouseButtons.Left Then
                WinAPI.SendMessage(Handle, Win32Messages.WM_NCLBUTTONDOWN, result, Nothing)
            End If

            Select Case CInt(result)
                Case HitTest.HTTOP, HitTest.HTBOTTOM
                    CType(sender, Control).Cursor = Cursors.SizeNS
                Case HitTest.HTLEFT, HitTest.HTRIGHT
                    CType(sender, Control).Cursor = Cursors.SizeWE
                Case HitTest.HTTOPLEFT, HitTest.HTBOTTOMRIGHT
                    CType(sender, Control).Cursor = Cursors.SizeNWSE
                Case HitTest.HTTOPRIGHT, HitTest.HTBOTTOMLEFT
                    CType(sender, Control).Cursor = Cursors.SizeNESW
                Case Else
                    CType(sender, Control).Cursor = Cursors.Default
            End Select
            Exit Sub
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub ExtendHitTest_MouseDoubleClick(sender As Object, e As EventArgs)
        Dim result As IntPtr = HitTestNCA(Cursor.Position - New Size(Location))
        ReleaseCapture()
        WinAPI.SendMessage(Handle, Win32Messages.WM_NCLBUTTONDBLCLK, result, Nothing)
    End Sub

    Public Sub AddControlToFormHitTest(c As Control)
        AddHandler c.MouseMove, AddressOf ExtendHitTest_MouseMove
        AddHandler c.DoubleClick, AddressOf ExtendHitTest_MouseDoubleClick
    End Sub
End Class