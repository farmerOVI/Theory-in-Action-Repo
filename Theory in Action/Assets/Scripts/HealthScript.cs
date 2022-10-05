using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthScript : MonoBehaviour
{
    public Image healthBar;
    private PlayerController playerController;
    private float maxHealth = 20;
    private float health;

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        health = playerController.PlayerHealth;
        float fillValue = health / maxHealth;
        healthBar.fillAmount = fillValue;

    }
}
