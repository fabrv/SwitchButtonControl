Imports System.ComponentModel
Public Class WindowsSwitchButton

#Region "Declarations"
    Private _frameState As FrameState
    Private _activated As Boolean
    Private _switchColor As ColorScheme
#End Region

#Region "Properties"
    'Property for image 
    Private Property Frame() As FrameState
        Get
            Return _frameState
        End Get
        Set(value As FrameState)
            If _frameState <> value Then
                _frameState = value
            End If
        End Set
    End Property

    'Property for Colors
    Public Property SwitchColor() As ColorScheme
        Get
            Return _switchColor
        End Get
        Set(value As ColorScheme)
            If _switchColor <> value Then
                _switchColor = value
            End If

            Select Case _switchColor
                Case ColorScheme.Black
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Black.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Black.Frame_1
                    End If
                Case ColorScheme.Blue
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Blue.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Blue.Frame_1
                    End If

                Case ColorScheme.Green
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Green.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Green.Frame_1
                    End If

                Case ColorScheme.Orange
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Orange.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Orange.Frame_1
                    End If

                Case ColorScheme.Pink
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Pink.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Pink.Frame_1
                    End If

                Case ColorScheme.Purple
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Purple.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Purple.Frame_1
                    End If

                Case ColorScheme.Red
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Red.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Red.Frame_1
                    End If

                Case ColorScheme.Teal
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Teal.Frame_10
                    Else
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Teal.Frame_1
                    End If

                Case ColorScheme.Yellow
                    If Activated Then
                        _frameState = FrameState.Frame_10
                        PictureBox1.Image = My.Resources.Windows_Yellow.Frame_10
                        _frameState = FrameState.Frame_1
                        PictureBox1.Image = My.Resources.Windows_Yellow.Frame_1
                    End If
            End Select
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
    Public Enum FrameState
        Frame_1 ' Inactive
        Frame_2
        Frame_3
        Frame_4
        Frame_5
        Frame_6
        Frame_7
        Frame_8
        Frame_9
        Frame_10 ' Active
    End Enum

    Public Enum ColorScheme
        Black
        Blue
        Green
        Orange
        Pink
        Purple
        Red
        Teal
        Yellow
    End Enum
#End Region

#Region "Events"
    Public Shared Event ValueChanged As PropertyChangedEventHandler

    Private Sub SwitchValueChanged(Value As String)
        RaiseEvent ValueChanged(Me, New PropertyChangedEventArgs(Value))
    End Sub
#End Region

    ''' <summary>
    ''' Goes through the Frames (starting at 10, ending at 1), showing on-to-off visuals.
    ''' </summary>
    Public Sub SwitchOff()
        If SwitchColor = ColorScheme.Yellow Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Yellow.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Yellow.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Yellow.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Yellow.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Yellow.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Yellow.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Yellow.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Yellow.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Yellow.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Purple Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Purple.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Purple.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Purple.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Purple.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Purple.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Purple.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Purple.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Purple.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Purple.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Orange Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Orange.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Orange.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Orange.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Orange.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Orange.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Orange.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Orange.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Orange.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Orange.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Green Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Green.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Green.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Green.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Green.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Green.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Green.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Green.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Green.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Green.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Pink Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Pink.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Pink.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Pink.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Pink.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Pink.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Pink.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Pink.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Pink.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Pink.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Black Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Black.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Black.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Black.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Black.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Black.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Black.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Black.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Black.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Black.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Blue Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Blue.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Blue.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Blue.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Blue.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Blue.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Blue.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Blue.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Blue.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Blue.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Red Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Red.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Red.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Red.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Red.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Red.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Red.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Red.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Red.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Red.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Teal Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_10
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Teal.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Teal.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Teal.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Teal.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Teal.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Teal.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Teal.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Teal.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_1
                        _activated = False
                        .Image = My.Resources.Windows_Teal.Frame_1
                        Timer1.Enabled = False
                End Select
            End With
        End If
    End Sub

    ''' <summary>
    ''' Goes through the Frames (starting at 1, ending at 10), showing off-to-on visuals.
    ''' </summary>
    Public Sub SwitchOn()
        If SwitchColor = ColorScheme.Yellow Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Yellow.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Yellow.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Yellow.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Yellow.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Yellow.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Yellow.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Yellow.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Yellow.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Yellow.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Black Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Black.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Black.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Black.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Black.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Black.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Black.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Black.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Black.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Black.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Blue Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Blue.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Blue.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Blue.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Blue.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Blue.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Blue.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Blue.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Blue.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Blue.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Green Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Green.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Green.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Green.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Green.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Green.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Green.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Green.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Green.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Green.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Orange Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Orange.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Orange.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Orange.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Orange.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Orange.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Orange.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Orange.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Orange.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Orange.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Pink Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Pink.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Pink.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Pink.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Pink.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Pink.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Pink.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Pink.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Pink.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Pink.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Purple Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Purple.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Purple.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Purple.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Purple.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Purple.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Purple.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Purple.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Purple.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Purple.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Red Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Red.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Red.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Red.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Red.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Red.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Red.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Red.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Red.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Red.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
        If SwitchColor = ColorScheme.Teal Then
            With PictureBox1
                Select Case _frameState
                    Case FrameState.Frame_1
                        _frameState = FrameState.Frame_2
                        .Image = My.Resources.Windows_Teal.Frame_2
                    Case FrameState.Frame_2
                        _frameState = FrameState.Frame_3
                        .Image = My.Resources.Windows_Teal.Frame_3
                    Case FrameState.Frame_3
                        _frameState = FrameState.Frame_4
                        .Image = My.Resources.Windows_Teal.Frame_4
                    Case FrameState.Frame_4
                        _frameState = FrameState.Frame_5
                        .Image = My.Resources.Windows_Teal.Frame_5
                    Case FrameState.Frame_5
                        _frameState = FrameState.Frame_6
                        .Image = My.Resources.Windows_Teal.Frame_6
                    Case FrameState.Frame_6
                        _frameState = FrameState.Frame_7
                        .Image = My.Resources.Windows_Teal.Frame_7
                    Case FrameState.Frame_7
                        _frameState = FrameState.Frame_8
                        .Image = My.Resources.Windows_Teal.Frame_8
                    Case FrameState.Frame_8
                        _frameState = FrameState.Frame_9
                        .Image = My.Resources.Windows_Teal.Frame_9
                    Case FrameState.Frame_9
                        _frameState = FrameState.Frame_10
                        _activated = True
                        .Image = My.Resources.Windows_Teal.Frame_10
                        Timer1.Enabled = False
                End Select
            End With
        End If
    End Sub

    'SwitchValue/_activated no longer are changed on the click event for the picture box
    'It occurs when the FrameState changes to the polar opposite of the starting FrameState (Active to Inactive and vice versa)
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

    Private Sub WindowsSwitchButton_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _activated Then
            _frameState = FrameState.Frame_10
            PictureBox1.Image = My.Resources.Windows_Teal.Frame_10
        Else
            _frameState = FrameState.Frame_1
            PictureBox1.Image = My.Resources.Windows_Teal.Frame_1
        End If
    End Sub
End Class