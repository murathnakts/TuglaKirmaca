using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuanKontrol : MonoBehaviour
{
    int puan;

    public void PuanArttir()
    {
        puan++;
    }

    public int PuanGoster()
    {
        return puan;
    }

    public void PuanSifirla()
    {
        puan = 0;
    }
}
