﻿using Aurora.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.Overwatch
{
    public class OverwatchSettings : ProfileSettings
    {
        //General
        public bool isEnabled;

        public OverwatchSettings()
        {
            //General
            isEnabled = true;
        }
    }
}
