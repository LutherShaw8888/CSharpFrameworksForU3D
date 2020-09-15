using UnityEngine;
using System.Collections;
using System;
using System.Windows.Forms;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;



public class OpenUrl : MonoBehaviour
{
    MeshFilter meshFilter;

    void Start()
    {
        meshFilter = transform.GetComponent<MeshFilter>();
    }

    public static void OpenFiles(ref string itemPath)
    {
        // if (string.IsNullOrEmpty(itemPath)) return;
        // itemPath = itemPath.Replace("/", "\\");
        // if (!Directory.Exists(itemPath))
        // {
        // 	UnityEngine.Debug.LogWarning("空值："+itemPath);
        // 	return;
        // }
        // Process.Start("explorer.exe", itemPath);
        // UnityEngine.Debug.LogWarning(itemPath);

        // meshFilter.sharedMesh = GameObject.Find("D:\\Documents\\121\\base.obj").transform.GetComponent<MeshFilter>().sharedMesh;	
    }

    public void Open()
    {


        OpenFileDialog od = new OpenFileDialog();
        od.Title = "请选择头像图片";
        od.Multiselect = false;
        // od.Filter = "图片文件(*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp";
        od.Filter = "文件(*.obj)|*.obj";
        if (od.ShowDialog() == DialogResult.OK)
        {
            // Debug.Log(od.FileName);
            StartCoroutine(GetTexture(od.FileName));
        }


    }
    IEnumerator GetTexture(string url)
    {
        WWW www = new WWW(url);
        yield return www;
        if (www.isDone && www.error == null)
        {
            Mesh meshHolder = new Mesh();
            ObjImporter newMesh = new ObjImporter();
            // meshHolder = newMesh.ImportFile("C:\\Users\\DragonShaw\\Desktop\\base.obj");
            meshHolder = newMesh.ImportFile(url);
            meshFilter.sharedMesh = meshHolder;

            // meshFilter.sharedMesh = transform.GetComponent<MeshFilter>().sharedMesh;
        }
    }

}
