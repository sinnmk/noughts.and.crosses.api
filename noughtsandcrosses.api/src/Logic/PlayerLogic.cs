using System.Collections.Generic;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Logic.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using noughtsandcrosses.api.Repositories.Interfaces;

namespace noughtsandcrosses.api.Logic
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
    }
}
