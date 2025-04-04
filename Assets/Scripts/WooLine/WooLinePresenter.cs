using System;
using R3;
using UnityEngine;

public class WooLinePresenter : IDisposable
{ 
    private WooLineView _view;
    private WooLineModel _model;

    private WooPath _path;

    private CompositeDisposable _disposable;

    private readonly Vector3 SelectedScale = new(.35f, .35f, 1f);
    private readonly Vector3 UnelectedScale = new(.5f, .5f, 1f);
    
    private readonly Color SelectedColor = new(.15f, .45f, .85f);
    private readonly Color UnelectedColor = Color.white;
    
    public void Initialize()
    {
        _disposable.Add(Observable.EveryUpdate()
            .Where(_ => !_view.HandleSpriteRenderer.enabled && Input.GetMouseButtonDown(0))
            .Subscribe(_ => CreateNewWooLine()));
        _disposable.Add(Observable.EveryUpdate()
            .Where(_ => _view.HandleSpriteRenderer.enabled && Input.GetMouseButtonUp(0))
            .Subscribe(_ => HideView()));
    }

    private void HideView()
    {
        _view.HandleSpriteRenderer.enabled = false;
        _view.LineRenderer.positionCount = 1;
        _view.LineRenderer.SetPosition(0, Vector3.zero);
    }

    private void CreateNewWooLine()
    {
        Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _view.transform.position = position;
        EnableView();
    }

    private void EnableView()
    {
        _view.HandleSpriteRenderer.enabled = true;
        _view.transform.localScale = SelectedScale;
        _view.HandleSpriteRenderer.color = SelectedColor;
        _view.LineRenderer.positionCount = 1;
        _view.LineRenderer.SetPosition(0, Vector3.zero);
    }

    public void Dispose()
    {
        _disposable.Dispose();
    }
}