using dotnet_rpg_6.DTO_s.Skill;
using dotnet_rpg_6.DTO_s.Weapon;

namespace dotnet_rpg_6.DTO_s.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 100;
        public RpgCharacter Class { get; set; } = RpgCharacter.Knight;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }
        public int Fight { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}
