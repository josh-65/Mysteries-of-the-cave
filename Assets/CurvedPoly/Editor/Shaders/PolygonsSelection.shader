/*Pretty Simple Color+Transparency Shader used to display Polygons Selections.*/
Shader "Custom/CurvedPolyEditor/PolygonsSelection" {
  Properties {
    _Color ("Color", Color) = (1.0, 1.0, 1.0, 1.0)
  }
  SubShader {
    Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }
    Blend SrcAlpha OneMinusSrcAlpha
	BlendOp Add
    Cull Off
    LOD 200
 
    CGPROGRAM
    #pragma surface surf Lambert
 
    fixed4 _Color;
  
    struct Input {
      float2 uv_MainTex;
    };
 
    void surf (Input IN, inout SurfaceOutput o) {
      o.Albedo = float3(0,0,0);
      o.Emission = _Color.rgb;
      o.Alpha = _Color.a; 
    }
    ENDCG
  } 
  FallBack "Diffuse"
}