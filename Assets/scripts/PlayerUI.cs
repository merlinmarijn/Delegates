using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUI : MonoBehaviour
{
    public Text HealthUI;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player.HealthChanged += UpdateHealth;
        player.Died += PlayerDied;
        HealthUI.text = "Health: " + 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateHealth(int health)
    {
        HealthUI.text = "Health: " + health;
    }
    private void PlayerDied()
    {
        HealthUI.text = "Health: Player has died";
    }
}
