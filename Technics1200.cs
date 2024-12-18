using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_TemplateMethod
{
	internal class Technics1200 : SoundPlayerTemplate
	{
		protected override void PrepareSupport()
		{
			Console.WriteLine("Put vynil on the turntable");
		}

		protected override  void SelectTrack()
		{
			string t = SelectedUserTrack();
			Console.WriteLine("Selected track: " + t + " move the turntable needle at the exact point"); ;
		}

		private string SelectedUserTrack()
		{
			Console.WriteLine("Dear user, select number of track:");
			string input = Console.ReadLine();
			return input;
		}
	}
}
