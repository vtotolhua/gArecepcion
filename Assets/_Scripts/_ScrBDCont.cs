using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
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
        //print ("lista de contactos");
        TextAsset filepath = Resources.Load<TextAsset>("liscont");
        string[] tomalineas = filepath.text.Split(';');
        //print (tomalineas[1]);
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
        foreach (_classContInf contacto in contactosinfo)
        {
            print("Holos " + contacto.nlinea + " " + contacto.gAnombre + " " + contacto.telef + " " + contacto.correo);
        }
        

    }
}
