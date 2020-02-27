using UnityEngine;
using TMPro;
using System.IO;
using System.Collections.Generic;
using System.Collections;

public class _ScrRcbInf : MonoBehaviour
{
    public TMP_InputField nvisit, ngAperson;
    private TMP_InputField.SubmitEvent escribe1, escribe2;
    public static string stgNvisit, stgNgAperson;

    private void Start()
    {
        if (gameObject.tag == "visita") {
            nvisit = this.gameObject.GetComponent<TMP_InputField>();
            escribe1 = new TMP_InputField.SubmitEvent();
            escribe1.AddListener(EnvInfvisit);
            nvisit.onEndEdit = escribe1;
        }

        if (gameObject.tag == "gAPerson")
        {
            ngAperson = this.gameObject.GetComponent<TMP_InputField>();
            escribe2 = new TMP_InputField.SubmitEvent();
            escribe2.AddListener(EnvInfgAper);
            ngAperson.onEndEdit = escribe2;
        }
    }
    private void EnvInfvisit(string nombre1) {
        stgNvisit = nombre1.ToLower();
    }
    private void EnvInfgAper(string nombre2)
    {
        nombre2 = nombre2.ToLower();
        stgNgAperson = nombre2;
    }
}
