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
    public List<_classContInf> contCoincide = new List<_classContInf>(); 
    private GameObject dbcontact;
    public _classContInf listacont;


    private List<string> nombres = new List<string>();
    
    void Start()
    {
        if (gameObject.tag == "visita") {
            stgvisita = _ScrRcbInf.stgNvisit.ToString();
            nvisita.text = stgvisita;
            //Debug.Log("verifv " + stgvisita);
        }

        if (gameObject.tag == "gAPerson") {
            if (GameObject.FindWithTag("contactos")!=null){
                dbcontact = GameObject.FindWithTag("contactos");
                basecontactos = dbcontact.GetComponent<_ScrBDCont>();
//                print ("base cargada"); 
            }
            StartCoroutine ("displnom");
        }
    }

    IEnumerator displnom ()
    {
        //El nombre del colaborador gA
        stggAperson = _ScrRcbInf.stgNgAperson.ToString();
        //compara el nombre que introdujo el usuario para encontrar las coincidencias en la base de datos
        //por el momento hace una lista, lo ideal es hacer spawn del objeto que muestra los nombres. 
        foreach (_classContInf contacto in basecontactos.contactosinfo){
            temper = contacto.gAnombre;
            if (temper.Contains(stggAperson))
            {
            //creamos lista que tiene nombres parecidos
            contCoincide.Add(new _classContInf(contacto.gAnombre, contacto.telef,contacto.correo));
//            nombres.Add(string.Format("{0}", "{1}", temper, numcont));
            ngAPerson.text = temper;
            gacont = temper;
            numcont = contacto.telef; 
            //tomamos la información de nombre y teléfono de la base de datos
            //break;
            }
            else 
            ngAPerson.text = "no encontramos a la persona";
        }
        //imprimimos la lista de coincidencias. 
        foreach(_classContInf coincide in contCoincide){
            print("coincidencias " + coincide.gAnombre + " tel  " + coincide.telef + " mail " + coincide.correo ) ;
        }
/*        for (int i = 0; i<nombres.Count; i++  )
        {
            Console.WriteLine(nombres);
            print("nombres en lista " + nombres.ToString()); 
            
        }

        foreach(string coinci in nombres){
            print("nombres en lista2 " + nombres.ToString());
        }
*/
        yield return null;
    }
}
