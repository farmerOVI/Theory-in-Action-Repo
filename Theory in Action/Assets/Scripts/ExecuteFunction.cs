using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class ExecuteFunction : Enemy
{
    private PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public override void DoSomething()
    {
        base.DoSomething();
        playerController.PlayerHealth -= 5;
    }

    public override void CountScore()
    {
        playerController.Score += 1;
        base.CountScore();
    }
}
