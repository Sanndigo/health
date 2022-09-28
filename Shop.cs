using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{

    [SerializeField] private GameObject[] _skins;
    [SerializeField] private int moneyPlus;
    [SerializeField] private TMP_Text _moneyView;


    private int money;
    private int i = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int b = 0; b < _skins.Length; b++)
        {
            _skins[b].SetActive(false);
            _skins[i].SetActive(true);
        }
        _moneyView.text = money.ToString();
    }

    public void OnBuyYellow()
    {
        i = 1;
        money -= 50;
    }

    public void OnBuyRed()
    {
        i = 0;
        money -= 25;
    }

    public void OnBuyGreen()
    {
        i = 2;
        money -= 75;
    }

    public void moneyAdd()
    {
        money += moneyPlus;
    }
}
