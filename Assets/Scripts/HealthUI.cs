using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    [SerializeField]
    private Text _health;

    [SerializeField]
    private Player player;
    
    void Start()
    {
        player.HealthChanged += SetHealth;
    }

    public void SetHealth(int amount)
    {
        _health.text = "Health: " + amount;
    }


}
