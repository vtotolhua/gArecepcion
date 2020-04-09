using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _classContInf
{
    /********************************************************************************************************/
    /*Hicimos esta clase pública para que podamos crear una lista de esta clase.*****************************/
    /*Crear la lista de la clase permite guardar información la información del txt de cada persona de gA ***/
    /*en una sola línea y tenemos entonces el nombre, el teléfono y el correo accesible en un arreglo lista */
    /********************************************************************************************************/
    public string gAnombre;
    public string telef;
    public string correo;

    public string nlinea;

    public _classContInf(string nlineaNue,
                        string gANombNue,
                        string telNue,
                        string corrNue) 
    {
        nlinea = nlineaNue;
        gAnombre = gANombNue;
        telef = telNue;
        correo = corrNue;

    }
}
