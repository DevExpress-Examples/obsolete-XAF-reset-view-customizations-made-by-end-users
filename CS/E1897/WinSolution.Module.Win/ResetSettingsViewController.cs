using System;
using DevExpress.ExpressApp;
using DevExpress.XtraEditors;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.ExpressApp.Model.Core;

namespace WinSolution.Module.Win {
    public partial class ResetSettingsViewController : ViewController {
        private WinLayoutManager layoutManager;
        public ResetSettingsViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        protected override void OnViewChanging(View view) {
            base.OnViewChanging(view);
            DetailView dv = view as DetailView;
            if (dv != null) {
                layoutManager = dv.LayoutManager as WinLayoutManager;
                Active["DetailViewUsesWinLayoutManager"] = layoutManager != null;
            }
        }
        private void saResetSettings_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
            try {
                if (View is DetailView) {
                    layoutManager.Container.RestoreDefaultLayout();
                }
                else {
                    ((ModelNode)View.Model).Undo();
                    View.SynchronizeWithInfo();
                }
            } catch {
                XtraMessageBox.Show("An error occurred when resetting the View's settings. Please contact your application administrator for a solution. We will try to close the current View after you press the OK button.", "Reset Settings", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                View.Close();
            }
        }
    }
}