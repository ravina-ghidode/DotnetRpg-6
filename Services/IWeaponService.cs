using dotnet_rpg_6.DTO_s.Weapon;

namespace dotnet_rpg_6.Services
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
