namespace Music_Rest
{
    public class MusicRepo
    {
        private List<Music>? _musicList;
        public MusicRepo() { }
        public List<Music> GetAll()
        {
          
            return new List<Music>(_musicList);
        }
    }
}
