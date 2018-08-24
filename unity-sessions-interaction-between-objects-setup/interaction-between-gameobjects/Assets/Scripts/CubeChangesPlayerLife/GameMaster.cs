using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesPlayerLife
{
	public class GameMaster : MonoBehaviour {
        
        public Player Sphere;
        // Use this for initialization

        void OnMouseDown()
        {
            Sphere.life--;
        }
    }
}
