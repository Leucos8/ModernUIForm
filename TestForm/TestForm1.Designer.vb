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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm1
    Inherits ModernUIForm.TemplateForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flpControlBox = New System.Windows.Forms.FlowLayoutPanel()
        Me.ControlBoxMinimize = New System.Windows.Forms.Button()
        Me.ControlBoxMaximize = New System.Windows.Forms.Button()
        Me.ControlBoxClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.flpControlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.flpControlBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 48)
        Me.Panel1.TabIndex = 1
        '
        'flpControlBox
        '
        Me.flpControlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpControlBox.AutoSize = True
        Me.flpControlBox.Controls.Add(Me.ControlBoxMinimize)
        Me.flpControlBox.Controls.Add(Me.ControlBoxMaximize)
        Me.flpControlBox.Controls.Add(Me.ControlBoxClose)
        Me.flpControlBox.Location = New System.Drawing.Point(195, 0)
        Me.flpControlBox.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.flpControlBox.Name = "flpControlBox"
        Me.flpControlBox.Size = New System.Drawing.Size(97, 20)
        Me.flpControlBox.TabIndex = 2
        Me.flpControlBox.WrapContents = False
        '
        'ControlBoxMinimize
        '
        Me.ControlBoxMinimize.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMinimize.FlatAppearance.BorderSize = 0
        Me.ControlBoxMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ControlBoxMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ControlBoxMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlBoxMinimize.Image = Global.TestForm.My.Resources.Resources.Window_ButtonMinimize_12x12
        Me.ControlBoxMinimize.Location = New System.Drawing.Point(0, 0)
        Me.ControlBoxMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.ControlBoxMinimize.Name = "ControlBoxMinimize"
        Me.ControlBoxMinimize.Size = New System.Drawing.Size(26, 20)
        Me.ControlBoxMinimize.TabIndex = 3
        Me.ControlBoxMinimize.UseVisualStyleBackColor = False
        '
        'ControlBoxMaximize
        '
        Me.ControlBoxMaximize.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMaximize.FlatAppearance.BorderSize = 0
        Me.ControlBoxMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ControlBoxMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ControlBoxMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlBoxMaximize.Image = Global.TestForm.My.Resources.Resources.Window_ButtonMaximize_12x12
        Me.ControlBoxMaximize.Location = New System.Drawing.Point(26, 0)
        Me.ControlBoxMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.ControlBoxMaximize.Name = "ControlBoxMaximize"
        Me.ControlBoxMaximize.Size = New System.Drawing.Size(26, 20)
        Me.ControlBoxMaximize.TabIndex = 2
        Me.ControlBoxMaximize.UseVisualStyleBackColor = False
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ControlBoxClose.FlatAppearance.BorderSize = 0
        Me.ControlBoxClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ControlBoxClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ControlBoxClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlBoxClose.Image = Global.TestForm.My.Resources.Resources.Window_ButtonCloseW_12x12
        Me.ControlBoxClose.Location = New System.Drawing.Point(52, 0)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(0)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(45, 20)
        Me.ControlBoxClose.TabIndex = 1
        Me.ControlBoxClose.UseVisualStyleBackColor = False
        '
        'TestForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BorderColorInactive = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CaptionColorActive = System.Drawing.Color.DarkGray
        Me.CaptionColorInactive = System.Drawing.Color.DarkGray
        Me.CaptionHeight = 48
        Me.ClientSize = New System.Drawing.Size(300, 139)
        Me.Controls.Add(Me.Panel1)
        Me.DWMMargins = New System.Windows.Forms.Padding(1)
        Me.Name = "TestForm1"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ResizeBorderThickness = New System.Drawing.Size(8, 8)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.flpControlBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents flpControlBox As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents ControlBoxMinimize As System.Windows.Forms.Button
    Private WithEvents ControlBoxMaximize As System.Windows.Forms.Button
    Private WithEvents ControlBoxClose As System.Windows.Forms.Button

End Class
