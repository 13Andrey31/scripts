using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUi : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;

        coinsCounterText.text = player.coins.ToString();
    }
}
