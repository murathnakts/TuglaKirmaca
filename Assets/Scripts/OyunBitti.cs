using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunBitti : MonoBehaviour
{
    [SerializeField]
    Text puanText;

    PuanKontrol puanKontrol;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        puanKontrol = GameObject.FindObjectOfType<PuanKontrol>().GetComponent<PuanKontrol>();
        puanText.text ="Puan: " + puanKontrol.PuanGoster();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
