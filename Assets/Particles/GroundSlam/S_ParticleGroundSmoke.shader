// Upgrade NOTE: commented out 'float4 unity_DynamicLightmapST', a built-in variable
// Upgrade NOTE: commented out 'float4 unity_LightmapST', a built-in variable

// Shader created with Shader Forge v1.03 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.03;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:1,uamb:True,mssp:True,lmpd:False,lprd:False,rprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:1,bsrc:3,bdst:7,culm:0,dpts:2,wrdp:False,dith:2,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:2080,x:34051,y:32662,varname:node_2080,prsc:2|diff-9721-OUT,lwrap-1947-OUT,amdfl-1947-OUT,alpha-3501-OUT;n:type:ShaderForge.SFN_Color,id:7552,x:32099,y:32174,ptovrint:False,ptlb:SmokeColor,ptin:_SmokeColor,varname:node_7552,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_VertexColor,id:9658,x:32099,y:32327,varname:node_9658,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5566,x:33401,y:33015,varname:node_5566,prsc:2|A-448-OUT,B-4883-OUT;n:type:ShaderForge.SFN_Multiply,id:4154,x:32704,y:32448,varname:node_4154,prsc:2|A-7552-RGB,B-9658-RGB;n:type:ShaderForge.SFN_DepthBlend,id:986,x:33401,y:33151,varname:node_986,prsc:2|DIST-8898-OUT;n:type:ShaderForge.SFN_Slider,id:8898,x:33065,y:33139,ptovrint:False,ptlb:node_8898,ptin:_node_8898,varname:node_8898,prsc:2,min:0,cur:0.7203244,max:5;n:type:ShaderForge.SFN_Multiply,id:3501,x:33655,y:32988,varname:node_3501,prsc:2|A-5566-OUT,B-986-OUT;n:type:ShaderForge.SFN_NormalVector,id:1542,x:32381,y:32610,prsc:2,pt:False;n:type:ShaderForge.SFN_LightVector,id:1496,x:32381,y:32757,varname:node_1496,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:3846,x:32381,y:32881,varname:node_3846,prsc:2;n:type:ShaderForge.SFN_Dot,id:4920,x:32570,y:32656,varname:node_4920,prsc:2,dt:0|A-1542-OUT,B-1496-OUT;n:type:ShaderForge.SFN_Dot,id:349,x:32570,y:32797,varname:node_349,prsc:2,dt:0|A-1496-OUT,B-3846-OUT;n:type:ShaderForge.SFN_Multiply,id:4108,x:32758,y:32656,varname:node_4108,prsc:2|A-5558-RGB,B-4920-OUT;n:type:ShaderForge.SFN_Color,id:5558,x:32381,y:32471,ptovrint:False,ptlb:Specular Color,ptin:_SpecularColor,varname:node_5558,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:6278,x:33216,y:32735,varname:node_6278,prsc:2|A-5540-OUT,B-8144-RGB,C-645-OUT,D-4740-OUT;n:type:ShaderForge.SFN_LightColor,id:8144,x:32866,y:32818,varname:node_8144,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:645,x:32998,y:32856,varname:node_645,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5540,x:32965,y:32656,varname:node_5540,prsc:2|A-4108-OUT,B-280-OUT;n:type:ShaderForge.SFN_Posterize,id:1989,x:33401,y:32735,varname:node_1989,prsc:2|IN-6278-OUT,STPS-3155-OUT;n:type:ShaderForge.SFN_Vector1,id:3155,x:33216,y:32858,varname:node_3155,prsc:2,v1:2;n:type:ShaderForge.SFN_ConstantClamp,id:280,x:32758,y:32780,varname:node_280,prsc:2,min:0.5,max:1|IN-349-OUT;n:type:ShaderForge.SFN_Vector1,id:4740,x:32998,y:32974,varname:node_4740,prsc:2,v1:4;n:type:ShaderForge.SFN_ConstantClamp,id:7160,x:33568,y:32735,varname:node_7160,prsc:2,min:0,max:1|IN-1989-OUT;n:type:ShaderForge.SFN_Desaturate,id:7409,x:33736,y:32735,varname:node_7409,prsc:2|COL-7160-OUT;n:type:ShaderForge.SFN_Relay,id:9721,x:33705,y:32629,varname:node_9721,prsc:2|IN-4154-OUT;n:type:ShaderForge.SFN_Relay,id:448,x:32315,y:33038,varname:node_448,prsc:2|IN-7552-A;n:type:ShaderForge.SFN_Relay,id:4883,x:32317,y:33097,varname:node_4883,prsc:2|IN-9658-A;n:type:ShaderForge.SFN_ConstantClamp,id:1947,x:33872,y:32783,varname:node_1947,prsc:2,min:0.75,max:1|IN-7409-OUT;proporder:7552-8898-5558;pass:END;sub:END;*/

