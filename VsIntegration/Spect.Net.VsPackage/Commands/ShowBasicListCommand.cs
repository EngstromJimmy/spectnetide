﻿using Microsoft.VisualStudio.Shell;
using Spect.Net.VsPackage.ToolWindows.BasicList;
using Spect.Net.VsPackage.Vsx;

namespace Spect.Net.VsPackage.Commands
{
    /// <summary>
    /// Displays the BASIC List tool window
    /// </summary>
    [CommandId(0x1600)]
    [ToolWindow(typeof(BasicListToolWindow))]
    public class ShowBasicListCommand :
        VsxShowToolWindowCommand<SpectNetPackage, SpectNetCommandSet>
    {
        protected override void OnQueryStatus(OleMenuCommand mc)
            => mc.Enabled = Package.CodeDiscoverySolution?.CurrentProject != null;
    }
}