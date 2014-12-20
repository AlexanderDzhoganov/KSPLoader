using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace PatchLib
{
    [System.Serializable]
    public class WheelPatched : IConfigNode
    {
	    public string wheelName;
	    public string wheelColliderName;
	    public string suspensionTransformName;
	    public Transform suspensionNeutralPoint;
	    public string suspensionNeutralPointName;
	    public string damagedObjectName;
	    public Transform damagedObject;
	    public List<Transform> wheelTransforms;
	    public Transform suspensionTransform;
	    public Transform colliderTransform;
	    public WheelCollider whCollider;
	    public float rotateX;
	    public float rotateY;
	    public float rotateZ;
	    public Vector3 wheelAxis;
	    public RaycastHit hit;
	    public bool isValid;
	    public bool damageAble;
	    public bool debug;
	    private int layerMask;
	    private WheelHit wheelHit;
	    public float rescaleFactor = 1.25f;

        public WheelPatched()
	    {
		    rotateX = 0f;
		    rotateY = 0f;
		    rotateZ = 0f;
		    wheelTransforms = new List<Transform>();
		    layerMask = 622593;
	    }

	    public void Update()
	    {
		    if (isValid)
		    {
			    Vector3 position = suspensionNeutralPoint.position;

			    if (Physics.Raycast(position, suspensionNeutralPoint.up * -1f, out hit, (whCollider.suspensionDistance + whCollider.radius) * rescaleFactor, layerMask))
			    {
				    suspensionTransform.position = hit.point + suspensionNeutralPoint.up * whCollider.radius * rescaleFactor;
			    }
			    else
			    {
				    suspensionTransform.position = position - suspensionNeutralPoint.up * (whCollider.suspensionDistance * rescaleFactor);
			    }

			    Vector3 eulerAngles = wheelAxis * (whCollider.rpm / 60f * 360f) * TimeWarp.deltaTime;

		        foreach (var transform in wheelTransforms)
		        {
		            transform.Rotate(eulerAngles);
		        }
		    }
	    }

        public void Load(ConfigNode node)
	    {
            wheelName = node.GetValue("wheelName");
		    wheelColliderName = node.GetValue("wheelColliderName");
		    suspensionTransformName = node.GetValue("suspensionTransformName");
		    suspensionNeutralPointName = node.GetValue("suspensionNeutralPointName");
            damagedObjectName = node.GetValue("damagedObjectName");

	    }

	    public void Save(ConfigNode node)
	    {
	    }

	    public void damageWheel()
	    {
		    if (damagedObject != null)
		    {
			    damagedObject.gameObject.SetActive(true);

		        foreach (var transform in wheelTransforms)
		        {
		            transform.gameObject.SetActive(false);
		        }
             
			    if (colliderTransform != null)
			    {
				    colliderTransform.gameObject.SetActive(false);
			    }
		    }
	    }
	    public void repairWheel()
	    {
		    if (damagedObject != null)
		    {
			    damagedObject.gameObject.SetActive(false);

		        foreach (var transform in wheelTransforms)
		        {
		            transform.gameObject.SetActive(true);
		        }

                if (colliderTransform != null)
			    {
				    colliderTransform.gameObject.SetActive(true);
			    }
		    }
	    }
    }

}
