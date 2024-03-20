using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarKontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip ses;
    [SerializeField]
    GameObject carpma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(ses,transform.position);
        Vector3 pos = collision.contacts[0].point;
        GameObject go = Instantiate(carpma, pos, Quaternion.identity);
        Destroy(go, 1f);
    }
}
