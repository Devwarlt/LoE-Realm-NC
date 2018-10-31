namespace LoESoft.GameServer.realm.world
{
    public class MadLab : World
    {
        public MadLab()
        {
            Name = "Mad Lab";
            Background = 0;
            Difficulty = 5;
            AllowTeleport = true;
        }

        protected override void Init() => LoadMap("vault", MapType.Wmap);
    }
}