using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager m_instance; // 싱글톤이 할당될 static 변수


    public static ResourceManager instance
    {
        get
        {
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_instance == null)
            {
                // 씬에서 GameManager 오브젝트를 찾아 할당
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // 싱글톤 오브젝트를 반환
            return m_instance;
        }
    }

    private static string zombieDataPath = default;
    public ZombieData zombieData_default = default;
    


    private void Awake()
    {
        //dataPath = Application.dataPath;
        //zombieDataPath = string.Format("{0}/{1}",Application.dataPath, "MyProject/Scriptable");

        //byte[] byteZombieData = File.ReadAllBytes(zombieDataPath + "/Zombie Data Default");

        zombieDataPath = "Scriptable";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");

        //ZombieData zombieData_ = Resources.Load<ZombieData>(zombieDataPath);
        zombieData_default = Resources.Load<ZombieData>(zombieDataPath);


        //Debug.LogFormat("Zombie Data Path : {0}", "/Zombie Data Default");
        //Debug.LogFormat("Zombie Data : {0} ,{1} ,{2}", zombieData_.health , zombieData_.damage , zombieData_.speed); 


        Debug.LogFormat("게임 Save Data 여기에다가 저장하는 것이 상식이다. -> {0}", Application.persistentDataPath);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
