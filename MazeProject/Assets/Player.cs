using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float movementSpeed = 1;
    private int collectableCounter = 0;
    [SerializeField]  private TMPro.TextMeshProUGUI collectableText;
    [SerializeField]  private GameObject doorHinge;


    // Start is called before the first frame update
    void Start() 
    {
        collectableText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        Vector3 movemennt = new Vector3(0, 0, 0);

      
        transform.Translate(movemennt * Time.fixedDeltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        CollectableCube colisionCube = collision.gameObject.GetComponent<CollectableCube>();

        if (colisionCube) {
            Destroy(collision.gameObject);
            collectableCounter++;
            //Debug.Log(collectableCounter);

            collectableText.text = collectableCounter.ToString();
            if (collectableCounter == 10)
            {
                gameObject.SetActive(false);
            }
        }

        //Debug.Log("oriiiiiiii");

        


    }
}
