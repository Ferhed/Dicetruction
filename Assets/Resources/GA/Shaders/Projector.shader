// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33545,y:32685,varname:node_3138,prsc:2|emission-3549-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32556,y:32865,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_Tex2d,id:9975,x:32581,y:32633,ptovrint:False,ptlb:node_9975,ptin:_node_9975,varname:node_9975,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2c29c08dd1c0b6749b7cd0fcff7a29fd,ntxv:0,isnm:False|UVIN-5118-OUT;n:type:ShaderForge.SFN_Multiply,id:3460,x:32883,y:32842,varname:node_3460,prsc:2|A-7241-RGB,B-9975-RGB;n:type:ShaderForge.SFN_ViewVector,id:8417,x:31133,y:32835,varname:node_8417,prsc:2;n:type:ShaderForge.SFN_SceneDepth,id:9762,x:30887,y:32885,varname:node_9762,prsc:2;n:type:ShaderForge.SFN_Depth,id:5907,x:30875,y:33079,varname:node_5907,prsc:2;n:type:ShaderForge.SFN_Subtract,id:1909,x:31133,y:33018,varname:node_1909,prsc:2|A-9762-OUT,B-5907-OUT;n:type:ShaderForge.SFN_Multiply,id:1797,x:31338,y:32919,varname:node_1797,prsc:2|A-8417-OUT,B-1909-OUT;n:type:ShaderForge.SFN_Subtract,id:3786,x:31587,y:32838,varname:node_3786,prsc:2|A-9735-XYZ,B-1797-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:9735,x:31366,y:32705,varname:node_9735,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:7238,x:31544,y:33021,varname:node_7238,prsc:2;n:type:ShaderForge.SFN_Subtract,id:8111,x:31797,y:32911,varname:node_8111,prsc:2|A-3786-OUT,B-7238-XYZ;n:type:ShaderForge.SFN_Transform,id:4682,x:31988,y:32911,varname:node_4682,prsc:2,tffrom:0,tfto:1|IN-8111-OUT;n:type:ShaderForge.SFN_ComponentMask,id:5551,x:32170,y:32911,varname:node_5551,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-4682-XYZ;n:type:ShaderForge.SFN_Add,id:5118,x:32341,y:32753,varname:node_5118,prsc:2|A-9084-OUT,B-5551-OUT;n:type:ShaderForge.SFN_Vector1,id:9084,x:32116,y:32746,varname:node_9084,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Abs,id:5976,x:32396,y:33122,varname:node_5976,prsc:2|IN-5551-OUT;n:type:ShaderForge.SFN_Step,id:1474,x:32613,y:33176,varname:node_1474,prsc:2|A-5976-OUT,B-7584-OUT;n:type:ShaderForge.SFN_Vector1,id:7584,x:32385,y:33296,varname:node_7584,prsc:2,v1:0.5;n:type:ShaderForge.SFN_ComponentMask,id:2621,x:32783,y:33187,varname:node_2621,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-1474-OUT;n:type:ShaderForge.SFN_Multiply,id:3819,x:33044,y:33158,varname:node_3819,prsc:2|A-2621-R,B-2621-G;n:type:ShaderForge.SFN_Multiply,id:3549,x:33262,y:32889,varname:node_3549,prsc:2|A-3460-OUT,B-3819-OUT;proporder:7241-9975;pass:END;sub:END;*/

Shader "Shader Forge/Projector" {
    Properties {
        _Color ("Color", Color) = (0.07843138,0.3921569,0.7843137,1)
        _node_9975 ("node_9975", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _Color;
            uniform sampler2D _node_9975; uniform float4 _node_9975_ST;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float4 projPos : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
////// Lighting:
////// Emissive:
                float2 node_5551 = mul( _World2Object, float4(((i.posWorld.rgb-(viewDirection*(sceneZ-partZ)))-objPos.rgb),0) ).xyz.rgb.rg;
                float2 node_5118 = (0.5+node_5551);
                float4 _node_9975_var = tex2D(_node_9975,TRANSFORM_TEX(node_5118, _node_9975));
                float2 node_2621 = step(abs(node_5551),0.5).rg;
                float3 emissive = ((_Color.rgb*_node_9975_var.rgb)*(node_2621.r*node_2621.g));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
