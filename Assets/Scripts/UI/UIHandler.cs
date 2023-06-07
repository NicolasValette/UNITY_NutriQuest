using NutriQuest.Interfaces;
using NutriQuest.Player;
using System.Collections;
using TMPro;
using UnityEngine;


public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerEnergy;
    [SerializeField]
    private TMP_Text _energyText;

    private IObservable<int> _energy;

    private void Start()
    {
        _energy = _playerEnergy.GetComponent<IObservable<int>>();
        _energyText.text = $"Energy : {_energy.Value}";
        if (_energy != null)
        {
            _energy.OnValueChange += DisplayEnergy;
        }
    }
    private void OnEnable()
    {
        if (_energy != null)
        {
            _energy.OnValueChange += DisplayEnergy;
        }
    }

    public void DisplayEnergy(int energy)
    {
        _energyText.text = $"Energy : {energy}";
    }
}
