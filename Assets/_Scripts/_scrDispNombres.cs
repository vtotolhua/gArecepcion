using UnityEngine;
using TMPro;
using System.Data;
using System.Collections.Generic;
public class _scrDispNombres : MonoBehaviour
{
<<<<<<< Updated upstream
    public TMP_Text nvisita, ngAPerson;
    private string stgvisita, stggAperson;

    // Start is called before the first frame update
=======
    /*************************************************************************************************/
    /*Esta clase nos permite mostrar los nombres que escribió el usuario*****************************/
    /*estos se muestran en la parte de la confirmación de los datos **********************************/
    /*************************************************************************************************/
    public  TMP_Text nvisita, ngAPerson;
    private string stgvisita, stggAperson, temper;
    public static string numcont, gacont;
    public _ScrBDCont basecontactos;
    public _classContInf listacont;
    
>>>>>>> Stashed changes
    void Start()
    {
        if (gameObject.tag == "visita") {
            stgvisita = _ScrRcbInf.stgNvisit.ToString();
            nvisita.text = stgvisita;
            Debug.Log("verifv " + stgvisita);
        }

        if (gameObject.tag == "gAPerson") {
            stggAperson = _ScrRcbInf.stgNgAperson.ToString();
            ngAPerson.text = stggAperson;
            Debug.Log("verifg " + stggAperson);
        }
        
        /*        stgvisita = _ScrRcbInf.stgNvisit;
                nvisita.text = stgvisita.ToString();
                stggAperson = _ScrRcbInf.stgNgAperson;
                ngAPerson.text = stggAperson.ToString();

        */


    }
}
