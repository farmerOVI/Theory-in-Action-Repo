using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class ExecuteOtherFunction : Enemy
{
    private GameObject player;
    private Renderer playerRen;
    private Renderer objectRen;
    private PlayerController playerController;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Model");
        playerRen = player.GetComponent<Renderer>();
        objectRen = gameObject.GetComponent<Renderer>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    //POLYMORPHISM
    public override void DoSomething()
    {
        
        playerRen.material = objectRen.material;
        base.DoSomething();
        playerController.PlayerHealth += 10;
    }

}
