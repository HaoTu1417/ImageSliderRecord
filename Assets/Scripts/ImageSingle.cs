using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSingle : MonoBehaviour
{
    [SerializeField] RawImage image;

    [SerializeField] private float maxHeight;
    [SerializeField] private float maxWidth;

    private void Start()
    {
       
        //Debug.Log("start: " + imageSize);
    }

    public void LoadTexture(Texture texture)
    {
        //Debug.Log("Loadtexutre: " + texture.height + " " + texture.width);

        Vector2 imageSize = image.GetComponent<RectTransform>().sizeDelta;
        maxHeight = imageSize.y;
        maxWidth = imageSize.x;
        image.texture = texture;
        image.SetNativeSize();


        if (texture.width > texture.height)
        {
            ScaleLanscapeImage(texture);
        }
        else
        {
            ScalePorTraitImage(texture);
        }
        

        

    }
    private void ScalePorTraitImage(Texture texture)
    {
        if (texture.height > maxHeight)
        {
            Vector2 newSize = new Vector2();
            newSize.y = maxHeight;
            newSize.x = maxHeight * texture.width / texture.height;
            image.rectTransform.sizeDelta = newSize;
        }
        Vector2 textureSize = image.rectTransform.sizeDelta;
        if (textureSize.x > maxWidth)
        {
            Vector2 newSize = new Vector2();
            newSize.x = maxWidth;
            newSize.y = maxWidth * textureSize.y / textureSize.x;
            image.rectTransform.sizeDelta = newSize;
        }
    }

    private void ScaleLanscapeImage(Texture texture)
    {
        if (texture.height > maxWidth)
        {
            Vector2 newSize = new Vector2();
            newSize.y = maxWidth;
            newSize.x = maxWidth * texture.width / texture.height ;
            image.rectTransform.sizeDelta = newSize;
        }
        //if (texture.width > maxHeight)
        //{
        //    Vector2 newSize = new Vector2();
        //    newSize.y = maxHeight;
        //    newSize.x = maxHeight * texture.width / texture.height;
        //    image.rectTransform.sizeDelta = newSize;
        //}
        image.GetComponent<RectTransform>().rotation = Quaternion.Euler(0,0,90);
    }
}
