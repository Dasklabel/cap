using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpPanel : MonoBehaviour {

    public GameObject Panel;

    public void PanelSetActive()
    {
        Panel.SetActive(!Panel.active);
    }
}
