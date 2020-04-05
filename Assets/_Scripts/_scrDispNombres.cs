using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;
public class _scrDispNombres : MonoBehaviour
{
<<<<<<< Updated upstream
    /*************************************************************************************************/
    /*Esta clase nos permite mostrar los nombres que escribión el usuario*****************************/
    /*estos se muestran en la parte de la confirmación de los datos **********************************/
    /*************************************************************************************************/
<<<<<<< Updated upstream
    public  TMP_Text nvisita, ngAPerson;
    private string stgvisita, stggAperson, temper;
    public static string numcont, gacont;
    public _ScrBDCont basecontactos;
=======
    private string stggAperson, temper;
    //Estas dos variables nos sirven para llenar los datos del script _scrEnvMsg
    //public static string numcont, gacont;
    [SerializeField] _ScrBDCont basecontactos;
    public List<_classContInf> contCoincide = new List<_classContInf>(); 
    private GameObject dbcontact; 
>>>>>>> Stashed changes
    public _classContInf listacont;

    private List<string> nombres = new List<string>();
    
<<<<<<< Updated upstream
    void Start()
    {
        if (gameObject.tag == "visita") {
            stgvisita = _ScrRcbInf.stgNvisit.ToString();
            nvisita.text = stgvisita;
            //Debug.Log("verifv " + stgvisita);
        }

        if (gameObject.tag == "gAPerson") {
=======
    void Awake()
    {       
            if (GameObject.FindWithTag("contactos")!=null){
                dbcontact = GameObject.FindWithTag("contactos");
                basecontactos = dbcontact.GetComponent<_ScrBDCont>();
//                print ("base cargada"); 
            }
>>>>>>> Stashed changes
            StartCoroutine ("displnom");
        }
    }

    IEnumerator displnom ()
    {

        //El nombre del colaborador gA
        stggAperson = _ScrRcbInf.stgNgAperson.ToString();
        foreach (_classContInf contacto in basecontactos.contactosinfo){
            temper = contacto.gAnombre;
            if (temper.Contains(stggAperson))
            {
            //creamos lista que tiene nombres parecidos
            nombres.Add(string.Format("{0}", temper)); 
            //llenamos la lista con la clase que definimos
            ngAPerson.text = temper;
            gacont = temper;
            numcont = contacto.telef;
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
=======
    /*************************************************************************************************/
    /*Esta clase nos permite mostrar los nombres que escribión el usuario*****************************/
    /*estos se muestran en la parte de la confirmación de los datos **********************************/
    /*************************************************************************************************/
    public  TMP_Text nvisita, ngAPerson;
    private string stgvisita, stggAperson, temper;
    public static string numcont, gacont;
    public _ScrBDCont basecontactos;
    public _classContInf listacont;
    private List<string> nombres = new List<string>();
    
    void Start()
    {
        if (gameObject.tag == "visita") {
            stgvisita = _ScrRcbInf.stgNvisit.ToString();
            nvisita.text = stgvisita;
            //Debug.Log("verifv " + stgvisita);
        }
        if (gameObject.tag == "gAPerson") {
            StartCoroutine ("displnom");
        }
    }
    IEnumerator displnom ()
    {
        //El nombre del colaborador gA
        print ("hola");
        stggAperson = _ScrRcbInf.stgNgAperson.ToString();
        foreach (_classContInf contacto in basecontactos.contactosinfo){
            temper = contacto.gAnombre;
            if (temper.Contains(stggAperson))
            {
            //creamos lista que tiene nombres parecidos
            nombres.Add(string.Format("{0}", temper)); 
            //llenamos la lista con la clase que definimos
            ngAPerson.text = temper;
            gacont = temper;
            numcont = contacto.telef;
            //break;
            }
            else 
            ngAPerson.text = "no encontramos a la persona";
        }
        for (int i = 0; i<nombres.Count; i++  )
        {
            print("nombres en lista " + nombres[i]); 
        }
        yield return null;
    }
}
>>>>>>> Stashed changes
