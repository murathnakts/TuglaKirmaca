using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolumKontrol : MonoBehaviour
{
    public static int bolum = 1;
 
    [SerializeField]
    Button bolum1Button;
    [SerializeField]
    Button bolum2Button;
    [SerializeField]
    Button bolum3Button;
    [SerializeField]
    Button bolum4Button;
    [SerializeField]
    Button bolum5Button;
    [SerializeField]
    Button bolum6Button;
    [SerializeField]
    Button bolum7Button;
    [SerializeField]
    Button bolum8Button;
    [SerializeField]
    Button bolum9Button;
    [SerializeField]
    Button bolum10Button;
    [SerializeField]
    Button bolum11Button;
    [SerializeField]
    Button bolum12Button;


    // Start is called before the first frame update
    void Awake()
    {
        if(bolum >= 2)
        {
            bolum2Button.interactable = true;
        }
        if (bolum >= 3)
        {
            bolum3Button.interactable = true;
        }
        if (bolum >= 4)
        {
            bolum4Button.interactable = true;
        }
        if (bolum >= 5)
        {
            bolum5Button.interactable = true;
        }
        if (bolum >= 6)
        {
            bolum6Button.interactable = true;
        }
        if (bolum >= 7)
        {
            bolum7Button.interactable = true;
        }
        if (bolum >= 8)
        {
            bolum8Button.interactable = true;
        }
        if (bolum >= 9)
        {
            bolum9Button.interactable = true;
        }
        if (bolum >= 10)
        {
            bolum10Button.interactable = true;
        }
        if (bolum >= 11)
        {
            bolum11Button.interactable = true;
        }
        if (bolum >= 12)
        {
            bolum12Button.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
