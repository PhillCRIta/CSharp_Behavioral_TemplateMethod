using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_TemplateMethod
{
	internal abstract class SoundPlayerTemplate
	{
		public void PlaySound()
		{
			//first two common method
			TurnOnPlayer();
			PlugIntoPowerSupply();
			//specific method
			PrepareSupport();
			SelectTrack();
		}

		private void TurnOnPlayer()
		{
			Console.WriteLine("The player is connect to power supply");
		}

		private void PlugIntoPowerSupply()
		{
			Console.WriteLine("The player is power on");
		}

		protected abstract void PrepareSupport(); //every subclass must to implement this method
		protected virtual void SelectTrack() { } //this method optionally implement in the subclasses

	}
}
