﻿Option Strict On
Option Explicit On
Namespace My
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared userOverrides() As String = {"ContactConnectionString"}

        Private Shared userOverrideSuffix As String = "User"

        Public Sub SetUserOverride(ByVal [property] As String, ByVal value As String)
            Me([property]) = value
        End Sub

        Private Sub userOverride_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            Dim userProperty As String
            For Each appProperty As String In userOverrides
                userProperty = appProperty & userOverrideSuffix
                If CType(Me(userProperty), String).Length > 0 Then
                    Me(appProperty) = Me(userProperty)
                End If
            Next
        End Sub

        Private Sub userOverride_SettingsSaving(ByVal sender As Object, _
                ByVal e As System.ComponentModel.CancelEventArgs) _
            Handles Me.SettingsSaving
            Dim userProperty As String
            For Each appProperty As String In userOverrides
                userProperty = appProperty & userOverrideSuffix
                Me(userProperty) = Me(appProperty)
            Next
        End Sub
    End Class
End Namespace