using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_TemplateMethod
{
	internal class MusicCasset : SoundPlayerTemplate
	{
		protected override void PrepareSupport()
		{
			Console.WriteLine("Put music casset into a player");
		}
	}
}
