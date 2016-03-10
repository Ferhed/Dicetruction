// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:8272,x:33130,y:32708,varname:node_8272,prsc:2|diff-4241-OUT,spec-2115-OUT,gloss-6866-OUT,normal-2905-OUT,voffset-6604-OUT,tess-5337-OUT;n:type:ShaderForge.SFN_Color,id:1707,x:32110,y:32294,ptovrint:False,ptlb:WaterColor,ptin:_WaterColor,varname:node_1707,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.116631,c2:0.3308824,c3:0.05595804,c4:1;n:type:ShaderForge.SFN_TexCoord,id:6368,x:31522,y:32952,varname:node_6368,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:9702,x:31710,y:32952,varname:node_9702,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6368-UVOUT;n:type:ShaderForge.SFN_Tau,id:6617,x:31935,y:33084,varname:node_6617,prsc:2;n:type:ShaderForge.SFN_Vector1,id:7697,x:31902,y:32900,varname:node_7697,prsc:2,v1:3;n:type:ShaderForge.SFN_Multiply,id:3297,x:32079,y:32955,varname:node_3297,prsc:2|A-7697-OUT,B-7562-OUT,C-6617-OUT;n:type:ShaderForge.SFN_Sin,id:6915,x:32246,y:32955,varname:node_6915,prsc:2|IN-3297-OUT;n:type:ShaderForge.SFN_RemapRange,id:7487,x:32407,y:32955,varname:node_7487,prsc:2,frmn:0,frmx:1,tomn:0,tomx:1|IN-6915-OUT;n:type:ShaderForge.SFN_Add,id:7562,x:31902,y:32955,varname:node_7562,prsc:2|A-9702-OUT,B-2222-TSL;n:type:ShaderForge.SFN_Time,id:2222,x:31710,y:33095,varname:node_2222,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:7581,x:32297,y:33108,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:6604,x:32640,y:33110,varname:node_6604,prsc:2|A-7487-OUT,B-7581-OUT,C-6722-OUT,D-85-R,E-2780-OUT;n:type:ShaderForge.SFN_Slider,id:5337,x:32713,y:33269,ptovrint:False,ptlb:TessellationAmount,ptin:_TessellationAmount,varname:node_5337,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3.12873,max:10;n:type:ShaderForge.SFN_Tex2d,id:8632,x:32375,y:33490,ptovrint:False,ptlb:NormalWaves,ptin:_NormalWaves,varname:node_8632,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e958c6041cfe445e987c73751e8d4082,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:6722,x:32218,y:33398,ptovrint:False,ptlb:NormalAmount,ptin:_NormalAmount,varname:node_6722,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.282051,max:10;n:type:ShaderForge.SFN_Vector1,id:2115,x:32607,y:32483,varname:node_2115,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:6866,x:32607,y:32531,varname:node_6866,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:85,x:32533,y:32761,ptovrint:False,ptlb:NormalTexture,ptin:_NormalTexture,varname:node_85,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:eafb8ae15e208b94e8dadaf3fe812d1c,ntxv:3,isnm:False|UVIN-6662-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:4854,x:32215,y:32761,varname:node_4854,prsc:2,uv:0;n:type:ShaderForge.SFN_Panner,id:6662,x:32373,y:32761,varname:node_6662,prsc:2,spu:0.05,spv:0.025|UVIN-4854-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:4929,x:32215,y:32593,ptovrint:False,ptlb:NormalTexture_Large,ptin:_NormalTexture_Large,varname:_NormalTexture_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:eafb8ae15e208b94e8dadaf3fe812d1c,ntxv:3,isnm:False|UVIN-5229-UVOUT;n:type:ShaderForge.SFN_Multiply,id:2905,x:32725,y:32761,varname:node_2905,prsc:2|A-4929-RGB,B-85-RGB;n:type:ShaderForge.SFN_TexCoord,id:4438,x:31868,y:32593,varname:node_4438,prsc:2,uv:0;n:type:ShaderForge.SFN_Panner,id:5229,x:32045,y:32593,varname:node_5229,prsc:2,spu:0.05,spv:0.05|UVIN-4438-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:4005,x:31994,y:33257,ptovrint:False,ptlb:NormalNoise,ptin:_NormalNoise,varname:node_4005,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e958c6041cfe445e987c73751e8d4082,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2780,x:32297,y:33257,varname:node_2780,prsc:2|A-4005-RGB,B-7159-OUT;n:type:ShaderForge.SFN_Vector1,id:7159,x:31994,y:33418,varname:node_7159,prsc:2,v1:1.5;n:type:ShaderForge.SFN_Multiply,id:4241,x:32607,y:32302,varname:node_4241,prsc:2|A-9125-OUT,B-1707-RGB;n:type:ShaderForge.SFN_Slider,id:9125,x:32165,y:32052,ptovrint:False,ptlb:color,ptin:_color,varname:node_9125,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:5337-8632-1707-6722-85-4929-4005-9125;pass:END;sub:END;*/

