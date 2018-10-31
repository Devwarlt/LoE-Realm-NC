namespace LoESoft.GameServer.realm.world
{
    public class OceanTrench : World
    {
        public OceanTrench()
        {
            Name = "Ocean Trench";
            Dungeon = true;
            Background = 0;
            AllowTeleport = true;
        }

        protected override void Init() => LoadMap("oceantrench", MapType.Wmap);
    }
}