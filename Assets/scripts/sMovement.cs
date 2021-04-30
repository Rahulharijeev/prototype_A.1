using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sMovement : MonoBehaviour
{
    public float levelSpeed ;


    public GameObject cube;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position += Vector3.back * levelSpeed * Time.deltaTime;
    }
}
