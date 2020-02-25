using UnityEngine;
using TMPro;

public class _scrDispNombres : MonoBehaviour
{
    public TMP_Text nvisita, ngAPerson;
    private string stgvisita, stggAperson;

    // Start is called before the first frame update
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
