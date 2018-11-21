using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public GameObject GBluePanel;
    public GameObject MBluePanel;
    public GameObject PBluePanel;
    public GameObject CBluePanel;

    //public Button SelectGirlButton;
    //  public Button SelectManButton;
    //public Button SelectPoliceButton;
    //  public Button SelectCameralButton;

    public Button GirlButton;
    public Button ManButton;
    public Button PoliceButton;
    public Button CameraButton;



    public void G_Click()
    {
        if (!GBluePanel.active)
        {
            if (MBluePanel.active)
                MBluePanel.SetActive(!MBluePanel.active);
            if (PBluePanel.active)
                PBluePanel.SetActive(!PBluePanel.active);
            if (CBluePanel.active)
                CBluePanel.SetActive(!CBluePanel.active);
        }
        GBluePanel.SetActive(true);
    }

    public void M_Click()
    {
        if (!MBluePanel.active)
        {
            if (GBluePanel.active)
                GBluePanel.SetActive(!GBluePanel.active);
            if (PBluePanel.active)
                PBluePanel.SetActive(!PBluePanel.active);
            if (CBluePanel.active)
                CBluePanel.SetActive(!CBluePanel.active);
        }
        MBluePanel.SetActive(true);
    }

    public void C_Click()
    {
        if (!CBluePanel.active)
        {
            if (MBluePanel.active)
                MBluePanel.SetActive(!MBluePanel.active);
            if (PBluePanel.active)
                PBluePanel.SetActive(!PBluePanel.active);
            if (GBluePanel.active)
                GBluePanel.SetActive(!CBluePanel.active);
        }
        CBluePanel.SetActive(true);
    }

    public void P_Click()
    {
        if (!PBluePanel.active)
        {
            if (MBluePanel.active)
                MBluePanel.SetActive(!MBluePanel.active);
            if (GBluePanel.active)
                GBluePanel.SetActive(!PBluePanel.active);
            if (CBluePanel.active)
                CBluePanel.SetActive(!CBluePanel.active);
        }
        PBluePanel.SetActive(true);
    }

}
