using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class _scrNomgAperson : MonoBehaviour
{
    public  TMP_Text ngAPerson;
    public static string nomconta, numcont, correo;
    private string stggAperson, temper;
    private GameObject gaperstx, goContConinc;
    private Transform gaperspos;
    [SerializeField] _scrDispNombres datoamuestra;
    public _classContInf listacont;
    void Start()
    {
/*        if (GameObject.FindWithTag("gAPerson") != null)
        {
            gaperstx = GameObject.FindWithTag("gAPerson");
            gaperspos = gaperstx.transform;    
        }
*/        
        if (GameObject.FindWithTag("contCoinci") != null)
        {
        print("encontré DBCon ");
        goContConinc= GameObject.FindWithTag("contCoinci");
        datoamuestra = goContConinc.GetComponent<_scrDispNombres>();
        print("encontré DBCon ");

        }
        else 
        {print("NO encontré DBCon ");}

        muestracoinci();
    }

    public void muestracoinci (){
        print("muestra coincidencias entro");
/*        for (int i = 1; i<=datoamuestra.contCoincide.Count; i++ ){
            print("muestra coincidencias ");
//           ngAPerson.text = datoamuestra.contCoincide ;
            nomconta = datoamuestra.contCoincide[i].gAnombre;
            numcont = datoamuestra.contCoincide[i].telef;
            correo = datoamuestra.contCoincide[i].correo;
            print("coincidencia p " + ngAPerson.ToString() + " numtel " + numcont.ToString() + "correo" + correo.ToString());
*/

        foreach (_classContInf conta in datoamuestra.contCoincide){
            //print("coincidencias " + conta.gAnombre + " tel  " + conta.telef + " mail " + conta.correo ) ;
            print("muestra coincidencias ");
            ngAPerson.text = conta.gAnombre;
            nomconta = conta.gAnombre;
            numcont = conta.telef;
            correo = conta.correo;
            print("coincidencia p " + ngAPerson.ToString() + " numtel " + conta.telef.ToString() + "correo" + correo );
            //Instantiate(gaperstx, new Vector3(gaperspos.transform.position.x, gaperspos.transform.position.y + 80, gaperspos.transform.position.z), Quaternion.identity);
        }
    }
}
