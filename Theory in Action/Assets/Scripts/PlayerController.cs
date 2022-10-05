using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private float playerHealth = 10;
    public int Score = 0;

    public float PlayerHealth
    {
        get
        {
            return playerHealth;
        }
        set
        {
            playerHealth = value;
            if (playerHealth <= 0)
            {
                Destroy(gameObject);
                Debug.Log("The Final Destination :(");
                Time.timeScale = 0;
            }
        }
    }

    public float HorizontalInput;
    private float moveRangeX = 6;

    public Material defaultMat;
    private Renderer playerRend;
    public bool isRunning = false;


    private void Awake()
    {
        playerRend = GameObject.FindGameObjectWithTag("Model").GetComponent<Renderer>();
    }

   

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        if (!isRunning)
        {
            StartCoroutine(ChangeMaterial());
        }

        if(transform.position.x < -moveRangeX)
        {
            transform.position = new Vector3(-moveRangeX, transform.position.y, transform.position.z);
        }
        if(transform.position.x > moveRangeX)
        {
            transform.position = new Vector3(moveRangeX, transform.position.y, transform.position.z);
        }


    }
   private IEnumerator ChangeMaterial()
    {
        isRunning = true;

        yield return new WaitForSeconds(3);
        if (playerRend.material != defaultMat)
        {
            playerRend.material = defaultMat;
        }
        isRunning = false;

    }
}    
