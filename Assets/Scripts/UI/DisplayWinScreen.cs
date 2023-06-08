using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWinScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject _winScreen;

    private void OnEnable()
    {
        WinLevel.OnWinLevel += ToggleWinScreen;
    }
    private void OnDisable()
    {
        WinLevel.OnWinLevel -= ToggleWinScreen;
    }
    public void ToggleWinScreen()
    {
        _winScreen.SetActive(!_winScreen.activeSelf);
    }
}
