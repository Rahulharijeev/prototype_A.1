using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingHeels : MonoBehaviour
{

    public GameObject heels;
    public GameObject studs;
    public GameObject pLayer;
    public GameObject sHitHeels;
    public Rigidbody rB;
    public Vector3 jump;



    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 0.02f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == sHitHeels)
        {
            //pLayer.transform.position = new Vector3(0, 0.5f, 0);
            //rB.AddForce(jump * 0.02f, ForceMode.Impulse);
            pLayer.transform.position = new Vector3(pLayer.transform.position.x, pLayer.transform.position.y + 3f, pLayer.transform.position.z);
            Debug.Log("im dead!!!");
            Destroy(other);
            Instantiate(heels, transform.position, Quaternion.identity).transform.parent = studs.transform;
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 2f, this.transform.position.z);

        }
    }

     private void OnTriggerExit(Collider other)
    {
        pLayer.transform.position = new Vector3(pLayer.transform.position.x, pLayer.transform.position.y, pLayer.transform.position.z);
       
    }

}
