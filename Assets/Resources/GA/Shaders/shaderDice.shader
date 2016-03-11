// Shader created with Shader Forge v1.25 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.25;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:2,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.3537764,fgcg:0.3352076,fgcb:0.3676471,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9722,x:33100,y:32844,varname:node_9722,prsc:2|diff-4848-RGB,spec-5311-OUT,gloss-6005-OUT,emission-2438-OUT,olwid-1628-OUT,olcol-6967-RGB;n:type:ShaderForge.SFN_Tex2d,id:9377,x:31341,y:33031,ptovrint:False,ptlb:Emissive,ptin:_Emissive,varname:node_9377,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a45a73599d70b7b4780c7c1511577895,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7409,x:31392,y:32836,ptovrint:False,ptlb:NormalMap,ptin:_NormalMap,varname:node_7409,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2401428f0cc90574a9c85b79d7ebec43,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Color,id:1917,x:32276,y:32419,ptovrint:False,ptlb:height color,ptin:_heightcolor,varname:node_1917,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2099899,c2:0,c3:0.7426471,c4:1;n:type:ShaderForge.SFN_Multiply,id:8590,x:31822,y:33021,varname:node_8590,prsc:2|A-9377-R,B-1931-OUT;n:type:ShaderForge.SFN_Slider,id:1931,x:31484,y:33114,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_1931,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:500;n:type:ShaderForge.SFN_Tex2d,id:5023,x:31138,y:34382,varname:node_8309,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-650-UVOUT,TEX-4408-TEX;n:type:ShaderForge.SFN_Multiply,id:7784,x:31514,y:34363,varname:node_7784,prsc:2|A-5023-RGB,B-1872-OUT;n:type:ShaderForge.SFN_Vector3,id:1872,x:31327,y:34539,varname:node_1872,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Panner,id:650,x:30847,y:34403,varname:node_650,prsc:2,spu:0,spv:0;n:type:ShaderForge.SFN_TexCoord,id:3199,x:30207,y:34400,varname:node_3199,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:2199,x:30225,y:34605,varname:node_2199,prsc:2,v1:0.2,v2:0.2;n:type:ShaderForge.SFN_Multiply,id:1209,x:30384,y:34400,varname:node_1209,prsc:2|A-3199-UVOUT,B-2199-OUT;n:type:ShaderForge.SFN_Panner,id:9684,x:30881,y:34877,varname:node_9684,prsc:2,spu:0.05,spv:0.07;n:type:ShaderForge.SFN_TexCoord,id:2383,x:30241,y:34874,varname:node_2383,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:3011,x:30259,y:35079,varname:node_3011,prsc:2,v1:2,v2:2;n:type:ShaderForge.SFN_Multiply,id:4540,x:30418,y:34874,varname:node_4540,prsc:2|A-2383-UVOUT,B-3011-OUT;n:type:ShaderForge.SFN_Tex2d,id:2846,x:31164,y:34863,varname:node_2501,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-9684-UVOUT,TEX-4408-TEX;n:type:ShaderForge.SFN_Multiply,id:4200,x:31528,y:34887,varname:node_4200,prsc:2|A-2846-RGB,B-8902-OUT;n:type:ShaderForge.SFN_Vector3,id:8902,x:31341,y:35063,varname:node_8902,prsc:2,v1:0,v2:0.3,v3:0;n:type:ShaderForge.SFN_Multiply,id:4104,x:31823,y:34392,varname:node_4104,prsc:2|A-7784-OUT,B-4200-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:4408,x:30726,y:34627,ptovrint:False,ptlb:node_4814_copy,ptin:_node_4814_copy,varname:node_4814,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:4504,x:31860,y:33195,ptovrint:False,ptlb:color emissive,ptin:_coloremissive,varname:node_4504,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Tex2d,id:4407,x:31202,y:34446,varname:node_8309,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-5340-UVOUT,TEX-8952-TEX;n:type:ShaderForge.SFN_Multiply,id:1136,x:31578,y:34427,varname:node_1136,prsc:2|A-4407-RGB,B-5221-OUT;n:type:ShaderForge.SFN_Vector3,id:5221,x:31391,y:34603,varname:node_5221,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Panner,id:5340,x:30911,y:34467,varname:node_5340,prsc:2,spu:0,spv:0;n:type:ShaderForge.SFN_TexCoord,id:1629,x:30271,y:34464,varname:node_1629,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:1560,x:30289,y:34669,varname:node_1560,prsc:2,v1:0.2,v2:0.2;n:type:ShaderForge.SFN_Multiply,id:6769,x:30448,y:34464,varname:node_6769,prsc:2|A-1629-UVOUT,B-1560-OUT;n:type:ShaderForge.SFN_Panner,id:2982,x:30945,y:34941,varname:node_2982,prsc:2,spu:0.05,spv:0.07;n:type:ShaderForge.SFN_TexCoord,id:3956,x:30305,y:34938,varname:node_3956,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector2,id:552,x:30323,y:35143,varname:node_552,prsc:2,v1:2,v2:2;n:type:ShaderForge.SFN_Multiply,id:2488,x:30482,y:34938,varname:node_2488,prsc:2|A-3956-UVOUT,B-552-OUT;n:type:ShaderForge.SFN_Tex2d,id:8489,x:31228,y:34927,varname:node_2501,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2982-UVOUT,TEX-8952-TEX;n:type:ShaderForge.SFN_Multiply,id:323,x:31592,y:34951,varname:node_323,prsc:2|A-8489-RGB,B-5332-OUT;n:type:ShaderForge.SFN_Vector3,id:5332,x:31405,y:35127,varname:node_5332,prsc:2,v1:0,v2:0.3,v3:0;n:type:ShaderForge.SFN_Multiply,id:8536,x:31887,y:34456,varname:node_8536,prsc:2|A-1136-OUT,B-323-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:8952,x:30790,y:34691,ptovrint:False,ptlb:node_4814_copy_copy,ptin:_node_4814_copy_copy,varname:_node_4814_copy_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2438,x:32049,y:33008,varname:node_2438,prsc:2|A-8590-OUT,B-4504-RGB;n:type:ShaderForge.SFN_Tex2d,id:7210,x:32460,y:32379,ptovrint:False,ptlb:specular,ptin:_specular,varname:node_7210,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2672,x:31582,y:32771,ptovrint:False,ptlb:metal,ptin:_metal,varname:node_2672,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:4848,x:32858,y:32434,ptovrint:False,ptlb:color dice,ptin:_colordice,varname:node_4848,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Slider,id:7275,x:32421,y:32611,ptovrint:False,ptlb:spec,ptin:_spec,varname:node_7275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:5311,x:32718,y:32472,varname:node_5311,prsc:2|A-7210-RGB,B-7275-OUT;n:type:ShaderForge.SFN_Slider,id:5584,x:31504,y:33006,ptovrint:False,ptlb:metal power,ptin:_metalpower,varname:node_5584,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:6005,x:31853,y:32777,varname:node_6005,prsc:2|A-2672-R,B-5584-OUT;n:type:ShaderForge.SFN_Slider,id:6360,x:32088,y:33385,ptovrint:False,ptlb:OutlineWidth,ptin:_OutlineWidth,varname:node_2111,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.02002229,max:1;n:type:ShaderForge.SFN_Color,id:6967,x:32549,y:33373,ptovrint:False,ptlb:OutlineColor,ptin:_OutlineColor,varname:node_4663,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_FragmentPosition,id:4061,x:32153,y:33068,varname:node_4061,prsc:2;n:type:ShaderForge.SFN_Distance,id:2876,x:32352,y:33100,varname:node_2876,prsc:2|A-4061-XYZ,B-4424-XYZ;n:type:ShaderForge.SFN_ViewPosition,id:4424,x:32153,y:33190,varname:node_4424,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1628,x:32615,y:33147,varname:node_1628,prsc:2|A-2876-OUT,B-6360-OUT;proporder:7409-9377-1917-1931-4504-7210-2672-4848-7275-5584-6360-6967;pass:END;sub:END;*/

