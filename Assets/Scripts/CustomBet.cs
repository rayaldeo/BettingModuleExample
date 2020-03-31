using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomBet : MonoBehaviour
{
    public Slider _customBetSlider;
    public Text _customBet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _customBet.text = _customBetSlider.value.ToString();
    }
}
