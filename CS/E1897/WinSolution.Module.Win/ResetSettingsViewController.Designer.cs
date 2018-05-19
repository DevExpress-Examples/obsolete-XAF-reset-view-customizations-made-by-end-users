namespace WinSolution.Module.Win {
    partial class ResetSettingsViewController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.saResetSettings = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saResetSettings
            // 
            this.saResetSettings.Caption = "Reset Settings";
            this.saResetSettings.Category = "View";
            this.saResetSettings.Id = "ResetSettings";
            this.saResetSettings.ImageName = "Attention";
            this.saResetSettings.Tag = null;
            this.saResetSettings.TypeOfView = null;
            this.saResetSettings.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saResetSettings_Execute);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saResetSettings;

    }
}
