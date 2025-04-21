using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class NewMonoBehaviourScript : MonoBehaviour
{
    // declaracion de variable pra selccionar
    public Transform target;
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //primer parametro el objetivo que va a girar ejemplo si la luna va girar debo darle el objetivo tierra entonces girara alrededor de ella y el posicinamiento sera la tierra, el segundo es como debe girar en eje x o y
        //rotar alrededor necesita un segundo parametro sobre el eje de rotacion 
        //tercer parametro velocidad de rotacion
        transform.RotateAround(target.transform.position,target.transform.up,speed * Time.deltaTime);
    }
}
