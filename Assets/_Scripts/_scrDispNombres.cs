using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;

public class _scrDispNombres : MonoBehaviour
{
    /*************************************************************************************************/
    /*Esta clase hace una comparación de la base de datos de contactos*****************************/
    /* con el nombre que escribe el usuario y guarda las coincidencias en una nueva lista*********/
    /*estos se muestran en la parte de la confirmación de los datos **********************************/
    /*************************************************************************************************/
    private string stggAperson, temper;
    //Estas dos variables nos sirven para llenar los datos del script _scrEnvMsg
    public static string numcont, gacont;
    [SerializeField] _ScrBDCont basecontactos;
    public List<_classContInf> contCoincide = new List<_classContInf>(); 
    private GameObject dbcontact; 
    public _classContInf listacont;


    private List<string> nombres = new List<string>();
    
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
        //El nombre del colaborador gA
        stggAperson = _ScrRcbInf.stgNgAperson.ToString();
        //compara el nombre que introdujo el usuario para encontrar las coincidencias en la base de datos
        //por el momento hace una lista, lo ideal es hacer spawn del objeto que muestra los nombres. 
        foreach (_classContInf contacto in basecontactos.contactosinfo)
        {
            temper = contacto.gAnombre;
            if (temper.Contains(stggAperson))
            {
            //creamos lista que tiene nombres parecidos
            contCoincide.Add(new _classContInf(contacto.gAnombre, contacto.telef,contacto.correo));
//           ngAPerson.text = temper;   //nos sirve para poner el nombre en econtrado
//           gacont = temper;       //no sive para llenar datos en el mensaje a enviar 
//           numcont = contacto.telef;   //obtenemos el teléfono de la persona a la que se envía el mensaje
//           break;
            }
        }
        yield return null;
    }
}
