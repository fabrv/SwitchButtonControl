Imports System.ComponentModel

Public Class AppleSwitchButton

#Region "Declarations"
    Private _frameState As FrameState
    Private _activated As Boolean
#End Region

#Region "Properties"

    'Property for image 
    Public Property Frame() As FrameState
        Get
            Return _frameState
        End Get
        Set(value As FrameState)
            If _frameState <> value Then
                _frameState = value
            End If
        End Set
    End Property

    'Property for getting and setting the SwitchValue
    Public Property Activated() As Boolean
        Get
            Return _activated
        End Get
        Set(value As Boolean)
            _activated = value
        End Set
    End Property

#End Region

#Region "Enumerations"

    'Replacing the variable AnimationSteps
    Public Enum FrameState
        Active ' Frame1
        Part_Active ' Frame2
        Part_Inactive ' Frame3
        Inactive ' Frame4
    End Enum

#End Region

#Region "Events"
    Public Shared Event ValueChanged As PropertyChangedEventHandler

    Private Sub SwitchValueChanged(Value As String)
        RaiseEvent ValueChanged(Me, New PropertyChangedEventArgs(Value))
    End Sub
#End Region


    'Methods SwitchOn & SwitchOff called in the timer tick event depending on the _activated boolean value 
    Public Sub SwitchOff()
        With PictureBox1
            Select Case _frameState
                Case FrameState.Active
                    _frameState = FrameState.Part_Active
                    .Image = My.Resources.AppleSwitchButton_Frame2
                Case FrameState.Part_Active
                    _frameState = FrameState.Part_Inactive
                    .Image = My.Resources.AppleSwitchButton_Frame3
                Case FrameState.Part_Inactive
                    _frameState = FrameState.Inactive
                    _activated = False
                    .Image = My.Resources.AppleSwitchButton_Frame4
                    Timer1.Enabled = False
            End Select
        End With
    End Sub

    Public Sub SwitchOn()
        With PictureBox1
            Select Case _frameState
                Case FrameState.Inactive
                    _frameState = FrameState.Part_Inactive
                    .Image = My.Resources.AppleSwitchButton_Frame3
                Case FrameState.Part_Inactive
                    _frameState = FrameState.Part_Active
                    .Image = My.Resources.AppleSwitchButton_Frame2
                Case FrameState.Part_Active
                    _frameState = FrameState.Active
                    _activated = True
                    .Image = My.Resources.AppleSwitchButton_Frame1
                    Timer1.Enabled = False
            End Select
        End With
    End Sub

    'SwitchValue/_activated no longer are changed on the click event for the picture box
    'It occurrs when the FrameState changes to the polar opposite of the starting FrameState (Active to Inactive and vice versa)
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If _activated Then
            SwitchOff()
        Else
            SwitchOn()
        End If
    End Sub

    Private Sub AppleSwitchButton_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _activated Then
            _frameState = FrameState.Active
            PictureBox1.Image = My.Resources.AppleSwitchButton_Frame1
        Else
            _frameState = FrameState.Inactive
            PictureBox1.Image = My.Resources.AppleSwitchButton_Frame4
        End If
    End Sub
End Class
