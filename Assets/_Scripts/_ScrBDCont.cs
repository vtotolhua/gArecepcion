
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class _ScrBDCont : MonoBehaviour
{
    private TextAsset filepath;
    public List<_classContInf> contactosinfo = new List<_classContInf>();
    void Start()
    {
        llenadoLista();
    }
    private void llenadoLista()
    {
        TextAsset filepath = Resources.Load<TextAsset>("liscont");
        string[] tomalineas = filepath.text.Split(';');
        for (int i = 0; i < tomalineas.Length-1; i++)
        {
            print("linea " + i + " " + tomalineas[i]);
            string[] nomfile = tomalineas[i].Split(',');
            contactosinfo.Add(new _classContInf(nomfile[0], nomfile[1], nomfile[2]));
                foreach (string elem in nomfile )
                {
                    print("elemento de lista " + elem);
                }
        }
        foreach (_classContInf contacto in contactosinfo)
        {
            print("Holos " + contacto.gAnombre + " " + contacto.telef + " " + contacto.correo);
        }
    }
}
