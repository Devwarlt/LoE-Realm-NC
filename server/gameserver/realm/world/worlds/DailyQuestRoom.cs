namespace LoESoft.GameServer.realm.world
{
    public class DailyQuestRoom : World, IDungeon
    {
        public DailyQuestRoom()
        {
            Name = "Daily Quest Room";
            Background = 0;
            AllowTeleport = false;
            Difficulty = -1;
        }

        protected override void Init() => LoadMap("dailyQuest", MapType.Wmap);
    }
}