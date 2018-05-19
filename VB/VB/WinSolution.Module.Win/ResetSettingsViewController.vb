Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Model.Core
Imports DevExpress.XtraEditors

Namespace WinSolution.Module.Win
	Partial Public Class ResetSettingsViewController
		Inherits ViewController
		Private Const EnabledKey As String = "DisabledForNewObjectInDetailView"
		Private committedEventHandler As EventHandler = Nothing
		Private privateResetViewSettingsAction As SimpleAction
		Public Property ResetViewSettingsAction() As SimpleAction
			Get
				Return privateResetViewSettingsAction
			End Get
			Private Set(ByVal value As SimpleAction)
				privateResetViewSettingsAction = value
			End Set
		End Property
		Public Sub New()
			TargetViewNesting = Nesting.Root
			ResetViewSettingsAction = New SimpleAction(Me, "ResetViewSettings", DevExpress.Persistent.Base.PredefinedCategory.View)
			ResetViewSettingsAction.ImageName = "Attention"
			AddHandler ResetViewSettingsAction.Execute, AddressOf ResetViewSettingsAction_Execute
#If EASYTEST Then
			AddHandler CType(New SimpleAction(Me, "Test", DevExpress.Persistent.Base.PredefinedCategory.View), SimpleAction).Execute, Sub(s, e)
				If TypeOf View Is DetailView Then
					Dim dv As DetailView = CType(View, DetailView)
					CType(dv.FindItem("Text"), DevExpress.ExpressApp.Editors.IAppearanceVisibility).Visibility = DevExpress.ExpressApp.Editors.ViewItemVisibility.Hide
				ElseIf TypeOf View Is ListView Then
					Dim lv As ListView = CType(View, ListView)
					CType(lv.Model.Columns, IModelList(Of IModelColumn))("Text").Index = -1
					lv.LoadModel() 'Dennis: This internal method is used for testing purposes only. Do not use it in real apps.
				End If
			End Sub
#End If
		End Sub
		Private Sub ResetViewSettingsAction_Execute(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs)
			Try
				Dim oldModel As IModelView = View.Model
				Dim oldViewShortcut As ViewShortcut = Frame.View.CreateShortcut()
				Frame.SetView(Nothing)
				CType(oldModel, ModelNode).Undo()
				Frame.SetView(Application.ProcessShortcut(oldViewShortcut), True, Frame)
			Catch
				XtraMessageBox.Show("An error occurred when resetting the View's settings. Please contact your application administrator for a solution. We will try to close the current View after you press the OK button.", ResetViewSettingsAction.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
				View.Close()
			End Try
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			If View.ObjectSpace.IsNewObject(View.CurrentObject) AndAlso (TypeOf View Is DetailView) Then
				ResetViewSettingsAction.Enabled(EnabledKey) = False
				committedEventHandler = Sub(s, e)
					RemoveHandler View.ObjectSpace.Committed, committedEventHandler
					ResetViewSettingsAction.Enabled(EnabledKey) = True
				End Sub
				AddHandler View.ObjectSpace.Committed, committedEventHandler
			End If
		End Sub
		Protected Overrides Sub OnDeactivated()
			RemoveHandler View.ObjectSpace.Committed, committedEventHandler
			MyBase.OnDeactivated()
		End Sub
	End Class
End Namespace