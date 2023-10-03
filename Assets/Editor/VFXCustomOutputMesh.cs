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
                    yield return slot;
                    break;
                }
            }
        }
    }
}