Shader "Shader Forge/Batiments" {
    Properties {
        _NormalMap ("NormalMap", 2D) = "bump" {}
        _Emissive ("Emissive", 2D) = "white" {}
        _heightcolor ("height color", Color) = (0.2099899,0,0.7426471,1)
        _Emission ("Emission", Range(0, 500)) = 1
        _coloremissive ("color emissive", Color) = (0.5,0.5,0.5,1)
        _specular ("specular", 2D) = "white" {}
        _metal ("metal", 2D) = "white" {}
        _colordice ("color dice", Color) = (0.5,0.5,0.5,1)
        _spec ("spec", Range(0, 1)) = 0
        _metalpower ("metal power", Range(0, 1)) = 0
        _OutlineWidth ("OutlineWidth", Range(0, 1)) = 0.02002229
        _OutlineColor ("OutlineColor", Color) = (1,1,1,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float _OutlineWidth;
            uniform float4 _OutlineColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + normalize(v.vertex)*(distance(mul(_Object2World, v.vertex).rgb,_WorldSpaceCameraPos)*_OutlineWidth),1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_OutlineColor.rgb,0);
            }
            ENDCG
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
            uniform sampler2D _Emissive; uniform float4 _Emissive_ST;
            uniform float _Emission;
            uniform float4 _coloremissive;
            uniform sampler2D _specular; uniform float4 _specular_ST;
            uniform sampler2D _metal; uniform float4 _metal_ST;
            uniform float4 _colordice;
            uniform float _spec;
            uniform float _metalpower;
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
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float4 _metal_var = tex2D(_metal,TRANSFORM_TEX(i.uv0, _metal));
                float gloss = (_metal_var.r*_metalpower);
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float4 _specular_var = tex2D(_specular,TRANSFORM_TEX(i.uv0, _specular));
                float3 specularColor = (_specular_var.rgb*_spec);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = _colordice.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _Emissive_var = tex2D(_Emissive,TRANSFORM_TEX(i.uv0, _Emissive));
                float3 emissive = ((_Emissive_var.r*_Emission)*_coloremissive.rgb);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
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
            uniform sampler2D _Emissive; uniform float4 _Emissive_ST;
            uniform float _Emission;
            uniform float4 _coloremissive;
            uniform sampler2D _specular; uniform float4 _specular_ST;
            uniform sampler2D _metal; uniform float4 _metal_ST;
            uniform float4 _colordice;
            uniform float _spec;
            uniform float _metalpower;
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
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float4 _metal_var = tex2D(_metal,TRANSFORM_TEX(i.uv0, _metal));
                float gloss = (_metal_var.r*_metalpower);
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float4 _specular_var = tex2D(_specular,TRANSFORM_TEX(i.uv0, _specular));
                float3 specularColor = (_specular_var.rgb*_spec);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuseColor = _colordice.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
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
