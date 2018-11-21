using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectHelpButton : MonoBehaviour {

    public GameObject SelectHelpPanel;

    public void PanelSetActive()
    {
        SelectHelpPanel.SetActive(!SelectHelpPanel.active);
    }
}
