using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DeleteMapTMP : MonoBehaviour {
	
	public void deleteMap () {
        File.Delete("Maps/" + ".tmp" + ".map");
    }
}
