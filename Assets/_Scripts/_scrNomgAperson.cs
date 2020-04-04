using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _scrNomgAperson : MonoBehaviour
{
    public  TMP_Text ngAPerson;
    private string stggAperson, temper;
    private GameObject gaperstx, goContConinc;
    private Transform gaperspos;
    [SerializeField] _scrDispNombres datoamuestra;
    public _classContInf listacont;
    void Start()
    {
        if (GameObject.FindWithTag("gAPerson") != null)
        {
        gaperstx = GameObject.FindWithTag("gAPerson");
        gaperspos = gaperstx.transform;    
        }
        if (GameObject.FindWithTag("contCoinci") != null)
        {
        goContConinc= GameObject.FindWithTag("contCoinci");
        datoamuestra = goContConinc.GetComponent<_scrDispNombres>();
        }


        muestracoinci();
    }

    private void muestracoinci (){
        foreach (_classContInf conta in datoamuestra.contCoincide){
            //print("coincidencias " + conta.gAnombre + " tel  " + conta.telef + " mail " + conta.correo ) ;
            ngAPerson.text = conta.gAnombre;
            print("coincidencia p " + ngAPerson);
            //Instantiate(gaperstx, new Vector3(gaperspos.transform.position.x, gaperspos.transform.position.y + 100,gaperspos.transform.position.z), Quaternion.identity);
        }


    }
}