Shader "Custom/S_Water" {
    Properties {
        _TessellationAmount ("TessellationAmount", Range(0, 10)) = 3.12873
        _NormalWaves ("NormalWaves", 2D) = "white" {}
        _WaterColor ("WaterColor", Color) = (0.116631,0.3308824,0.05595804,1)
        _NormalAmount ("NormalAmount", Range(0, 10)) = 1.282051
        _NormalTexture ("NormalTexture", 2D) = "bump" {}
        _NormalTexture_Large ("NormalTexture_Large", 2D) = "bump" {}
        _NormalNoise ("NormalNoise", 2D) = "white" {}
        _color ("color", Range(0, 1)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform float4 _WaterColor;
            uniform float _TessellationAmount;
            uniform float _NormalAmount;
            uniform sampler2D _NormalTexture; uniform float4 _NormalTexture_ST;
            uniform sampler2D _NormalTexture_Large; uniform float4 _NormalTexture_Large_ST;
            uniform sampler2D _NormalNoise; uniform float4 _NormalNoise_ST;
            uniform float _color;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_2222 = _Time + _TimeEditor;
                float4 node_1641 = _Time + _TimeEditor;
                float2 node_6662 = (o.uv0+node_1641.g*float2(0.05,0.025));
                float4 _NormalTexture_var = tex2Dlod(_NormalTexture,float4(TRANSFORM_TEX(node_6662, _NormalTexture),0.0,0));
                float4 _NormalNoise_var = tex2Dlod(_NormalNoise,float4(TRANSFORM_TEX(o.uv0, _NormalNoise),0.0,0));
                v.vertex.xyz += ((sin((3.0*(o.uv0.r+node_2222.r)*6.28318530718))*1.0+0.0)*v.normal*_NormalAmount*_NormalTexture_var.r*(_NormalNoise_var.rgb*1.5));
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _TessellationAmount;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_1641 = _Time + _TimeEditor;
                float2 node_5229 = (i.uv0+node_1641.g*float2(0.05,0.05));
                float4 _NormalTexture_Large_var = tex2D(_NormalTexture_Large,TRANSFORM_TEX(node_5229, _NormalTexture_Large));
                float2 node_6662 = (i.uv0+node_1641.g*float2(0.05,0.025));
                float4 _NormalTexture_var = tex2D(_NormalTexture,TRANSFORM_TEX(node_6662, _NormalTexture));
                float3 normalLocal = (_NormalTexture_Large_var.rgb*_NormalTexture_var.rgb);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_2115 = 1.0;
                float3 specularColor = float3(node_2115,node_2115,node_2115);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = (_color*_WaterColor.rgb);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
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
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform float4 _WaterColor;
            uniform float _TessellationAmount;
            uniform float _NormalAmount;
            uniform sampler2D _NormalTexture; uniform float4 _NormalTexture_ST;
            uniform sampler2D _NormalTexture_Large; uniform float4 _NormalTexture_Large_ST;
            uniform sampler2D _NormalNoise; uniform float4 _NormalNoise_ST;
            uniform float _color;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_2222 = _Time + _TimeEditor;
                float4 node_3906 = _Time + _TimeEditor;
                float2 node_6662 = (o.uv0+node_3906.g*float2(0.05,0.025));
                float4 _NormalTexture_var = tex2Dlod(_NormalTexture,float4(TRANSFORM_TEX(node_6662, _NormalTexture),0.0,0));
                float4 _NormalNoise_var = tex2Dlod(_NormalNoise,float4(TRANSFORM_TEX(o.uv0, _NormalNoise),0.0,0));
                v.vertex.xyz += ((sin((3.0*(o.uv0.r+node_2222.r)*6.28318530718))*1.0+0.0)*v.normal*_NormalAmount*_NormalTexture_var.r*(_NormalNoise_var.rgb*1.5));
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _TessellationAmount;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_3906 = _Time + _TimeEditor;
                float2 node_5229 = (i.uv0+node_3906.g*float2(0.05,0.05));
                float4 _NormalTexture_Large_var = tex2D(_NormalTexture_Large,TRANSFORM_TEX(node_5229, _NormalTexture_Large));
                float2 node_6662 = (i.uv0+node_3906.g*float2(0.05,0.025));
                float4 _NormalTexture_var = tex2D(_NormalTexture,TRANSFORM_TEX(node_6662, _NormalTexture));
                float3 normalLocal = (_NormalTexture_Large_var.rgb*_NormalTexture_var.rgb);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_2115 = 1.0;
                float3 specularColor = float3(node_2115,node_2115,node_2115);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuseColor = (_color*_WaterColor.rgb);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _TessellationAmount;
            uniform float _NormalAmount;
            uniform sampler2D _NormalTexture; uniform float4 _NormalTexture_ST;
            uniform sampler2D _NormalNoise; uniform float4 _NormalNoise_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_2222 = _Time + _TimeEditor;
                float4 node_2415 = _Time + _TimeEditor;
                float2 node_6662 = (o.uv0+node_2415.g*float2(0.05,0.025));
                float4 _NormalTexture_var = tex2Dlod(_NormalTexture,float4(TRANSFORM_TEX(node_6662, _NormalTexture),0.0,0));
                float4 _NormalNoise_var = tex2Dlod(_NormalNoise,float4(TRANSFORM_TEX(o.uv0, _NormalNoise),0.0,0));
                v.vertex.xyz += ((sin((3.0*(o.uv0.r+node_2222.r)*6.28318530718))*1.0+0.0)*v.normal*_NormalAmount*_NormalTexture_var.r*(_NormalNoise_var.rgb*1.5));
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _TessellationAmount;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
