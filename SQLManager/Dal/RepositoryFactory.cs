namespace SQLManager.Dal
{
    internal static class RepositoryFactory
    {
        private static readonly Lazy<IRepository> repository = new Lazy<IRepository>(() => new SQLRepository());
        internal static IRepository GetRepository() => repository.Value;
    }
}
