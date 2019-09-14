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
            
        
            float2 normalizedFromCenter = normalize(vectorFromCenterTOUV);
            
            float2 changePos = normalizedFromCenter * vectorFromCenterTOUV * _Strength;


            
      
             float3 textureColor = tex2D(_MainTex, IN.uv_MainTex + _Time.y*0.1 ).rgb;
            
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
