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
    public GameObject panel1, panel2, txtnm;
    public string stgnumgApers, stgmsgtxt, URL;
    private TMP_InputField.SubmitEvent escMsg;
    public TMP_Text dspnm1, dspnom2;
    private string gAcolab;  

    //private _scrDispNombres dispnom;

    // Start is called before the first frame update
    void Start()
    {
        escMsg = new TMP_InputField.SubmitEvent();
        escMsg.AddListener(escrMsg);
        msgEnv.onEndEdit = escMsg;

        if (GameObject.FindWithTag("gAPerson") != null){
            gAcolab = _scrBtnCoinci.selnom;
            dspnm1.text = gAcolab;
            dspnom2.text = gAcolab;
        }
    }

    private void escrMsg(string msgtext) {
        stgmsgtxt = msgtext;
        stgnumgApers = _scrBtnCoinci.seltel;
        Debug.Log("Mensaje" + stgmsgtxt);
        Debug.Log("Numero" + stgnumgApers);
    }

    public void BtnEnvMsg() {
        URL = string.Format("sms:{0}?body={1}", stgnumgApers, System.Uri.EscapeDataString(stgmsgtxt));    
        panel1.SetActive(false);
        panel2.SetActive(true);
        LlamaSms();
    }

    private void LlamaSms() {
        Application.OpenURL(URL);
        return;
    }
}
