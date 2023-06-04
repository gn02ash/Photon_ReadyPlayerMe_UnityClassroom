using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ReadyPlayerMe;

using Photon.Pun;

  
        [RequireComponent(typeof(PhotonView))]
    public class ReadyPlayerMeAvatarEditor :  MonoBehaviourPunCallbacks
    {
        private AvatarLoader avatarLoader;
            
        [SerializeField] private AvatarConfig config;
        private Animator animator;
        private PhotonView photonView;
        private Transform leftEye;
        private Transform rightEye;
        private SkinnedMeshRenderer[] skinnedMeshRenderers;
        private const string FULL_BODY_LEFT_EYE_BONE_NAME = "Armature/Hips/Spine/Spine1/Spine2/Neck/Head/LeftEye";
        private const string FULL_BODY_RIGHT_EYE_BONE_NAME = "Armature/Hips/Spine/Spine1/Spine2/Neck/Head/RightEye";

    

        private void Awake()
        {
            animator = GetComponent<Animator>();
            photonView = GetComponent<PhotonView>();
            leftEye = transform.Find(FULL_BODY_LEFT_EYE_BONE_NAME);
            rightEye = transform.Find(FULL_BODY_RIGHT_EYE_BONE_NAME);
            skinnedMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
            
        }
        public void LoadAvatar(string url)
        {
            photonView.RPC("SetPlayer", RpcTarget.AllBuffered, url);
        }

       
            [PunRPC]
        private void SetPlayer(string incomingUrl)
        {
            var loader = new AvatarLoader();  
            loader.LoadAvatar(incomingUrl);
            loader.AvatarConfig = config;
            loader.OnCompleted += (sender, args) =>
            {
                leftEye.transform.localPosition = args.Avatar.transform.Find(FULL_BODY_LEFT_EYE_BONE_NAME).localPosition;
                rightEye.transform.localPosition = args.Avatar.transform.Find(FULL_BODY_RIGHT_EYE_BONE_NAME).localPosition;
                
                TransferMesh(args.Avatar); 
             
            };

        }
        [PunRPC]
        private void TransferMesh(GameObject source)
        {
            Animator sourceAnimator = source.GetComponentInChildren<Animator>();
            SkinnedMeshRenderer[] sourceMeshes = source.GetComponentsInChildren<SkinnedMeshRenderer>();
            for (int i = 0; i < sourceMeshes.Length; i++)
            {
                Mesh mesh = sourceMeshes[i].sharedMesh;
                skinnedMeshRenderers[i].sharedMesh = mesh;
                Material[] materials = sourceMeshes[i].sharedMaterials;
                skinnedMeshRenderers[i].sharedMaterials = materials;
            }
            Avatar avatar = sourceAnimator.avatar;
            animator.avatar = avatar;
            Destroy(source);
        }


        
    }
   

//how to synchronise the player mesh across pun network?
