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
    public partial class PlottingSchemeTranslationReviewer
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

        partial void PlottingSchemeTranslationReviewer_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.plot_plottingscheme);
        }
    }
}