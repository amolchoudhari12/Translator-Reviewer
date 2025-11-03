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
    public partial class OfficeAddressTranslationReviewer
    {
        partial void common_officeaddress_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.common_officeaddress);
        }

        partial void common_officeaddress_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.common_officeaddress);
        }

        partial void OfficeAddressTranslationReviewer_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.common_officeaddress);
        }
    }
}