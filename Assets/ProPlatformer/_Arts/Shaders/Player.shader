﻿Shader "Demo/TrailSpriteEffect"
{
    Properties
    {
        _TrailColor ("TrailColor", Color) = (1,1,1,1)
        [PerRendererData] _MainTex("Sprite Texture", 2D) = "white" {}
        [HideInInspector] _Color ("Tint", Color) = (1,1,1,1)
        [MaterialToggle] PixelSnap("Pixel snap", Float) = 0
        [HideInInspector] _RendererColor("RendererColor", Color) = (1,1,1,1)
        [HideInInspector] _Flip("Flip", Vector) = (1,1,1,1)
        [PerRendererData] _AlphaTex("External Alpha", 2D) = "white" {}
        [PerRendererData] _EnableExternalAlpha("Enable External Alpha", Float) = 0
    }

        SubShader
        {
            Tags
            {
                "Queue" = "Transparent"
                "IgnoreProjector" = "True"
                "RenderType" = "Transparent"
                "PreviewType" = "Plane"
                "CanUseSpriteAtlas" = "True"
            }

            Cull Off
            Lighting Off
            ZWrite Off
            Blend One OneMinusSrcAlpha

            Pass
            {
            CGPROGRAM
                #pragma vertex SpriteVert
                #pragma fragment SpriteColorFragment
                #pragma target 2.0
                #pragma multi_compile_instancing
                #pragma multi_compile_local _ PIXELSNAP_ON
                #pragma multi_compile _ ETC1_EXTERNAL_ALPHA
                fixed4 _TrailColor;
                #include "UnitySprites.cginc"

                fixed4 SpriteColorFragment(v2f IN) : SV_Target
                {
                    fixed4 c = SampleSpriteTexture (IN.texcoord) * IN.color;
                    c.rgb = _TrailColor.rgb;
                    c.rgb *= c.a;
                    return c; 
                }
            ENDCG
            }
        }
}