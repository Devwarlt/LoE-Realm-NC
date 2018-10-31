namespace LoESoft.GameServer.realm.world
{
    public class ForestMaze : World
    {
        public ForestMaze()
        {
            Name = "Forest Maze";
            Background = 0;
            Difficulty = 1;
            AllowTeleport = true;
        }

        protected override void Init() => LoadMap("forestmaze", MapType.Wmap);
    }
}