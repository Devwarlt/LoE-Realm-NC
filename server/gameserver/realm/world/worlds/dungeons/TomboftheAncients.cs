namespace LoESoft.GameServer.realm.world
{
    public class TomboftheAncients : World
    {
        public TomboftheAncients()
        {
            Name = "Tomb of the Ancients";
            Dungeon = true;
            Background = 0;
            AllowTeleport = true;
        }

        protected override void Init() => LoadMap("tomb", MapType.Wmap);
    }
}