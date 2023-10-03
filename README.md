# VFX Custom Output Mesh

This repository is an experiment for creation of a VFX custom template output.

This is **not** a recommended approach since new [Shader Graph integration](https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/sg-working-with.html) is providing the same feature with HDRP & URP.

![README_VFX_Custom_Mesh](README_VFX_Custom_Mesh.gif)

Custom entry points:

https://github.com/PaulDemeulenaere/vfx-custom-mesh-output/blob/aae4bbb448556883fac3cb5200536a4950222435/Assets/Editor/VFXCustomParticleCommon.template#L10

https://github.com/PaulDemeulenaere/vfx-custom-mesh-output/blob/aae4bbb448556883fac3cb5200536a4950222435/Assets/Editor/VFXCustomOutputMesh.cs#L8

⚠️ This hack is allowing simpler template include:
https://github.com/PaulDemeulenaere/vfx-custom-mesh-output/blob/aae4bbb448556883fac3cb5200536a4950222435/Packages/com.unity.visualeffectgraph%4014.0.9/Editor/Compiler/VFXCodeGenerator.cs#L313

Tested with 2022.3.11f1
