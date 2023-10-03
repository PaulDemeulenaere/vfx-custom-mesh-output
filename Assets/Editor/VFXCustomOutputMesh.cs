using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.VFX.URP
{
    [VFXInfo]
    class VFXCustomOutputMesh : VFXURPLitMeshOutput
    {
        public override string name => "Custom Output Mesh";

        public override string codeGeneratorTemplate => "Assets/Editor/VFXCustomOutputMesh";

        protected override IEnumerable<VFXPropertyWithValue> inputProperties
        {
            get
            {
                foreach (var inputProperty in base.inputProperties)
                    yield return inputProperty;

                //This yield return will automatically add a slot in this output.
                yield return new VFXPropertyWithValue(new VFXProperty(typeof(float), "customDeformation"));
            }
        }

        protected override IEnumerable<VFXNamedExpression> CollectGPUExpressions(IEnumerable<VFXNamedExpression> slotExpressions)
        {
            foreach (var gpuExpression in base.CollectGPUExpressions(slotExpressions))
                yield return gpuExpression;

            foreach (var slot in slotExpressions)
            {
                if (slot.name == "customDeformation")
                {
                    //It makes this value readable on GPU thanks to "${VFXLoadParameter:{customDeformation}}" in template.
                    yield return slot;
                    break;
                }
            }
        }
    }
}
