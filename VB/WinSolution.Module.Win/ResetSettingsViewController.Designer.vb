Imports Microsoft.VisualBasic
Imports System
Namespace WinSolution.Module.Win
	Partial Public Class ResetSettingsViewController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.saResetSettings = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' saResetSettings
			' 
			Me.saResetSettings.Caption = "Reset Settings"
			Me.saResetSettings.Category = "View"
			Me.saResetSettings.Id = "ResetSettings"
			Me.saResetSettings.ImageName = "Attention"
			Me.saResetSettings.Tag = Nothing
			Me.saResetSettings.TypeOfView = Nothing
'			Me.saResetSettings.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.saResetSettings_Execute);

		End Sub

		#End Region

		Private WithEvents saResetSettings As DevExpress.ExpressApp.Actions.SimpleAction

	End Class
End Namespace
