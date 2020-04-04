using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _scrNomgAperson : MonoBehaviour
{
    public  TMP_Text ngAPerson;
    private string stggAperson, temper;
    private GameObject gaperstx;
    private Transform gaperspos;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindWithTag("gAPerson") != null){
        //print("holas person");
        gaperstx = GameObject.FindWithTag("gAPerson");
        gaperspos = gaperstx.transform;    }
    }
}
