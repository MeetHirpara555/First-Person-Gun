using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiegen : MonoBehaviour
{
    public GameObject zomibeprefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generatezombie", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void generatezombie()
    {
        float xpos = Random.Range(450f, 600f);
        float zpos = Random.Range(0, 60f);
        Instantiate(zomibeprefab, new Vector3(xpos,transform.position.y,zpos), Quaternion.identity);
    }
}
