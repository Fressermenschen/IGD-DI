using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Game : MonoBehaviour
{
    [SerializeField] private BallView _ballView;
    private BallPresenter _ballPresenter;
    [Inject] private BallModel _ballModel;
    private void Start()
    {
        _ballPresenter = new BallPresenter(_ballView, _ballModel);       
    }
    
    private void OnDestroy()
    {
        _ballPresenter.Dispose();
    }
}
