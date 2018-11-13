using System;
using System.Collections.Generic;
using System.Linq;
using NoughtsAndCrosses.Src.Repositories.Interfaces;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace NoughtsAndCrosses.Src.Repositories
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
            var newPlayer = new Player{ PlayerLevel = 1, PlayerName = "" };
            _dataContext.Players.Add(newPlayer);
            _dataContext.SaveChanges();
            return newPlayer;
        }

        public List<Player> GetPlayers()
        {
            return _dataContext.Players.ToList();
        }

        public bool UpdatePlayer(Player player)
        {
            var existingPlayers = _dataContext.Players.FirstOrDefault(x => x.PlayerId == player.PlayerId);
            if (existingPlayers == null) throw new System.Exception("Player is not found");

            existingPlayers.PlayerLevel = player.PlayerLevel;
            existingPlayers.PlayerName = player.PlayerName;

            _dataContext.SaveChanges();
            return true;
        }

        public bool DeletePlayer(int id)
        {
            var playerToDelete = _dataContext.Players.FirstOrDefault(x => x.PlayerId == id);
            if (playerToDelete == null) throw new Exception("Player not found");

            _dataContext.Players.Remove(playerToDelete);
            _dataContext.SaveChanges();
            return true;
        }
    }
}
