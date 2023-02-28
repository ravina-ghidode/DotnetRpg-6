using AutoMapper;
using dotnet_rpg_6.DTO_s.Fight;
using dotnet_rpg_6.DTO_s.Skill;
using dotnet_rpg_6.DTO_s.Weapon;

namespace dotnet_rpg_6
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
           // CreateMap<UpdateCharacterDto, Character>().ReverseMap();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}
