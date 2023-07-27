using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager m_instance; // �̱����� �Ҵ�� static ����


    public static ResourceManager instance
    {
        get
        {
            // ���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if (m_instance == null)
            {
                // ������ GameManager ������Ʈ�� ã�� �Ҵ�
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // �̱��� ������Ʈ�� ��ȯ
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


        Debug.LogFormat("���� Save Data ���⿡�ٰ� �����ϴ� ���� ����̴�. -> {0}", Application.persistentDataPath);
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
