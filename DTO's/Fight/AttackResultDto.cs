namespace dotnet_rpg_6.DTO_s.Fight
{
    public class AttackResultDto
    {
        public string AttackerName { get; set; } = string.Empty;
        public string OpponentName { get; set; } = string.Empty;
        public int AttackerHP { get; set; }
        public int OpponentHP { get; set; }
        public int Damage { get; set; }
    }
}
