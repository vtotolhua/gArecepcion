using UnityEngine;
using TMPro;

public class _scrDispNombres : MonoBehaviour
{
    /*************************************************************************************************/
    /*Esta clase nos permite mostrar los nombres que escribión el usuario*****************************/
    /*estos se muestran en la parte de la confirmación de los datos **********************************/
    /*************************************************************************************************/
    public TMP_Text nvisita, ngAPerson;
    private string stgvisita, stggAperson, temper;
    public _ScrBDCont basecontactos;
    public _classContInf listacont;
    
    void Start()
    {
        if (gameObject.tag == "visita") {
            stgvisita = _ScrRcbInf.stgNvisit.ToString();
            nvisita.text = stgvisita;
            //Debug.Log("verifv " + stgvisita);
        }

        if (gameObject.tag == "gAPerson") {
            stggAperson = _ScrRcbInf.stgNgAperson.ToString();
            int vez = 0;
            bool tiene;
            foreach (_classContInf contacto in basecontactos.contactosinfo)
            {
                temper = contacto.gAnombre;
                print("nombre ingresado " + stggAperson + " " + vez);
                print("nombre a comparar " + temper);
                if(temper.Contains(stggAperson) == true)
                {
                    ngAPerson.text = temper;
                    tiene = temper.Contains(stggAperson);
                    print(tiene);
                    break;
                }
                else
                    ngAPerson.text = "no encontramos a la persona";
                vez ++;
            }
            //ngAPerson.text = stggAperson;
            //stggAperson = basecontactos.contactosinfo[0].gAnombre.ToString();
            //foreach (_classContInf contacto in basecontactos.contactosinfo) {}
            //    ngAPerson.text = basecontactos.contactosinfo[0].gAnombre;
            //    print(basecontactos.contactosinfo[0].gAnombre);

            //stggAperson = _ScrRcbInf.stgNgAperson.ToString();
            //ngAPerson.text = stggAperson;
            //             Debug.Log("verifg " + stggAperson);
        }
    }
}
