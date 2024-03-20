using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    GameObject pedal;

    bool oyun = false;

    // Start is called before the first frame update
    void Start()
    {
        pedal = GameObject.FindObjectOfType<PedalKontrol>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(!oyun)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
            if (Input.GetMouseButtonDown(0) && !oyun)
            {
                oyun = true;  
                GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
    }
}
