using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class StartGameButton : MonoBehaviour
    {
        
        public void HoverStart()
        {
            transform.localScale = Vector3.one * 1.1f;
        }
        public void HoverEnd()
        {
            transform.localScale = Vector3.one;
        }
        public void ClickStart()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.black;
        }
        public void ClickEnd()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.white;

        }

        public void Click()
        {
            SceneManager.LoadScene("GameScene");
        }
        
        
        
    }
}