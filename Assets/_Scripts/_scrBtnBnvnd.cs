using UnityEngine;
using UnityEngine.SceneManagement;

public class _scrBtnBnvnd : MonoBehaviour
{
    /*************************************************************************************/
    /*****Esta clase controla la navegación entre las escenas*****************************/
    /*************************************************************************************/
    public void Inicio()
    {
        SceneManager.LoadScene(0);
    }
    public void Personal() {
        SceneManager.LoadScene(1);
    }
    public void Entrevista()
    {
        SceneManager.LoadScene(2);
    }
    public void Reunion()
    {
        SceneManager.LoadScene(3);
    }
    public void Sigui1() {
        SceneManager.LoadScene(4);
    }
    public void Sigui2() {
        SceneManager.LoadScene(5);
    }
}
