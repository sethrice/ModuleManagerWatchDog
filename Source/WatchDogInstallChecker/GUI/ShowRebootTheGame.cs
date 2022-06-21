﻿/*
	This file is part of Module Manager Watch Dog
		©2020-22 Lisias T : http://lisias.net <support@lisias.net>

	Module Manager Watch Dog is licensed as follows:
		* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt

	Module Manager Watchdog is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with Module Manager Watch Dog. If not, see
	<https://ksp.lisias.net/SKL-1_0.txt>.

*/
using UnityEngine;

namespace WatchDog.InstallChecker.GUI
{
	internal static class ShowRebootTheGame
	{
		private static readonly string AMSG = @"close KSP and restart it so the changes take effect";

		internal static void Show(string msg)
		{
			KSPe.Common.Dialogs.WarningAlertBox.Show(
				msg,
				AMSG,
				() => { Application.Quit(); },
				true
			);
			Log.detail("\"Your Attention Please!\" was displayed about : {0}", msg.Replace("\n"," "));
		}
	}
}
