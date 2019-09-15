Shader "Custom/ToothBrushShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Disorder("Gravity To Point",Vector) = (0.5 , 0.5 , 0 ,0)
        _Strength("Strength", float) = 0.5
        
    }
    SubShader
    {
        CGPROGRAM

        #pragma surface surf Standard fullforwardshadows



        sampler2D _MainTex;
        fixed4 _Color;
        float _Strength;
        float4 _Disorder;
        
        struct Input
        {
            float2 uv_MainTex;
        };

      


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            float2 vectorFromCenterTOUV = IN.uv_MainTex - _Disorder;
            
            float distanceFromCenter = length (vectorFromCenterTOUV);
            
            float2 closestPoints = IN.uv_MainTex - IN.uv_MainTex *0.1f;
            
            float distanceFromClosestPoints = length(closestPoints);
            
        
            float2 normalizedFromCenter = normalize(vectorFromCenterTOUV);
            
            float2 changePos = float2(sin(_Time.y * 0.5f), 1.4* sin(_Time.y*2 + distanceFromClosestPoints ) ) * 99;

            float2 changePos2 = closestPoints*distanceFromClosestPoints;
            
            changePos = changePos *0.001f;
      
             float3 textureColor = tex2D(_MainTex, IN.uv_MainTex + changePos ).rgb * _Color;
            
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
