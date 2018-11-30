using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using VoxelBusters.NativePlugins;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void ShowMessage()
    {
        NPBinding.UI.ShowToast("This is a sample message.", eToastMessageLength.SHORT);
    }

    public void ShowAd()
    {
        Advertisement.Show();
    }
}
