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

Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports ModernUIForm.WinAPI

Public Class TemplateForm
    Private _dwmNCAMargins As MARGINS
    <Description("Sets the margin of the non client area."), Category("ModernUIForm")> _
    Public Property DWMMargins() As Padding
        Get
            Return New Padding(_dwmNCAMargins.cxLeftWidth, _dwmNCAMargins.cyTopHeight, _dwmNCAMargins.cxRightWidth, _dwmNCAMargins.cyBottomHeight)
        End Get
        Set(ByVal value As Padding)
            _dwmNCAMargins = New MARGINS(value.Left, value.Top, value.Right, value.Bottom)
            Me.OnActivated(Nothing)
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
            Me.OnActivated(Nothing)
        End Set
    End Property

    Private _captionColorActive As Color
    <Description("Sets the caption color when windows is active."), Category("ModernUIForm")>
    Public Property CaptionColorActive() As Color
        Get
            Return _captionColorActive
        End Get
        Set(ByVal value As Color)
            _captionColorActive = value
            Me.OnActivated(Nothing)
        End Set
    End Property
    Private _captionColorInactive As Color
    <Description("Sets the caption color when windows is inactive."), Category("ModernUIForm")>
    Public Property CaptionColorInactive() As Color
        Get
            Return _captionColorInactive
        End Get
        Set(ByVal value As Color)
            _captionColorInactive = value
            Me.OnActivated(Nothing)
        End Set
    End Property

    Private _borderColorActive As Color
    <Description("Sets the border color when windows is active."), Category("ModernUIForm")>
    Public Property BorderColorActive() As Color
        Get
            Return _borderColorActive
        End Get
        Set(ByVal value As Color)
            _borderColorActive = value
            Me.OnActivated(Nothing)
        End Set
    End Property
    Private _borderColorInactive As Color
    <Description("Sets the border color when windows is inactive."), Category("ModernUIForm")>
    Public Property BorderColorInactive() As Color
        Get
            Return _borderColorInactive
        End Get
        Set(ByVal value As Color)
            _borderColorInactive = value
            Dim HTValues() As HitTest = {HitTest.HTLEFT, HitTest.HTRIGHT, _
                                 HitTest.HTTOP, HitTest.HTTOPLEFT, HitTest.HTTOPRIGHT, _
                                 HitTest.HTBOTTOM, HitTest.HTBOTTOMLEFT, HitTest.HTBOTTOMRIGHT}
            Me.OnActivated(Nothing)
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

    Private CaptionColorCurrent As Color
    Private BorderColorCurrent As Color

    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)

        ' Default property values
        _dwmNCAMargins = New MARGINS(SystemInformation.FrameBorderSize.Width, SystemInformation.FrameBorderSize.Height, _
                                     SystemInformation.FrameBorderSize.Width, SystemInformation.FrameBorderSize.Height)
        Me.Padding = Me.DWMMargins

        _captionHeight = 23
        _RBT = New Size(SystemInformation.HorizontalResizeBorderThickness, SystemInformation.VerticalResizeBorderThickness)

        _captionColorActive = SystemColors.ActiveCaption
        _captionColorInactive = SystemColors.InactiveCaption
        _borderColorActive = SystemColors.ActiveBorder
        _borderColorInactive = SystemColors.InactiveBorder

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        DoubleBuffered = True

    End Sub

