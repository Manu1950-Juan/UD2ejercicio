using UnityEngine;

public class ClonEgg : MonoBehaviour
{
    // Prefab del huevo que se va a instanciar
    [SerializeField] 
    private GameObject _egg;

    // Punto desde donde se genera el huevo (dentro del conejo)
    [SerializeField]
    private Transform _postRotBunny;

    [SerializeField]
    private  float _thrustY;
    [SerializeField]
    private float _thrustZ;
    [SerializeField]
    private float _timeDestroy;


    void Update()
    {
        CreateEgg(); // Generar el huevo
    }

    // Comprueba si se pulsa la barra espaciadora y genera el huevo
    private void CreateEgg()
    {
        if
           (Input.GetMouseButtonDown(0))
        {
            
            GameObject clonEgg = Instantiate(_egg, _postRotBunny.position, _postRotBunny.rotation);

            // Mensaje de Huevo 
            Debug.Log("Huevo instanciado");
            Rigidbody rbEgg= clonEgg.GetComponent<Rigidbody>();
            Destroy(clonEgg, _timeDestroy);

            //Fuerza arriba
            rbEgg.AddForce(Vector3.up * _thrustY);
            //Fuerza hacia adelante
            rbEgg.AddForce(transform.forward * _thrustZ);

        }
    }
}
