using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class plot_plottingschemeDetail
    {
        partial void plot_plottingscheme_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.plot_plottingscheme);
        }

        partial void plot_plottingscheme_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.plot_plottingscheme);
        }

        partial void plot_plottingschemeDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.plot_plottingscheme);
        }
    }
}