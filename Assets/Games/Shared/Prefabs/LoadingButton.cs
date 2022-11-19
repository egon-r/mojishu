using System;
using System.Collections;
using System.Collections.Generic;
using Games.Shared.Prefabs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingButton : MonoBehaviour
{
    public TextMeshProUGUI ButtonText;
    public LoadingSpinner Spinner;

    private bool _loading;
    public bool Loading
    {
        get => _loading;
        set
        {
            _loading = value;
            try
            {
                Spinner.gameObject.SetActive(value);
                ButtonText.gameObject.SetActive(!value);
                GetComponentInParent<Button>().interactable = !value;
            }
            catch
            {
                // ignored, button was likely destroyed due to a scene switch
            }
        }
    }

    void Start()
    {
        Loading = false;
    }
}
