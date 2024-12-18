using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_TemplateMethod
{
	internal class MusicCasset_STRATEGY : ISound_STRATEGY
	{
		public void PlayMusic()
		{
			PrepareSupport();
		}

		private void PrepareSupport()
		{
			Console.WriteLine("Put music casset into a player");
		}

		 
	}
}
