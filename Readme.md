<!-- default file list -->
*Files to look at*:

* [Model.DesignedDiffs.xafml](./CS/WinSolution.Module.Win/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinSolution.Module.Win/Model.DesignedDiffs.xafml))
* **[ResetSettingsViewController.cs](./CS/WinSolution.Module.Win/ResetSettingsViewController.cs) (VB: [ResetSettingsViewController.vb](./VB/WinSolution.Module.Win/ResetSettingsViewController.vb))**
* [Updater.cs](./CS/WinSolution.Module.Win/Updater.cs) (VB: [Updater.vb](./VB/WinSolution.Module.Win/Updater.vb))
* [WinModule.cs](./CS/WinSolution.Module.Win/WinModule.cs) (VB: [WinModule.vb](./VB/WinSolution.Module.Win/WinModule.vb))
* [BO.cs](./CS/WinSolution.Module/BO.cs) (VB: [BO.vb](./VB/WinSolution.Module/BO.vb))
* [CodeCentralExampleInMemoryDataStoreProvider.cs](./CS/WinSolution.Module/CodeCentralExampleInMemoryDataStoreProvider.cs) (VB: [CodeCentralExampleInMemoryDataStoreProvider.vb](./VB/WinSolution.Module/CodeCentralExampleInMemoryDataStoreProvider.vb))
* [Model.DesignedDiffs.xafml](./CS/WinSolution.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinSolution.Module/Model.DesignedDiffs.xafml))
* [Module.cs](./CS/WinSolution.Module/Module.cs) (VB: [Module.vb](./VB/WinSolution.Module/Module.vb))
* [Updater.cs](./CS/WinSolution.Module/Updater.cs) (VB: [Updater.vb](./VB/WinSolution.Module/Updater.vb))
* [Model.xafml](./CS/WinSolution.Win/Model.xafml) (VB: [Model.xafml](./VB/WinSolution.Win/Model.xafml))
* [Program.cs](./CS/WinSolution.Win/Program.cs) (VB: [Program.vb](./VB/WinSolution.Win/Program.vb))
* [WinApplication.cs](./CS/WinSolution.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/WinSolution.Win/WinApplication.vb))
<!-- default file list end -->
# OBSOLETE - How to reset View customizations made by end-users


<p><strong>===================================<br />This example is now obsolete. Instead, use a solution from the <a href="http://dennisgaravsky.blogspot.com/2015/09/how-to-reset-view-customizations-made.html">http://dennisgaravsky.blogspot.com/2015/09/how-to-reset-view-customizations-made.html</a> blog post.<br />===================================<br /><br />Scen</strong><strong>ario</strong><strong><br /> </strong>A new <em>Reset View Settings Action</em> is added into the toolbar that allows end-users to reset customizations made in <strong>root</strong> Views (this approach is not suitable for nested ListViews).<br /> This functionality can be helpful if your end-users break the default layout, and after that, they want to restore it back.</p>
<p><strong>Steps to implement</strong><br /> <strong>1.</strong> Copy the <em>...\WinSolution.Module.Win\ResetSettingsViewController.xx</em> file into <em>YourSolution.Module.Win</em> module project.</p>
<p><strong><br />IMPORTANT NOTES</strong><br />We do not currently provide an easy solution for the nested ListView. For now, I can only recommend the following solution to you: 1. Close the parent DetailView containing a required nested ListView; 2. Programmatically reset the associated nested ListView model using the ModelNode API shown in the current example; 3. Reopen the previously closed parent DetailView (depending on the situation you can consider using the Frame.SetView, XafApplication.ProcessShortcut or other suitable APIs of our framework).</p>

<br/>


