using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuzikKontrol : MonoBehaviour
{
    [SerializeField]
    Sprite[] muzikIkons = default;

    [SerializeField]
    Button muzikButton = default;

    AudioSource audioSource;

    bool play = false;
    static bool load;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("muzik") == 1)
        {
                audioSource.Play();
                muzikButton.image.sprite = muzikIkons[1];
                play = true;
        } else 
        {
            muzikButton.image.sprite = muzikIkons[0];
            play = false;
        }
        
        if(!load)
        {
            GameObject.DontDestroyOnLoad(gameObject);
            load = true;
        } else
        {
            Destroy(this.gameObject);
        }
    }

   public void MuzikDurdurBaslat()
    {
        if (play)
        {
            audioSource.Pause();
            muzikButton.image.sprite = muzikIkons[0];
            PlayerPrefs.SetInt("muzik", 0);
            play = false;
        } else
        {
            audioSource.Play();
            muzikButton.image.sprite = muzikIkons[1];
            PlayerPrefs.SetInt("muzik", 1);
            play = true;
        }
    }
}
