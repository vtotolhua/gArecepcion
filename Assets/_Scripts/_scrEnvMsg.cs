using UnityEngine;
using TMPro;

public class _scrEnvMsg : MonoBehaviour
{
    /***************************************************************************************/
    /******Esta clase toma el mensaje que escribe el visitante *****************************/
    /******y envía el mensaje al colaborador de gA******************************************/
    /***************************************************************************************/
    public TMP_InputField msgEnv;
    //public TMP_Text usuario1, usuario2;
<<<<<<< Updated upstream
    public GameObject panel1, panel2;
    public string stgnumgApers, stgmsgtxt, stgcorreogApers , URL;
=======
    public GameObject panel1, panel2, txtnm;
    public string stgnumgApers, URL;
    public static string stgmsgtxt;
>>>>>>> Stashed changes
    private TMP_InputField.SubmitEvent escMsg;
    //private _scrDispNombres dispnom;

    // Start is called before the first frame update
    void Start()
    {
        //stgnumgApers = "0";
        //msgEnv = panel1.GetComponent<TMP_InputField>();
        //usuario1.text = _scrDispNombres.gacont;
        //usuario2.text = _scrDispNombres.gacont;
        escMsg = new TMP_InputField.SubmitEvent();
        escMsg.AddListener(escrMsg);
        msgEnv.onEndEdit = escMsg;
    }

    private void escrMsg(string msgtext) {
        stgmsgtxt = msgtext;
<<<<<<< Updated upstream
        stgnumgApers = _scrNomgAperson.numcont;
        stgcorreogApers = _scrNomgAperson.correo;
        Debug.Log("Mensaje" + stgmsgtxt);
        Debug.Log("Numero" + stgnumgApers);
        Debug.Log("correo" + stgcorreogApers);
=======
        //stgnumgApers = _scrBtnCoinci.seltel;
        //Debug.Log("Mensaje" + stgmsgtxt);
        //Debug.Log("Numero" + stgnumgApers);
>>>>>>> Stashed changes
    }

    public void BtnEnvMsg() {
        //URL = string.Format("sms:{0}?body={1}", stgnumgApers, System.Uri.EscapeDataString(stgmsgtxt));    
        panel1.SetActive(false);
        panel2.SetActive(true);
        //LlamaSms();
    }

    private void LlamaSms() {
        Application.OpenURL(URL);
        return;
    }
}
