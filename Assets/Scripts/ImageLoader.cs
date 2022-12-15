using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ImageLoader : MonoBehaviour
{
    [SerializeField] ImageSingle imageSinglePrefab;
    [SerializeField] int maxImageToLoad;

    private string rootFolderPath = @"C:\Users\HaoTu\Documents\UnityDemo\Assets\Images";
    // Start is called before the first frame update
    void Start()
    {
        DirectoryInfo d = new DirectoryInfo(rootFolderPath); //Assuming Test is your Folder

        FileInfo[] Files = d.GetFiles(); //Getting Text files
        string str = "";
        int index = 0;
        foreach (FileInfo file in Files)
        {
            if (file.Name.ToLower().Contains(".meta"))
            {
                continue;
            }
            index += 1;
            if (index > maxImageToLoad)
            {
                break;
            }

            ImageSingle imageSingle = Instantiate(imageSinglePrefab, transform);
            Texture2D tex = LoadTexture(Path.Combine(rootFolderPath, file.Name));
            imageSingle.LoadTexture(tex);
        }

        //
    }
    private Texture2D LoadTexture(string fileName)
    {
        //string filename = "Assets/Resources/Heightmaps/filename.png";
        var rawData = System.IO.File.ReadAllBytes(fileName);
        Texture2D tex = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter (she said)
        tex.LoadImage(rawData);
        return tex;
    }
}
