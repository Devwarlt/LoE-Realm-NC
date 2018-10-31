namespace LoESoft.GameServer.realm.world
{
    public class AbyssofDemons : World
    {
        public AbyssofDemons()
        {
            Name = "Abyss of Demons";
            Dungeon = true;
            Background = 0;
            AllowTeleport = true;
        }

        protected override void Init() => LoadMap("abyss", MapType.Wmap);
    }
}