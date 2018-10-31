namespace LoESoft.GameServer.realm.world
{
    public class OryxCastle : World
    {
        public OryxCastle()
        {
            Name = "Oryx's Castle";
            Background = 0;
            AllowTeleport = false;
        }

        public override bool NeedsPortalKey => true;

        protected override void Init() => LoadMap("OryxCastle", MapType.Wmap);
    }
}