using UnityEngine;
using TMPro;

public class _scrEnvMsg : MonoBehaviour
{
    public TMP_InputField msgEnv;
    public GameObject panel1, panel2;
    public string stgnumgApers, stgmsgtxt, URL;
    private TMP_InputField.SubmitEvent escMsg;
    // Start is called before the first frame update
    void Start()
    {
        stgnumgApers = "5531113583";
        //msgEnv = panel1.GetComponent<TMP_InputField>();
        escMsg = new TMP_InputField.SubmitEvent();
        escMsg.AddListener(escrMsg);
        msgEnv.onEndEdit = escMsg;
    }

    private void escrMsg(string msgtext) {
        stgmsgtxt = msgtext;
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
