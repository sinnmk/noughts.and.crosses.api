using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Models;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.src.Repositories.Interfaces;

namespace noughtsandcrosses.api.src.Repositories
{
    public class PlayerRepository: IPlayerRepository
    {
        private readonly IDataContext _dataContext;

        public PlayerRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Player AddPlayer(Player player)
        {
            var newPlayer = new Player()
            {
                PlayerLevel = player.PlayerLevel,
                PlayerName = player.PlayerName
            };
            _dataContext.SaveChanges();
            return newPlayer;
        }

        public Player GetPlayer()
        {
            return _dataContext.Players.First();
        }

        public List<Player> GetPlayers()
        {
            return _dataContext.Players.ToList();
        }
    }
}
