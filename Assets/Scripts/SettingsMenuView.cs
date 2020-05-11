using System;
using UnityEngine;

public class SettingsMenuView : View
{
    [SerializeField] private ButtonView _backButtonView;

    public void Setup(Action backCallback, string labelText)
    {
        _backButtonView.Setup(backCallback, labelText);
    }
}
