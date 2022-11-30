using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class TextChangeOnClick : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textStartGame;
    [SerializeField] private TextMeshProUGUI _textExitGame;
    [SerializeField] private TextMeshProUGUI _textAboutAuthor;
    [SerializeField] private RectTransform _transformTextStart;
    [SerializeField] private RectTransform _transformTextAboutAuthors;
    [SerializeField] private RectTransform _transformTextExit;

    private Color _color = Color.red;

    public void OnButtonClickPlay()
    {
        _textStartGame.DOColor(_color, 3);
        _transformTextStart.DORotate(new Vector3(0, 0, -80), 0.5f);
    }

    public void OnButtonClickAboutAuthor()
    {
        _textAboutAuthor.DOColor(_color, 3);
        _transformTextAboutAuthors.DORotate(new Vector3(0, -60, 0), 0.5f);
    }

    public void OnButtonClickExit()
    {
        _textExitGame.DOColor(_color, 3);
        _transformTextExit.DOScaleX(6, 3);
    }
}
