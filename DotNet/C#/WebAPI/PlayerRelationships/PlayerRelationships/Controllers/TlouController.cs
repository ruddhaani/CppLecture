using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerRelationships.Data;
using PlayerRelationships.DTOs;
using PlayerRelationships.Entity;

namespace PlayerRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TlouController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public TlouController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayerById(int id)
        {
            var player = await _dataContext.Players
                                           .Include(c => c.Backpack)
                                           .Include(c => c.Weapons)
                                           .Include(c => c.Clans)
                                           .FirstOrDefaultAsync(x => x.PlayerId == id);

            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<List<Player>>> CreatePlayer(PlayerCreateDto request)
        {
            var newPlayer = new Player
            {
                Name = request.Name
            };

            var backpack = new Backpack
            {
                Color = request.Backpack.Color , Player = newPlayer
            };

            var weapons = request.Weapons.Select(w => new Weapons { WeaponName = w.WeaponName , Player = newPlayer}).ToList();

            var clans = request.Clans.Select(c => new Clans { ClanName = c.ClanName, Players = new List<Player> { newPlayer } }) .ToList();

            newPlayer.Weapons = weapons;

            newPlayer.Backpack = backpack;

            newPlayer.Clans = clans;

            _dataContext.Add(newPlayer);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext .Players.Include(c=>c.Backpack).Include(c=>c.Weapons).ToListAsync());
        }
    }
}
