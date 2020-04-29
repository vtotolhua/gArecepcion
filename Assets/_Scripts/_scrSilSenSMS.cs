using UnityEngine;
using TMPro;
public class _scrSilSenSMS : MonoBehaviour
{
    AndroidJavaObject currentActivity;
    private string phone, texts;
    public void Send(string phone)
    {
        print("envio mensaje android");

//        phone = _scrBtnCoinci.seltel;
//        texts = _scrEnvMsg.stgmsgtxt;
//        print("phone " + phone);
//        print ("mensaje " + texts);

        if (Application.platform == RuntimePlatform.Android)
        {
            RunAndroidUiThread();
        }
    }

    void RunAndroidUiThread()
    {
        AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.gA.Receptrion.UnityPlayer");
        currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(SendProcess));
    }

    void SendProcess()
    {
        Debug.Log("Running on UI thread");
        AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
        
        // SMS Information
        string phone = _scrBtnCoinci.seltel;
        string text = _scrEnvMsg.stgmsgtxt;
        //string phone = "5620349501";
        //string text = "Hello World. This SMS is sent using Android SMS Manager.";
        string alert;

        try
        {
            // SMS Manager

            AndroidJavaClass SMSManagerClass = new AndroidJavaClass("android.telephony.SmsManager");
            AndroidJavaObject SMSManagerObject = SMSManagerClass.CallStatic<AndroidJavaObject>("getDefault");
            SMSManagerObject.Call("sendTextMessage", phone, null, texts, null, null);

            alert = "Message sent successfully.";
        }
        catch (System.Exception e)
        {
            Debug.Log("Error : " + e.StackTrace.ToString());

            alert = "Error has been Occurred. Fail to send message.";
        }

        // Show Toast

        AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
        AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", alert);
        AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));
        toast.Call("show");
    }
}