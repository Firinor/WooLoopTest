using UnityEngine;

public static class Bootstrap 
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void GameStart()
    {
        InitializeGameContext();
        InitializeModels();
        InitializeSystems();
        InitializePresenters();
    }
    private static void InitializeGameContext()
    {
        
    }
    private static void InitializeModels()
    {
        
    }
    private static void InitializeSystems()
    {
        
    }
    private static void InitializePresenters()
    {
        GameContext.WooLine = new WooLinePresenter();
        GameContext.WooLine.Initialize();
    }
}