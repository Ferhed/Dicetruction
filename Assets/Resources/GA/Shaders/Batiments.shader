// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:2,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.3537764,fgcg:0.3352076,fgcb:0.3676471,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9722,x:33100,y:32844,varname:node_9722,prsc:2|diff-8583-OUT,emission-2438-OUT;n:type:ShaderForge.SFN_Tex2d,id:1287,x:32256,y:32616,ptovrint:False,ptlb:BaseTexture,ptin:_BaseTexture,varname:node_1287,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a6a583bbda818d84a9235f22fab6aeef,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9377,x:32193,y:33016,ptovrint:False,ptlb:Emissive,ptin:_Emissive,varname:node_9377,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a45a73599d70b7b4780c7c1511577895,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7409,x:32244,y:32821,ptovrint:False,ptlb:NormalMap,ptin:_NormalMap,varname:node_7409,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2401428f0cc90574a9c85b79d7ebec43,ntxv:3,isnm:True;n:type:ShaderForge.SFN_FragmentPosition,id:4664,x:31763,y:33173,varname:node_4664,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5859,x:32116,y:33285,varname:node_5859,prsc:2|A-4664-Y,B-2344-OUT;n:type:ShaderForge.SFN_Vector1,id:2344,x:31787,y:33436,varname:node_2344,prsc:2,v1:0.01;n:type:ShaderForge.SFN_ConstantClamp,id:2213,x:32437,y:33293,varname:node_2213,prsc:2,min:0,max:1|IN-5859-OUT;n:type:ShaderForge.SFN_Lerp,id:5044,x:32690,y:32738,varname:node_5044,prsc:2|A-1287-RGB,B-8882-OUT,T-2213-OUT;n:type:ShaderForge.SFN_Color,id:1917,x:32276,y:32419,ptovrint:False,ptlb:height color,ptin:_heightcolor,varname:node_1917,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2099899,c2:0,c3:0.7426471,c4:1;n:type:ShaderForge.SFN_Multiply,id:8590,x:32674,y:33006,varname:node_8590,prsc:2|A-9377-R,B-1931-OUT;n:type:ShaderForge.SFN_Slider,id:1931,x:32336,y:33099,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_1931,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:500;n:type:ShaderForge.SFN_Tex2d,id:5023,x:31138,y:34382,varname:node_8309,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-650-UVOUT,TEX-4408-TEX;n:type:ShaderForge.SFN_Multiply,id:7784,x:31514,y:34363,varname:node_7784,prsc:2|A-5023-RGB,B-1872-OUT;n:type:ShaderForge.SFN_Vector3,id:1872,x:31327,y:34539,varname:node_1872,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Panner,id:650,x:30847,y:34403,varname:node_650,prsc:2,spu:0,spv:0;n:type:ShaderForge.SFN_TexCoord,id:3199,x:30207,y:34400,varname:node_3199,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:2199,x:30225,y:34605,varname:node_2199,prsc:2,v1:0.2,v2:0.2;n:type:ShaderForge.SFN_Multiply,id:1209,x:30384,y:34400,varname:node_1209,prsc:2|A-3199-UVOUT,B-2199-OUT;n:type:ShaderForge.SFN_Panner,id:9684,x:30881,y:34877,varname:node_9684,prsc:2,spu:0.05,spv:0.07;n:type:ShaderForge.SFN_TexCoord,id:2383,x:30241,y:34874,varname:node_2383,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:3011,x:30259,y:35079,varname:node_3011,prsc:2,v1:2,v2:2;n:type:ShaderForge.SFN_Multiply,id:4540,x:30418,y:34874,varname:node_4540,prsc:2|A-2383-UVOUT,B-3011-OUT;n:type:ShaderForge.SFN_Tex2d,id:2846,x:31164,y:34863,varname:node_2501,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-9684-UVOUT,TEX-4408-TEX;n:type:ShaderForge.SFN_Multiply,id:4200,x:31528,y:34887,varname:node_4200,prsc:2|A-2846-RGB,B-8902-OUT;n:type:ShaderForge.SFN_Vector3,id:8902,x:31341,y:35063,varname:node_8902,prsc:2,v1:0,v2:0.3,v3:0;n:type:ShaderForge.SFN_Multiply,id:4104,x:31823,y:34392,varname:node_4104,prsc:2|A-7784-OUT,B-4200-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:4408,x:30726,y:34627,ptovrint:False,ptlb:node_4814_copy,ptin:_node_4814_copy,varname:node_4814,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:8882,x:32567,y:32505,varname:node_8882,prsc:2|A-5307-OUT,B-1917-RGB;n:type:ShaderForge.SFN_Slider,id:5307,x:32440,y:32303,ptovrint:False,ptlb:color strenght,ptin:_colorstrenght,varname:node_5307,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:100;n:type:ShaderForge.SFN_Color,id:4504,x:32712,y:33180,ptovrint:False,ptlb:color emissive,ptin:_coloremissive,varname:node_4504,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Tex2d,id:4407,x:31202,y:34446,varname:node_8309,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-5340-UVOUT,TEX-8952-TEX;n:type:ShaderForge.SFN_Multiply,id:1136,x:31578,y:34427,varname:node_1136,prsc:2|A-4407-RGB,B-5221-OUT;n:type:ShaderForge.SFN_Vector3,id:5221,x:31391,y:34603,varname:node_5221,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Panner,id:5340,x:30911,y:34467,varname:node_5340,prsc:2,spu:0,spv:0;n:type:ShaderForge.SFN_TexCoord,id:1629,x:30271,y:34464,varname:node_1629,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:1560,x:30289,y:34669,varname:node_1560,prsc:2,v1:0.2,v2:0.2;n:type:ShaderForge.SFN_Multiply,id:6769,x:30448,y:34464,varname:node_6769,prsc:2|A-1629-UVOUT,B-1560-OUT;n:type:ShaderForge.SFN_Panner,id:2982,x:30945,y:34941,varname:node_2982,prsc:2,spu:0.05,spv:0.07;n:type:ShaderForge.SFN_TexCoord,id:3956,x:30305,y:34938,varname:node_3956,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:552,x:30323,y:35143,varname:node_552,prsc:2,v1:2,v2:2;n:type:ShaderForge.SFN_Multiply,id:2488,x:30482,y:34938,varname:node_2488,prsc:2|A-3956-UVOUT,B-552-OUT;n:type:ShaderForge.SFN_Tex2d,id:8489,x:31228,y:34927,varname:node_2501,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2982-UVOUT,TEX-8952-TEX;n:type:ShaderForge.SFN_Multiply,id:323,x:31592,y:34951,varname:node_323,prsc:2|A-8489-RGB,B-5332-OUT;n:type:ShaderForge.SFN_Vector3,id:5332,x:31405,y:35127,varname:node_5332,prsc:2,v1:0,v2:0.3,v3:0;n:type:ShaderForge.SFN_Multiply,id:8536,x:31887,y:34456,varname:node_8536,prsc:2|A-1136-OUT,B-323-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:8952,x:30790,y:34691,ptovrint:False,ptlb:node_4814_copy_copy,ptin:_node_4814_copy_copy,varname:_node_4814_copy_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2438,x:32901,y:32993,varname:node_2438,prsc:2|A-8590-OUT,B-4504-RGB;n:type:ShaderForge.SFN_Multiply,id:8583,x:32934,y:32727,varname:node_8583,prsc:2|A-3910-OUT,B-5044-OUT;n:type:ShaderForge.SFN_Slider,id:3910,x:32870,y:32495,ptovrint:False,ptlb:black,ptin:_black,varname:node_3910,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9145299,max:10;proporder:7409-9377-1287-1917-1931-5307-4504-3910;pass:END;sub:END;*/

