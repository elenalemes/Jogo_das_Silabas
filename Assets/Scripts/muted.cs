using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muted : MonoBehaviour
{
    private bool somOn;
    [SerializeField] Image soundOFF;
    [SerializeField] Image soundON;

    void Start()
    {
        somOn = AudioListener.volume > 0;
        OnOff();
    }

    public void VolumeDoJogo()
    {
        somOn = !somOn;
        AudioListener.volume = somOn ? 1 : 0;
        OnOff();
    }

    private void OnOff()
    {
        if (somOn)
        {
            soundON.gameObject.SetActive(true);
            soundOFF.gameObject.SetActive(false);
        }
        else
        {
            soundON.gameObject.SetActive(false);
            soundOFF.gameObject.SetActive(true);
        }
    }
}