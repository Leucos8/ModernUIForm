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
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports ModernUIForm.DWM

Public Class TemplateForm
    Private dwmMargins As MARGINS
    Private topRect As Rectangle = Rectangle.Empty
    Private dwmEnabled As Boolean = False

    Public Sub New()
        Me.SetStyle(ControlStyles.ResizeRedraw, True)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        Me.DoubleBuffered = True

        Me.dwmEnabled = Me.IsDwmEnabled
        If Me.dwmEnabled Then
            dwmMargins = New MARGINS(SystemInformation.FrameBorderSize.Width, _
                                     SystemInformation.FrameBorderSize.Width, _
                                     SystemInformation.FrameBorderSize.Height, _
                                     SystemInformation.FrameBorderSize.Height)
            DwmExtendFrameIntoClientArea(Me.Handle, dwmMargins)
        End If

    End Sub

    Private Function IsDwmEnabled() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then
            Return False
        End If
        Dim isGlassSupported As Boolean = False
        DWM.DwmIsCompositionEnabled(isGlassSupported)
        Return isGlassSupported
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim b As New SolidBrush(SystemColors.GradientActiveCaption)
        e.Graphics.FillRectangle(b, 0, 0, Me.Width, dwmMargins.cyTopHeight) 'Top border
        e.Graphics.FillRectangle(b, 0, Me.Height - dwmMargins.cyBottomHeight, Me.Width, dwmMargins.cyBottomHeight)  'Bottom border
        e.Graphics.FillRectangle(b, 0, 0, dwmMargins.cxLeftWidth, Me.Height) 'Left border
        e.Graphics.FillRectangle(b, Me.Width - dwmMargins.cxRightWidth, 0, dwmMargins.cxRightWidth, Me.Height) 'Right border5
        e.Graphics.DrawLine(Pens.Red, 0, 0, Me.Width, Me.Height)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim result As IntPtr

        If dwmEnabled AndAlso DWM.DwmDefWindowProc(Me.Handle, m.Msg, m.WParam, m.LParam, result) Then
            m.Result = result
            Exit Sub
        End If

        If (m.Msg = WM_NCCALCSIZE) AndAlso (CType(m.WParam, Boolean) = True) Then
            m.Result = IntPtr.Zero
        ElseIf (m.Msg = WM_NCHITTEST) AndAlso (m.Result = IntPtr.Zero) Then
            m.Result = HitTestNCA(m.HWnd, m.WParam, m.LParam)
        Else
            MyBase.WndProc(m)
        End If
    End Sub

    Private Function HitTestNCA(hWnd As IntPtr, wParam As IntPtr, lParam As IntPtr) As IntPtr
        'Const HTERROR As Integer = -2
        'Const HTTRANSPARENT As Integer = -1
        Const HTNOWHERE As Integer = 0
        Const HTCLIENT As Integer = 1
        Const HTCAPTION As Integer = 2
        'Const HTSIZE As Integer = 4
        'Const HTMENU As Integer = 5
        'Const HTHSCROLL As Integer = 6
        'Const HTVSCROLL As Integer = 7
        'Const HTMINBUTTON As Integer = 8
        'Const HTMAXBUTTON As Integer = 9
        Const HTLEFT As Integer = 10
        Const HTRIGHT As Integer = 11
        Const HTTOP As Integer = 12
        Const HTTOPLEFT As Integer = 13
        Const HTTOPRIGHT As Integer = 14
        Const HTBOTTOM As Integer = 15
        Const HTBOTTOMLEFT As Integer = 16
        Const HTBOTTOMRIGHT As Integer = 17
        'Const HTBORDER As Integer = 18
        'Const HTCLOSE As Integer = 20
        'Const HTHELP As Integer = 21


        Dim p As New Point(CInt(lParam) And &HFFFF, (CInt(lParam) >> 16) And &HFFFF)
        p = p - New Size(Me.Location)

        'Dim windowRect As Rectangle = RectangleToScreen(New Rectangle(0, 0, Me.Width, Me.Height))
        Dim hRBT As Integer = SystemInformation.HorizontalResizeBorderThickness
        Dim vRBT As Integer = SystemInformation.VerticalResizeBorderThickness
        Dim hitRect As New Rectangle(vRBT, hRBT + SystemInformation.CaptionHeight, _
                                     Me.Width - hRBT * 2, Me.Height - SystemInformation.CaptionHeight - vRBT * 2)
        'Client
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTCLIENT"
            Return New IntPtr(HTCLIENT)
        End If
        'Caption
        hitRect.Y = hRBT
        hitRect.Height = SystemInformation.CaptionHeight
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTCAPTION"
            Return New IntPtr(HTCAPTION)
        End If
        'Top
        hitRect.Y = 0
        hitRect.Height = vRBT
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTTOP"
            Return New IntPtr(HTTOP)
        End If
        'Bottom
        hitRect.Y = Me.Height - vRBT
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTBOTTOM"
            Return New IntPtr(HTBOTTOM)
        End If
        'Left
        hitRect.X = 0
        hitRect.Y = hRBT
        hitRect.Width = vRBT
        hitRect.Height = Me.Height - hRBT * 2
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTLEFT"
            Return New IntPtr(HTLEFT)
        End If
        'Right
        hitRect.X = Me.Width - vRBT
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTRIGHT"
            Return New IntPtr(HTRIGHT)
        End If
        'TopLeft
        hitRect.X = 0
        hitRect.Y = 0
        hitRect.Width = vRBT
        hitRect.Height = hRBT
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTTOPLEFT"
            Return New IntPtr(HTTOPLEFT)
        End If
        'TopRight
        hitRect.X = Me.Width - vRBT
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTTOPRIGHT"
            Return New IntPtr(HTTOPRIGHT)
        End If
        'BottomRight
        hitRect.Y = Me.Height - vRBT
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTBOTTOMRIGHT"
            Return New IntPtr(HTBOTTOMRIGHT)
        End If
        'BottomLeft
        hitRect.X = 0
        If hitRect.Contains(p) Then
            Me.Label1.Text = "HTBOTTOMLEFT"
            Return New IntPtr(HTBOTTOMLEFT)
        End If

        Me.Label1.Text = "NOWHERE"
        Return New IntPtr(HTNOWHERE)

    End Function
End Class