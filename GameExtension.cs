using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGameChecker
{
	public enum CanYouRunIT { Yes, No, Maybe };
	partial class Game
	{
		private CanYouRunIT _CYRI;
		public CanYouRunIT CYRI
		{
			get
			{
				return this._CYRI;
			}
			set
			{
				if(this._CYRI != value)
				{
					this._CYRI = value;
					this.SendPropertyChanging();
				}
			}
		}
		public List<HardwareWarning> _HardwareWarnings = new List<HardwareWarning>();
		public override string ToString()
		{
			return "Game id: " + this.Id.ToString() + " " + this.Name;
		}
	}

	partial class Platform
	{
		public override string ToString()
		{
			return "Id: " + this.Id.ToString() + " " + this.Subname;
		}
	}

	partial class GameToPlatform
	{
		private string getGameName(int gameid)
        {
			GamesDatabaseDataContext dataContext = new GamesDatabaseDataContext();
			var query = from Game in dataContext.Games.AsQueryable()
						where Game.Id == gameid
						select Game.Name;
			if (query.Count() > 0) return query.First();
			return gameid.ToString();
        }
		private string getPlatformName(int platformid)
        {
			GamesDatabaseDataContext dataContext = new GamesDatabaseDataContext();
			var query = from Platform in dataContext.Platforms
						where Platform.Id == platformid
						select Platform.Name;
			if (query.Count() > 0) return query.First();
			return platformid.ToString();
		}
		public override string ToString()
		{
			return getGameName(GameId) + " \t Platform: " + getPlatformName(PlatformId);
		}
	}
}
