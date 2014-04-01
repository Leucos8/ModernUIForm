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

Public Class TemplateForm
    Private dwmMargins As DWM.MARGINS
    Private topRect As Rectangle = Rectangle.Empty


    Public Sub New()
        Me.SetStyle(ControlStyles.ResizeRedraw, True)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        'Me.DoubleBuffered = True

        If Me.IsGlassEnabled Then
            dwmMargins = New DWM.MARGINS(0, 0, 1, 0)
            DWM.DwmExtendFrameIntoClientArea(Me.Handle, dwmMargins)
        End If

    End Sub

    Private Function IsGlassEnabled() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then
            MessageBox.Show("Works on vista and later")
            Return False
        End If
        Dim isGlassSupported As Boolean = False
        DWM.DwmIsCompositionEnabled(isGlassSupported)
        Return isGlassSupported
    End Function
End Class