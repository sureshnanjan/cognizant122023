namespace ApplicationScenarios
{
    internal interface ISlowResource
    {
        void Load();
        int getLoadTime();
    }
}