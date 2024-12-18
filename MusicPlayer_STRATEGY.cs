using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_TemplateMethod
{
	internal class MusicPlayer_STRATEGY
	{
		private ISound_STRATEGY _player;

		public MusicPlayer_STRATEGY(ISound_STRATEGY player)
		{
			_player = player;
		}
		public void SetPlayer(ISound_STRATEGY player)
		{
			_player = player;
		}

		//common operations
		public void PlaySound()
		{
			PlugIntoPowerSupply();
			TurnOnPlayer();
			_player.PlayMusic();
		}

		private void TurnOnPlayer()
		{
			Console.WriteLine("The player is connect to power supply");
		}

		private void PlugIntoPowerSupply()
		{
			Console.WriteLine("The player is power on");
		}
	}
}
