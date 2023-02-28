﻿namespace dotnet_rpg_6.Entities
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public Character Character { get; set; }
        public int CharacterId { get; set; }

    }
}