#Region "Overrides"
    Protected Overrides Sub OnActivated(e As EventArgs)
        CaptionColorCurrent = _captionColorActive
        BorderColorCurrent = _borderColorActive

        If DWM.IsDwmEnabled Then
            DWM.DwmExtendFrameIntoClientArea(Handle, _dwmNCAMargins)
        End If

        MyBase.OnActivated(e)

        Me.InvalidateFrame()
    End Sub

    Protected Overrides Sub OnDeactivate(e As EventArgs)
        CaptionColorCurrent = _captionColorInactive
        BorderColorCurrent = _borderColorInactive
        MyBase.OnDeactivate(e)

        Me.InvalidateFrame()
    End Sub

    Private Sub InvalidateFrame()
        Dim HTValues() As HitTest = {HitTest.HTCAPTION, _
                                     HitTest.HTLEFT, HitTest.HTRIGHT, _
                                     HitTest.HTTOP, HitTest.HTTOPLEFT, HitTest.HTTOPRIGHT, _
                                     HitTest.HTBOTTOM, HitTest.HTBOTTOMLEFT, HitTest.HTBOTTOMRIGHT}
        For i As Integer = 0 To HTValues.Count - 1
            Me.Invalidate(Me.GetFrameRectangle(HTValues(i)))
        Next i
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        'Caption brush
        Dim b As New SolidBrush(CaptionColorCurrent)
        'Caption
        e.Graphics.FillRectangle(b, Me.GetFrameRectangle(HitTest.HTCAPTION))
        'Border brush
        b = New SolidBrush(BorderColorCurrent)

        Dim HTValues() As HitTest = {HitTest.HTLEFT, HitTest.HTRIGHT, _
                                     HitTest.HTTOP, HitTest.HTTOPLEFT, HitTest.HTTOPRIGHT, _
                                     HitTest.HTBOTTOM, HitTest.HTBOTTOMLEFT, HitTest.HTBOTTOMRIGHT}
        For i As Integer = 0 To HTValues.Count - 1
            e.Graphics.FillRectangle(b, Me.GetFrameRectangle(HTValues(i)))
        Next i
        'e.Graphics.DrawLine(Pens.Red, 0, 0, Width, Height)
        'e.Graphics.DrawRectangle(Pens.Green, _RBT.Width, _RBT.Height, Width - _RBT.Width * 2, Height - _RBT.Height * 2)
    End Sub

    ''' <summary>
    ''' Overrides default Windows message handling.
    ''' http://msdn.microsoft.com/it-it/library/system.windows.forms.control.wndproc%28v=vs.110%29.aspx
    ''' </summary>
    ''' <param name="m">The Windows Message to process</param>
    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim result As IntPtr

        If DWM.IsDwmEnabled AndAlso DWM.DwmDefWindowProc(Handle, m.Msg, m.WParam, m.LParam, result) Then
            m.Result = result
            Exit Sub
        End If

        If (m.Msg = Win32Messages.WM_NCCALCSIZE) AndAlso (CType(m.WParam, Boolean) = True) Then
            m.Result = IntPtr.Zero
        ElseIf (m.Msg = Win32Messages.WM_NCHITTEST) AndAlso (m.Result = IntPtr.Zero) Then
            m.Result = New IntPtr(HitTestNCA(m.LParam))
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
#End Region

#Region "Hit test emulation"
    Private Function HitTestNCA(lParam As IntPtr) As Integer
        Dim p As New Point(CInt(lParam) And &HFFFF, (CInt(lParam) >> 16) And &HFFFF)
        Return HitTestNCA(p)
    End Function

    Private Function HitTestNCA(CursorPosition As Point) As Integer
        CursorPosition = CursorPosition - New Size(Me.Location)

        Dim HTValues() As HitTest = {HitTest.HTCLIENT, HitTest.HTCAPTION, _
                                     HitTest.HTLEFT, HitTest.HTRIGHT, _
                                     HitTest.HTTOP, HitTest.HTTOPLEFT, HitTest.HTTOPRIGHT, _
                                     HitTest.HTBOTTOM, HitTest.HTBOTTOMLEFT, HitTest.HTBOTTOMRIGHT}
        For i As Integer = 0 To HTValues.Count - 1
            If Me.GetHitTestRectangle(HTValues(i)).Contains(CursorPosition) Then
                Return HTValues(i)
            End If
        Next i

        Return HitTest.HTNOWHERE

    End Function
#End Region

#Region "Hit testing extension events"
    Private Sub HitTestingExtension_MouseMove(sender As Object, e As MouseEventArgs)
        Dim result As Integer = HitTestNCA(Cursor.Position)
        Dim c As Control = CType(sender, Control)
        Select Case result
            Case HitTest.HTTOP, HitTest.HTBOTTOM : CType(sender, Control).Cursor = Cursors.SizeNS
            Case HitTest.HTLEFT, HitTest.HTRIGHT : CType(sender, Control).Cursor = Cursors.SizeWE
            Case HitTest.HTTOPLEFT, HitTest.HTBOTTOMRIGHT : CType(sender, Control).Cursor = Cursors.SizeNWSE
            Case HitTest.HTTOPRIGHT, HitTest.HTBOTTOMLEFT : CType(sender, Control).Cursor = Cursors.SizeNESW
            Case HitTest.HTCAPTION : CType(sender, Control).Cursor = Cursors.Default
        End Select

        If e.Button = Windows.Forms.MouseButtons.Left Then
            WinAPI.SendMessage(Handle, Win32Messages.WM_NCLBUTTONDOWN, result, 0)
        End If
        WinAPI.ReleaseCapture()
    End Sub

    Private Sub HitTestingExtension_MouseUp(sender As Object, e As EventArgs)
        If e.GetType = GetType(MouseEventArgs) AndAlso _
            CInt(HitTestNCA(Cursor.Position)) = HitTest.HTCAPTION AndAlso
            CType(e, MouseEventArgs).Button = Windows.Forms.MouseButtons.Right Then

            Dim sysMenu As IntPtr = WinAPI.GetSystemMenu(Me.Handle, False)
            Dim result As Integer
            result = WinAPI.TrackPopupMenu(sysMenu, TPM.TPM_RETURNCMD, Cursor.Position.X, Cursor.Position.Y, 0, Me.Handle, New RECT)
            WinAPI.PostMessage(Me.Handle, Win32Messages.WM_SYSCOMMAND, result, 0)
        End If
        WinAPI.ReleaseCapture()
    End Sub

    Private Sub HitTestingExtension_MouseDoubleClick(sender As Object, e As EventArgs)
        WinAPI.ReleaseCapture()
        WinAPI.SendMessage(Handle, Win32Messages.WM_NCLBUTTONDBLCLK, HitTestNCA(Cursor.Position), 0)
    End Sub

    Private Sub HitTestingExtension_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Control).Cursor = Cursors.Default
    End Sub

    Public Sub HitTestingAddControl(c As Control)
        AddHandler c.MouseMove, AddressOf HitTestingExtension_MouseMove
        AddHandler c.MouseUp, AddressOf HitTestingExtension_MouseUp
        AddHandler c.DoubleClick, AddressOf HitTestingExtension_MouseDoubleClick
        AddHandler c.MouseLeave, AddressOf HitTestingExtension_MouseLeave
    End Sub
#End Region

#Region "GetRectangle"
    Friend Function GetFrameRectangle(area As HitTest) As Rectangle
        Return Me.GetFormRectangle(area, Me.DWMMargins)
    End Function

    Friend Function GetHitTestRectangle(area As HitTest) As Rectangle
        Dim tmpRBT As New Padding(0)
        If Me.IsResizable AndAlso (Me.WindowState = FormWindowState.Normal) Then
            tmpRBT = New Padding(_RBT.Width, _RBT.Height, _RBT.Width, _RBT.Height)
        End If

        Return Me.GetFormRectangle(area, tmpRBT)
    End Function

    Private Function GetFormRectangle(area As HitTest, bt As Padding) As Rectangle

        Select Case area
            Case HitTest.HTCAPTION      '1
                Return New Rectangle(bt.Left, bt.Top, Me.Width - (bt.Left + bt.Right), CaptionHeight)
            Case HitTest.HTCLIENT       '2
                Return New Rectangle(bt.Left, bt.Top + CaptionHeight, Me.Width - (bt.Left + bt.Right), _
                                     Me.Height - (CaptionHeight + bt.Top + bt.Bottom))
            Case HitTest.HTLEFT         '10
                Return New Rectangle(0, bt.Top, bt.Left, Me.Height - (bt.Top + bt.Bottom))
            Case HitTest.HTRIGHT        '11
                Return New Rectangle(Me.Width - bt.Right, bt.Top, bt.Right, Me.Height - (bt.Top + bt.Bottom))
            Case HitTest.HTTOP          '12
                Return New Rectangle(bt.Left, 0, Me.Width - (bt.Left + bt.Right), bt.Top)
            Case HitTest.HTTOPLEFT      '13
                Return New Rectangle(0, 0, bt.Left, bt.Top)
            Case HitTest.HTTOPRIGHT     '14
                Return New Rectangle(Me.Width - bt.Right, 0, bt.Right, bt.Top)
            Case HitTest.HTBOTTOM       '15
                Return New Rectangle(bt.Left, Me.Height - bt.Bottom, Me.Width - (bt.Left + bt.Right), bt.Bottom)
            Case HitTest.HTBOTTOMLEFT   '16
                Return New Rectangle(0, Me.Height - bt.Bottom, bt.Left, bt.Bottom)
            Case HitTest.HTBOTTOMRIGHT  '17
                Return New Rectangle(Me.Width - bt.Right, Me.Height - bt.Bottom, bt.Right, bt.Bottom)
            Case Else
                Return Rectangle.Empty
        End Select
    End Function
#End Region
End Class