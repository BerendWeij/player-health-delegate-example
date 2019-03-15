using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamager : MonoBehaviour
{

    private Player _player;
    
    void Start()
    {
        _player = GetComponent<Player>();
    }
    
    void OnMouseDown ()
    {
        _player.TakeDamage(10);
    }

    
}
