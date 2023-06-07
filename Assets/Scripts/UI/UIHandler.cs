using NutriQuest.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private PlayerEnergy _playerEnergy;
    [SerializeField]
    private TMP_Text _energyText;

    private void Start()
    {
        _energyText.text = $"Energy : {_playerEnergy.Energy}";
    }
    private void OnEnable()
    {
        if (_playerEnergy != null)
        {
            _playerEnergy.OnEnergyChange += DisplayEnergy;
        }
    }

    public void DisplayEnergy(int energy)
    {
        _energyText.text = $"Energy : {energy}";
    }
}
