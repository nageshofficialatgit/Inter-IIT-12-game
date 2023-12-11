using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private int _width,_height;
    [SerializeField] private tile _tileprefab;
    [SerializeField] private Transform _cam;

    void Start(){

        generate();
    }

   void generate(){

    for(int x=0;x<_width;x++){
        for(int y=0;y<_height;y++){

            var spawnTile= Instantiate(_tileprefab,new Vector2(x,y),Quaternion.identity);
            spawnTile.count=Random.Range(0,10);
        }
    }

    _cam.transform.position= new Vector3((float)_width/2 -0.5f,(float)_height/2-0.5f,-10);


   }

}
