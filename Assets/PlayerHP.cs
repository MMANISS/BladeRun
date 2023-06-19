using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Text hpText;
    public GameObject player;

    private float playerHealth;

    void Update()
    {
        playerHealth = player.GetComponent<Health>().health;
        hpText.text = playerHealth.ToString();
    }
}
