using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alta
{
    public class FirstScript : MonoBehaviour
    {
        [SerializeField] private string name = "Hao";

        public Transform go;
        public Transform targetA;
        public Transform targetB;


        private string name2 = "Hao";

        private List<string> abc;

        public GameObject goPf;

        // Start is called before the first frame update
        void Start()
        {
            //StartCoroutine( DoSomeThing());
            //Debug.Log("Do something 2");

        }
        IEnumerator DoSomeThing()
        {
            Debug.Log("DO something");
            yield return new WaitForSeconds(5f);
            Debug.Log("time out");
        }
        float timer = 0;
        // Update is called once per frame
        void Update()
        {
            //Debug.Log(Mathf.Lerp(0,100,0.2f));
            timer += Time.deltaTime / 50f;

            //go.position = Vector3.Lerp(targetA.position, targetB.position, timer);
            go.position = Vector3.Lerp(go.position, targetB.position, timer);

            
        }
    }

}