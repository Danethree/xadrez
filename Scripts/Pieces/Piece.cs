using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public abstract  class Piece : MonoBehaviour
    {
        public Tile tile;
       
        
         void Awake()
         {
             Debug.Log("Adicionando peças");
            Invoke("InvokePieces",4f*Time.deltaTime);
             
         }
         
         void InvokePieces()
         {
            
             if (Board.instance.isLoaded)
             {
                 Board.instance.AddPiece(transform.parent.name, this);
             }
         }
    }