Shader "Custom/S_ParticleGroundSmoke" {
    Properties {
        _SmokeColor ("SmokeColor", Color) = (0.5,0.5,0.5,1)
        _node_8898 ("node_8898", Range(0, 5)) = 0.7203244
        _SpecularColor ("Specular Color", Color) = (0.5,0.5,0.5,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            // Dithering function, to use with scene UVs (screen pixel coords)
            // 3x3 Bayer matrix, based on https://en.wikipedia.org/wiki/Ordered_dithering
            float BinaryDither3x3( float value, float2 sceneUVs ) {
                float3x3 mtx = float3x3(
                    float3( 3,  7,  4 )/10.0,
                    float3( 6,  1,  9 )/10.0,
                    float3( 2,  8,  5 )/10.0
                );
                float2 px = floor(_ScreenParams.xy * sceneUVs);
                int xSmp = fmod(px.x,3);
                int ySmp = fmod(px.y,3);
                float3 xVec = 1-saturate(abs(float3(0,1,2) - xSmp));
                float3 yVec = 1-saturate(abs(float3(0,1,2) - ySmp));
                float3 pxMult = float3( dot(mtx[0],yVec), dot(mtx[1],yVec), dot(mtx[2],yVec) );
                return round(value + dot(pxMult, xVec));
            }
            uniform sampler2D _CameraDepthTexture;
            // float4 unity_LightmapST;
            #ifdef DYNAMICLIGHTMAP_ON
                // float4 unity_DynamicLightmapST;
            #endif
            uniform float4 _SmokeColor;
            uniform float _node_8898;
            uniform float4 _SpecularColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float4 screenPos : TEXCOORD2;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD3;
                UNITY_FOG_COORDS(4)
                #ifndef LIGHTMAP_OFF
                    float4 uvLM : TEXCOORD5;
                #else
                    float3 shLight : TEXCOORD5;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.vertexColor = v.vertexColor;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                o.screenPos = o.pos;
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5;
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = dot( normalDirection, lightDirection );
                float node_3155 = 2.0;
                float node_1947 = clamp(dot(clamp(floor((((_SpecularColor.rgb*dot(i.normalDir,lightDirection))*clamp(dot(lightDirection,viewReflectDirection),0.5,1))*_LightColor0.rgb*attenuation*4.0) * node_3155) / (node_3155 - 1),0,1),float3(0.3,0.59,0.11)),0.75,1);
                float3 w = float3(node_1947,node_1947,node_1947)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 indirectDiffuse = float3(0,0,0);
                float3 directDiffuse = forwardLight * attenColor;
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                indirectDiffuse += float3(node_1947,node_1947,node_1947); // Diffuse Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * (_SmokeColor.rgb*i.vertexColor.rgb);
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor,((_SmokeColor.a*i.vertexColor.a)*saturate((sceneZ-partZ)/_node_8898)));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ForwardAdd"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            // Dithering function, to use with scene UVs (screen pixel coords)
            // 3x3 Bayer matrix, based on https://en.wikipedia.org/wiki/Ordered_dithering
            float BinaryDither3x3( float value, float2 sceneUVs ) {
                float3x3 mtx = float3x3(
                    float3( 3,  7,  4 )/10.0,
                    float3( 6,  1,  9 )/10.0,
                    float3( 2,  8,  5 )/10.0
                );
                float2 px = floor(_ScreenParams.xy * sceneUVs);
                int xSmp = fmod(px.x,3);
                int ySmp = fmod(px.y,3);
                float3 xVec = 1-saturate(abs(float3(0,1,2) - xSmp));
                float3 yVec = 1-saturate(abs(float3(0,1,2) - ySmp));
                float3 pxMult = float3( dot(mtx[0],yVec), dot(mtx[1],yVec), dot(mtx[2],yVec) );
                return round(value + dot(pxMult, xVec));
            }
            uniform sampler2D _CameraDepthTexture;
            // float4 unity_LightmapST;
            #ifdef DYNAMICLIGHTMAP_ON
                // float4 unity_DynamicLightmapST;
            #endif
            uniform float4 _SmokeColor;
            uniform float _node_8898;
            uniform float4 _SpecularColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float4 screenPos : TEXCOORD2;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                #ifndef LIGHTMAP_OFF
                    float4 uvLM : TEXCOORD6;
                #else
                    float3 shLight : TEXCOORD6;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.vertexColor = v.vertexColor;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                o.screenPos = o.pos;
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5;
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = dot( normalDirection, lightDirection );
                float node_3155 = 2.0;
                float node_1947 = clamp(dot(clamp(floor((((_SpecularColor.rgb*dot(i.normalDir,lightDirection))*clamp(dot(lightDirection,viewReflectDirection),0.5,1))*_LightColor0.rgb*attenuation*4.0) * node_3155) / (node_3155 - 1),0,1),float3(0.3,0.59,0.11)),0.75,1);
                float3 w = float3(node_1947,node_1947,node_1947)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 directDiffuse = forwardLight * attenColor;
                float3 diffuse = directDiffuse * (_SmokeColor.rgb*i.vertexColor.rgb);
/// Final Color:
                float3 finalColor = diffuse;
                return fixed4(finalColor * ((_SmokeColor.a*i.vertexColor.a)*saturate((sceneZ-partZ)/_node_8898)),0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
