using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOn : MonoBehaviour
{

    public GameObject GBluePanel;
    public GameObject MBluePanel;
    public GameObject PBluePanel;
    public GameObject CBluePanel;

    public GameObject Spon_Position;

    public GameObject GPrefab;
    public GameObject MPrefab;
    public GameObject PPrefab;
    //public GameObject CPrefab;


    void On()
    {
        if (GBluePanel.active)
        {
            Instantiate(female, Spon_Position.transform.position, Quaternion.identity);
        }
    }
}
