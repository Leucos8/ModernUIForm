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

Public Class TestForm1
    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.AddControlToFormHitTest(Me.Panel1)
    End Sub

#Region "Form - ControlBox & Resize"
    Private lastWindowState As FormWindowState

    Private Sub ControlBoxMaximize_Click(sender As Object, e As EventArgs) Handles ControlBoxMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ControlBoxMinimize_Click(sender As Object, e As EventArgs) Handles ControlBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ControlBoxClose_Click(sender As Object, e As EventArgs) Handles ControlBoxClose.Click
        Me.Close()
    End Sub

    Private Sub ControlBoxMaximize_MouseEnter(sender As Object, e As EventArgs) Handles ControlBoxMaximize.MouseEnter
        If Me.WindowState = FormWindowState.Normal Then
            CType(sender, Button).Image = My.Resources.Window_ButtonMaximizeW_12x12
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            CType(sender, Button).Image = My.Resources.Window_ButtonRestoreW_12x12
        End If
    End Sub

    Private Sub ControlBoxMaximize_MouseLeave(sender As Object, e As EventArgs) Handles ControlBoxMaximize.MouseLeave
        If Me.WindowState = FormWindowState.Normal Then
            CType(sender, Button).Image = My.Resources.Window_ButtonMaximize_12x12
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            CType(sender, Button).Image = My.Resources.Window_ButtonRestore_12x12
        End If
    End Sub

    Private Sub ControlBoxMinimize_MouseEnter(sender As Object, e As EventArgs) Handles ControlBoxMinimize.MouseEnter
        CType(sender, Button).Image = My.Resources.Window_ButtonMinimizeW_12x12
    End Sub

    Private Sub ControlBoxMinimize_MouseLeave(sender As Object, e As EventArgs) Handles ControlBoxMinimize.MouseLeave
        CType(sender, Button).Image = My.Resources.Window_ButtonMinimize_12x12
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        If Not (Me.lastWindowState = Me.WindowState) Then
            Me.lastWindowState = Me.WindowState
            If Me.lastWindowState = FormWindowState.Normal Then
                Me.ControlBoxMaximize.Image = My.Resources.Window_ButtonMaximize_12x12
                Me.flpControlBox.Margin = New Padding(0, 0, 6, 0)
                'Me.Padding = New Padding(1)
            ElseIf Me.lastWindowState = FormWindowState.Maximized Then
                Me.ControlBoxMaximize.Image = My.Resources.Window_ButtonRestore_12x12
                Me.flpControlBox.Margin = New Padding(0, 0, 3, 0)
                'Me.Padding = New Padding(Windows.Forms.SystemInformation.FrameBorderSize.Width, _
                '                         Windows.Forms.SystemInformation.FrameBorderSize.Height, _
                '                         Windows.Forms.SystemInformation.FrameBorderSize.Width, _
                '                         Windows.Forms.SystemInformation.FrameBorderSize.Height)
            End If
        End If
    End Sub
#End Region
End Class
