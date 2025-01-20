namespace PlayerRelationships.DTOs
{
    public record struct PlayerCreateDto(string Name,
        BackpackCreateDto Backpack, 
        List<WeaponCreateDto> Weapons,
        List<ClanCreateDto> Clans);
}
