using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories
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
            var newPlayer = new Player{ PlayerLevel = 1, PlayerName = "Name" };
            _dataContext.Players.Add(newPlayer);
            _dataContext.SaveChanges();
            return newPlayer;
        }

        public List<Player> GetPlayers()
        {
            return _dataContext.Players.ToList();
        }
    }
}
