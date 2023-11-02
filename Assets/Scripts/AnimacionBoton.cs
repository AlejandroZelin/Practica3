using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionBoton : MonoBehaviour
{
    public GameObject Boton;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(Boton, new Vector3(3, 3, 1), 1).setEaseInOutElastic().setLoopPingPong(1);
    }

}
