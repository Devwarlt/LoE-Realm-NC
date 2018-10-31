namespace LoESoft.GameServer.realm.world
{
    public class Kitchen : World
    {
        public Kitchen()
        {
            Name = "Kitchen";
            Background = 0;
        }

        protected override void Init() => LoadMap("kitchen", MapType.Wmap);
    }
}