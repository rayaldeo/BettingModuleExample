using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetPanel : MonoBehaviour
{
    #region Resources
    public GameObject _imageResources;
    #endregion
    public Player leftPlayer, rightPlayer;
    public Text leftPlayerNameText, rightPlayerNameText,_confirmationBetValue,_customBetValue,
        leftPlayerTMValue,rightPlayerTMValue;
    public Image leftPlayerImage, rightPlayerImage;
    public Slider _customBetSlider;
    public Text _smallButtonValue, _mediumButtonValue, _largeButtonValue;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayBetPanel()
    {

    }
}
