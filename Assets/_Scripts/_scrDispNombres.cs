using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;

public class _scrDispNombres : MonoBehaviour
{
    /*************************************************************************************************/
    /*Esta clase hace una comparación de la BD de contactos********************************/
    /**con el nombre que escribe el usuario y guarda las coincidencias en una nueva lista*************/
    /*esta lista se va a usar para generar botones para la confirmación de los datos******************/
    /*************************************************************************************************/
    
    public _classContInf listacont;
    public List<_classContInf> contCoincide = new List<_classContInf>(); 
    private GameObject dbcontact; 
    [SerializeField] _ScrBDCont basecontactos;
    private string inptgAColabo, temper;
    
    void Start()
    {       
            if (GameObject.FindWithTag("contactos")!=null){
                dbcontact = GameObject.FindWithTag("contactos");
                basecontactos = dbcontact.GetComponent<_ScrBDCont>();
//                print ("base cargada"); 
            }
            StartCoroutine ("displnom");
    }

    IEnumerator displnom ()
    {
        //El input del nombre del colaborador gA por el usuario
        inptgAColabo = _ScrRcbInf.stgNgAperson.ToString();
        //compara el nombre que introdujo el usuario con la DB de contactos
        //para encontrar las coincidencias 
        //y hacer una lista de dichas. 
        foreach (_classContInf contacto in basecontactos.contactosinfo)
        {
            temper = contacto.gAnombre;
            if (temper.Contains(inptgAColabo))
            {
            contCoincide.Add(new _classContInf(contacto.nlinea, contacto.gAnombre, contacto.telef,contacto.correo));
            }
        }
        yield return null;
    }
}
