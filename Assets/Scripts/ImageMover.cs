using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMover : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.localPosition -= speed * Time.deltaTime * Vector3.right;
    }
}
