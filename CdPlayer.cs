using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_TemplateMethod
{
	internal class CdPlayer : SoundPlayerTemplate
	{
		protected override void PrepareSupport()
		{
			Console.WriteLine("Put cd into cdplayer");
		}

		protected override void SelectTrack()
		{
			string t = SelectedUserTrack();
			Console.WriteLine("Selected track: " + t); ;
		}

		private string SelectedUserTrack()
		{
			Console.WriteLine("Dear user, select number of track:");
			string input = Console.ReadLine();
			return input;
		}
	}
}
