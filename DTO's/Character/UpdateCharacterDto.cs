namespace dotnet_rpg_6.DTO_s.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 100;
        public RpgCharacter Class { get; set; } = RpgCharacter.Knight;
    }
}
