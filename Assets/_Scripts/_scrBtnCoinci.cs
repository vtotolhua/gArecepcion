using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _scrBtnCoinci : MonoBehaviour
{
    public string nL, nm, tel, emal;
    public static string selnl, selnom, seltel, selemal;

    // Start is called before the first frame update
    void Start()
    {
        //print("en btn " + "linea " + nL + " nombre " + nm + " tel " + tel + " mail" + emal);
    }

    public void pasaDatos (){
        selnl = nL;
        selnom = nm;
        seltel = tel;
        selemal = emal; 
        print("al click btn" + "linea " + selnl + " nombre " + selnom + " tel " + seltel + " mail" + selemal);
    }
}
