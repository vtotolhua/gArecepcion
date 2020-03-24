using UnityEngine;
using UnityEngine.SceneManagement;

public class _scrBtnBnvnd : MonoBehaviour
{
    public void Inicio()
    {
        SceneManager.LoadScene("Entrada");
    }
    public void Personal() {
        SceneManager.LoadScene("Personal");
    }
    public void Loby() {
        SceneManager.LoadScene("Loby");
    }
    public void Espera() {
        SceneManager.LoadScene("Espera");
    }
    /*    public void Entrevista()
    {
        SceneManager.LoadScene(2);
    }
    public void Reunion()
    {
        SceneManager.LoadScene(3);
    }
*/
}
