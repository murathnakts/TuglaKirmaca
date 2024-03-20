using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GecisKontrol : MonoBehaviour
{
    PuanKontrol puanKontrol;
    public void YeniOyun()
    {
        TuglaKontrol.tuglaSayisi = 0;
        puanKontrol = GameObject.FindObjectOfType<PuanKontrol>().GetComponent<PuanKontrol>();
        puanKontrol.PuanSifirla();
        SceneManager.LoadScene("Bolum1");
    }

    public void Bolumler()
    {
        TuglaKontrol.tuglaSayisi = 0;
        puanKontrol = GameObject.FindObjectOfType<PuanKontrol>().GetComponent<PuanKontrol>();
        puanKontrol.PuanSifirla();
        SceneManager.LoadScene("Bolumler");
    }

    public void Geri()
    {
        SceneManager.LoadScene("AnaMenu");
    }

    public void Bolum()
    {
        SceneManager.LoadScene(gameObject.name);
    }
}
