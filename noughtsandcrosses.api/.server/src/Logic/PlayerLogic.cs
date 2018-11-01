using System.Collections.Generic;
using NoughtsAndCrosses.Server.Src.Logic.Dtos;
using NoughtsAndCrosses.Server.Src.Logic.Interfaces;
using NoughtsAndCrosses.Server.Src.Repositories.Interfaces;

namespace NoughtsAndCrosses.Server.Src.Logic
{
    public class PlayerLogic : IPlayerLogic
    {
    private readonly IPlayerRepository _playerRepository;

        public PlayerLogic(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public PlayerDto CreatePlayer(PlayerDto playerDto)
        {
            var player = _playerRepository.AddPlayer(Mapper.MapPlayerDtoToPlayer(playerDto));
            return Mapper.MapPlayerToPlayerDto(player);
        }

        public List<PlayerDto> GetPlayers()
        {
            var players = Mapper.MapPlayers(_playerRepository.GetPlayers());
            return players;
        }

        public bool UpdatePlayer(PlayerDto playerDto)
        {
            _playerRepository.UpdatePlayer(Mapper.MapPlayerDtoToPlayer(playerDto));
            return true;
        }

        public bool DeletePlayer(int id)
        {
            _playerRepository.DeletePlayer(id);
            return true;
        }
    }
}