Shader "Shader Forge/Batiments" {
    Properties {
        _NormalMap ("NormalMap", 2D) = "bump" {}
        _Emissive ("Emissive", 2D) = "white" {}
        _BaseTexture ("BaseTexture", 2D) = "white" {}
        _heightcolor ("height color", Color) = (0.2099899,0,0.7426471,1)
        _Emission ("Emission", Range(0, 500)) = 1
        _colorstrenght ("color strenght", Range(0, 100)) = 0
        _coloremissive ("color emissive", Color) = (0.5,0.5,0.5,1)
        _black ("black", Range(0, 10)) = 0.9145299
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _BaseTexture; uniform float4 _BaseTexture_ST;
            uniform sampler2D _Emissive; uniform float4 _Emissive_ST;
            uniform float4 _heightcolor;
            uniform float _Emission;
            uniform float _colorstrenght;
            uniform float4 _coloremissive;
            uniform float _black;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _BaseTexture_var = tex2D(_BaseTexture,TRANSFORM_TEX(i.uv0, _BaseTexture));
                float3 diffuseColor = (_black*lerp(_BaseTexture_var.rgb,(_colorstrenght*_heightcolor.rgb),clamp((i.posWorld.g*0.01),0,1)));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _Emissive_var = tex2D(_Emissive,TRANSFORM_TEX(i.uv0, _Emissive));
                float3 emissive = ((_Emissive_var.r*_Emission)*_coloremissive.rgb);
/// Final Color:
                float3 finalColor = diffuse + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _BaseTexture; uniform float4 _BaseTexture_ST;
            uniform sampler2D _Emissive; uniform float4 _Emissive_ST;
            uniform float4 _heightcolor;
            uniform float _Emission;
            uniform float _colorstrenght;
            uniform float4 _coloremissive;
            uniform float _black;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 _BaseTexture_var = tex2D(_BaseTexture,TRANSFORM_TEX(i.uv0, _BaseTexture));
                float3 diffuseColor = (_black*lerp(_BaseTexture_var.rgb,(_colorstrenght*_heightcolor.rgb),clamp((i.posWorld.g*0.01),0,1)));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
