using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            Destroy(gameObject);
            CountScore();
        } else if(other.tag == "Model")
        {
            DoSomething();
        } 
    }
    // POLYMORPHISM
    public virtual void DoSomething()
    {

    }
    // POLYMORPHISM
    public virtual void CountScore()
    {

    }
}
