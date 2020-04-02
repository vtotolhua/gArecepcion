using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;

public class _scrDispNombres : MonoBehaviour
{
    /*************************************************************************************************/
    /*Esta clase nos permite mostrar los nombres que escribión el usuario*****************************/
    /*estos se muestran en la parte de la confirmación de los datos **********************************/
    /*************************************************************************************************/
    public  TMP_Text nvisita, ngAPerson;
    private string stgvisita, stggAperson, temper;
    public static string numcont, gacont;
    [SerializeField] _ScrBDCont basecontactos;
    [SerializeField] _classContInf listacont;

    private Transform posdispnm;
    public GameObject dispnom;

    private List<string> nombres = new List<string>();
    
    void Start()
    {
        if (gameObject.tag == "visita") {
            stgvisita = _ScrRcbInf.stgNvisit.ToString();
            nvisita.text = stgvisita;
            //Debug.Log("verifv " + stgvisita);
        }

        if (gameObject.tag == "gAPerson") {
            basecontactos = GameObject.FindGameObjectWithTag("contactos").GetComponent<_ScrBDCont>();
            posdispnm = GameObject.FindGameObjectWithTag("gAPerson").GetComponent<Transform>();
            StartCoroutine ("displnom");
        }
    }

    IEnumerator displnom ()
    {

        //El nombre del colaborador gA
        stggAperson = _ScrRcbInf.stgNgAperson.ToString();
        //Instantiate(this.gameObject, new Vector3(posdispnm.transform.position.x, posdispnm.transform.position.y,posdispnm.transform.position.z), Quaternion.identity);
        gacont = temper;
        foreach (_classContInf contacto in basecontactos.contactosinfo){
            print("hello wolrd");
            temper = contacto.gAnombre;
            if (temper.Contains(stggAperson))
            {
            //creamos lista que tiene nombres parecidos
            nombres.Add(string.Format("{0}", temper)); 
            //Instantiate(this.gameObject, new Vector3(posdispnm.transform.position.x, posdispnm.transform.position.y+150,posdispnm.transform.position.z), Quaternion.identity);

            //break;
            }
            else 
            ngAPerson.text = "no encontramos a la persona";
        }
        for (int i = 0; i<nombres.Count; i++  )
        {
            print("nombres en lista " + nombres[i]); 
        }


/************************************************************
        stggAperson = _ScrRcbInf.stgNgAperson.ToString();
            foreach (_classContInf contacto in basecontactos.contactosinfo)
            {
                temper = contacto.gAnombre;
                if(temper.Contains(stggAperson) == true)
                {
                    ngAPerson.text = temper;
                    gacont = temper;
                    numcont = contacto.telef;
                    break;
                }
                else
                    ngAPerson.text = "no encontramos a la persona";
            }
***************************************************************/

/*
        //El nombre del colaborador gA
        stggAperson = _ScrRcbInf.stgNgAperson.ToString();
        foreach (_classContInf contacto in basecontactos.contactosinfo){
            string nom = contacto.gAnombre.ToString();
            if (nom.Contains(stggAperson)){
            nombres.Add(string.Format("{0}", nom));    
            }
        }
        for (int i = 0; i<nombres.Count; i++  )
        {
            print("nombres en lista " + nombres[i]); 
        }
*/

        yield return null;
    }
}
