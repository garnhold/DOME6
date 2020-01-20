using System;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

namespace DOME
{
    public class DOMEVariableTypeCreator
    {
        [DOMEVariableTypeCreator("Auto")]
        static public readonly DOMEVariableTypeCreator AUTO = new DOMEVariableTypeCreator(
            typeof(DOMEClass_Generated_GrammarElement_Element_AutoParent),

            typeof(DOMEVariableType_Single_RuleDefinition_AutoParent),
            typeof(DOMEVariableType_Multiple_RuleDefinition_AutoParent_List),
            typeof(DOMEVariableType_Multiple_RuleDefinition_AutoParent_LabeledItemSet)
        );

        [DOMEVariableTypeCreator("Manual")]
        static public readonly DOMEVariableTypeCreator MANUAL = new DOMEVariableTypeCreator(
            typeof(DOMEClass_Generated_GrammarElement_Element_ManualParent),

            typeof(DOMEVariableType_Single_RuleDefinition_ManualParent),
            typeof(DOMEVariableType_Multiple_RuleDefinition_ManualParent_List),
            typeof(DOMEVariableType_Multiple_RuleDefinition_ManualParent_LabeledItemSet)
        );

        [DOMEVariableTypeCreator("None")]
        static public readonly DOMEVariableTypeCreator NONE = new DOMEVariableTypeCreator(
            typeof(DOMEClass_Generated_GrammarElement_Element_NoParent),

            typeof(DOMEVariableType_Single_RuleDefinition_NoParent),
            typeof(DOMEVariableType_Multiple_RuleDefinition_NoParent_List),
            typeof(DOMEVariableType_Multiple_RuleDefinition_NoParent_LabeledItemSet)
        );

        private Factory<DOMEClass_Generated_GrammarElement_Element, DOMElement_GrammarDefinition> element_factory;

        private Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept> rule_definition_single_factory;
        private Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept> rule_definition_list_factory;
        private Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept, DOMEVariableTypeConcept> rule_definition_labeled_item_set_factory;

        private DOMEVariableTypeCreator(Type e, Type rs, Type rl, Type rlis)
        {
            element_factory = new Factory<DOMEClass_Generated_GrammarElement_Element, DOMElement_GrammarDefinition>(e);

            rule_definition_single_factory = new Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept>(rs);
            rule_definition_list_factory = new Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept>(rl);
            rule_definition_labeled_item_set_factory = new Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept, DOMEVariableTypeConcept>(rlis);
        }

        public Factory<DOMEClass_Generated_GrammarElement_Element, DOMElement_GrammarDefinition> GetElementFactory()
        {
            return element_factory;
        }

        public Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept> GetRuleDefinitionSingleFactory()
        {
            return rule_definition_single_factory;
        }

        public Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept> GetRuleDefinitionListFactory()
        {
            return rule_definition_list_factory;
        }

        public Factory<DOMEVariableType, DOMEClass, DOMEVariableTypeConcept, DOMEVariableTypeConcept> GetRuleDefinitionLabeledItemSetFactory()
        {
            return rule_definition_labeled_item_set_factory;
        }
    }
}