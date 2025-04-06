using Zenject;

public class SceneContextInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        InitializeGameContext();
        InitializeModels();
        InitializePresenters();
        InitializeSystems();
    }

    private void InitializeGameContext()
    {
        
    }
    private void InitializeModels()
    {
        
    }
    
    private void InitializePresenters()
    {
        Container.Bind<WooLinePresenter>().AsSingle();
    }
    
    private void InitializeSystems()
    {
        
    }
}