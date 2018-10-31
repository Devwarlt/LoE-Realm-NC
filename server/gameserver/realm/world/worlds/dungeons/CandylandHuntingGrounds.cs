namespace LoESoft.GameServer.realm.world
{
    public class CandylandHuntingGrounds : World
    {
        public CandylandHuntingGrounds()
        {
            Name = "Candyland Hunting Grounds";
            Background = 0;
            Difficulty = 3;
            AllowTeleport = true;
        }

        protected override void Init() => LoadMap("candyland", MapType.Wmap);
    }
}