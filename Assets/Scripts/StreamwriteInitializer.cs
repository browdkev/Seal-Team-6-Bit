using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.IO;

public class StreamwriteInitializer : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        string fileLocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);

        StreamWriter createLogFileWriter = new StreamWriter(System.IO.Path.Combine(@fileLocation, "Seal Team 6-Bit Game Log.txt"), false);
        createLogFileWriter.Close();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
