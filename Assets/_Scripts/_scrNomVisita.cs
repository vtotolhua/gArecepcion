using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class _scrNomVisita : MonoBehaviour
{
    public  TMP_Text nvisita;
    private string stgvisita;
    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.FindWithTag("visita")!= null)  {
            stgvisita = _ScrRcbInf.stgNvisit.ToString();
            nvisita.text = stgvisita;
            //Debug.Log("verifv " + stgvisita);
        }
    }
}
