﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class switch_android
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pb_switch = New System.Windows.Forms.PictureBox()
        Me.timer_move = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb_switch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_switch
        '
        Me.pb_switch.Image = Global.switchButton.My.Resources.Resources.switch_1_android
        Me.pb_switch.Location = New System.Drawing.Point(0, 0)
        Me.pb_switch.Name = "pb_switch"
        Me.pb_switch.Size = New System.Drawing.Size(97, 24)
        Me.pb_switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_switch.TabIndex = 1
        Me.pb_switch.TabStop = False
        '
        'timer_move
        '
        Me.timer_move.Interval = 10
        '
        'switch_android
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pb_switch)
        Me.Name = "switch_android"
        Me.Size = New System.Drawing.Size(97, 24)
        CType(Me.pb_switch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_switch As System.Windows.Forms.PictureBox
    Friend WithEvents timer_move As System.Windows.Forms.Timer

End Class
