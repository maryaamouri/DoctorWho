namespace DoctorWhoDomain.Repos
{
    public interface IEpisodeRepo<T> : IRepo<T> where T : class
    {
        public void AddCompanionToEpisode(T Entity);
        public void AddEnemyToEpisode(T Entity);
    }
}