using ColossalFramework;
using ColossalFramework.IO;
using ColossalFramework.Math;
using ColossalFramework.Threading;
using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

namespace PatchLib
{

    public class TreeManager_v2 : SimulationManagerBase<TreeManager, TreeProperties>, IRenderableManager, ISimulationManager, ITerrainManager
    {
        public class Data : IDataContainer
        {
            public void Serialize(DataSerializer s)
            {
                Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.BeginSerialize(s, "TreeManager_v2");
                TreeManager_v2 instance = Singleton<TreeManager_v2>.instance;
                global::TreeInstance[] buffer = instance.m_trees.m_buffer;
                int num = buffer.Length;
                EncodedArray.UShort uShort = EncodedArray.UShort.BeginWrite(s);
                for (int i = 1; i < num; i++)
                {
                    uShort.Write(buffer[i].m_flags);
                }
                uShort.EndWrite();
                try
                {
                    PrefabCollection<TreeInfo>.BeginSerialize(s);
                    for (int j = 1; j < num; j++)
                    {
                        if (buffer[j].m_flags != 0)
                        {
                            PrefabCollection<TreeInfo>.Serialize((uint)buffer[j].m_infoIndex);
                        }
                    }
                }
                finally
                {
                    PrefabCollection<TreeInfo>.EndSerialize(s);
                }
                EncodedArray.Short @short = EncodedArray.Short.BeginWrite(s);
                for (int k = 1; k < num; k++)
                {
                    if (buffer[k].m_flags != 0)
                    {
                        @short.Write(buffer[k].m_posX);
                    }
                }
                @short.EndWrite();
                EncodedArray.Short short2 = EncodedArray.Short.BeginWrite(s);
                for (int l = 1; l < num; l++)
                {
                    if (buffer[l].m_flags != 0)
                    {
                        short2.Write(buffer[l].m_posZ);
                    }
                }
                short2.EndWrite();
                Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.EndSerialize(s, "TreeManager_v2");
            }
            public void Deserialize(DataSerializer s)
            {
                Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.BeginDeserialize(s, "TreeManager_v2");
                TreeManager_v2 instance = Singleton<TreeManager_v2>.instance;
                global::TreeInstance[] buffer = instance.m_trees.m_buffer;
                uint[] treeGrid = instance.m_treeGrid;
                int num = buffer.Length;
                int num2 = treeGrid.Length;
                instance.m_trees.ClearUnused();
                SimulationManager.UpdateMode updateMode = Singleton<SimulationManager>.instance.m_metaData.m_updateMode;
                bool assetEditor = updateMode == SimulationManager.UpdateMode.NewAsset || updateMode == SimulationManager.UpdateMode.LoadAsset;
                for (int i = 0; i < num2; i++)
                {
                    treeGrid[i] = 0u;
                }
                EncodedArray.UShort uShort = EncodedArray.UShort.BeginRead(s);
                for (int j = 1; j < num; j++)
                {
                    buffer[j].m_flags = uShort.Read();
                }
                uShort.EndRead();
                PrefabCollection<TreeInfo>.BeginDeserialize(s);
                for (int k = 1; k < num; k++)
                {
                    if (buffer[k].m_flags != 0)
                    {
                        buffer[k].m_infoIndex = (ushort)PrefabCollection<TreeInfo>.Deserialize();
                    }
                }
                PrefabCollection<TreeInfo>.EndDeserialize(s);
                EncodedArray.Short @short = EncodedArray.Short.BeginRead(s);
                for (int l = 1; l < num; l++)
                {
                    if (buffer[l].m_flags != 0)
                    {
                        buffer[l].m_posX = @short.Read();
                    }
                    else
                    {
                        buffer[l].m_posX = 0;
                    }
                }
                @short.EndRead();
                EncodedArray.Short short2 = EncodedArray.Short.BeginRead(s);
                for (int m = 1; m < num; m++)
                {
                    if (buffer[m].m_flags != 0)
                    {
                        buffer[m].m_posZ = short2.Read();
                    }
                    else
                    {
                        buffer[m].m_posZ = 0;
                    }
                }
                short2.EndRead();
                for (int n = 1; n < num; n++)
                {
                    buffer[n].m_nextGridTree = 0u;
                    buffer[n].m_posY = 0;
                    if (buffer[n].m_flags != 0)
                    {
                        instance.InitializeTree((uint)n, ref buffer[n], assetEditor);
                    }
                    else
                    {
                        instance.m_trees.ReleaseItem((uint)n);
                    }
                }
                Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.EndDeserialize(s, "TreeManager_v2");
            }
            public void AfterDeserialize(DataSerializer s)
            {
                Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.BeginAfterDeserialize(s, "TreeManager_v2");
                Singleton<LoadingManager>.instance.WaitUntilEssentialScenesLoaded();
                PrefabCollection<TreeInfo>.BindPrefabs();
                TreeManager_v2 instance = Singleton<TreeManager_v2>.instance;
                global::TreeInstance[] buffer = instance.m_trees.m_buffer;
                int num = buffer.Length;
                for (int i = 1; i < num; i++)
                {
                    if (buffer[i].m_flags != 0)
                    {
                        TreeInfo info = buffer[i].Info;
                        if (info != null)
                        {
                            buffer[i].m_infoIndex = (ushort)info.m_prefabDataIndex;
                        }
                    }
                }
                instance.m_treeCount = (int)(instance.m_trees.ItemCount() - 1u);
                Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.EndAfterDeserialize(s, "TreeManager_v2");
            }
        }
        public const float TREEGRID_CELL_SIZE = 32f;
        public const int TREEGRID_RESOLUTION = 540;
        public const int MAX_TREE_COUNT = 262144;
        public const int MAX_MAP_TREES = 250000;
        public const int MAX_ASSET_TREES = 64;
        public int m_treeCount;
        public int m_infoCount;
        public RenderTexture m_renderDiffuseTexture;
        public RenderTexture m_renderXycaTexture;
        public RenderTexture m_renderShadowTexture;
        [NonSerialized]
        public Array32<global::TreeInstance> m_trees;
        [NonSerialized]
        public ulong[] m_updatedTrees;
        [NonSerialized]
        public bool m_treesUpdated;
        [NonSerialized]
        public uint[] m_treeGrid;
        [NonSerialized]
        public MaterialPropertyBlock m_materialBlock;
        [NonSerialized]
        public int ID_XYCAMap;
        [NonSerialized]
        public int ID_ShadowAMap;
        [NonSerialized]
        public int ID_ShadowMatrix;
        [NonSerialized]
        public int ID_Color;
        [NonSerialized]
        public int ID_TileRect;
        [NonSerialized]
        public int[] ID_TreeLocation;
        [NonSerialized]
        public int[] ID_TreeColor;
        [NonSerialized]
        public int m_treeLayer;
        private int m_renderPass;
        private Camera m_renderCamera;
        private RenderManager.CameraInfo m_cameraInfo;
        private Quaternion m_lastShadowRotation;
        private Quaternion m_lastCameraRotation;
        protected override void Awake()
        {
            base.Awake();
            this.m_trees = new Array32<global::TreeInstance>(262144u);
            this.m_updatedTrees = new ulong[4096];
            this.m_treeGrid = new uint[291600];
            this.m_materialBlock = new MaterialPropertyBlock();
            this.ID_XYCAMap = Shader.PropertyToID("_XYCAMap");
            this.ID_ShadowAMap = Shader.PropertyToID("_ShadowAMap");
            this.ID_ShadowMatrix = Shader.PropertyToID("_ShadowMatrix");
            this.ID_Color = Shader.PropertyToID("_Color");
            this.ID_TileRect = Shader.PropertyToID("_TileRect");
            this.ID_TreeLocation = new int[16];
            this.ID_TreeColor = new int[16];
            for (int i = 0; i < 16; i++)
            {
                this.ID_TreeLocation[i] = Shader.PropertyToID("_TreeLocation" + i);
                this.ID_TreeColor[i] = Shader.PropertyToID("_TreeColor" + i);
            }
            this.m_treeLayer = LayerMask.NameToLayer("Trees");
            this.m_renderCamera = base.gameObject.AddComponent<Camera>();
            this.m_renderCamera.eventMask = 0;
            this.m_renderCamera.enabled = false;
            this.m_renderCamera.targetTexture = null;
            this.m_renderCamera.backgroundColor = new Color(0f, 0f, 0f, 0f);
            this.m_renderCamera.clearFlags = CameraClearFlags.Color;
            this.m_renderCamera.ResetAspect();
            this.m_renderCamera.orthographic = true;
            this.m_renderCamera.orthographicSize = 0.5f;
            this.m_renderCamera.nearClipPlane = 1f;
            this.m_renderCamera.farClipPlane = 100f;
            this.m_renderCamera.cullingMask = 0;
            this.m_renderCamera.renderingPath = RenderingPath.VertexLit;
            this.m_renderCamera.useOcclusionCulling = false;
            this.m_renderDiffuseTexture = new RenderTexture(512, 512, 24, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
            this.m_renderDiffuseTexture.filterMode = FilterMode.Trilinear;
            this.m_renderDiffuseTexture.generateMips = true;
            this.m_renderXycaTexture = new RenderTexture(512, 512, 24, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
            this.m_renderXycaTexture.filterMode = FilterMode.Trilinear;
            this.m_renderXycaTexture.generateMips = true;
            this.m_renderShadowTexture = new RenderTexture(512, 512, 24, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
            this.m_renderShadowTexture.filterMode = FilterMode.Point;
            this.m_renderShadowTexture.generateMips = false;
            uint num;
            this.m_trees.CreateItem(out num);
        }
        public override void InitializeProperties(TreeProperties properties)
        {
            base.InitializeProperties(properties);
            if (this.m_properties.m_placementEffect != null)
            {
                this.m_properties.m_placementEffect.InitializeEffect();
            }
            if (this.m_properties.m_bulldozeEffect != null)
            {
                this.m_properties.m_bulldozeEffect.InitializeEffect();
            }
        }
        public override void DestroyProperties(TreeProperties properties)
        {
            if (this.m_properties == properties)
            {
                if (this.m_properties.m_placementEffect != null)
                {
                    this.m_properties.m_placementEffect.ReleaseEffect();
                }
                if (this.m_properties.m_bulldozeEffect != null)
                {
                    this.m_properties.m_bulldozeEffect.ReleaseEffect();
                }
            }
            base.DestroyProperties(properties);
        }
        private void OnDestroy()
        {
            if (this.m_renderDiffuseTexture != null)
            {
                UnityEngine.Object.Destroy(this.m_renderDiffuseTexture);
                this.m_renderDiffuseTexture = null;
            }
            if (this.m_renderXycaTexture != null)
            {
                UnityEngine.Object.Destroy(this.m_renderXycaTexture);
                this.m_renderXycaTexture = null;
            }
            if (this.m_renderShadowTexture != null)
            {
                UnityEngine.Object.Destroy(this.m_renderShadowTexture);
                this.m_renderShadowTexture = null;
            }
        }
      

        private void OnPostRender()
        {
            if (this.m_cameraInfo == null)
            {
                return;
            }
            int num = PrefabCollection<TreeInfo>.PrefabCount();

            int num2 = 1;
            while (num2 * num2 < num)
            {
                num2++;
            }
            Quaternion quaternion = Quaternion.Inverse((this.m_renderPass != 3) ? this.m_cameraInfo.m_rotation : this.m_cameraInfo.m_shadowRotation);
            float num3;
            if (this.m_renderCamera.orthographic)
            {
                num3 = 0.1f;
            }
            else
            {
                num3 = Mathf.Tan(this.m_renderCamera.fieldOfView * 0.0174532924f * 0.5f);
            }

            for (int i = 0; i < num; i++)
            {
                TreeInfo prefab = PrefabCollection<TreeInfo>.GetPrefab((uint)i);
                if (prefab != null)
                {
                    if (prefab.m_renderMaterial == null)
                    {
                        prefab.m_renderMaterial = new Material(this.m_properties.m_renderShader);
                        prefab.m_renderMaterial.CopyPropertiesFromMaterial(prefab.m_material);
                    }


                    Vector3 vector = new Vector3((0.5f - (float)num2 * 0.5f + (float)(i % num2)) / (float)num2, (0.5f - (float)num2 * 0.5f + (float)(i / num2)) / (float)num2, 0.5f / num3);
                    Vector3 vector2 = vector;
                    vector2 -= quaternion * new Vector3(0f, prefab.m_renderOffset / (prefab.m_renderScale * (float)num2), 0f);
                    Matrix4x4 matrix = default(Matrix4x4);
                    matrix.SetTRS(vector2, quaternion, Vector3.one / (prefab.m_renderScale * (float)num2));
                    Vector4 vector3 = new Vector4(vector.x - 0.5f / (float)num2, vector.y - 0.5f / (float)num2, vector.x + 0.5f / (float)num2, vector.y + 0.5f / (float)num2);
                    if (this.m_renderPass == 0)
                    {
                        Quaternion quaternion2 = Quaternion.Inverse(this.m_cameraInfo.m_shadowRotation);
                        Vector3 vector4 = new Vector3((0.5f + (float)(i % num2)) / (float)num2, (0.5f + (float)(i / num2)) / (float)num2, 0.5f / num3);
                        vector4 -= quaternion2 * new Vector3(0f, prefab.m_renderOffset / (prefab.m_renderScale * (float)num2), 0f);
                        Matrix4x4 matrix2 = default(Matrix4x4);
                        matrix2.SetTRS(vector4, quaternion2, Vector3.one / (prefab.m_renderScale * (float)num2));
                        prefab.m_renderMaterial.SetTexture(this.ID_ShadowAMap, this.m_renderShadowTexture);
                        prefab.m_renderMaterial.SetMatrix(this.ID_ShadowMatrix, matrix2);
                    }
                    prefab.m_renderMaterial.SetVector(this.ID_TileRect, vector3);
                    if (prefab.m_renderMaterial.SetPass(this.m_renderPass))
                    {
                        TreeManager_v2 expr_2C2_cp_0 = Singleton<TreeManager_v2>.instance;
                        expr_2C2_cp_0.m_drawCallData.m_defaultCalls = expr_2C2_cp_0.m_drawCallData.m_defaultCalls + 1;
                        Graphics.DrawMeshNow(prefab.m_mesh, matrix);
                    }
                    if ((this.m_renderPass == 1 || this.m_renderPass == 3) && prefab.m_renderMaterial.SetPass(2))
                    {
                        TreeManager_v2 expr_311_cp_0 = Singleton<TreeManager_v2>.instance;
                        expr_311_cp_0.m_drawCallData.m_defaultCalls = expr_311_cp_0.m_drawCallData.m_defaultCalls + 1;
                        Graphics.DrawMeshNow(prefab.m_mesh, matrix);
                    }
                }
            }
        }
        protected void BeginRenderingImpl(RenderManager.CameraInfo cameraInfo)
        {
            this.m_cameraInfo = cameraInfo;
            try
            {
                bool flag = Quaternion.Angle(this.m_lastShadowRotation, this.m_cameraInfo.m_shadowRotation) > 0.1f || !this.m_renderShadowTexture.IsCreated();
                bool flag2 = Quaternion.Angle(this.m_lastCameraRotation, this.m_cameraInfo.m_rotation) > 0.1f || !this.m_renderDiffuseTexture.IsCreated();
                bool flag3 = Quaternion.Angle(this.m_lastCameraRotation, this.m_cameraInfo.m_rotation) > 0.1f || !this.m_renderXycaTexture.IsCreated();
                if (flag)
                {
                    this.m_renderCamera.targetTexture = this.m_renderShadowTexture;
                    this.m_renderPass = 3;
                    this.m_renderCamera.Render();
                    this.m_lastShadowRotation = cameraInfo.m_shadowRotation;
                }
                if (flag3)
                {
                    this.m_renderCamera.targetTexture = this.m_renderXycaTexture;
                    this.m_renderPass = 1;
                    this.m_renderCamera.Render();
                    this.m_lastCameraRotation = this.m_cameraInfo.m_rotation;
                }
                if (flag || flag2)
                {
                    this.m_renderCamera.targetTexture = this.m_renderDiffuseTexture;
                    this.m_renderPass = 0;
                    this.m_renderCamera.Render();
                    this.m_lastCameraRotation = this.m_cameraInfo.m_rotation;
                }
                this.m_renderCamera.targetTexture = null;
                Singleton<RenderManager>.instance.m_groupLayerMaterials[this.m_treeLayer].mainTexture = this.m_renderDiffuseTexture;
                Singleton<RenderManager>.instance.m_groupLayerMaterials[this.m_treeLayer].SetTexture(this.ID_XYCAMap, this.m_renderXycaTexture);
                Singleton<RenderManager>.instance.m_groupLayerMaterials[this.m_treeLayer].SetTexture(this.ID_ShadowAMap, this.m_renderShadowTexture);
            }
            finally
            {
                this.m_cameraInfo = null;
            }
            int num = PrefabCollection<TreeInfo>.PrefabCount();
            for (int i = 0; i < num; i++)
            {
                TreeInfo prefab = PrefabCollection<TreeInfo>.GetPrefab((uint)i);
                if (prefab != null)
                {
                    if (prefab.m_lodMeshData1 != null)
                    {
                        RenderGroup.MeshData lodMeshData = prefab.m_lodMeshData1;
                        prefab.m_lodMeshData1 = null;
                        if (prefab.m_lodMesh1 == null)
                        {
                            prefab.m_lodMesh1 = new Mesh();
                        }
                        lodMeshData.PopulateMesh(prefab.m_lodMesh1);
                    }
                    if (prefab.m_lodMeshData4 != null)
                    {
                        RenderGroup.MeshData lodMeshData2 = prefab.m_lodMeshData4;
                        prefab.m_lodMeshData4 = null;
                        if (prefab.m_lodMesh4 == null)
                        {
                            prefab.m_lodMesh4 = new Mesh();
                        }
                        lodMeshData2.PopulateMesh(prefab.m_lodMesh4);
                    }
                    if (prefab.m_lodMeshData8 != null)
                    {
                        RenderGroup.MeshData lodMeshData3 = prefab.m_lodMeshData8;
                        prefab.m_lodMeshData8 = null;
                        if (prefab.m_lodMesh8 == null)
                        {
                            prefab.m_lodMesh8 = new Mesh();
                        }
                        lodMeshData3.PopulateMesh(prefab.m_lodMesh8);
                    }
                    if (prefab.m_lodMeshData16 != null)
                    {
                        RenderGroup.MeshData lodMeshData4 = prefab.m_lodMeshData16;
                        prefab.m_lodMeshData16 = null;
                        if (prefab.m_lodMesh16 == null)
                        {
                            prefab.m_lodMesh16 = new Mesh();
                        }
                        lodMeshData4.PopulateMesh(prefab.m_lodMesh16);
                    }
                    if (prefab.m_lodMaterial == null)
                    {
                        Shader shader = Singleton<RenderManager>.instance.m_properties.m_groupLayerShaders[this.m_treeLayer];
                        prefab.m_lodMaterial = new Material(shader);
                        prefab.m_lodMaterial.EnableKeyword("MULTI_INSTANCE");
                    }
                    prefab.m_lodMaterial.mainTexture = this.m_renderDiffuseTexture;
                    prefab.m_lodMaterial.SetTexture(this.ID_XYCAMap, this.m_renderXycaTexture);
                    prefab.m_lodMaterial.SetTexture(this.ID_ShadowAMap, this.m_renderShadowTexture);
                }
            }
        }
        protected void EndRenderingImpl(RenderManager.CameraInfo cameraInfo)
        {
            FastList<RenderGroup> renderedGroups = Singleton<RenderManager>.instance.m_renderedGroups;
            for (int i = 0; i < renderedGroups.m_size; i++)
            {
                RenderGroup renderGroup = renderedGroups.m_buffer[i];
                if ((renderGroup.m_instanceMask & 1 << this.m_treeLayer) != 0)
                {
                    int num = renderGroup.m_x * 540 / 45;
                    int num2 = renderGroup.m_z * 540 / 45;
                    int num3 = (renderGroup.m_x + 1) * 540 / 45 - 1;
                    int num4 = (renderGroup.m_z + 1) * 540 / 45 - 1;
                    for (int j = num2; j <= num4; j++)
                    {
                        for (int k = num; k <= num3; k++)
                        {
                            int num5 = j * 540 + k;
                            uint num6 = this.m_treeGrid[num5];
                            int num7 = 0;
                            while (num6 != 0u)
                            {
                                this.m_trees.m_buffer[(int)((UIntPtr)num6)].RenderInstance(cameraInfo, num6, renderGroup.m_instanceMask);
                                num6 = this.m_trees.m_buffer[(int)((UIntPtr)num6)].m_nextGridTree;
                                if (++num7 >= 262144)
                                {
                                    CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            int num8 = PrefabCollection<TreeInfo>.PrefabCount();
            for (int l = 0; l < num8; l++)
            {
                TreeInfo prefab = PrefabCollection<TreeInfo>.GetPrefab((uint)l);
                if (prefab != null)
                {
                    if (prefab.m_lodCount != 0)
                    {
                        global::TreeInstance.RenderLod(cameraInfo, prefab);
                    }
                }
            }
        }
        public float SampleSmoothHeight(Vector3 worldPos)
        {
            float num = 0f;
            int num2 = Mathf.Max((int)((worldPos.x - 32f) / 32f + 270f), 0);
            int num3 = Mathf.Max((int)((worldPos.z - 32f) / 32f + 270f), 0);
            int num4 = Mathf.Min((int)((worldPos.x + 32f) / 32f + 270f), 539);
            int num5 = Mathf.Min((int)((worldPos.z + 32f) / 32f + 270f), 539);
            for (int i = num3; i <= num5; i++)
            {
                for (int j = num2; j <= num4; j++)
                {
                    uint num6 = this.m_treeGrid[i * 540 + j];
                    int num7 = 0;
                    while (num6 != 0u)
                    {
                        if (this.m_trees.m_buffer[(int)((UIntPtr)num6)].GrowState != 0)
                        {
                            Vector3 position = this.m_trees.m_buffer[(int)((UIntPtr)num6)].Position;
                            Vector3 vector = worldPos - position;
                            float num8 = 1024f;
                            float num9 = vector.x * vector.x + vector.z * vector.z;
                            if (num9 < num8)
                            {
                                TreeInfo info = this.m_trees.m_buffer[(int)((UIntPtr)num6)].Info;
                                float num10 = MathUtils.SmoothClamp01(1f - Mathf.Sqrt(num9 / num8));
                                num10 = position.y + info.m_generatedInfo.m_size.y * 1.25f * num10;
                                if (num10 > num)
                                {
                                    num = num10;
                                }
                            }
                        }
                        num6 = this.m_trees.m_buffer[(int)((UIntPtr)num6)].m_nextGridTree;
                        if (++num7 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
            return num;
        }
        public bool CheckLimits()
        {
            ItemClass.Availability mode = Singleton<ToolManager>.instance.m_properties.m_mode;
            if ((mode & ItemClass.Availability.MapEditor) != ItemClass.Availability.None)
            {
                if (this.m_treeCount >= 250000)
                {
                    return false;
                }
            }
            else if ((mode & ItemClass.Availability.AssetEditor) != ItemClass.Availability.None)
            {
                if (this.m_treeCount + Singleton<PropManager>.instance.m_propCount >= 64)
                {
                    return false;
                }
            }
            else if (this.m_treeCount >= 262139)
            {
                return false;
            }
            return true;
        }
        public bool CreateTree(out uint tree, ref Randomizer randomizer, TreeInfo info, Vector3 position, bool single)
        {
            if (!this.CheckLimits())
            {
                tree = 0u;
                return false;
            }
            uint num;
            if (this.m_trees.CreateItem(out num, ref randomizer))
            {
                tree = num;
                this.m_trees.m_buffer[(int)((UIntPtr)tree)].m_flags = 1;
                this.m_trees.m_buffer[(int)((UIntPtr)tree)].Info = info;
                this.m_trees.m_buffer[(int)((UIntPtr)tree)].Single = single;
                this.m_trees.m_buffer[(int)((UIntPtr)tree)].GrowState = 15;
                this.m_trees.m_buffer[(int)((UIntPtr)tree)].Position = position;
                ItemClass.Availability mode = Singleton<ToolManager>.instance.m_properties.m_mode;
                this.InitializeTree(tree, ref this.m_trees.m_buffer[(int)((UIntPtr)tree)], (mode & ItemClass.Availability.AssetEditor) != ItemClass.Availability.None);
                this.UpdateTree(tree);
                this.m_treeCount = (int)(this.m_trees.ItemCount() - 1u);
                return true;
            }
            tree = 0u;
            return false;
        }
        public void ReleaseTree(uint tree)
        {
            this.ReleaseTreeImplementation(tree, ref this.m_trees.m_buffer[(int)((UIntPtr)tree)]);
        }
        private void InitializeTree(uint tree, ref global::TreeInstance data, bool assetEditor)
        {
            int num;
            int num2;
            if (assetEditor)
            {
                num = Mathf.Clamp(((int)(data.m_posX / 16) + 32768) * 540 / 65536, 0, 539);
                num2 = Mathf.Clamp(((int)(data.m_posZ / 16) + 32768) * 540 / 65536, 0, 539);
            }
            else
            {
                num = Mathf.Clamp(((int)data.m_posX + 32768) * 540 / 65536, 0, 539);
                num2 = Mathf.Clamp(((int)data.m_posZ + 32768) * 540 / 65536, 0, 539);
            }
            int num3 = num2 * 540 + num;
            while (!Monitor.TryEnter(this.m_treeGrid, SimulationManager.SYNCHRONIZE_TIMEOUT))
            {
            }
            try
            {
                this.m_trees.m_buffer[(int)((UIntPtr)tree)].m_nextGridTree = this.m_treeGrid[num3];
                this.m_treeGrid[num3] = tree;
            }
            finally
            {
                Monitor.Exit(this.m_treeGrid);
            }
        }
        private void ReleaseTreeImplementation(uint tree, ref global::TreeInstance data)
        {
            if (data.m_flags != 0)
            {
                InstanceID id = default(InstanceID);
                id.Tree = tree;
                Singleton<InstanceManager>.instance.ReleaseInstance(id);
                data.m_flags |= 2;
                data.UpdateTree(tree);
                data.m_flags = 0;
                int num;
                int num2;
                if (Singleton<ToolManager>.instance.m_properties.m_mode == ItemClass.Availability.AssetEditor)
                {
                    num = Mathf.Clamp(((int)(data.m_posX / 16) + 32768) * 540 / 65536, 0, 539);
                    num2 = Mathf.Clamp(((int)(data.m_posZ / 16) + 32768) * 540 / 65536, 0, 539);
                }
                else
                {
                    num = Mathf.Clamp(((int)data.m_posX + 32768) * 540 / 65536, 0, 539);
                    num2 = Mathf.Clamp(((int)data.m_posZ + 32768) * 540 / 65536, 0, 539);
                }
                int num3 = num2 * 540 + num;
                while (!Monitor.TryEnter(this.m_treeGrid, SimulationManager.SYNCHRONIZE_TIMEOUT))
                {
                }
                try
                {
                    uint num4 = 0u;
                    uint num5 = this.m_treeGrid[num3];
                    int num6 = 0;
                    while (num5 != 0u)
                    {
                        if (num5 == tree)
                        {
                            if (num4 == 0u)
                            {
                                this.m_treeGrid[num3] = data.m_nextGridTree;
                            }
                            else
                            {
                                this.m_trees.m_buffer[(int)((UIntPtr)num4)].m_nextGridTree = data.m_nextGridTree;
                            }
                            break;
                        }
                        num4 = num5;
                        num5 = this.m_trees.m_buffer[(int)((UIntPtr)num5)].m_nextGridTree;
                        if (++num6 > 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                    data.m_nextGridTree = 0u;
                }
                finally
                {
                    Monitor.Exit(this.m_treeGrid);
                }
                this.m_trees.ReleaseItem(tree);
                this.UpdateTree(tree);
                this.m_treeCount = (int)(this.m_trees.ItemCount() - 1u);
                Singleton<RenderManager>.instance.UpdateGroup(num * 45 / 540, num2 * 45 / 540, this.m_treeLayer);
            }
        }
        private void UpdateTree(uint tree)
        {
            this.m_updatedTrees[(int)((UIntPtr)(tree >> 6))] |= 1uL << (int)tree;
            this.m_treesUpdated = true;
        }
        public void UpdateTrees(float minX, float minZ, float maxX, float maxZ)
        {
            int num = Mathf.Max((int)((minX - 8f) / 32f + 270f), 0);
            int num2 = Mathf.Max((int)((minZ - 8f) / 32f + 270f), 0);
            int num3 = Mathf.Min((int)((maxX + 8f) / 32f + 270f), 539);
            int num4 = Mathf.Min((int)((maxZ + 8f) / 32f + 270f), 539);
            for (int i = num2; i <= num4; i++)
            {
                for (int j = num; j <= num3; j++)
                {
                    uint num5 = this.m_treeGrid[i * 540 + j];
                    int num6 = 0;
                    while (num5 != 0u)
                    {
                        Vector3 position = this.m_trees.m_buffer[(int)((UIntPtr)num5)].Position;
                        float num7 = Mathf.Max(Mathf.Max(minX - 8f - position.x, minZ - 8f - position.z), Mathf.Max(position.x - maxX - 8f, position.z - maxZ - 8f));
                        if (num7 < 0f)
                        {
                            this.m_updatedTrees[(int)((UIntPtr)(num5 >> 6))] |= 1uL << (int)num5;
                            this.m_treesUpdated = true;
                        }
                        num5 = this.m_trees.m_buffer[(int)((UIntPtr)num5)].m_nextGridTree;
                        if (++num6 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
        }
        public void UpdateTreeRenderer(uint tree, bool updateGroup)
        {
            if (this.m_trees.m_buffer[(int)((UIntPtr)tree)].m_flags == 0)
            {
                return;
            }
            if (updateGroup)
            {
                int num;
                int num2;
                if (Singleton<ToolManager>.instance.m_properties.m_mode == ItemClass.Availability.AssetEditor)
                {
                    num = Mathf.Clamp(((int)(this.m_trees.m_buffer[(int)((UIntPtr)tree)].m_posX / 16) + 32768) * 540 / 65536, 0, 539);
                    num2 = Mathf.Clamp(((int)(this.m_trees.m_buffer[(int)((UIntPtr)tree)].m_posZ / 16) + 32768) * 540 / 65536, 0, 539);
                }
                else
                {
                    num = Mathf.Clamp(((int)this.m_trees.m_buffer[(int)((UIntPtr)tree)].m_posX + 32768) * 540 / 65536, 0, 539);
                    num2 = Mathf.Clamp(((int)this.m_trees.m_buffer[(int)((UIntPtr)tree)].m_posZ + 32768) * 540 / 65536, 0, 539);
                }
                Singleton<RenderManager>.instance.UpdateGroup(num * 45 / 540, num2 * 45 / 540, this.m_treeLayer);
            }
        }
        public bool OverlapQuad(Quad2 quad, float minY, float maxY, int layer, uint ignoreTree)
        {
            Vector2 vector = quad.Min();
            Vector2 vector2 = quad.Max();
            int num = Mathf.Max((int)((vector.x - 8f) / 32f + 270f), 0);
            int num2 = Mathf.Max((int)((vector.y - 8f) / 32f + 270f), 0);
            int num3 = Mathf.Min((int)((vector2.x + 8f) / 32f + 270f), 539);
            int num4 = Mathf.Min((int)((vector2.y + 8f) / 32f + 270f), 539);
            for (int i = num2; i <= num4; i++)
            {
                for (int j = num; j <= num3; j++)
                {
                    uint num5 = this.m_treeGrid[i * 540 + j];
                    int num6 = 0;
                    while (num5 != 0u)
                    {
                        Vector3 position = this.m_trees.m_buffer[(int)((UIntPtr)num5)].Position;
                        float num7 = Mathf.Max(Mathf.Max(vector.x - 8f - position.x, vector.y - 8f - position.z), Mathf.Max(position.x - vector2.x - 8f, position.z - vector2.y - 8f));
                        if (num7 < 0f && this.m_trees.m_buffer[(int)((UIntPtr)num5)].OverlapQuad(num5, quad, minY, maxY))
                        {
                            return true;
                        }
                        num5 = this.m_trees.m_buffer[(int)((UIntPtr)num5)].m_nextGridTree;
                        if (++num6 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
            return false;
        }
        public bool RayCast(Segment3 ray, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Layer itemLayers, global::TreeInstance.Flags ignoreFlags, out Vector3 hit, out uint treeIndex)
        {
            Bounds bounds = new Bounds(new Vector3(0f, 512f, 0f), new Vector3(17280f, 1152f, 17280f));
            if (ray.Clip(bounds))
            {
                Vector3 vector = ray.b - ray.a;
                int num = (int)(ray.a.x / 32f + 270f);
                int num2 = (int)(ray.a.z / 32f + 270f);
                int num3 = (int)(ray.b.x / 32f + 270f);
                int num4 = (int)(ray.b.z / 32f + 270f);
                float num5 = Mathf.Abs(vector.x);
                float num6 = Mathf.Abs(vector.z);
                int num7;
                int num8;
                if (num5 >= num6)
                {
                    num7 = ((vector.x <= 0f) ? -1 : 1);
                    num8 = 0;
                    if (num5 != 0f)
                    {
                        vector *= 32f / num5;
                    }
                }
                else
                {
                    num7 = 0;
                    num8 = ((vector.z <= 0f) ? -1 : 1);
                    if (num6 != 0f)
                    {
                        vector *= 32f / num6;
                    }
                }
                float num9 = 2f;
                float num10 = 10000f;
                treeIndex = 0u;
                Vector3 vector2 = ray.a;
                Vector3 vector3 = ray.a;
                int num11 = num;
                int num12 = num2;
                do
                {
                    Vector3 vector4 = vector3 + vector;
                    int num13;
                    int num14;
                    int num15;
                    int num16;
                    if (num7 != 0)
                    {
                        if ((num11 == num && num7 > 0) || (num11 == num3 && num7 < 0))
                        {
                            num13 = Mathf.Max((int)((vector4.x - 72f) / 32f + 270f), 0);
                        }
                        else
                        {
                            num13 = Mathf.Max(num11, 0);
                        }
                        if ((num11 == num && num7 < 0) || (num11 == num3 && num7 > 0))
                        {
                            num14 = Mathf.Min((int)((vector4.x + 72f) / 32f + 270f), 539);
                        }
                        else
                        {
                            num14 = Mathf.Min(num11, 539);
                        }
                        num15 = Mathf.Max((int)((Mathf.Min(vector2.z, vector4.z) - 72f) / 32f + 270f), 0);
                        num16 = Mathf.Min((int)((Mathf.Max(vector2.z, vector4.z) + 72f) / 32f + 270f), 539);
                    }
                    else
                    {
                        if ((num12 == num2 && num8 > 0) || (num12 == num4 && num8 < 0))
                        {
                            num15 = Mathf.Max((int)((vector4.z - 72f) / 32f + 270f), 0);
                        }
                        else
                        {
                            num15 = Mathf.Max(num12, 0);
                        }
                        if ((num12 == num2 && num8 < 0) || (num12 == num4 && num8 > 0))
                        {
                            num16 = Mathf.Min((int)((vector4.z + 72f) / 32f + 270f), 539);
                        }
                        else
                        {
                            num16 = Mathf.Min(num12, 539);
                        }
                        num13 = Mathf.Max((int)((Mathf.Min(vector2.x, vector4.x) - 72f) / 32f + 270f), 0);
                        num14 = Mathf.Min((int)((Mathf.Max(vector2.x, vector4.x) + 72f) / 32f + 270f), 539);
                    }
                    for (int i = num15; i <= num16; i++)
                    {
                        for (int j = num13; j <= num14; j++)
                        {
                            uint num17 = this.m_treeGrid[i * 540 + j];
                            int num18 = 0;
                            while (num17 != 0u)
                            {
                                global::TreeInstance.Flags flags = (global::TreeInstance.Flags)this.m_trees.m_buffer[(int)((UIntPtr)num17)].m_flags;
                                if ((flags & ignoreFlags) == global::TreeInstance.Flags.None && ray.DistanceSqr(this.m_trees.m_buffer[(int)((UIntPtr)num17)].Position) < 2500f)
                                {
                                    TreeInfo info = this.m_trees.m_buffer[(int)((UIntPtr)num17)].Info;
                                    float num19;
                                    float num20;
                                    if ((service == ItemClass.Service.None || info.m_class.m_service == service) && (subService == ItemClass.SubService.None || info.m_class.m_subService == subService) && (itemLayers == ItemClass.Layer.None || (info.m_class.m_layer & itemLayers) != ItemClass.Layer.None) && this.m_trees.m_buffer[(int)((UIntPtr)num17)].RayCast(num17, ray, out num19, out num20) && (num19 < num9 - 0.0001f || (num19 < num9 + 0.0001f && num20 < num10)))
                                    {
                                        num9 = num19;
                                        num10 = num20;
                                        treeIndex = num17;
                                    }
                                }
                                num17 = this.m_trees.m_buffer[(int)((UIntPtr)num17)].m_nextGridTree;
                                if (++num18 > 262144)
                                {
                                    CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                                    break;
                                }
                            }
                        }
                    }
                    vector2 = vector3;
                    vector3 = vector4;
                    num11 += num7;
                    num12 += num8;
                }
                while ((num11 <= num3 || num7 <= 0) && (num11 >= num3 || num7 >= 0) && (num12 <= num4 || num8 <= 0) && (num12 >= num4 || num8 >= 0));
                if (num9 != 2f)
                {
                    hit = ray.Position(num9);
                    return true;
                }
            }
            hit = Vector3.zero;
            treeIndex = 0u;
            return false;
        }
        protected override void SimulationStepImpl(int subStep)
        {
            if (this.m_treesUpdated)
            {
                int num = this.m_updatedTrees.Length;
                for (int i = 0; i < num; i++)
                {
                    ulong num2 = this.m_updatedTrees[i];
                    if (num2 != 0uL)
                    {
                        for (int j = 0; j < 64; j++)
                        {
                            if ((num2 & 1uL << j) != 0uL)
                            {
                                uint num3 = (uint)(i << 6 | j);
                                this.m_trees.m_buffer[(int)((UIntPtr)num3)].CalculateTree(num3);
                            }
                        }
                    }
                }
                this.m_treesUpdated = false;
                for (int k = 0; k < num; k++)
                {
                    ulong num4 = this.m_updatedTrees[k];
                    if (num4 != 0uL)
                    {
                        this.m_updatedTrees[k] = 0uL;
                        for (int l = 0; l < 64; l++)
                        {
                            if ((num4 & 1uL << l) != 0uL)
                            {
                                uint num5 = (uint)(k << 6 | l);
                                this.m_trees.m_buffer[(int)((UIntPtr)num5)].UpdateTree(num5);
                                this.UpdateTreeRenderer(num5, true);
                            }
                        }
                    }
                }
            }
        }
        public override void TerrainUpdated(TerrainArea heightArea, TerrainArea surfaceArea, TerrainArea zoneArea)
        {
            float x = surfaceArea.m_min.x;
            float z = surfaceArea.m_min.z;
            float x2 = surfaceArea.m_max.x;
            float z2 = surfaceArea.m_max.z;
            int num = Mathf.Max((int)((x - 8f) / 32f + 270f), 0);
            int num2 = Mathf.Max((int)((z - 8f) / 32f + 270f), 0);
            int num3 = Mathf.Min((int)((x2 + 8f) / 32f + 270f), 539);
            int num4 = Mathf.Min((int)((z2 + 8f) / 32f + 270f), 539);
            for (int i = num2; i <= num4; i++)
            {
                for (int j = num; j <= num3; j++)
                {
                    uint num5 = this.m_treeGrid[i * 540 + j];
                    int num6 = 0;
                    while (num5 != 0u)
                    {
                        Vector3 position = this.m_trees.m_buffer[(int)((UIntPtr)num5)].Position;
                        float num7 = Mathf.Max(Mathf.Max(x - 8f - position.x, z - 8f - position.z), Mathf.Max(position.x - x2 - 8f, position.z - z2 - 8f));
                        if (num7 < 0f)
                        {
                            this.m_trees.m_buffer[(int)((UIntPtr)num5)].TerrainUpdated(num5, x, z, x2, z2);
                        }
                        num5 = this.m_trees.m_buffer[(int)((UIntPtr)num5)].m_nextGridTree;
                        if (++num6 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
        }
        public override void AfterTerrainUpdate(TerrainArea heightArea, TerrainArea surfaceArea, TerrainArea zoneArea)
        {
            float x = heightArea.m_min.x;
            float z = heightArea.m_min.z;
            float x2 = heightArea.m_max.x;
            float z2 = heightArea.m_max.z;
            int num = Mathf.Max((int)((x - 8f) / 32f + 270f), 0);
            int num2 = Mathf.Max((int)((z - 8f) / 32f + 270f), 0);
            int num3 = Mathf.Min((int)((x2 + 8f) / 32f + 270f), 539);
            int num4 = Mathf.Min((int)((z2 + 8f) / 32f + 270f), 539);
            for (int i = num2; i <= num4; i++)
            {
                for (int j = num; j <= num3; j++)
                {
                    uint num5 = this.m_treeGrid[i * 540 + j];
                    int num6 = 0;
                    while (num5 != 0u)
                    {
                        Vector3 position = this.m_trees.m_buffer[(int)((UIntPtr)num5)].Position;
                        float num7 = Mathf.Max(Mathf.Max(x - 8f - position.x, z - 8f - position.z), Mathf.Max(position.x - x2 - 8f, position.z - z2 - 8f));
                        if (num7 < 0f)
                        {
                            this.m_trees.m_buffer[(int)((UIntPtr)num5)].AfterTerrainUpdated(num5, x, z, x2, z2);
                        }
                        num5 = this.m_trees.m_buffer[(int)((UIntPtr)num5)].m_nextGridTree;
                        if (++num6 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
        }
        public void CalculateAreaHeight(float minX, float minZ, float maxX, float maxZ, out int num, out float min, out float avg, out float max)
        {
            int num2 = Mathf.Max((int)((minX - 8f) / 32f + 270f), 0);
            int num3 = Mathf.Max((int)((minZ - 8f) / 32f + 270f), 0);
            int num4 = Mathf.Min((int)((maxX + 8f) / 32f + 270f), 539);
            int num5 = Mathf.Min((int)((maxZ + 8f) / 32f + 270f), 539);
            num = 0;
            min = 1024f;
            avg = 0f;
            max = 0f;
            for (int i = num3; i <= num5; i++)
            {
                for (int j = num2; j <= num4; j++)
                {
                    uint num6 = this.m_treeGrid[i * 540 + j];
                    int num7 = 0;
                    while (num6 != 0u)
                    {
                        Vector3 position = this.m_trees.m_buffer[(int)((UIntPtr)num6)].Position;
                        float num8 = Mathf.Max(Mathf.Max(minX - 8f - position.x, minZ - 8f - position.z), Mathf.Max(position.x - maxX - 8f, position.z - maxZ - 8f));
                        if (num8 < 0f)
                        {
                            TreeInfo info = this.m_trees.m_buffer[(int)((UIntPtr)num6)].Info;
                            if (info != null)
                            {
                                Randomizer randomizer = new Randomizer(num6);
                                float num9 = info.m_minScale + (float)randomizer.Int32(10000u) * (info.m_maxScale - info.m_minScale) * 0.0001f;
                                float num10 = position.y + info.m_generatedInfo.m_size.y * num9 * 2f;
                                if (num10 < min)
                                {
                                    min = num10;
                                }
                                avg += num10;
                                if (num10 > max)
                                {
                                    max = num10;
                                }
                                num++;
                            }
                        }
                        num6 = this.m_trees.m_buffer[(int)((UIntPtr)num6)].m_nextGridTree;
                        if (++num7 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
            if (avg != 0f)
            {
                avg /= (float)num;
            }
        }
        public override bool CalculateGroupData(int groupX, int groupZ, int layer, ref int vertexCount, ref int triangleCount, ref int objectCount, ref RenderGroup.VertexArrays vertexArrays)
        {
            bool result = false;
            if (layer != this.m_treeLayer)
            {
                return result;
            }
            int num = groupX * 540 / 45;
            int num2 = groupZ * 540 / 45;
            int num3 = (groupX + 1) * 540 / 45 - 1;
            int num4 = (groupZ + 1) * 540 / 45 - 1;
            for (int i = num2; i <= num4; i++)
            {
                for (int j = num; j <= num3; j++)
                {
                    int num5 = i * 540 + j;
                    uint num6 = this.m_treeGrid[num5];
                    int num7 = 0;
                    while (num6 != 0u)
                    {
                        if (this.m_trees.m_buffer[(int)((UIntPtr)num6)].CalculateGroupData(num6, layer, ref vertexCount, ref triangleCount, ref objectCount, ref vertexArrays))
                        {
                            result = true;
                        }
                        num6 = this.m_trees.m_buffer[(int)((UIntPtr)num6)].m_nextGridTree;
                        if (++num7 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
            return result;
        }
        public override void PopulateGroupData(int groupX, int groupZ, int layer, ref int vertexIndex, ref int triangleIndex, Vector3 groupPosition, RenderGroup.MeshData data, ref Vector3 min, ref Vector3 max, ref float maxRenderDistance, ref float maxInstanceDistance, ref bool requireSurfaceMaps)
        {
            if (layer != this.m_treeLayer)
            {
                return;
            }
            int num = groupX * 540 / 45;
            int num2 = groupZ * 540 / 45;
            int num3 = (groupX + 1) * 540 / 45 - 1;
            int num4 = (groupZ + 1) * 540 / 45 - 1;
            for (int i = num2; i <= num4; i++)
            {
                for (int j = num; j <= num3; j++)
                {
                    int num5 = i * 540 + j;
                    uint num6 = this.m_treeGrid[num5];
                    int num7 = 0;
                    while (num6 != 0u)
                    {
                        this.m_trees.m_buffer[(int)((UIntPtr)num6)].PopulateGroupData(num6, layer, ref vertexIndex, ref triangleIndex, groupPosition, data, ref min, ref max, ref maxRenderDistance, ref maxInstanceDistance);
                        num6 = this.m_trees.m_buffer[(int)((UIntPtr)num6)].m_nextGridTree;
                        if (++num7 >= 262144)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
        }
        public override void UpdateData(SimulationManager.UpdateMode mode)
        {
            Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.BeginLoading("TreeManager_v2.UpdateData");
            base.UpdateData(mode);
            for (int i = 1; i < 262144; i++)
            {
                if (this.m_trees.m_buffer[i].m_flags != 0 && this.m_trees.m_buffer[i].Info == null)
                {
                    this.ReleaseTree((uint)i);
                }
            }
            int num = PrefabCollection<TreeInfo>.PrefabCount();
            int num2 = 1;
            while (num2 * num2 < num)
            {
                num2++;
            }
            for (int j = 0; j < num; j++)
            {
                TreeInfo prefab = PrefabCollection<TreeInfo>.GetPrefab((uint)j);
                if (prefab != null)
                {
                    prefab.SetRenderParameters(j, num2);
                }
            }
            ThreadHelper.dispatcher.Dispatch(delegate
            {
                this.m_lastShadowRotation = default(Quaternion);
                this.m_lastCameraRotation = default(Quaternion);
            });
            this.m_infoCount = num;
            Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.EndLoading();
        }
        public override void GetData(FastList<IDataContainer> data)
        {
            base.GetData(data);
            data.Add(new TreeManager_v2.Data());
        }
        public virtual string GetName()
        {
            return base.GetName();
        }
        public virtual ThreadProfiler GetSimulationProfiler()
        {
            return base.GetSimulationProfiler();
        }
        public virtual void SimulationStep(int subStep)
        {
            base.SimulationStep(subStep);
        }
        public virtual DrawCallData GetDrawCallData()
        {
            return base.GetDrawCallData();
        }
        public virtual void BeginRendering(RenderManager.CameraInfo cameraInfo)
        {
            base.BeginRendering(cameraInfo);
        }
        public virtual void EndRendering(RenderManager.CameraInfo cameraInfo)
        {
            base.EndRendering(cameraInfo);
        }
        public virtual void BeginOverlay(RenderManager.CameraInfo cameraInfo)
        {
            base.BeginOverlay(cameraInfo);
        }
        public virtual void EndOverlay(RenderManager.CameraInfo cameraInfo)
        {
            base.EndOverlay(cameraInfo);
        }
        public virtual void UndergroundOverlay(RenderManager.CameraInfo cameraInfo)
        {
            base.UndergroundOverlay(cameraInfo);
        }
    }


}
