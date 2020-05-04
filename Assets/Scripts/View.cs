using System;
using UnityEngine;

public class View : MonoBehaviour
{
    public Action OnDestroyCallback { get; set; }

    private void OnDestroy()
    {
        OnDestroyCallback?.Invoke();
    }
}