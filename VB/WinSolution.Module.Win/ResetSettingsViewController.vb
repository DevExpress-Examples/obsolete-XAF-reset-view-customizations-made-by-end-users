Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.XtraEditors
Imports DevExpress.ExpressApp.Win.Layout
Imports DevExpress.ExpressApp.Model.Core

Namespace WinSolution.Module.Win
	Partial Public Class ResetSettingsViewController
		Inherits ViewController
		Private layoutManager As WinLayoutManager
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Protected Overrides Overloads Sub OnViewChanging(ByVal view As View)
			MyBase.OnViewChanging(view)
			Dim dv As DetailView = TryCast(view, DetailView)
			If dv IsNot Nothing Then
				layoutManager = TryCast(dv.LayoutManager, WinLayoutManager)
				Active("DetailViewUsesWinLayoutManager") = layoutManager IsNot Nothing
			End If
		End Sub
		Private Sub saResetSettings_Execute(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs) Handles saResetSettings.Execute
			Try
				If TypeOf View Is DetailView Then
					layoutManager.Container.RestoreDefaultLayout()
				Else
                    CType(View.Model, ModelNode).Undo()
                    View.SynchronizeWithInfo()
				End If
			Catch
				XtraMessageBox.Show("An error occurred when resetting the View's settings. Please contact your application administrator for a solution. We will try to close the current View after you press the OK button.", "Reset Settings", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
				View.Close()
			End Try
		End Sub
	End Class
End Namespace