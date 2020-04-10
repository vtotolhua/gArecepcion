using UnityEngine;
using UnityEngine.SceneManagement;
public class _scrBtnBnvnd : MonoBehaviour
{
    public void Inicio()
    {
        SceneManager.LoadScene("1_Entrada");
    }
    public void Personal() {
        SceneManager.LoadScene("2_Personal");
    }
    public void Loby() {
        SceneManager.LoadScene("3_Loby");
    }
    public void Espera() {
        SceneManager.LoadScene("4_Espera");
    }
    public void Salir(){
        Application.Quit();
    }
}