namespace LoESoft.GameServer.realm.world
{
    public class BelladonnasGarden : World
    {
        public BelladonnasGarden()
        {
            Name = "Belladonna's Garden";
            Background = 0;
            AllowTeleport = false;
            Difficulty = 5;
        }

        protected override void Init() => LoadMap("belladonnasGarden", MapType.Wmap);
    }
}