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
        Me.ControlBoxMaximize.FlatAppearance.MouseOverBackColor = Me.BorderColorActive
        Me.ControlBoxMaximize.FlatAppearance.MouseDownBackColor = Me.BorderColorInactive
        Me.ControlBoxMinimize.FlatAppearance.MouseOverBackColor = Me.BorderColorActive
        Me.ControlBoxMinimize.FlatAppearance.MouseDownBackColor = Me.BorderColorInactive

        Me.HitTestingAddControl(Me.Panel1)
        Me.HitTestingAddControl(Me.TableLayoutPanel1)
        Me.HitTestingAddControl(Me.FlowLayoutPanel1)
    End Sub

#Region "Form - ControlBox & Resize"
    Private lastWindowState As FormWindowState
    Private npadding As Padding

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
                Me.Padding = Me.npadding
            ElseIf Me.lastWindowState = FormWindowState.Maximized Then
                Me.ControlBoxMaximize.Image = My.Resources.Window_ButtonRestore_12x12
                Me.flpControlBox.Margin = New Padding(0, 0, 3, 0)
                Me.npadding = Me.Padding
                Me.Padding = New Padding(Windows.Forms.SystemInformation.FrameBorderSize.Width, _
                                         Windows.Forms.SystemInformation.FrameBorderSize.Height, _
                                         Windows.Forms.SystemInformation.FrameBorderSize.Width, _
                                         Windows.Forms.SystemInformation.FrameBorderSize.Height)
            Else
                Me.npadding = Me.Padding
            End If
        End If
    End Sub
#End Region

    Private Sub TestForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ValuesLoad()
    End Sub

    Private Sub ValuesLoad()
        Me.txtPadding.Text = Me.Padding.All.ToString
        Me.txtDWMMargins.Text = Me.DWMMargins.All.ToString
        Me.ckbDoubleBuffered.Checked = Me.DoubleBuffered
        Me.txtResizeBorder.Text = Me.ResizeBorderThickness.Width.ToString
        Me.txtCaptionHeight.Text = Me.CaptionHeight.ToString

        Me.txtCaptionActiveColorR.Text = Me.CaptionColorActive.R.ToString
        Me.txtCaptionActiveColorG.Text = Me.CaptionColorActive.G.ToString
        Me.txtCaptionActiveColorB.Text = Me.CaptionColorActive.B.ToString

        Me.txtCaptionInactiveColorR.Text = Me.CaptionColorInactive.R.ToString
        Me.txtCaptionInactiveColorG.Text = Me.CaptionColorInactive.G.ToString
        Me.txtCaptionInactiveColorB.Text = Me.CaptionColorInactive.B.ToString

        Me.txtBorderActiveColorR.Text = Me.BorderColorActive.R.ToString
        Me.txtBorderActiveColorG.Text = Me.BorderColorActive.G.ToString
        Me.txtBorderActiveColorB.Text = Me.BorderColorActive.B.ToString

        Me.txtBorderInactiveColorR.Text = Me.BorderColorInactive.R.ToString
        Me.txtBorderInactiveColorG.Text = Me.BorderColorInactive.G.ToString
        Me.txtBorderInactiveColorB.Text = Me.BorderColorInactive.B.ToString
    End Sub

    Private Sub ValuesApply()
        Try
            Me.Padding = New Padding(CInt(Me.txtPadding.Text))
            Me.DWMMargins = New Padding(CInt(txtDWMMargins.Text))
            Me.DoubleBuffered = Me.ckbDoubleBuffered.Checked
            Me.ResizeBorderThickness = New Size(CInt(txtResizeBorder.Text), CInt(txtResizeBorder.Text))
            Me.CaptionHeight = CInt(Me.txtCaptionHeight.Text)
            Me.Panel1.Height = CInt(Me.txtCaptionHeight.Text)
            Me.CaptionColorActive = Color.FromArgb(CInt(Me.txtCaptionActiveColorR.Text), _
                                                   CInt(Me.txtCaptionActiveColorG.Text), _
                                                   CInt(Me.txtCaptionActiveColorB.Text))
            Me.CaptionColorInactive = Color.FromArgb(CInt(Me.txtCaptionInactiveColorR.Text), _
                                                   CInt(Me.txtCaptionInactiveColorG.Text), _
                                                   CInt(Me.txtCaptionInactiveColorB.Text))
            Me.BorderColorActive = Color.FromArgb(CInt(Me.txtBorderActiveColorR.Text), _
                                                   CInt(Me.txtBorderActiveColorG.Text), _
                                                   CInt(Me.txtBorderActiveColorB.Text))
            Me.BorderColorInactive = Color.FromArgb(CInt(Me.txtBorderInactiveColorR.Text), _
                                                   CInt(Me.txtBorderInactiveColorG.Text), _
                                                   CInt(Me.txtBorderInactiveColorB.Text))

            Me.ControlBoxMaximize.FlatAppearance.MouseOverBackColor = Me.BorderColorActive
            Me.ControlBoxMaximize.FlatAppearance.MouseDownBackColor = Me.BorderColorInactive
            Me.ControlBoxMinimize.FlatAppearance.MouseOverBackColor = Me.BorderColorActive
            Me.ControlBoxMinimize.FlatAppearance.MouseDownBackColor = Me.BorderColorInactive

            Me.ValuesLoad()
        Catch ex As Exception
            MessageBox.Show("Error while applying values." & Environment.NewLine & ex.Message, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Me.ValuesApply()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.ValuesLoad()
    End Sub

    Private Sub btnAero_Click(sender As Object, e As EventArgs) Handles btnAero.Click
        Me.Padding = New Padding(8)
        Me.DWMMargins = New Padding(8)
        Me.ResizeBorderThickness = New Size(8, 8)
        Me.BorderColorActive = Color.Black
        Me.BorderColorInactive = Color.Black
        Me.DoubleBuffered = False

        Me.ValuesLoad()
    End Sub
End Class
