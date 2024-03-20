using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuglaKontrol : MonoBehaviour
{
    public static int tuglaSayisi;

    [SerializeField]
    Sprite[] tuglalar;
    [SerializeField]
    AudioClip tuglaCarpma;
    [SerializeField]
    AudioClip tuglaKirilma;
    [SerializeField]
    GameObject kirilma;

    PuanKontrol puanKontrol;

    int maxCarpma;
    int carpma;
    // Start is called before the first frame update
    void Start()
    {
        puanKontrol = GameObject.FindObjectOfType<PuanKontrol>().GetComponent<PuanKontrol>();
        maxCarpma = tuglalar.Length + 1;
        tuglaSayisi++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Top"))
        {
            carpma++;
            puanKontrol.PuanArttir();
            if(carpma >= maxCarpma)
            {
                tuglaSayisi--;
                if(tuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().SonrakiSahne();
                }
                Vector3 pos = collision.contacts[0].point;
                GameObject go = Instantiate(kirilma, pos, Quaternion.identity);
                Color tuglaRengi = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = tuglaRengi;
                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(tuglaKirilma, transform.position);
                Destroy(gameObject);
            } else
            {
                AudioSource.PlayClipAtPoint(tuglaCarpma, transform.position);
                GetComponent<SpriteRenderer>().sprite = tuglalar[carpma - 1];
            }
        }
    }
}
