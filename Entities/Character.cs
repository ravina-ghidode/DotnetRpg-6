using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg_6.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } =    10;
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 100;
        public RpgCharacter Class { get; set; } = RpgCharacter.Knight;
       
        public User?  User { get; set; }
        public Weapon? Weapon { get; set; }
        public List<Skill> Skills { get; set; }
        public int Fight { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }


    }
}
