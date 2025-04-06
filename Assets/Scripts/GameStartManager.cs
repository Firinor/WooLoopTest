using System;
using R3;
using UnityEngine;
using Zenject;

public class GameStartManager : MonoBehaviour
{
    [Inject] private WooLinePresenter _wooLinePresenter;
    void Start()
    { 
        //ObservableSystem.DefaultTimeProvider = UnityTimeProvider.Update;
        //ObservableSystem.DefaultFrameProvider = UnityFrameProvider.Update;
        
        _wooLinePresenter.Initialize();
    }
}