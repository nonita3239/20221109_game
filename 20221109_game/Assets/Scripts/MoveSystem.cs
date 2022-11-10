using UnityEngine;

namespace ZY
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField,Header("���ʳt��"),Range(-10,0)]
         private float speed = -3.5f;

        private void Update()
        {
            //transform ��������Transform����
            //Translate(x,y,z)�첾
            transform.Translate(speed*Time.deltaTime, 0, 0);
        }
    }
}
