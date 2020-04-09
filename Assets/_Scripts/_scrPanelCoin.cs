using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class _scrPanelCoin : MonoBehaviour
{
    private GameObject goContCoin, panel;  // goContCoin objeto con BD coinciden    //panel espacio a instanciar los objetos
    //private TextMeshProUGUI tmpganombre;
    public GameObject dispContacto;  //objeto a instanciar
    [SerializeField] _scrDispNombres baseCoincidencias;   // script donde están las coincidencias
    public _classContInf listacoinc; //clase que tiene el formato de la tabla  
    public static string nlinea, ganombre, gatelefono, gamail; //variables que guardan los valores de cada fila de coincidencia
    //[SerializeField] TMP_Text ganombrepro;
    private Transform transpanelparent;  //transform del panel para que el objeto a instanciar se genere aquí
    //public  TMP_Text ngAPerson;
    void Start()
    {

        //tomamos el transform del panel donde se instancian las coincidencias
        panel = this.gameObject;
        transpanelparent = panel.transform;

        //Buscamos el Game Object que tiene el script y la BD de las coincidencias
        //guardamos el tanto el objeto como el script en variables internas para facilitar uso
        //Inicio la corrutina de generar las coincidencias 
        if (GameObject.FindWithTag("contCoinci") != null)
        {
            goContCoin = GameObject.FindWithTag("contCoinci");
            baseCoincidencias = goContCoin.GetComponent<_scrDispNombres>();
            StartCoroutine("spawnCoincidencias");
        }
    }

    // Iniciamos la corrutina que busca las coincidencias en la BD de coincidencias 
    //y guarda el nombre, correo y teléfono en una variable pública 
    //instancia un objeto tipo con los datos de la coincidencia y lo despliega dentro del panel
    IEnumerator spawnCoincidencias ()
    {
        foreach (_classContInf coincidencia in baseCoincidencias.contCoincide)
        {
            nlinea = coincidencia.nlinea;
            ganombre = coincidencia.gAnombre;
            gatelefono = coincidencia.telef;
            gamail = coincidencia.correo;
//          ganombrepro.text = ganombre;

            print("las coincidencias son " + "linea " + nlinea  + "nombre "+ ganombre + " telefono " + gatelefono + " mail " + gamail);
            GameObject dipnomcoin = Instantiate(dispContacto, panel.transform.position, panel.transform.rotation) as GameObject;
            dipnomcoin.transform.SetParent(transpanelparent);
            dipnomcoin.GetComponentInChildren<TMP_Text>().text = ganombre;
        }
        yield return null;
    }
}
