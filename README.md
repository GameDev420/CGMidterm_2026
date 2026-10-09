# CGMidterm_2026

Reflection Shader Explanation
This shader is fairly simple, as it essentially replaces its texture with the output of the nearest reflection probe in Unity (though you could also multiply the result by a texture if you had one).It takes the view direction and normal vector, both in object space, and passes it to a Reflection Probe node to sample its cubemap. Furthermore, it also had a reflection blurriness parameter specifically for the probe reflections, you would want it close to the material's smoothness for realistic results.

Texture Tiling Shader Explanation
Basic Lit shader with standard properties (metallic, smoothness, base texture and color, etc.) with customizable, time-based texture offsets, which yields great results when paired with tileable textures. Simply multiplies the current game time by the offset speed, adds it with a base offset, and given along with the base UV (UV0) when sampling the texture. This shader also supports texture tiling, which pairs nicely with dynamic offsets. I believe using ShaderGraph here is effective due to the simplicity of the effect and using Unity's built-in lighting as it's not the focus of this shader.

Multiple UV Shader Explanation
I tried to do this in HLSL, but failed.

Other Shaders
Didn't get enough time to complete :(
