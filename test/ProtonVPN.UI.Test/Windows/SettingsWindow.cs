﻿/*
 * Copyright (c) 2020 Proton Technologies AG
 *
 * This file is part of ProtonVPN.
 *
 * ProtonVPN is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ProtonVPN is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with ProtonVPN.  If not, see <https://www.gnu.org/licenses/>.
 */

using ProtonVPN.UI.Test.TestsHelper;

namespace ProtonVPN.UI.Test.Windows
{
    public class SettingsWindow : UIActions
    {
        public SettingsWindow ClickGeneralTab()
        {
            ClickOnObjectWithName("General");
            return this;
        }

        public SettingsWindow ClickConnectionTab()
        {
            ClickOnObjectWithName("Connection");
            return this;
        }

        public SettingsWindow EnableCustomDnsServers()
        {
            ClickOnObjectWithId("CheckBoxCustomDnsServers");
            return this;
        }

        public SettingsWindow EnterCustomIpv4Address(string ipv4Address)
        {
            InsertTextIntoFieldWithId("InputIpv4Address", ipv4Address);
            ClickOnObjectWithId("SettingsPlusButton");
            return this;
        }

        public SettingsWindow CloseSettings()
        {
            ClickOnObjectWithId("ModalCloseButton");
            return this;
        }
    }
}
