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
        Me.lblDWMMargins = New System.Windows.Forms.Label()
        Me.txtDWMMargins = New System.Windows.Forms.TextBox()
        Me.lblResizeBorder = New System.Windows.Forms.Label()
        Me.txtResizeBorder = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblPadding = New System.Windows.Forms.Label()
        Me.txtPadding = New System.Windows.Forms.TextBox()
        Me.lblCaptionHeight = New System.Windows.Forms.Label()
        Me.txtCaptionHeight = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBorderInactiveColorB = New System.Windows.Forms.TextBox()
        Me.lblBorderInactiveColor = New System.Windows.Forms.Label()
        Me.txtBorderInactiveColorG = New System.Windows.Forms.TextBox()
        Me.lblBorderActiveColor = New System.Windows.Forms.Label()
        Me.txtBorderInactiveColorR = New System.Windows.Forms.TextBox()
        Me.lblCaptionActiveColor = New System.Windows.Forms.Label()
        Me.txtCaptionActiveColorR = New System.Windows.Forms.TextBox()
        Me.txtCaptionActiveColorG = New System.Windows.Forms.TextBox()
        Me.txtCaptionActiveColorB = New System.Windows.Forms.TextBox()
        Me.lblCaptionInactiveColor = New System.Windows.Forms.Label()
        Me.txtCaptionInactiveColorR = New System.Windows.Forms.TextBox()
        Me.txtCaptionInactiveColorG = New System.Windows.Forms.TextBox()
        Me.txtCaptionInactiveColorB = New System.Windows.Forms.TextBox()
        Me.txtBorderActiveColorR = New System.Windows.Forms.TextBox()
        Me.txtBorderActiveColorG = New System.Windows.Forms.TextBox()
        Me.txtBorderActiveColorB = New System.Windows.Forms.TextBox()
        Me.ckbDoubleBuffered = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAero = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.flpControlBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.flpControlBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 48)
        Me.Panel1.TabIndex = 0
        '
        'flpControlBox
        '
        Me.flpControlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpControlBox.AutoSize = True
        Me.flpControlBox.Controls.Add(Me.ControlBoxMinimize)
        Me.flpControlBox.Controls.Add(Me.ControlBoxMaximize)
        Me.flpControlBox.Controls.Add(Me.ControlBoxClose)
        Me.flpControlBox.Location = New System.Drawing.Point(312, 0)
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
        'lblDWMMargins
        '
        Me.lblDWMMargins.AutoSize = True
        Me.lblDWMMargins.Location = New System.Drawing.Point(3, 0)
        Me.lblDWMMargins.Name = "lblDWMMargins"
        Me.lblDWMMargins.Size = New System.Drawing.Size(75, 13)
        Me.lblDWMMargins.TabIndex = 0
        Me.lblDWMMargins.Text = "DWM Margins"
        '
        'txtDWMMargins
        '
        Me.txtDWMMargins.Location = New System.Drawing.Point(118, 1)
        Me.txtDWMMargins.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDWMMargins.Name = "txtDWMMargins"
        Me.txtDWMMargins.Size = New System.Drawing.Size(40, 20)
        Me.txtDWMMargins.TabIndex = 1
        '
        'lblResizeBorder
        '
        Me.lblResizeBorder.AutoSize = True
        Me.lblResizeBorder.Location = New System.Drawing.Point(3, 23)
        Me.lblResizeBorder.Name = "lblResizeBorder"
        Me.lblResizeBorder.Size = New System.Drawing.Size(73, 13)
        Me.lblResizeBorder.TabIndex = 2
        Me.lblResizeBorder.Text = "Resize Border"
        '
        'txtResizeBorder
        '
        Me.txtResizeBorder.Location = New System.Drawing.Point(118, 24)
        Me.txtResizeBorder.Margin = New System.Windows.Forms.Padding(1)
        Me.txtResizeBorder.Name = "txtResizeBorder"
        Me.txtResizeBorder.Size = New System.Drawing.Size(40, 20)
        Me.txtResizeBorder.TabIndex = 3
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(3, 3)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Apply values"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblPadding
        '
        Me.lblPadding.AutoSize = True
        Me.lblPadding.Location = New System.Drawing.Point(3, 45)
        Me.lblPadding.Name = "lblPadding"
        Me.lblPadding.Size = New System.Drawing.Size(64, 13)
        Me.lblPadding.TabIndex = 4
        Me.lblPadding.Text = "Me.Padding"
        '
        'txtPadding
        '
        Me.txtPadding.Location = New System.Drawing.Point(118, 46)
        Me.txtPadding.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPadding.Name = "txtPadding"
        Me.txtPadding.Size = New System.Drawing.Size(40, 20)
        Me.txtPadding.TabIndex = 5
        '
        'lblCaptionHeight
        '
        Me.lblCaptionHeight.AutoSize = True
        Me.lblCaptionHeight.Location = New System.Drawing.Point(3, 67)
        Me.lblCaptionHeight.Name = "lblCaptionHeight"
        Me.lblCaptionHeight.Size = New System.Drawing.Size(77, 13)
        Me.lblCaptionHeight.TabIndex = 6
        Me.lblCaptionHeight.Text = "Caption Height"
        '
        'txtCaptionHeight
        '
        Me.txtCaptionHeight.Location = New System.Drawing.Point(118, 68)
        Me.txtCaptionHeight.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCaptionHeight.Name = "txtCaptionHeight"
        Me.txtCaptionHeight.Size = New System.Drawing.Size(40, 20)
        Me.txtCaptionHeight.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtCaptionHeight, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDWMMargins, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCaptionHeight, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBorderInactiveColorB, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBorderInactiveColor, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBorderInactiveColorG, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBorderActiveColor, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBorderInactiveColorR, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDWMMargins, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtResizeBorder, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPadding, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblResizeBorder, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPadding, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCaptionActiveColor, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCaptionActiveColorR, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCaptionActiveColorG, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCaptionActiveColorB, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCaptionInactiveColor, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCaptionInactiveColorR, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCaptionInactiveColorG, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCaptionInactiveColorB, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBorderActiveColorR, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBorderActiveColorG, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBorderActiveColorB, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ckbDoubleBuffered, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 49)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(415, 222)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txtBorderInactiveColorB
        '
        Me.txtBorderInactiveColorB.Location = New System.Drawing.Point(202, 156)
        Me.txtBorderInactiveColorB.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBorderInactiveColorB.Name = "txtBorderInactiveColorB"
        Me.txtBorderInactiveColorB.Size = New System.Drawing.Size(40, 20)
        Me.txtBorderInactiveColorB.TabIndex = 23
        '
        'lblBorderInactiveColor
        '
        Me.lblBorderInactiveColor.AutoSize = True
        Me.lblBorderInactiveColor.Location = New System.Drawing.Point(3, 155)
        Me.lblBorderInactiveColor.Name = "lblBorderInactiveColor"
        Me.lblBorderInactiveColor.Size = New System.Drawing.Size(106, 13)
        Me.lblBorderInactiveColor.TabIndex = 20
        Me.lblBorderInactiveColor.Text = "Border Inactive Color"
        '
        'txtBorderInactiveColorG
        '
        Me.txtBorderInactiveColorG.Location = New System.Drawing.Point(160, 156)
        Me.txtBorderInactiveColorG.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBorderInactiveColorG.Name = "txtBorderInactiveColorG"
        Me.txtBorderInactiveColorG.Size = New System.Drawing.Size(40, 20)
        Me.txtBorderInactiveColorG.TabIndex = 22
        '
        'lblBorderActiveColor
        '
        Me.lblBorderActiveColor.AutoSize = True
        Me.lblBorderActiveColor.Location = New System.Drawing.Point(3, 133)
        Me.lblBorderActiveColor.Name = "lblBorderActiveColor"
        Me.lblBorderActiveColor.Size = New System.Drawing.Size(98, 13)
        Me.lblBorderActiveColor.TabIndex = 16
        Me.lblBorderActiveColor.Text = "Border Active Color"
        '
        'txtBorderInactiveColorR
        '
        Me.txtBorderInactiveColorR.Location = New System.Drawing.Point(118, 156)
        Me.txtBorderInactiveColorR.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBorderInactiveColorR.Name = "txtBorderInactiveColorR"
        Me.txtBorderInactiveColorR.Size = New System.Drawing.Size(40, 20)
        Me.txtBorderInactiveColorR.TabIndex = 21
        '
        'lblCaptionActiveColor
        '
        Me.lblCaptionActiveColor.AutoSize = True
        Me.lblCaptionActiveColor.Location = New System.Drawing.Point(3, 89)
        Me.lblCaptionActiveColor.Name = "lblCaptionActiveColor"
        Me.lblCaptionActiveColor.Size = New System.Drawing.Size(103, 13)
        Me.lblCaptionActiveColor.TabIndex = 8
        Me.lblCaptionActiveColor.Text = "Caption Active Color"
        '
        'txtCaptionActiveColorR
        '
        Me.txtCaptionActiveColorR.Location = New System.Drawing.Point(118, 90)
        Me.txtCaptionActiveColorR.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCaptionActiveColorR.Name = "txtCaptionActiveColorR"
        Me.txtCaptionActiveColorR.Size = New System.Drawing.Size(40, 20)
        Me.txtCaptionActiveColorR.TabIndex = 9
        '
        'txtCaptionActiveColorG
        '
        Me.txtCaptionActiveColorG.Location = New System.Drawing.Point(160, 90)
        Me.txtCaptionActiveColorG.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCaptionActiveColorG.Name = "txtCaptionActiveColorG"
        Me.txtCaptionActiveColorG.Size = New System.Drawing.Size(40, 20)
        Me.txtCaptionActiveColorG.TabIndex = 10
        '
        'txtCaptionActiveColorB
        '
        Me.txtCaptionActiveColorB.Location = New System.Drawing.Point(202, 90)
        Me.txtCaptionActiveColorB.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCaptionActiveColorB.Name = "txtCaptionActiveColorB"
        Me.txtCaptionActiveColorB.Size = New System.Drawing.Size(40, 20)
        Me.txtCaptionActiveColorB.TabIndex = 11
        '
        'lblCaptionInactiveColor
        '
        Me.lblCaptionInactiveColor.AutoSize = True
        Me.lblCaptionInactiveColor.Location = New System.Drawing.Point(3, 111)
        Me.lblCaptionInactiveColor.Name = "lblCaptionInactiveColor"
        Me.lblCaptionInactiveColor.Size = New System.Drawing.Size(111, 13)
        Me.lblCaptionInactiveColor.TabIndex = 12
        Me.lblCaptionInactiveColor.Text = "Caption Inactive Color"
        '
        'txtCaptionInactiveColorR
        '
        Me.txtCaptionInactiveColorR.Location = New System.Drawing.Point(118, 112)
        Me.txtCaptionInactiveColorR.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCaptionInactiveColorR.Name = "txtCaptionInactiveColorR"
        Me.txtCaptionInactiveColorR.Size = New System.Drawing.Size(40, 20)
        Me.txtCaptionInactiveColorR.TabIndex = 13
        '
        'txtCaptionInactiveColorG
        '
        Me.txtCaptionInactiveColorG.Location = New System.Drawing.Point(160, 112)
        Me.txtCaptionInactiveColorG.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCaptionInactiveColorG.Name = "txtCaptionInactiveColorG"
        Me.txtCaptionInactiveColorG.Size = New System.Drawing.Size(40, 20)
        Me.txtCaptionInactiveColorG.TabIndex = 14
        '
        'txtCaptionInactiveColorB
        '
        Me.txtCaptionInactiveColorB.Location = New System.Drawing.Point(202, 112)
        Me.txtCaptionInactiveColorB.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCaptionInactiveColorB.Name = "txtCaptionInactiveColorB"
        Me.txtCaptionInactiveColorB.Size = New System.Drawing.Size(40, 20)
        Me.txtCaptionInactiveColorB.TabIndex = 15
        '
        'txtBorderActiveColorR
        '
        Me.txtBorderActiveColorR.Location = New System.Drawing.Point(118, 134)
        Me.txtBorderActiveColorR.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBorderActiveColorR.Name = "txtBorderActiveColorR"
        Me.txtBorderActiveColorR.Size = New System.Drawing.Size(40, 20)
        Me.txtBorderActiveColorR.TabIndex = 17
        '
        'txtBorderActiveColorG
        '
        Me.txtBorderActiveColorG.Location = New System.Drawing.Point(160, 134)
        Me.txtBorderActiveColorG.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBorderActiveColorG.Name = "txtBorderActiveColorG"
        Me.txtBorderActiveColorG.Size = New System.Drawing.Size(40, 20)
        Me.txtBorderActiveColorG.TabIndex = 18
        '
        'txtBorderActiveColorB
        '
        Me.txtBorderActiveColorB.Location = New System.Drawing.Point(202, 134)
        Me.txtBorderActiveColorB.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBorderActiveColorB.Name = "txtBorderActiveColorB"
        Me.txtBorderActiveColorB.Size = New System.Drawing.Size(40, 20)
        Me.txtBorderActiveColorB.TabIndex = 19
        '
        'ckbDoubleBuffered
        '
        Me.ckbDoubleBuffered.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ckbDoubleBuffered, 3)
        Me.ckbDoubleBuffered.Location = New System.Drawing.Point(162, 3)
        Me.ckbDoubleBuffered.Name = "ckbDoubleBuffered"
        Me.ckbDoubleBuffered.Size = New System.Drawing.Size(100, 17)
        Me.ckbDoubleBuffered.TabIndex = 24
        Me.ckbDoubleBuffered.Text = "DoubleBuffered"
        Me.ckbDoubleBuffered.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnApply)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnRefresh)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAero)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 271)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(415, 29)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.Location = New System.Drawing.Point(84, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(88, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh values"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnAero
        '
        Me.btnAero.Location = New System.Drawing.Point(178, 3)
        Me.btnAero.Name = "btnAero"
        Me.btnAero.Size = New System.Drawing.Size(75, 23)
        Me.btnAero.TabIndex = 6
        Me.btnAero.Text = "Aero values"
        Me.btnAero.UseVisualStyleBackColor = True
        '
        'TestForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BorderColorInactive = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CaptionColorActive = System.Drawing.Color.Gainsboro
        Me.CaptionColorInactive = System.Drawing.Color.LightGray
        Me.CaptionHeight = 48
        Me.ClientSize = New System.Drawing.Size(417, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.DWMMargins = New System.Windows.Forms.Padding(1)
        Me.Name = "TestForm1"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ResizeBorderThickness = New System.Drawing.Size(8, 8)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.flpControlBox.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents flpControlBox As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents ControlBoxMinimize As System.Windows.Forms.Button
    Private WithEvents ControlBoxMaximize As System.Windows.Forms.Button
    Private WithEvents ControlBoxClose As System.Windows.Forms.Button
    Private WithEvents btnApply As System.Windows.Forms.Button
    Private WithEvents txtResizeBorder As System.Windows.Forms.TextBox
    Private WithEvents lblResizeBorder As System.Windows.Forms.Label
    Private WithEvents txtDWMMargins As System.Windows.Forms.TextBox
    Private WithEvents lblDWMMargins As System.Windows.Forms.Label
    Private WithEvents txtPadding As System.Windows.Forms.TextBox
    Private WithEvents lblPadding As System.Windows.Forms.Label
    Private WithEvents lblCaptionHeight As System.Windows.Forms.Label
    Private WithEvents txtCaptionHeight As System.Windows.Forms.TextBox
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblCaptionActiveColor As System.Windows.Forms.Label
    Private WithEvents txtCaptionActiveColorR As System.Windows.Forms.TextBox
    Private WithEvents txtCaptionActiveColorG As System.Windows.Forms.TextBox
    Private WithEvents txtCaptionActiveColorB As System.Windows.Forms.TextBox
    Private WithEvents lblCaptionInactiveColor As System.Windows.Forms.Label
    Private WithEvents txtCaptionInactiveColorR As System.Windows.Forms.TextBox
    Private WithEvents txtCaptionInactiveColorG As System.Windows.Forms.TextBox
    Private WithEvents txtCaptionInactiveColorB As System.Windows.Forms.TextBox
    Private WithEvents lblBorderActiveColor As System.Windows.Forms.Label
    Private WithEvents txtBorderActiveColorR As System.Windows.Forms.TextBox
    Private WithEvents txtBorderActiveColorG As System.Windows.Forms.TextBox
    Private WithEvents txtBorderActiveColorB As System.Windows.Forms.TextBox
    Private WithEvents txtBorderInactiveColorB As System.Windows.Forms.TextBox
    Private WithEvents txtBorderInactiveColorG As System.Windows.Forms.TextBox
    Private WithEvents txtBorderInactiveColorR As System.Windows.Forms.TextBox
    Private WithEvents lblBorderInactiveColor As System.Windows.Forms.Label
    Private WithEvents ckbDoubleBuffered As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAero As System.Windows.Forms.Button

End Class
