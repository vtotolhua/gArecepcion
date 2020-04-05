using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class _scrPanelCoin : MonoBehaviour
{
    private GameObject goContCoin;
    [SerializeField] _scrDispNombres baseCoincidencias;
    public _classContInf listacoinc;
    public static string ganombre, gatelefono, gamail;
    //public  TMP_Text ngAPerson;
    void Start()
    {
        if (GameObject.FindWithTag("contCoinci") != null)
        {
            goContCoin = GameObject.FindWithTag("contCoinci");
            baseCoincidencias = goContCoin.GetComponent<_scrDispNombres>();
            StartCoroutine("spawnCoincidencias");
        }

    }

    IEnumerator spawnCoincidencias ()
    {
        foreach (_classContInf coincidencia in baseCoincidencias.contCoincide)
        {
            ganombre = coincidencia.gAnombre;
            gatelefono = coincidencia.telef;
            gamail = coincidencia.correo;
            print("las coincidencias son " + "nombre "+ ganombre + " telefono " + gatelefono + " mail " + gamail);
        }
        yield return null;
    }
}
