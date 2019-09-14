Shader "Custom/ToothBrushShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Disorder("Gravity To Point",Vector) = (0.5 , 0.5 , 0 ,0)
        
    }
    SubShader
    {
        CGPROGRAM

        #pragma surface surf Standard fullforwardshadows



        sampler2D _MainTex;
        fixed4 _Color;
        float4 _Disorder;
        
        struct Input
        {
            float2 uv_MainTex;
        };

      


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            float2 vectorFromCenterTOUV = IN.uv_MainTex - _Disorder;
            
            float distanceFromCenter = length (vectorFromCenterTOUV);
            
        
            
            float2 changePos = vectorFromCenterTOUV * distanceFromCenter * 10;

            

            
            if( IN.uv_MainTex.x + changePos.x <= 1 && IN.uv_MainTex.y + changePos.y <= 1 && IN.uv_MainTex.x + changePos.x >= 0 && IN.uv_MainTex.y + changePos.y >= 0)
            {
               
             
            }
            else
            {
                o.Emission = _Color;
            }
            float3 textureColor = tex2D(_MainTex, IN.uv_MainTex + changePos ).rgb;
            
                o.Emission = textureColor;
           
        
            // Albedo comes from a texture tinted by color
           // fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
           //o.Albedo = c.rgb;
           // o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
