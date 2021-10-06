using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.0f;

    [SerializeField]
    private Transform trans = null;

    [SerializeField]
    private Contenedor contenedor = null;

    /*[SerializeField]
    private Rigidbody rB = null;*/

    [SerializeField]
    private GameObject _go = null;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_go, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        trans.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
    }
}

[System.Serializable]
public class Contenedor
{
    [SerializeField]
    private float altura = 0.0f;
    [SerializeField]
    private float anchura = 0.0f;
    [SerializeField]
    private float profundidad = 0.0f;

}
