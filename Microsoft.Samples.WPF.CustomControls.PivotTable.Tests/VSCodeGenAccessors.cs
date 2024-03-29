﻿// ------------------------------------------------------------------------------
//<autogenerated>
//        This code was generated by Microsoft Visual Studio Team System 2005.
//
//        Changes to this file may cause incorrect behavior and will be lost if
//        the code is regenerated.
//</autogenerated>
//------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Samples.WPF.CustomControls.PivotTable.Tests
{
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class BaseAccessor {
    
    protected Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject m_privateObject;
    
    protected BaseAccessor(object target, Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType type) {
        m_privateObject = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(target, type);
    }
    
    protected BaseAccessor(Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType type) : 
            this(null, type) {
    }
    
    internal virtual object Target {
        get {
            return m_privateObject.Target;
        }
    }
    
    public override string ToString() {
        return this.Target.ToString();
    }
    
    public override bool Equals(object obj) {
        if (typeof(BaseAccessor).IsInstanceOfType(obj)) {
            obj = ((BaseAccessor)(obj)).Target;
        }
        return this.Target.Equals(obj);
    }
    
    public override int GetHashCode() {
        return this.Target.GetHashCode();
    }
}


[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_AverageAggregateFunctionAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.AverageAggregateFunction");
    
    internal Microsoft_Samples_WPF_CustomControls_AverageAggregateFunctionAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal static global::Microsoft.Samples.WPF.CustomControls.NumericAggregateFunction CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.AverageAggregateFunction", new System.Type[0], args);
        return ((global::Microsoft.Samples.WPF.CustomControls.NumericAggregateFunction)(priv_obj.Target));
    }
    
    internal object ComputeValueForInt32Arguments(System.Collections.Generic.IEnumerable<System.Nullable<int>> arguments) {
        object[] args = new object[] {
                arguments};
        object ret = ((object)(m_privateObject.Invoke("ComputeValueForInt32Arguments", new System.Type[] {
                    typeof(System.Collections.Generic.IEnumerable<System.Nullable<int>>)}, args)));
        return ret;
    }
    
    internal object ComputeValueForSingleArguments(System.Collections.Generic.IEnumerable<System.Nullable<float>> arguments) {
        object[] args = new object[] {
                arguments};
        object ret = ((object)(m_privateObject.Invoke("ComputeValueForSingleArguments", new System.Type[] {
                    typeof(System.Collections.Generic.IEnumerable<System.Nullable<float>>)}, args)));
        return ret;
    }
    
    internal object ComputeValueForDoubleArguments(System.Collections.Generic.IEnumerable<System.Nullable<double>> arguments) {
        object[] args = new object[] {
                arguments};
        object ret = ((object)(m_privateObject.Invoke("ComputeValueForDoubleArguments", new System.Type[] {
                    typeof(System.Collections.Generic.IEnumerable<System.Nullable<double>>)}, args)));
        return ret;
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_SumAggregateFunctionAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.SumAggregateFunction");
    
    internal Microsoft_Samples_WPF_CustomControls_SumAggregateFunctionAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal static global::Microsoft.Samples.WPF.CustomControls.NumericAggregateFunction CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.SumAggregateFunction", new System.Type[0], args);
        return ((global::Microsoft.Samples.WPF.CustomControls.NumericAggregateFunction)(priv_obj.Target));
    }
    
    internal object ComputeValueForInt32Arguments(System.Collections.Generic.IEnumerable<System.Nullable<int>> arguments) {
        object[] args = new object[] {
                arguments};
        object ret = ((object)(m_privateObject.Invoke("ComputeValueForInt32Arguments", new System.Type[] {
                    typeof(System.Collections.Generic.IEnumerable<System.Nullable<int>>)}, args)));
        return ret;
    }
    
    internal object ComputeValueForSingleArguments(System.Collections.Generic.IEnumerable<System.Nullable<float>> arguments) {
        object[] args = new object[] {
                arguments};
        object ret = ((object)(m_privateObject.Invoke("ComputeValueForSingleArguments", new System.Type[] {
                    typeof(System.Collections.Generic.IEnumerable<System.Nullable<float>>)}, args)));
        return ret;
    }
    
    internal object ComputeValueForDoubleArguments(System.Collections.Generic.IEnumerable<System.Nullable<double>> arguments) {
        object[] args = new object[] {
                arguments};
        object ret = ((object)(m_privateObject.Invoke("ComputeValueForDoubleArguments", new System.Type[] {
                    typeof(System.Collections.Generic.IEnumerable<System.Nullable<double>>)}, args)));
        return ret;
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_CountAggregateFunctionAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.CountAggregateFunction");
    
    internal Microsoft_Samples_WPF_CustomControls_CountAggregateFunctionAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal static global::Microsoft.Samples.WPF.CustomControls.AggregateFunction CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.CountAggregateFunction", new System.Type[0], args);
        return ((global::Microsoft.Samples.WPF.CustomControls.AggregateFunction)(priv_obj.Target));
    }
    
    internal object ComputeValue(global::System.Collections.IEnumerable arguments) {
        object[] args = new object[] {
                arguments};
        object ret = ((object)(m_privateObject.Invoke("ComputeValue", new System.Type[] {
                    typeof(global::System.Collections.IEnumerable)}, args)));
        return ret;
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_DataModel_MdxUtilsAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.MdxUtils");
    
    internal Microsoft_Samples_WPF_CustomControls_DataModel_MdxUtilsAccessor() : 
            base(m_privateType) {
    }
    
    internal static void GenerateTuplesSetExpression(global::System.Text.StringBuilder result, System.Collections.Generic.IEnumerable<Microsoft.Samples.WPF.CustomControls.Tuple> tuples) {
        object[] args = new object[] {
                result,
                tuples};
        m_privateType.InvokeStatic("GenerateTuplesSetExpression", new System.Type[] {
                    typeof(global::System.Text.StringBuilder),
                    typeof(System.Collections.Generic.IEnumerable<Microsoft.Samples.WPF.CustomControls.Tuple>)}, args);
    }
    
    internal static void GenerateTupleExpression(global::System.Text.StringBuilder result, global::Microsoft.Samples.WPF.CustomControls.Tuple tuple) {
        object[] args = new object[] {
                result,
                tuple};
        m_privateType.InvokeStatic("GenerateTupleExpression", new System.Type[] {
                    typeof(global::System.Text.StringBuilder),
                    typeof(global::Microsoft.Samples.WPF.CustomControls.Tuple)}, args);
    }
    
    internal static object CreatePrivate() {
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.MdxUtils", new object[0]);
        return priv_obj.Target;
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_DataModel_ExpandedMembersSetAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.ExpandedMembersSet");
    
    internal Microsoft_Samples_WPF_CustomControls_DataModel_ExpandedMembersSetAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal static object CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.ExpandedMembersSet", new System.Type[0], args);
        return priv_obj.Target;
    }
    
    internal void CollapseMember(global::Microsoft.Samples.WPF.CustomControls.IMember member) {
        object[] args = new object[] {
                member};
        m_privateObject.Invoke("CollapseMember", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IMember)}, args);
    }
    
    internal void ExpandMember(global::Microsoft.Samples.WPF.CustomControls.IMember member) {
        object[] args = new object[] {
                member};
        m_privateObject.Invoke("ExpandMember", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IMember)}, args);
    }
    
    internal global::Microsoft.Samples.WPF.CustomControls.MemberState GetMemberState(global::Microsoft.Samples.WPF.CustomControls.IMember member) {
        object[] args = new object[] {
                member};
        global::Microsoft.Samples.WPF.CustomControls.MemberState ret = ((global::Microsoft.Samples.WPF.CustomControls.MemberState)(m_privateObject.Invoke("GetMemberState", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IMember)}, args)));
        return ret;
    }
    
    internal void OnHierarchyRemoved(global::Microsoft.Samples.WPF.CustomControls.IHierarchy hierarchy) {
        object[] args = new object[] {
                hierarchy};
        m_privateObject.Invoke("OnHierarchyRemoved", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args);
    }
    
    internal void OnHierarchiesCleared() {
        object[] args = new object[0];
        m_privateObject.Invoke("OnHierarchiesCleared", new System.Type[0], args);
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_DataModel_AdomdFilterAxisAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.AdomdFilterAxis");
    
    internal Microsoft_Samples_WPF_CustomControls_DataModel_AdomdFilterAxisAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_AdomdHierarchiesObservableCollectionAccessor _hierarchies {
        get {
            object _ret_val = m_privateObject.GetField("_hierarchies");
            global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_AdomdHierarchiesObservableCollectionAccessor _ret = null;
            if ((_ret_val != null)) {
                _ret = new global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_AdomdHierarchiesObservableCollectionAccessor(_ret_val);
            }
            global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_AdomdHierarchiesObservableCollectionAccessor ret = _ret;
            return ret;
        }
        set {
            m_privateObject.SetField("_hierarchies", value);
        }
    }
    
    internal global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_TuplesObservableCollectionAccessor _tuples {
        get {
            object _ret_val = m_privateObject.GetField("_tuples");
            global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_TuplesObservableCollectionAccessor _ret = null;
            if ((_ret_val != null)) {
                _ret = new global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_TuplesObservableCollectionAccessor(_ret_val);
            }
            global::Microsoft.Samples.WPF.CustomControls.PivotTable.Tests.Microsoft_Samples_WPF_CustomControls_DataModel_TuplesObservableCollectionAccessor ret = _ret;
            return ret;
        }
        set {
            m_privateObject.SetField("_tuples", value);
        }
    }
    
    internal System.Collections.ObjectModel.ObservableCollection<Microsoft.Samples.WPF.CustomControls.IHierarchy> Hierarchies {
        get {
            System.Collections.ObjectModel.ObservableCollection<Microsoft.Samples.WPF.CustomControls.IHierarchy> ret = ((System.Collections.ObjectModel.ObservableCollection<Microsoft.Samples.WPF.CustomControls.IHierarchy>)(m_privateObject.GetProperty("Hierarchies")));
            return ret;
        }
    }
    
    internal System.Collections.ObjectModel.ReadOnlyObservableCollection<Microsoft.Samples.WPF.CustomControls.Tuple> Tuples {
        get {
            System.Collections.ObjectModel.ReadOnlyObservableCollection<Microsoft.Samples.WPF.CustomControls.Tuple> ret = ((System.Collections.ObjectModel.ReadOnlyObservableCollection<Microsoft.Samples.WPF.CustomControls.Tuple>)(m_privateObject.GetProperty("Tuples")));
            return ret;
        }
    }
    
    internal static object CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.AdomdFilterAxis", new System.Type[0], args);
        return priv_obj.Target;
    }
    
    internal void OnHierarchiesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
        object[] args = new object[] {
                sender,
                e};
        m_privateObject.Invoke("OnHierarchiesChanged", new System.Type[] {
                    typeof(object),
                    typeof(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)}, args);
    }
    
    internal void OnHierarchyAdded(global::Microsoft.Samples.WPF.CustomControls.IHierarchy hierarchy) {
        object[] args = new object[] {
                hierarchy};
        m_privateObject.Invoke("OnHierarchyAdded", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args);
    }
    
    internal void OnHierarchyMoved() {
        object[] args = new object[0];
        m_privateObject.Invoke("OnHierarchyMoved", new System.Type[0], args);
    }
    
    internal void OnHierarchyRemoved(global::Microsoft.Samples.WPF.CustomControls.IHierarchy hierarchy) {
        object[] args = new object[] {
                hierarchy};
        m_privateObject.Invoke("OnHierarchyRemoved", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args);
    }
    
    internal void OnHierarchyReplaced(global::Microsoft.Samples.WPF.CustomControls.IHierarchy oldHierarchy, global::Microsoft.Samples.WPF.CustomControls.IHierarchy newHierarchy) {
        object[] args = new object[] {
                oldHierarchy,
                newHierarchy};
        m_privateObject.Invoke("OnHierarchyReplaced", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy),
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args);
    }
    
    internal void OnHierarchiesCleared() {
        object[] args = new object[0];
        m_privateObject.Invoke("OnHierarchiesCleared", new System.Type[0], args);
    }
    
    internal System.Collections.Generic.Dictionary<Microsoft.Samples.WPF.CustomControls.IMember, bool> CreateVisibleMembersForNewHierarchy(global::Microsoft.Samples.WPF.CustomControls.IHierarchy hierarchy) {
        object[] args = new object[] {
                hierarchy};
        System.Collections.Generic.Dictionary<Microsoft.Samples.WPF.CustomControls.IMember, bool> ret = ((System.Collections.Generic.Dictionary<Microsoft.Samples.WPF.CustomControls.IMember, bool>)(m_privateObject.Invoke("CreateVisibleMembersForNewHierarchy", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args)));
        return ret;
    }
    
    internal void RecreateTuples() {
        object[] args = new object[0];
        m_privateObject.Invoke("RecreateTuples", new System.Type[0], args);
    }
    
    internal System.Collections.Generic.IList<Microsoft.Samples.WPF.CustomControls.Tuple> CreateTuplesStartingFromHierarchy(int hierarchyNumber) {
        object[] args = new object[] {
                hierarchyNumber};
        System.Collections.Generic.IList<Microsoft.Samples.WPF.CustomControls.Tuple> ret = ((System.Collections.Generic.IList<Microsoft.Samples.WPF.CustomControls.Tuple>)(m_privateObject.Invoke("CreateTuplesStartingFromHierarchy", new System.Type[] {
                    typeof(int)}, args)));
        return ret;
    }
    
    internal System.Collections.Generic.IEnumerable<Microsoft.Samples.WPF.CustomControls.IMember> GetAllMembersFromHierarchy(global::Microsoft.Samples.WPF.CustomControls.IHierarchy hierarchy) {
        object[] args = new object[] {
                hierarchy};
        System.Collections.Generic.IEnumerable<Microsoft.Samples.WPF.CustomControls.IMember> ret = ((System.Collections.Generic.IEnumerable<Microsoft.Samples.WPF.CustomControls.IMember>)(m_privateObject.Invoke("GetAllMembersFromHierarchy", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args)));
        return ret;
    }
    
    internal void FilterMember(global::Microsoft.Samples.WPF.CustomControls.IMember member, bool isFiltered) {
        object[] args = new object[] {
                member,
                isFiltered};
        m_privateObject.Invoke("FilterMember", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IMember),
                    typeof(bool)}, args);
    }
    
    internal bool IsMemberFiltered(global::Microsoft.Samples.WPF.CustomControls.IMember member) {
        object[] args = new object[] {
                member};
        bool ret = ((bool)(m_privateObject.Invoke("IsMemberFiltered", new System.Type[] {
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IMember)}, args)));
        return ret;
    }
    
    internal void GenerateMdxWhereExpression(global::System.Text.StringBuilder result) {
        object[] args = new object[] {
                result};
        m_privateObject.Invoke("GenerateMdxWhereExpression", new System.Type[] {
                    typeof(global::System.Text.StringBuilder)}, args);
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_DataModel_AdomdHierarchiesObservableCollectionAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.AdomdHierarchiesObservableCollecti" +
            "on");
    
    internal Microsoft_Samples_WPF_CustomControls_DataModel_AdomdHierarchiesObservableCollectionAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal static global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Samples.WPF.CustomControls.IHierarchy> CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.AdomdHierarchiesObservableCollecti" +
                "on", new System.Type[0], args);
        return ((global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Samples.WPF.CustomControls.IHierarchy>)(priv_obj.Target));
    }
    
    internal void InsertItem(int index, global::Microsoft.Samples.WPF.CustomControls.IHierarchy item) {
        object[] args = new object[] {
                index,
                item};
        m_privateObject.Invoke("InsertItem", new System.Type[] {
                    typeof(int),
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args);
    }
    
    internal void SetItem(int index, global::Microsoft.Samples.WPF.CustomControls.IHierarchy item) {
        object[] args = new object[] {
                index,
                item};
        m_privateObject.Invoke("SetItem", new System.Type[] {
                    typeof(int),
                    typeof(global::Microsoft.Samples.WPF.CustomControls.IHierarchy)}, args);
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class Microsoft_Samples_WPF_CustomControls_DataModel_TuplesObservableCollectionAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.TuplesObservableCollection");
    
    internal Microsoft_Samples_WPF_CustomControls_DataModel_TuplesObservableCollectionAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal bool _notifyChanges {
        get {
            bool ret = ((bool)(m_privateObject.GetField("_notifyChanges")));
            return ret;
        }
        set {
            m_privateObject.SetField("_notifyChanges", value);
        }
    }
    
    internal static global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Samples.WPF.CustomControls.Tuple> CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("Microsoft.Samples.WPF.CustomControls.PivotTable", "Microsoft.Samples.WPF.CustomControls.DataModel.TuplesObservableCollection", new System.Type[0], args);
        return ((global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Samples.WPF.CustomControls.Tuple>)(priv_obj.Target));
    }
    
    internal void ReplaceAllTuples(System.Collections.Generic.IEnumerable<Microsoft.Samples.WPF.CustomControls.Tuple> newTuples) {
        object[] args = new object[] {
                newTuples};
        m_privateObject.Invoke("ReplaceAllTuples", new System.Type[] {
                    typeof(System.Collections.Generic.IEnumerable<Microsoft.Samples.WPF.CustomControls.Tuple>)}, args);
    }
    
    internal void InsertItem(int index, global::Microsoft.Samples.WPF.CustomControls.Tuple item) {
        object[] args = new object[] {
                index,
                item};
        m_privateObject.Invoke("InsertItem", new System.Type[] {
                    typeof(int),
                    typeof(global::Microsoft.Samples.WPF.CustomControls.Tuple)}, args);
    }
    
    internal void ClearItems() {
        object[] args = new object[0];
        m_privateObject.Invoke("ClearItems", new System.Type[0], args);
    }
    
    internal void OnPropertyChanged(string propertyName) {
        object[] args = new object[] {
                propertyName};
        m_privateObject.Invoke("OnPropertyChanged", new System.Type[] {
                    typeof(string)}, args);
    }
}
}
