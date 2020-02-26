using UnityEngine;
using TMPro;
using System.IO;
using System.Collections.Generic;
using System.Collections;

public class _ScrRcbInf : MonoBehaviour
{
    public TMP_InputField nvisit, ngAperson;
    private TMP_InputField.SubmitEvent escribe1, escribe2;
    public static string stgNvisit, stgNgAperson;
    private string filepath = "Assets/_Contactos/listacontactos.txt";
    
    private void Start()
    {
        llenadoLista();

        if (gameObject.tag == "visita") {
            nvisit = this.gameObject.GetComponent<TMP_InputField>();
            escribe1 = new TMP_InputField.SubmitEvent();
            escribe1.AddListener(EnvInfvisit);
            nvisit.onEndEdit = escribe1;
        }

        if (gameObject.tag == "gAPerson")
        {
            ngAperson = this.gameObject.GetComponent<TMP_InputField>();
            escribe2 = new TMP_InputField.SubmitEvent();
            escribe2.AddListener(EnvInfgAper);
            ngAperson.onEndEdit = escribe2;
        }
    }

    private void EnvInfvisit(string nombre1) {
        stgNvisit = nombre1.ToLower();
    }

    private void EnvInfgAper(string nombre2)
    {
        nombre2 = nombre2.ToLower();
        stgNgAperson = nombre2;
        Debug.Log("nombre gA " + nombre2);
    }

    private void llenadoLista() {
        string[] tomalineas = File.ReadAllLines(filepath);
        List<_classContInf> contactosinfo = new List<_classContInf>();
        for (int i = 0; i < tomalineas.Length; i++)
        {
            string[] nomfile = tomalineas[i].Split(',');
            contactosinfo.Add(new _classContInf(nomfile[0], nomfile[1], nomfile[2]));
        }

        print("numero de filas" + contactosinfo.Count);
        foreach (_classContInf contacto in contactosinfo) {
            print(contacto.gAnombre + " " + contacto.telef + " " + contacto.correo );
        }
    }
}
