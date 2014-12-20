using System.Collections.Generic;
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
            MonoBehaviour.print("############ WHEEL INITIALIZED ################");
        }

	    public void Update()
	    {
            MonoBehaviour.print("############ WHEEL UPDATE ################");

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
		  /*  this.wheelName = node.GetValue(.(134457));
		    this.wheelColliderName = node.GetValue(.(134476));
		    this.suspensionTransformName = node.GetValue(.(134511));
		    this.suspensionNeutralPointName = node.GetValue(.(134558));
		    this.damagedObjectName = node.GetValue(.(134611));

		    if (node.HasValue(.(134646)))
		    {
			    while (true)
			    {
				    switch (4)
				    {
				    case 0:
					    continue;
				    }
				    break;
			    }
			    if (!true)
			    {
				    System.RuntimeMethodHandle arg_AA_0 = methodof(Wheel.Load(ConfigNode)).MethodHandle;
			    }
			    this.rotateX = float.Parse(node.GetValue(.(134646)));
		    }
		    if (node.HasValue(.(134661)))
		    {
			    while (true)
			    {
				    switch (2)
				    {
				    case 0:
					    continue;
				    }
				    break;
			    }
			    this.rotateY = float.Parse(node.GetValue(.(134661)));
		    }
		    if (node.HasValue(.(134676)))
		    {
			    while (true)
			    {
				    switch (5)
				    {
				    case 0:
					    continue;
				    }
				    break;
			    }
			    this.rotateZ = float.Parse(node.GetValue(.(134676)));
		    }
		    Vector3 vector = new Vector3(this.rotateX, this.rotateY, this.rotateZ);
		    this.wheelAxis = vector.normalized;*/
	    }

	    public void Save(ConfigNode node)
	    {
		 /*   node.AddValue(.(134457), this.wheelName);
		    node.AddValue(.(134476), this.wheelColliderName);
		    node.AddValue(.(134511), this.suspensionTransformName);
		    node.AddValue(.(134558), this.suspensionNeutralPointName);
		    node.AddValue(.(134611), this.damagedObjectName);
		    node.AddValue(.(134646), this.rotateX);
		    node.AddValue(.(134661), this.rotateY);
		    node.AddValue(.(134676), this.rotateZ);*/
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
