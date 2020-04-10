using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


/*****************************************************************************/
/************Este script lo que hace es cargar el archivo donde se tiene *****/
/************la DB de los contactos y crear una lista con los campos de*******/
/************linea, nombre, teléfono, email***********************************/
/************con la finalidad de accesarla dentro del proceso*****************/
/*****************************************************************************/
public class _ScrBDCont : MonoBehaviour
{
    private TextAsset filepath;
    public List<_classContInf> contactosinfo = new List<_classContInf>();
    void Awake()
    {
        llenadoLista();
    }
    private void llenadoLista()
    {
        //Cargamos la lista del path resources que nos permite guardar el archivo en la aplicación
        TextAsset filepath = Resources.Load<TextAsset>("liscont");
        //Dividimos cada línea con el ;
        string[] tomalineas = filepath.text.Split(';');
        //print (tomalineas[1]);
        //En esta parte tomamos cada linea, la dividimos en campos y hacemos la lista del tipo classConnInf 
        for (int i = 0; i < tomalineas.Length-1; i++)
        {
         //   print("linea " + i + " " + tomalineas[i]);
            string[] nomfile = tomalineas[i].Split(',');
            contactosinfo.Add(new _classContInf(nomfile[0], nomfile[1], nomfile[2], nomfile[3]));
         /*       foreach (string elem in nomfile )
                {
                    print("elemento de lista " + elem);
                }
        */
        }
/*        foreach (_classContInf contacto in contactosinfo)
        {
            print("Holos " + contacto.nlinea + " " + contacto.gAnombre + " " + contacto.telef + " " + contacto.correo);
        }
*/        

    }
}
