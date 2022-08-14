using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creater : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector2 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateExercise()
    {
        // crearte inside parent object of this gameObject
        GameObject exersizeGO = Instantiate(prefab, spawnPosition, Quaternion.identity) as GameObject;
        exersizeGO.transform.SetParent(this.transform);
        //exersizeGO.transform.setParent(this.transform.parent);


        //Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
