using UnityEngine;

public class BakePerson : MonoBehaviour {
	public GameObject[] cpTarget;
	public SkinnedMeshRenderer[] skinnedMeshes;
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (skinnedMeshes.Length > 0) CopyHuman ();
			if (cpTarget.Length > 0) CopySword ();
			//Destroy(gameObject);
		}
	}

	public void CopyHuman () {
		for (int i = 0; i < skinnedMeshes.Length; i++) {
			Mesh staticMesh = new Mesh ();
			skinnedMeshes[i].BakeMesh (staticMesh);
			GameObject newGo = new GameObject ("Human_" + i);
			newGo.AddComponent<MeshFilter> ().sharedMesh = staticMesh;
			newGo.AddComponent<MeshRenderer> ().sharedMaterials = skinnedMeshes[i].sharedMaterials;
			newGo.transform.position = skinnedMeshes[i].transform.position;
			newGo.transform.rotation = skinnedMeshes[i].transform.rotation;
			Destroy (newGo, 6.0f);
		}
	}

	public void CopySword () {
		for (int i = 0; i < cpTarget.Length; i++) {
			GameObject newGo = new GameObject ("Sword_" + i);
			newGo.AddComponent<MeshFilter> ().sharedMesh = cpTarget[i].transform.GetComponent<MeshFilter> ().sharedMesh;
			newGo.AddComponent<MeshRenderer> ().sharedMaterials = cpTarget[i].transform.GetComponent<MeshRenderer> ().sharedMaterials;
			newGo.transform.position = cpTarget[i].transform.position;
			newGo.transform.rotation = cpTarget[i].transform.rotation;
			Destroy (newGo, 6.0f);
		}
	}
}
