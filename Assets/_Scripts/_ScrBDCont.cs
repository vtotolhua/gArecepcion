using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class _ScrBDCont : MonoBehaviour
{
    private string filepath = "Assets/_Contactos/listacontactos.txt";
    public List<_classContInf> contactosinfo = new List<_classContInf>();

    // Start is called before the first frame update
    void Start()
    {
        llenadoLista();    
    }

    private void llenadoLista()
    {
        string[] tomalineas = File.ReadAllLines(filepath);

        for (int i = 0; i < tomalineas.Length; i++)
        {
            string[] nomfile = tomalineas[i].Split(',');
            contactosinfo.Add(new _classContInf(nomfile[0], nomfile[1], nomfile[2]));
        }
        foreach (_classContInf contacto in contactosinfo)
        {
            print(contacto.gAnombre + " " + contacto.telef + " " + contacto.correo);
        }
    }
}
