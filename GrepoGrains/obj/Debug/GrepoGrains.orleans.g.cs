#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.5.2.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("GrepoGrains, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace GrepoTools.Distributed.Grains
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.5.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::GrepoTools.Distributed.Grains.PongHistoryModel))]
    internal class OrleansCodeGenGrepoTools_Distributed_Grains_PongHistoryModelSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::GrepoTools.Distributed.Grains.PongHistoryModel input = ((global::GrepoTools.Distributed.Grains.PongHistoryModel)original);
            global::GrepoTools.Distributed.Grains.PongHistoryModel result = new global::GrepoTools.Distributed.Grains.PongHistoryModel();
            context.@RecordCopy(original, result);
            result.@History = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@History, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::GrepoTools.Distributed.Grains.PongHistoryModel input = (global::GrepoTools.Distributed.Grains.PongHistoryModel)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@History, context, typeof (global::System.Collections.Generic.List<global::System.String>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::GrepoTools.Distributed.Grains.PongHistoryModel result = new global::GrepoTools.Distributed.Grains.PongHistoryModel();
            context.@RecordObject(result);
            result.@History = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.String>), context);
            return (global::GrepoTools.Distributed.Grains.PongHistoryModel)result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
