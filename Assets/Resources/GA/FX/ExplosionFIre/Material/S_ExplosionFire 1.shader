// Shader created with Shader Forge v1.25 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.25;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:6404,x:32852,y:32700,varname:node_6404,prsc:2|emission-3154-OUT,alpha-1199-OUT;n:type:ShaderForge.SFN_VertexColor,id:949,x:31959,y:32901,varname:node_949,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:3164,x:31959,y:32744,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_3164,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2943,x:31959,y:33050,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_2943,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:9439,x:32444,y:32722,varname:node_9439,prsc:2|A-7830-OUT,B-949-RGB;n:type:ShaderForge.SFN_Multiply,id:4470,x:32286,y:32997,varname:node_4470,prsc:2|A-949-A,B-2943-A;n:type:ShaderForge.SFN_Desaturate,id:7830,x:32227,y:32708,varname:node_7830,prsc:2|COL-3164-RGB;n:type:ShaderForge.SFN_ConstantClamp,id:1199,x:32474,y:32997,varname:node_1199,prsc:2,min:0,max:0.5|IN-4470-OUT;n:type:ShaderForge.SFN_Multiply,id:3154,x:32630,y:32796,varname:node_3154,prsc:2|A-9439-OUT,B-4873-OUT;n:type:ShaderForge.SFN_Slider,id:4873,x:32313,y:32880,ptovrint:False,ptlb:Emissive,ptin:_Emissive,varname:node_4873,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;proporder:2943-3164-4873;pass:END;sub:END;*/

Shader "Unlit/S_ExplosionFire" {
    Properties {
        _Alpha ("Alpha", 2D) = "white" {}
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Emissive ("Emissive", Range(0, 10)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 100
        Pass {
            Name "FORWARD"
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
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _Alpha; uniform float4 _Alpha_ST;
            uniform float _Emissive;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float3 emissive = ((dot(_Diffuse_var.rgb,float3(0.3,0.59,0.11))*i.vertexColor.rgb)*_Emissive);
                float3 finalColor = emissive;
                float4 _Alpha_var = tex2D(_Alpha,TRANSFORM_TEX(i.uv0, _Alpha));
                fixed4 finalRGBA = fixed4(finalColor,clamp((i.vertexColor.a*_Alpha_var.a),0,0.5));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
