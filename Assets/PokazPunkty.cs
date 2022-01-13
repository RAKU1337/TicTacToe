using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PokazPunkty : MonoBehaviour
{
    public Bird gracz;
    public TMP_Text punkty;



    // Update is called once per frame
    void Update()
    {
        punkty.text = gracz.punkty.ToString();
    }
}
