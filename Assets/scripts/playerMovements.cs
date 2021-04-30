using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovements : MonoBehaviour
{
    Vector3 player;
    

    public float playerSpeed;
    public GameObject heels;
    public GameObject highHeels;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = transform.localPosition;
        player.x += Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        transform.localPosition = player;
    }  

   
}
