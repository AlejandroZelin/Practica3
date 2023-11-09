using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class CambiadorIdioma : MonoBehaviour
{
    private List<Locale> idiomas;
    public int cambioIdioma = 2;

    void Start()
    {
        idiomas = LocalizationSettings.AvailableLocales.Locales;
    }

    public void Español() 
    {
        LocalizationSettings.Instance.SetSelectedLocale(idiomas[2]);
    }

    public void Ingles()
    {
        LocalizationSettings.Instance.SetSelectedLocale(idiomas[0]);
    }

    public void Frances()
    {
        LocalizationSettings.Instance.SetSelectedLocale(idiomas[1]);
    }

    public void SiguienteIdioma() 
    {
        cambioIdioma++;
        if (cambioIdioma == 3) 
        {
            cambioIdioma = 0;
        }

        LocalizationSettings.Instance.SetSelectedLocale(idiomas[cambioIdioma]);
    }

    public void AnteriorIdioma()
    {
        cambioIdioma--;
        if (cambioIdioma == -1)
        {
            cambioIdioma = 2;
        }

        LocalizationSettings.Instance.SetSelectedLocale(idiomas[cambioIdioma]);
    }
}
