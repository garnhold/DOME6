
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: January 19 2020 22:39:32 -08:00

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace DOME
{
	public abstract partial class DOMElement_Definition : DOMElement
	{
		public abstract DOMElement_Definition Duplicate();
		static public DOMElement_Definition DOMify(DOMEParser.DefinitionContext context)
		{
			return DOMEResolver.Resolve<DOMElement_Definition>(context);
		}
		
		static public DOMElement_Definition DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.DefinitionContext);
		}
		
		static public DOMElement_Definition DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).definition());
		}
		
		static public DOMElement_Definition DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).definition());
		}
		
		static public DOMElement_Definition DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).definition());
		}
		
	}
	
	public partial class DOMElement_Definition_RuleDefinition_ConcreteDirect : DOMElement_Definition_RuleDefinition
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleDefinition_Concrete_Direct> rule_definition_concrete_direct;
		static public DOMElement_Definition_RuleDefinition_ConcreteDirect DOMify(DOMEParser.Definition_RuleDefinition_ConcreteDirectContext context)
		{
			if(context != null)
			{
				return new DOMElement_Definition_RuleDefinition_ConcreteDirect(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteDirect DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.Definition_RuleDefinition_ConcreteDirectContext);
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteDirect DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).definition());
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteDirect DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).definition());
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteDirect DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).definition());
		}
		
		public DOMElement_Definition_RuleDefinition_ConcreteDirect()
		{
			rule_definition_concrete_direct = new HoldingSingle<DOMElement, DOMElement_RuleDefinition_Concrete_Direct>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Definition_RuleDefinition_ConcreteDirect(DOMEParser.Definition_RuleDefinition_ConcreteDirectContext context) : this()
		{
			SetRuleDefinitionConcreteDirect(DOMElement_RuleDefinition_Concrete_Direct.DOMify(context.ruleDefinitionConcreteDirect()));
		}
		
		public override DOMElement_Definition Duplicate()
		{
			DOMElement_Definition_RuleDefinition_ConcreteDirect instance = new DOMElement_Definition_RuleDefinition_ConcreteDirect();
			instance.SetRuleDefinitionConcreteDirect(GetRuleDefinitionConcreteDirect().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleDefinitionConcreteDirect(DOMElement_RuleDefinition_Concrete_Direct input)
		{
			rule_definition_concrete_direct.Set(input);
		}
		
		public DOMElement_RuleDefinition_Concrete_Direct GetRuleDefinitionConcreteDirect()
		{
			return rule_definition_concrete_direct.Get();
		}
		
	}
	
	public partial class DOMElement_Definition_RuleDefinition_ConcreteInherited : DOMElement_Definition_RuleDefinition
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleDefinition_Concrete_Inherited> rule_definition_concrete_inherited;
		static public DOMElement_Definition_RuleDefinition_ConcreteInherited DOMify(DOMEParser.Definition_RuleDefinition_ConcreteInheritedContext context)
		{
			if(context != null)
			{
				return new DOMElement_Definition_RuleDefinition_ConcreteInherited(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteInherited DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.Definition_RuleDefinition_ConcreteInheritedContext);
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteInherited DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).definition());
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteInherited DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).definition());
		}
		
		static new public DOMElement_Definition_RuleDefinition_ConcreteInherited DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).definition());
		}
		
		public DOMElement_Definition_RuleDefinition_ConcreteInherited()
		{
			rule_definition_concrete_inherited = new HoldingSingle<DOMElement, DOMElement_RuleDefinition_Concrete_Inherited>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Definition_RuleDefinition_ConcreteInherited(DOMEParser.Definition_RuleDefinition_ConcreteInheritedContext context) : this()
		{
			SetRuleDefinitionConcreteInherited(DOMElement_RuleDefinition_Concrete_Inherited.DOMify(context.ruleDefinitionConcreteInherited()));
		}
		
		public override DOMElement_Definition Duplicate()
		{
			DOMElement_Definition_RuleDefinition_ConcreteInherited instance = new DOMElement_Definition_RuleDefinition_ConcreteInherited();
			instance.SetRuleDefinitionConcreteInherited(GetRuleDefinitionConcreteInherited().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleDefinitionConcreteInherited(DOMElement_RuleDefinition_Concrete_Inherited input)
		{
			rule_definition_concrete_inherited.Set(input);
		}
		
		public DOMElement_RuleDefinition_Concrete_Inherited GetRuleDefinitionConcreteInherited()
		{
			return rule_definition_concrete_inherited.Get();
		}
		
	}
	
	public partial class DOMElement_Definition_RuleDefinition_Abstract : DOMElement_Definition_RuleDefinition
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleDefinition_Abstract> rule_definition_abstract;
		static public DOMElement_Definition_RuleDefinition_Abstract DOMify(DOMEParser.Definition_RuleDefinition_AbstractContext context)
		{
			if(context != null)
			{
				return new DOMElement_Definition_RuleDefinition_Abstract(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Definition_RuleDefinition_Abstract DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.Definition_RuleDefinition_AbstractContext);
		}
		
		static new public DOMElement_Definition_RuleDefinition_Abstract DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).definition());
		}
		
		static new public DOMElement_Definition_RuleDefinition_Abstract DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).definition());
		}
		
		static new public DOMElement_Definition_RuleDefinition_Abstract DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).definition());
		}
		
		public DOMElement_Definition_RuleDefinition_Abstract()
		{
			rule_definition_abstract = new HoldingSingle<DOMElement, DOMElement_RuleDefinition_Abstract>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Definition_RuleDefinition_Abstract(DOMEParser.Definition_RuleDefinition_AbstractContext context) : this()
		{
			SetRuleDefinitionAbstract(DOMElement_RuleDefinition_Abstract.DOMify(context.ruleDefinitionAbstract()));
		}
		
		public override DOMElement_Definition Duplicate()
		{
			DOMElement_Definition_RuleDefinition_Abstract instance = new DOMElement_Definition_RuleDefinition_Abstract();
			instance.SetRuleDefinitionAbstract(GetRuleDefinitionAbstract().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleDefinitionAbstract(DOMElement_RuleDefinition_Abstract input)
		{
			rule_definition_abstract.Set(input);
		}
		
		public DOMElement_RuleDefinition_Abstract GetRuleDefinitionAbstract()
		{
			return rule_definition_abstract.Get();
		}
		
	}
	
	public partial class DOMElement_Definition_TokenDefinition : DOMElement_Definition
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_TokenDefinition> token_definition;
		static public DOMElement_Definition_TokenDefinition DOMify(DOMEParser.Definition_TokenDefinitionContext context)
		{
			if(context != null)
			{
				return new DOMElement_Definition_TokenDefinition(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Definition_TokenDefinition DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.Definition_TokenDefinitionContext);
		}
		
		static new public DOMElement_Definition_TokenDefinition DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).definition());
		}
		
		static new public DOMElement_Definition_TokenDefinition DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).definition());
		}
		
		static new public DOMElement_Definition_TokenDefinition DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).definition());
		}
		
		public DOMElement_Definition_TokenDefinition()
		{
			token_definition = new HoldingSingle<DOMElement, DOMElement_TokenDefinition>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Definition_TokenDefinition(DOMEParser.Definition_TokenDefinitionContext context) : this()
		{
			SetTokenDefinition(DOMElement_TokenDefinition.DOMify(context.tokenDefinition()));
		}
		
		public override DOMElement_Definition Duplicate()
		{
			DOMElement_Definition_TokenDefinition instance = new DOMElement_Definition_TokenDefinition();
			instance.SetTokenDefinition(GetTokenDefinition().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTokenDefinition(DOMElement_TokenDefinition input)
		{
			token_definition.Set(input);
		}
		
		public DOMElement_TokenDefinition GetTokenDefinition()
		{
			return token_definition.Get();
		}
		
	}
	
	public partial class DOMElement_Id : DOMElement
	{
		private string rule_id;
		private string token_id;
		static public DOMElement_Id DOMify(DOMEParser.IdContext context)
		{
			if(context != null)
			{
				return new DOMElement_Id(context);
			}
			
			return null;
		}
		
		static public DOMElement_Id DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.IdContext);
		}
		
		static public DOMElement_Id DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).id());
		}
		
		static public DOMElement_Id DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).id());
		}
		
		static public DOMElement_Id DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).id());
		}
		
		public DOMElement_Id()
		{
			rule_id = "";
			token_id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Id(DOMEParser.IdContext context) : this()
		{
			SetRuleId(context.RULE_ID().GetTextEX());
			SetTokenId(context.TOKEN_ID().GetTextEX());
		}
		
		public DOMElement_Id Duplicate()
		{
			DOMElement_Id instance = new DOMElement_Id();
			instance.SetRuleId(GetRuleId());
			instance.SetTokenId(GetTokenId());
			return instance;
		}
		
		private void SetRuleId(string input)
		{
			rule_id = input;
		}
		
		public string GetRuleId()
		{
			return rule_id;
		}
		
		private void SetTokenId(string input)
		{
			token_id = input;
		}
		
		public string GetTokenId()
		{
			return token_id;
		}
		
	}
	
	public partial class DOMElement_GrammarHeader : DOMElement
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_GrammarType> grammar_type;
		private string grammar_name;
		static public DOMElement_GrammarHeader DOMify(DOMEParser.GrammarHeaderContext context)
		{
			if(context != null)
			{
				return new DOMElement_GrammarHeader(context);
			}
			
			return null;
		}
		
		static public DOMElement_GrammarHeader DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.GrammarHeaderContext);
		}
		
		static public DOMElement_GrammarHeader DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).grammarHeader());
		}
		
		static public DOMElement_GrammarHeader DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).grammarHeader());
		}
		
		static public DOMElement_GrammarHeader DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).grammarHeader());
		}
		
		public DOMElement_GrammarHeader()
		{
			grammar_type = new HoldingSingle<DOMElement, DOMElement_GrammarType>(this);
			grammar_name = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_GrammarHeader(DOMEParser.GrammarHeaderContext context) : this()
		{
			SetGrammarType(DOMElement_GrammarType.DOMify(context.grammarType()));
			SetGrammarName(context.id().GetTextEX());
		}
		
		public DOMElement_GrammarHeader Duplicate()
		{
			DOMElement_GrammarHeader instance = new DOMElement_GrammarHeader();
			instance.SetGrammarType(GetGrammarType().IfNotNull(z => z.Duplicate()));
			instance.SetGrammarName(GetGrammarName());
			return instance;
		}
		
		private void SetGrammarType(DOMElement_GrammarType input)
		{
			grammar_type.Set(input);
		}
		
		public DOMElement_GrammarType GetGrammarType()
		{
			return grammar_type.Get();
		}
		
		private void SetGrammarName(string input)
		{
			grammar_name = input;
		}
		
		public string GetGrammarName()
		{
			return grammar_name;
		}
		
	}
	
	public partial class DOMElement_ImportHeader : DOMElement
	{
		private List<string> grammar_names;
		static public DOMElement_ImportHeader DOMify(DOMEParser.ImportHeaderContext context)
		{
			if(context != null)
			{
				return new DOMElement_ImportHeader(context);
			}
			
			return null;
		}
		
		static public DOMElement_ImportHeader DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.ImportHeaderContext);
		}
		
		static public DOMElement_ImportHeader DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).importHeader());
		}
		
		static public DOMElement_ImportHeader DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).importHeader());
		}
		
		static public DOMElement_ImportHeader DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).importHeader());
		}
		
		public DOMElement_ImportHeader()
		{
			grammar_names = new List<string>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_ImportHeader(DOMEParser.ImportHeaderContext context) : this()
		{
			AddGrammarNames(context.id().Convert(c => c.GetTextEX()));
		}
		
		public DOMElement_ImportHeader Duplicate()
		{
			DOMElement_ImportHeader instance = new DOMElement_ImportHeader();
			instance.SetGrammarNames(GetGrammarNames());
			return instance;
		}
		
		private void ClearGrammarNames()
		{
			grammar_names.Clear();
		}
		
		private void SetGrammarNames(IEnumerable<string> input)
		{
			ClearGrammarNames();
			AddGrammarNames(input);
		}
		
		private void SetGrammarNames(params string[] input)
		{
			SetGrammarNames((IEnumerable<string>)input);
		}
		
		private void AddGrammarName(string input)
		{
			grammar_names.Add(input);
		}
		
		private void AddGrammarNames(IEnumerable<string> input)
		{
			input.Process(i => AddGrammarName(i));
		}
		
		private void AddGrammarNames(params string[] input)
		{
			AddGrammarNames((IEnumerable<string>)input);
		}
		
		public IEnumerable<string> GetGrammarNames()
		{
			return grammar_names;
		}
		
	}
	
	public abstract partial class DOMElement_GrammarType : DOMElement
	{
		public abstract DOMElement_GrammarType Duplicate();
		static public DOMElement_GrammarType DOMify(DOMEParser.GrammarTypeContext context)
		{
			return DOMEResolver.Resolve<DOMElement_GrammarType>(context);
		}
		
		static public DOMElement_GrammarType DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.GrammarTypeContext);
		}
		
		static public DOMElement_GrammarType DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).grammarType());
		}
		
		static public DOMElement_GrammarType DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).grammarType());
		}
		
		static public DOMElement_GrammarType DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).grammarType());
		}
		
	}
	
	public partial class DOMElement_GrammarType_Parser : DOMElement_GrammarType
	{
		static public DOMElement_GrammarType_Parser DOMify(DOMEParser.GrammarTypeParserContext context)
		{
			if(context != null)
			{
				return new DOMElement_GrammarType_Parser(context);
			}
			
			return null;
		}
		
		static new public DOMElement_GrammarType_Parser DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.GrammarTypeParserContext);
		}
		
		static new public DOMElement_GrammarType_Parser DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).grammarType());
		}
		
		static new public DOMElement_GrammarType_Parser DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).grammarType());
		}
		
		static new public DOMElement_GrammarType_Parser DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).grammarType());
		}
		
		public DOMElement_GrammarType_Parser()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_GrammarType_Parser(DOMEParser.GrammarTypeParserContext context) : this()
		{
		}
		
		public override DOMElement_GrammarType Duplicate()
		{
			DOMElement_GrammarType_Parser instance = new DOMElement_GrammarType_Parser();
			return instance;
		}
		
	}
	
	public partial class DOMElement_GrammarType_Lexer : DOMElement_GrammarType
	{
		static public DOMElement_GrammarType_Lexer DOMify(DOMEParser.GrammarTypeLexerContext context)
		{
			if(context != null)
			{
				return new DOMElement_GrammarType_Lexer(context);
			}
			
			return null;
		}
		
		static new public DOMElement_GrammarType_Lexer DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.GrammarTypeLexerContext);
		}
		
		static new public DOMElement_GrammarType_Lexer DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).grammarType());
		}
		
		static new public DOMElement_GrammarType_Lexer DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).grammarType());
		}
		
		static new public DOMElement_GrammarType_Lexer DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).grammarType());
		}
		
		public DOMElement_GrammarType_Lexer()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_GrammarType_Lexer(DOMEParser.GrammarTypeLexerContext context) : this()
		{
		}
		
		public override DOMElement_GrammarType Duplicate()
		{
			DOMElement_GrammarType_Lexer instance = new DOMElement_GrammarType_Lexer();
			return instance;
		}
		
	}
	
	public partial class DOMElement_Configuration_Info : DOMElement_Configuration
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Settings> settings;
		static public DOMElement_Configuration_Info DOMify(DOMEParser.InfoContext context)
		{
			if(context != null)
			{
				return new DOMElement_Configuration_Info(context);
			}
			
			return null;
		}
		
		static public DOMElement_Configuration_Info DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.InfoContext);
		}
		
		static public DOMElement_Configuration_Info DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).info());
		}
		
		static public DOMElement_Configuration_Info DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).info());
		}
		
		static public DOMElement_Configuration_Info DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).info());
		}
		
		public DOMElement_Configuration_Info()
		{
			settings = new HoldingSingle<DOMElement, DOMElement_Settings>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Configuration_Info(DOMEParser.InfoContext context) : this()
		{
			SetSettings(DOMElement_Settings.DOMify(context.settings()));
		}
		
		public DOMElement_Configuration_Info Duplicate()
		{
			DOMElement_Configuration_Info instance = new DOMElement_Configuration_Info();
			instance.SetSettings(GetSettings().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetSettings(DOMElement_Settings input)
		{
			settings.Set(input);
		}
		
		public override DOMElement_Settings GetSettings()
		{
			return settings.Get();
		}
		
	}
	
	public abstract partial class DOMElement_Quantifier : DOMElement
	{
		public abstract DOMElement_Quantifier Duplicate();
		static public DOMElement_Quantifier DOMify(DOMEParser.QuantifierContext context)
		{
			return DOMEResolver.Resolve<DOMElement_Quantifier>(context);
		}
		
		static public DOMElement_Quantifier DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.QuantifierContext);
		}
		
		static public DOMElement_Quantifier DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).quantifier());
		}
		
		static public DOMElement_Quantifier DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).quantifier());
		}
		
		static public DOMElement_Quantifier DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).quantifier());
		}
		
	}
	
	public partial class DOMElement_Quantifier_NoneOrOne : DOMElement_Quantifier
	{
		static public DOMElement_Quantifier_NoneOrOne DOMify(DOMEParser.QuantifierNoneOrOneContext context)
		{
			if(context != null)
			{
				return new DOMElement_Quantifier_NoneOrOne(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Quantifier_NoneOrOne DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.QuantifierNoneOrOneContext);
		}
		
		static new public DOMElement_Quantifier_NoneOrOne DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).quantifier());
		}
		
		static new public DOMElement_Quantifier_NoneOrOne DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).quantifier());
		}
		
		static new public DOMElement_Quantifier_NoneOrOne DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).quantifier());
		}
		
		public DOMElement_Quantifier_NoneOrOne()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Quantifier_NoneOrOne(DOMEParser.QuantifierNoneOrOneContext context) : this()
		{
		}
		
		public override DOMElement_Quantifier Duplicate()
		{
			DOMElement_Quantifier_NoneOrOne instance = new DOMElement_Quantifier_NoneOrOne();
			return instance;
		}
		
	}
	
	public partial class DOMElement_Quantifier_NoneOrMore : DOMElement_Quantifier
	{
		static public DOMElement_Quantifier_NoneOrMore DOMify(DOMEParser.QuantifierNoneOrMoreContext context)
		{
			if(context != null)
			{
				return new DOMElement_Quantifier_NoneOrMore(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Quantifier_NoneOrMore DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.QuantifierNoneOrMoreContext);
		}
		
		static new public DOMElement_Quantifier_NoneOrMore DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).quantifier());
		}
		
		static new public DOMElement_Quantifier_NoneOrMore DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).quantifier());
		}
		
		static new public DOMElement_Quantifier_NoneOrMore DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).quantifier());
		}
		
		public DOMElement_Quantifier_NoneOrMore()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Quantifier_NoneOrMore(DOMEParser.QuantifierNoneOrMoreContext context) : this()
		{
		}
		
		public override DOMElement_Quantifier Duplicate()
		{
			DOMElement_Quantifier_NoneOrMore instance = new DOMElement_Quantifier_NoneOrMore();
			return instance;
		}
		
	}
	
	public partial class DOMElement_Quantifier_OneOrMore : DOMElement_Quantifier
	{
		static public DOMElement_Quantifier_OneOrMore DOMify(DOMEParser.QuantifierOneOrMoreContext context)
		{
			if(context != null)
			{
				return new DOMElement_Quantifier_OneOrMore(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Quantifier_OneOrMore DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.QuantifierOneOrMoreContext);
		}
		
		static new public DOMElement_Quantifier_OneOrMore DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).quantifier());
		}
		
		static new public DOMElement_Quantifier_OneOrMore DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).quantifier());
		}
		
		static new public DOMElement_Quantifier_OneOrMore DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).quantifier());
		}
		
		public DOMElement_Quantifier_OneOrMore()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Quantifier_OneOrMore(DOMEParser.QuantifierOneOrMoreContext context) : this()
		{
		}
		
		public override DOMElement_Quantifier Duplicate()
		{
			DOMElement_Quantifier_OneOrMore instance = new DOMElement_Quantifier_OneOrMore();
			return instance;
		}
		
	}
	
	public partial class DOMElement_RuleReference : DOMElement
	{
		private string rule_id;
		static public DOMElement_RuleReference DOMify(DOMEParser.RuleReferenceContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleReference(context);
			}
			
			return null;
		}
		
		static public DOMElement_RuleReference DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleReferenceContext);
		}
		
		static public DOMElement_RuleReference DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleReference());
		}
		
		static public DOMElement_RuleReference DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleReference());
		}
		
		static public DOMElement_RuleReference DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleReference());
		}
		
		public DOMElement_RuleReference()
		{
			rule_id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleReference(DOMEParser.RuleReferenceContext context) : this()
		{
			SetRuleId(context.RULE_ID().GetTextEX());
		}
		
		public DOMElement_RuleReference Duplicate()
		{
			DOMElement_RuleReference instance = new DOMElement_RuleReference();
			instance.SetRuleId(GetRuleId());
			return instance;
		}
		
		private void SetRuleId(string input)
		{
			rule_id = input;
		}
		
		public string GetRuleId()
		{
			return rule_id;
		}
		
	}
	
	public partial class DOMElement_RuleDefinition_Concrete_Direct : DOMElement_RuleDefinition_Concrete
	{
		private string rule_id;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleExpression> rule_expression;
		static public DOMElement_RuleDefinition_Concrete_Direct DOMify(DOMEParser.RuleDefinitionConcreteDirectContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleDefinition_Concrete_Direct(context);
			}
			
			return null;
		}
		
		static public DOMElement_RuleDefinition_Concrete_Direct DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleDefinitionConcreteDirectContext);
		}
		
		static public DOMElement_RuleDefinition_Concrete_Direct DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleDefinitionConcreteDirect());
		}
		
		static public DOMElement_RuleDefinition_Concrete_Direct DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleDefinitionConcreteDirect());
		}
		
		static public DOMElement_RuleDefinition_Concrete_Direct DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleDefinitionConcreteDirect());
		}
		
		public DOMElement_RuleDefinition_Concrete_Direct()
		{
			rule_id = "";
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			rule_expression = new HoldingSingle<DOMElement, DOMElement_RuleExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleDefinition_Concrete_Direct(DOMEParser.RuleDefinitionConcreteDirectContext context) : this()
		{
			SetRuleId(context.RULE_ID().GetTextEX());
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
			SetRuleExpression(DOMElement_RuleExpression.DOMify(context.ruleExpression()));
		}
		
		public DOMElement_RuleDefinition_Concrete_Direct Duplicate()
		{
			DOMElement_RuleDefinition_Concrete_Direct instance = new DOMElement_RuleDefinition_Concrete_Direct();
			instance.SetRuleId(GetRuleId());
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			instance.SetRuleExpression(GetRuleExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleId(string input)
		{
			rule_id = input;
		}
		
		public override string GetRuleId()
		{
			return rule_id;
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public override DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
		private void SetRuleExpression(DOMElement_RuleExpression input)
		{
			rule_expression.Set(input);
		}
		
		public override DOMElement_RuleExpression GetRuleExpression()
		{
			return rule_expression.Get();
		}
		
	}
	
	public partial class DOMElement_RuleDefinition_Concrete_Inherited : DOMElement_RuleDefinition_Concrete
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleExpression> rule_expression;
		private string rule_id;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		static public DOMElement_RuleDefinition_Concrete_Inherited DOMify(DOMEParser.RuleDefinitionConcreteInheritedContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleDefinition_Concrete_Inherited(context);
			}
			
			return null;
		}
		
		static public DOMElement_RuleDefinition_Concrete_Inherited DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleDefinitionConcreteInheritedContext);
		}
		
		static public DOMElement_RuleDefinition_Concrete_Inherited DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleDefinitionConcreteInherited());
		}
		
		static public DOMElement_RuleDefinition_Concrete_Inherited DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleDefinitionConcreteInherited());
		}
		
		static public DOMElement_RuleDefinition_Concrete_Inherited DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleDefinitionConcreteInherited());
		}
		
		public DOMElement_RuleDefinition_Concrete_Inherited()
		{
			rule_expression = new HoldingSingle<DOMElement, DOMElement_RuleExpression>(this);
			rule_id = "";
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleDefinition_Concrete_Inherited(DOMEParser.RuleDefinitionConcreteInheritedContext context) : this()
		{
			SetRuleExpression(DOMElement_RuleExpression.DOMify(context.ruleExpression()));
			SetRuleId(context.RULE_ID().GetTextEX());
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
		}
		
		public DOMElement_RuleDefinition_Concrete_Inherited Duplicate()
		{
			DOMElement_RuleDefinition_Concrete_Inherited instance = new DOMElement_RuleDefinition_Concrete_Inherited();
			instance.SetRuleExpression(GetRuleExpression().IfNotNull(z => z.Duplicate()));
			instance.SetRuleId(GetRuleId());
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleExpression(DOMElement_RuleExpression input)
		{
			rule_expression.Set(input);
		}
		
		public override DOMElement_RuleExpression GetRuleExpression()
		{
			return rule_expression.Get();
		}
		
		private void SetRuleId(string input)
		{
			rule_id = input;
		}
		
		public override string GetRuleId()
		{
			return rule_id;
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public override DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
	}
	
	public partial class DOMElement_RuleDefinition_Abstract : DOMElement_RuleDefinition
	{
		private string rule_id;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		[RelatableChild]private HoldingList<DOMElement, DOMElement_RuleDefinition_Concrete_Inherited> rule_definition_concrete_inheriteds;
		static public DOMElement_RuleDefinition_Abstract DOMify(DOMEParser.RuleDefinitionAbstractContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleDefinition_Abstract(context);
			}
			
			return null;
		}
		
		static public DOMElement_RuleDefinition_Abstract DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleDefinitionAbstractContext);
		}
		
		static public DOMElement_RuleDefinition_Abstract DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleDefinitionAbstract());
		}
		
		static public DOMElement_RuleDefinition_Abstract DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleDefinitionAbstract());
		}
		
		static public DOMElement_RuleDefinition_Abstract DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleDefinitionAbstract());
		}
		
		public DOMElement_RuleDefinition_Abstract()
		{
			rule_id = "";
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			rule_definition_concrete_inheriteds = new HoldingList<DOMElement, DOMElement_RuleDefinition_Concrete_Inherited>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleDefinition_Abstract(DOMEParser.RuleDefinitionAbstractContext context) : this()
		{
			SetRuleId(context.RULE_ID().GetTextEX());
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
			AddRuleDefinitionConcreteInheriteds(context.ruleDefinitionConcreteInherited().Convert(c => DOMElement_RuleDefinition_Concrete_Inherited.DOMify(c)));
		}
		
		public DOMElement_RuleDefinition_Abstract Duplicate()
		{
			DOMElement_RuleDefinition_Abstract instance = new DOMElement_RuleDefinition_Abstract();
			instance.SetRuleId(GetRuleId());
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			instance.SetRuleDefinitionConcreteInheriteds(GetRuleDefinitionConcreteInheriteds().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void SetRuleId(string input)
		{
			rule_id = input;
		}
		
		public override string GetRuleId()
		{
			return rule_id;
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public override DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
		private void ClearRuleDefinitionConcreteInheriteds()
		{
			rule_definition_concrete_inheriteds.Clear();
		}
		
		private void SetRuleDefinitionConcreteInheriteds(IEnumerable<DOMElement_RuleDefinition_Concrete_Inherited> input)
		{
			ClearRuleDefinitionConcreteInheriteds();
			AddRuleDefinitionConcreteInheriteds(input);
		}
		
		private void SetRuleDefinitionConcreteInheriteds(params DOMElement_RuleDefinition_Concrete_Inherited[] input)
		{
			SetRuleDefinitionConcreteInheriteds((IEnumerable<DOMElement_RuleDefinition_Concrete_Inherited>)input);
		}
		
		private void AddRuleDefinitionConcreteInherited(DOMElement_RuleDefinition_Concrete_Inherited input)
		{
			rule_definition_concrete_inheriteds.Add(input);
		}
		
		private void AddRuleDefinitionConcreteInheriteds(IEnumerable<DOMElement_RuleDefinition_Concrete_Inherited> input)
		{
			input.ProcessCopy(i => AddRuleDefinitionConcreteInherited(i));
		}
		
		private void AddRuleDefinitionConcreteInheriteds(params DOMElement_RuleDefinition_Concrete_Inherited[] input)
		{
			AddRuleDefinitionConcreteInheriteds((IEnumerable<DOMElement_RuleDefinition_Concrete_Inherited>)input);
		}
		
		public IEnumerable<DOMElement_RuleDefinition_Concrete_Inherited> GetRuleDefinitionConcreteInheriteds()
		{
			return rule_definition_concrete_inheriteds;
		}
		
	}
	
	public abstract partial class DOMElement_RuleAtom : DOMElement
	{
		public abstract DOMElement_RuleAtom Duplicate();
		static public DOMElement_RuleAtom DOMify(DOMEParser.RuleAtomContext context)
		{
			return DOMEResolver.Resolve<DOMElement_RuleAtom>(context);
		}
		
		static public DOMElement_RuleAtom DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleAtomContext);
		}
		
		static public DOMElement_RuleAtom DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleAtom());
		}
		
		static public DOMElement_RuleAtom DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleAtom());
		}
		
		static public DOMElement_RuleAtom DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleAtom());
		}
		
	}
	
	public partial class DOMElement_RuleAtom_Literal : DOMElement_RuleAtom
	{
		private string literal_string;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		static public DOMElement_RuleAtom_Literal DOMify(DOMEParser.RuleAtomLiteralContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleAtom_Literal(context);
			}
			
			return null;
		}
		
		static new public DOMElement_RuleAtom_Literal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleAtomLiteralContext);
		}
		
		static new public DOMElement_RuleAtom_Literal DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Literal DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Literal DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleAtom());
		}
		
		public DOMElement_RuleAtom_Literal()
		{
			literal_string = "";
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleAtom_Literal(DOMEParser.RuleAtomLiteralContext context) : this()
		{
			LoadContextIntermediateLiteralString(context.LITERAL_STRING().GetTextEX());
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
		}
		
		public override DOMElement_RuleAtom Duplicate()
		{
			DOMElement_RuleAtom_Literal instance = new DOMElement_RuleAtom_Literal();
			instance.SetLiteralString(GetLiteralString());
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLiteralString(string input)
		{
			literal_string = input;
		}
		
		public string GetLiteralString()
		{
			return literal_string;
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
	}
	
	public partial class DOMElement_RuleAtom_Variable_Reference_Token : DOMElement_RuleAtom_Variable_Reference
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_TokenReference> token_reference;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		static public DOMElement_RuleAtom_Variable_Reference_Token DOMify(DOMEParser.RuleAtomTokenReferenceContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleAtom_Variable_Reference_Token(context);
			}
			
			return null;
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Token DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleAtomTokenReferenceContext);
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Token DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Token DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Token DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleAtom());
		}
		
		public DOMElement_RuleAtom_Variable_Reference_Token()
		{
			token_reference = new HoldingSingle<DOMElement, DOMElement_TokenReference>(this);
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleAtom_Variable_Reference_Token(DOMEParser.RuleAtomTokenReferenceContext context) : this()
		{
			SetTokenReference(DOMElement_TokenReference.DOMify(context.tokenReference()));
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
		}
		
		public override DOMElement_RuleAtom Duplicate()
		{
			DOMElement_RuleAtom_Variable_Reference_Token instance = new DOMElement_RuleAtom_Variable_Reference_Token();
			instance.SetTokenReference(GetTokenReference().IfNotNull(z => z.Duplicate()));
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTokenReference(DOMElement_TokenReference input)
		{
			token_reference.Set(input);
		}
		
		public DOMElement_TokenReference GetTokenReference()
		{
			return token_reference.Get();
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public override DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public override DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
	}
	
	public partial class DOMElement_RuleAtom_Variable_Reference_Rule : DOMElement_RuleAtom_Variable_Reference
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleReference> rule_reference;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		static public DOMElement_RuleAtom_Variable_Reference_Rule DOMify(DOMEParser.RuleAtomRuleReferenceContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleAtom_Variable_Reference_Rule(context);
			}
			
			return null;
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Rule DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleAtomRuleReferenceContext);
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Rule DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Rule DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Variable_Reference_Rule DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleAtom());
		}
		
		public DOMElement_RuleAtom_Variable_Reference_Rule()
		{
			rule_reference = new HoldingSingle<DOMElement, DOMElement_RuleReference>(this);
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleAtom_Variable_Reference_Rule(DOMEParser.RuleAtomRuleReferenceContext context) : this()
		{
			SetRuleReference(DOMElement_RuleReference.DOMify(context.ruleReference()));
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
		}
		
		public override DOMElement_RuleAtom Duplicate()
		{
			DOMElement_RuleAtom_Variable_Reference_Rule instance = new DOMElement_RuleAtom_Variable_Reference_Rule();
			instance.SetRuleReference(GetRuleReference().IfNotNull(z => z.Duplicate()));
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleReference(DOMElement_RuleReference input)
		{
			rule_reference.Set(input);
		}
		
		public DOMElement_RuleReference GetRuleReference()
		{
			return rule_reference.Get();
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public override DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public override DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
	}
	
	public partial class DOMElement_RuleAtom_Group : DOMElement_RuleAtom
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleExpression> rule_expression;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		static public DOMElement_RuleAtom_Group DOMify(DOMEParser.RuleAtomGroupContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleAtom_Group(context);
			}
			
			return null;
		}
		
		static new public DOMElement_RuleAtom_Group DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleAtomGroupContext);
		}
		
		static new public DOMElement_RuleAtom_Group DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Group DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Group DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleAtom());
		}
		
		public DOMElement_RuleAtom_Group()
		{
			rule_expression = new HoldingSingle<DOMElement, DOMElement_RuleExpression>(this);
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleAtom_Group(DOMEParser.RuleAtomGroupContext context) : this()
		{
			SetRuleExpression(DOMElement_RuleExpression.DOMify(context.ruleExpression()));
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
		}
		
		public override DOMElement_RuleAtom Duplicate()
		{
			DOMElement_RuleAtom_Group instance = new DOMElement_RuleAtom_Group();
			instance.SetRuleExpression(GetRuleExpression().IfNotNull(z => z.Duplicate()));
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleExpression(DOMElement_RuleExpression input)
		{
			rule_expression.Set(input);
		}
		
		public DOMElement_RuleExpression GetRuleExpression()
		{
			return rule_expression.Get();
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
	}
	
	public partial class DOMElement_RuleAtom_Variable_InfoGroup : DOMElement_RuleAtom_Variable
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_RuleExpression> rule_expression;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		static public DOMElement_RuleAtom_Variable_InfoGroup DOMify(DOMEParser.RuleAtomInfoGroupContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleAtom_Variable_InfoGroup(context);
			}
			
			return null;
		}
		
		static new public DOMElement_RuleAtom_Variable_InfoGroup DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleAtomInfoGroupContext);
		}
		
		static new public DOMElement_RuleAtom_Variable_InfoGroup DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Variable_InfoGroup DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleAtom());
		}
		
		static new public DOMElement_RuleAtom_Variable_InfoGroup DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleAtom());
		}
		
		public DOMElement_RuleAtom_Variable_InfoGroup()
		{
			rule_expression = new HoldingSingle<DOMElement, DOMElement_RuleExpression>(this);
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleAtom_Variable_InfoGroup(DOMEParser.RuleAtomInfoGroupContext context) : this()
		{
			SetRuleExpression(DOMElement_RuleExpression.DOMify(context.ruleExpression()));
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
		}
		
		public override DOMElement_RuleAtom Duplicate()
		{
			DOMElement_RuleAtom_Variable_InfoGroup instance = new DOMElement_RuleAtom_Variable_InfoGroup();
			instance.SetRuleExpression(GetRuleExpression().IfNotNull(z => z.Duplicate()));
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetRuleExpression(DOMElement_RuleExpression input)
		{
			rule_expression.Set(input);
		}
		
		public DOMElement_RuleExpression GetRuleExpression()
		{
			return rule_expression.Get();
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public override DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
	}
	
	public abstract partial class DOMElement_RuleExpression : DOMElement
	{
		public abstract DOMElement_RuleExpression Duplicate();
		static public DOMElement_RuleExpression DOMify(DOMEParser.RuleExpressionContext context)
		{
			return DOMEResolver.Resolve<DOMElement_RuleExpression>(context);
		}
		
		static public DOMElement_RuleExpression DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleExpressionContext);
		}
		
		static public DOMElement_RuleExpression DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleExpression());
		}
		
		static public DOMElement_RuleExpression DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleExpression());
		}
		
		static public DOMElement_RuleExpression DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleExpression());
		}
		
	}
	
	public partial class DOMElement_RuleExpression_Sequence : DOMElement_RuleExpression
	{
		[RelatableChild]private HoldingList<DOMElement, DOMElement_RuleAtom> rule_atoms;
		static public DOMElement_RuleExpression_Sequence DOMify(DOMEParser.RuleExpression_SequenceContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleExpression_Sequence(context);
			}
			
			return null;
		}
		
		static new public DOMElement_RuleExpression_Sequence DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleExpression_SequenceContext);
		}
		
		static new public DOMElement_RuleExpression_Sequence DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleExpression());
		}
		
		static new public DOMElement_RuleExpression_Sequence DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleExpression());
		}
		
		static new public DOMElement_RuleExpression_Sequence DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleExpression());
		}
		
		public DOMElement_RuleExpression_Sequence()
		{
			rule_atoms = new HoldingList<DOMElement, DOMElement_RuleAtom>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleExpression_Sequence(DOMEParser.RuleExpression_SequenceContext context) : this()
		{
			AddRuleAtoms(context.ruleAtom().Convert(c => DOMElement_RuleAtom.DOMify(c)));
		}
		
		public override DOMElement_RuleExpression Duplicate()
		{
			DOMElement_RuleExpression_Sequence instance = new DOMElement_RuleExpression_Sequence();
			instance.SetRuleAtoms(GetRuleAtoms().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearRuleAtoms()
		{
			rule_atoms.Clear();
		}
		
		private void SetRuleAtoms(IEnumerable<DOMElement_RuleAtom> input)
		{
			ClearRuleAtoms();
			AddRuleAtoms(input);
		}
		
		private void SetRuleAtoms(params DOMElement_RuleAtom[] input)
		{
			SetRuleAtoms((IEnumerable<DOMElement_RuleAtom>)input);
		}
		
		private void AddRuleAtom(DOMElement_RuleAtom input)
		{
			rule_atoms.Add(input);
		}
		
		private void AddRuleAtoms(IEnumerable<DOMElement_RuleAtom> input)
		{
			input.ProcessCopy(i => AddRuleAtom(i));
		}
		
		private void AddRuleAtoms(params DOMElement_RuleAtom[] input)
		{
			AddRuleAtoms((IEnumerable<DOMElement_RuleAtom>)input);
		}
		
		public IEnumerable<DOMElement_RuleAtom> GetRuleAtoms()
		{
			return rule_atoms;
		}
		
	}
	
	public partial class DOMElement_RuleExpression_Alternatives : DOMElement_RuleExpression
	{
		[RelatableChild]private HoldingList<DOMElement, DOMElement_RuleExpression> rule_expressions;
		static public DOMElement_RuleExpression_Alternatives DOMify(DOMEParser.RuleExpression_AlternativesContext context)
		{
			if(context != null)
			{
				return new DOMElement_RuleExpression_Alternatives(context);
			}
			
			return null;
		}
		
		static new public DOMElement_RuleExpression_Alternatives DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.RuleExpression_AlternativesContext);
		}
		
		static new public DOMElement_RuleExpression_Alternatives DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).ruleExpression());
		}
		
		static new public DOMElement_RuleExpression_Alternatives DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).ruleExpression());
		}
		
		static new public DOMElement_RuleExpression_Alternatives DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).ruleExpression());
		}
		
		public DOMElement_RuleExpression_Alternatives()
		{
			rule_expressions = new HoldingList<DOMElement, DOMElement_RuleExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_RuleExpression_Alternatives(DOMEParser.RuleExpression_AlternativesContext context) : this()
		{
			AddRuleExpressions(context.ruleExpression().Convert(c => DOMElement_RuleExpression.DOMify(c)));
		}
		
		public override DOMElement_RuleExpression Duplicate()
		{
			DOMElement_RuleExpression_Alternatives instance = new DOMElement_RuleExpression_Alternatives();
			instance.SetRuleExpressions(GetRuleExpressions().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearRuleExpressions()
		{
			rule_expressions.Clear();
		}
		
		private void SetRuleExpressions(IEnumerable<DOMElement_RuleExpression> input)
		{
			ClearRuleExpressions();
			AddRuleExpressions(input);
		}
		
		private void SetRuleExpressions(params DOMElement_RuleExpression[] input)
		{
			SetRuleExpressions((IEnumerable<DOMElement_RuleExpression>)input);
		}
		
		private void AddRuleExpression(DOMElement_RuleExpression input)
		{
			rule_expressions.Add(input);
		}
		
		private void AddRuleExpressions(IEnumerable<DOMElement_RuleExpression> input)
		{
			input.ProcessCopy(i => AddRuleExpression(i));
		}
		
		private void AddRuleExpressions(params DOMElement_RuleExpression[] input)
		{
			AddRuleExpressions((IEnumerable<DOMElement_RuleExpression>)input);
		}
		
		public IEnumerable<DOMElement_RuleExpression> GetRuleExpressions()
		{
			return rule_expressions;
		}
		
	}
	
	public partial class DOMElement_Settings : DOMElement
	{
		[RelatableChild]private HoldingList<DOMElement, DOMElement_Setting> settings;
		static public DOMElement_Settings DOMify(DOMEParser.SettingsContext context)
		{
			if(context != null)
			{
				return new DOMElement_Settings(context);
			}
			
			return null;
		}
		
		static public DOMElement_Settings DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.SettingsContext);
		}
		
		static public DOMElement_Settings DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).settings());
		}
		
		static public DOMElement_Settings DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).settings());
		}
		
		static public DOMElement_Settings DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).settings());
		}
		
		public DOMElement_Settings()
		{
			settings = new HoldingList<DOMElement, DOMElement_Setting>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Settings(DOMEParser.SettingsContext context) : this()
		{
			AddSettings(context.setting().Convert(c => DOMElement_Setting.DOMify(c)));
		}
		
		public DOMElement_Settings Duplicate()
		{
			DOMElement_Settings instance = new DOMElement_Settings();
			instance.SetSettings(GetSettings().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearSettings()
		{
			settings.Clear();
		}
		
		private void SetSettings(IEnumerable<DOMElement_Setting> input)
		{
			ClearSettings();
			AddSettings(input);
		}
		
		private void SetSettings(params DOMElement_Setting[] input)
		{
			SetSettings((IEnumerable<DOMElement_Setting>)input);
		}
		
		private void AddSetting(DOMElement_Setting input)
		{
			settings.Add(input);
		}
		
		private void AddSettings(IEnumerable<DOMElement_Setting> input)
		{
			input.ProcessCopy(i => AddSetting(i));
		}
		
		private void AddSettings(params DOMElement_Setting[] input)
		{
			AddSettings((IEnumerable<DOMElement_Setting>)input);
		}
		
		public IEnumerable<DOMElement_Setting> GetSettings()
		{
			return settings;
		}
		
	}
	
	public abstract partial class DOMElement_Setting : DOMElement
	{
		public abstract DOMElement_Setting Duplicate();
		static public DOMElement_Setting DOMify(DOMEParser.SettingContext context)
		{
			return DOMEResolver.Resolve<DOMElement_Setting>(context);
		}
		
		static public DOMElement_Setting DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.SettingContext);
		}
		
		static public DOMElement_Setting DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).setting());
		}
		
		static public DOMElement_Setting DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).setting());
		}
		
		static public DOMElement_Setting DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).setting());
		}
		
	}
	
	public partial class DOMElement_Setting_Flag : DOMElement_Setting
	{
		private string name;
		static public DOMElement_Setting_Flag DOMify(DOMEParser.Setting_FlagContext context)
		{
			if(context != null)
			{
				return new DOMElement_Setting_Flag(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Setting_Flag DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.Setting_FlagContext);
		}
		
		static new public DOMElement_Setting_Flag DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).setting());
		}
		
		static new public DOMElement_Setting_Flag DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).setting());
		}
		
		static new public DOMElement_Setting_Flag DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).setting());
		}
		
		public DOMElement_Setting_Flag()
		{
			name = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Setting_Flag(DOMEParser.Setting_FlagContext context) : this()
		{
			SetName(context.id().GetTextEX());
		}
		
		public override DOMElement_Setting Duplicate()
		{
			DOMElement_Setting_Flag instance = new DOMElement_Setting_Flag();
			instance.SetName(GetName());
			return instance;
		}
		
		private void SetName(string input)
		{
			name = input;
		}
		
		public override string GetName()
		{
			return name;
		}
		
	}
	
	public partial class DOMElement_Setting_Value : DOMElement_Setting
	{
		private string name;
		private string value;
		static public DOMElement_Setting_Value DOMify(DOMEParser.Setting_ValueContext context)
		{
			if(context != null)
			{
				return new DOMElement_Setting_Value(context);
			}
			
			return null;
		}
		
		static new public DOMElement_Setting_Value DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.Setting_ValueContext);
		}
		
		static new public DOMElement_Setting_Value DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).setting());
		}
		
		static new public DOMElement_Setting_Value DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).setting());
		}
		
		static new public DOMElement_Setting_Value DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).setting());
		}
		
		public DOMElement_Setting_Value()
		{
			name = "";
			value = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_Setting_Value(DOMEParser.Setting_ValueContext context) : this()
		{
			SetName(context.id(0).GetTextEX());
			SetValue(context.id(1).GetTextEX());
		}
		
		public override DOMElement_Setting Duplicate()
		{
			DOMElement_Setting_Value instance = new DOMElement_Setting_Value();
			instance.SetName(GetName());
			instance.SetValue(GetValue());
			return instance;
		}
		
		private void SetName(string input)
		{
			name = input;
		}
		
		public override string GetName()
		{
			return name;
		}
		
		private void SetValue(string input)
		{
			value = input;
		}
		
		public override string GetValue()
		{
			return value;
		}
		
	}
	
	public partial class DOMElement_TokenReference : DOMElement
	{
		private string token_id;
		static public DOMElement_TokenReference DOMify(DOMEParser.TokenReferenceContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenReference(context);
			}
			
			return null;
		}
		
		static public DOMElement_TokenReference DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenReferenceContext);
		}
		
		static public DOMElement_TokenReference DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenReference());
		}
		
		static public DOMElement_TokenReference DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenReference());
		}
		
		static public DOMElement_TokenReference DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenReference());
		}
		
		public DOMElement_TokenReference()
		{
			token_id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenReference(DOMEParser.TokenReferenceContext context) : this()
		{
			SetTokenId(context.TOKEN_ID().GetTextEX());
		}
		
		public DOMElement_TokenReference Duplicate()
		{
			DOMElement_TokenReference instance = new DOMElement_TokenReference();
			instance.SetTokenId(GetTokenId());
			return instance;
		}
		
		private void SetTokenId(string input)
		{
			token_id = input;
		}
		
		public string GetTokenId()
		{
			return token_id;
		}
		
	}
	
	public partial class DOMElement_TokenDefinition : DOMElement
	{
		private string token_id;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_TokenAtom> token_atom;
		private string id;
		static public DOMElement_TokenDefinition DOMify(DOMEParser.TokenDefinitionContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenDefinition(context);
			}
			
			return null;
		}
		
		static public DOMElement_TokenDefinition DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenDefinitionContext);
		}
		
		static public DOMElement_TokenDefinition DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenDefinition());
		}
		
		static public DOMElement_TokenDefinition DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenDefinition());
		}
		
		static public DOMElement_TokenDefinition DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenDefinition());
		}
		
		public DOMElement_TokenDefinition()
		{
			token_id = "";
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			token_atom = new HoldingSingle<DOMElement, DOMElement_TokenAtom>(this);
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenDefinition(DOMEParser.TokenDefinitionContext context) : this()
		{
			SetTokenId(context.TOKEN_ID().GetTextEX());
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
			SetTokenAtom(DOMElement_TokenAtom.DOMify(context.tokenAtom()));
			SetId(context.id().GetTextEX());
		}
		
		public DOMElement_TokenDefinition Duplicate()
		{
			DOMElement_TokenDefinition instance = new DOMElement_TokenDefinition();
			instance.SetTokenId(GetTokenId());
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			instance.SetTokenAtom(GetTokenAtom().IfNotNull(z => z.Duplicate()));
			instance.SetId(GetId());
			return instance;
		}
		
		private void SetTokenId(string input)
		{
			token_id = input;
		}
		
		public string GetTokenId()
		{
			return token_id;
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
		private void SetTokenAtom(DOMElement_TokenAtom input)
		{
			token_atom.Set(input);
		}
		
		public DOMElement_TokenAtom GetTokenAtom()
		{
			return token_atom.Get();
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public string GetId()
		{
			return id;
		}
		
	}
	
	public abstract partial class DOMElement_TokenAtom : DOMElement
	{
		public abstract DOMElement_TokenAtom Duplicate();
		static public DOMElement_TokenAtom DOMify(DOMEParser.TokenAtomContext context)
		{
			return DOMEResolver.Resolve<DOMElement_TokenAtom>(context);
		}
		
		static public DOMElement_TokenAtom DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomContext);
		}
		
		static public DOMElement_TokenAtom DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static public DOMElement_TokenAtom DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static public DOMElement_TokenAtom DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
	}
	
	public partial class DOMElement_TokenAtom_Literal : DOMElement_TokenAtom
	{
		private string literal_string;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		static public DOMElement_TokenAtom_Literal DOMify(DOMEParser.TokenAtomLiteralContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_Literal(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_Literal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomLiteralContext);
		}
		
		static new public DOMElement_TokenAtom_Literal DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Literal DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Literal DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_Literal()
		{
			literal_string = "";
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_Literal(DOMEParser.TokenAtomLiteralContext context) : this()
		{
			SetLiteralString(context.LITERAL_STRING().GetTextEX());
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_Literal instance = new DOMElement_TokenAtom_Literal();
			instance.SetLiteralString(GetLiteralString());
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLiteralString(string input)
		{
			literal_string = input;
		}
		
		public string GetLiteralString()
		{
			return literal_string;
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
	}
	
	public partial class DOMElement_TokenAtom_Class : DOMElement_TokenAtom
	{
		private string literal_class;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		static public DOMElement_TokenAtom_Class DOMify(DOMEParser.TokenAtomClassContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_Class(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_Class DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomClassContext);
		}
		
		static new public DOMElement_TokenAtom_Class DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Class DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Class DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_Class()
		{
			literal_class = "";
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_Class(DOMEParser.TokenAtomClassContext context) : this()
		{
			SetLiteralClass(context.LITERAL_CLASS().GetTextEX());
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_Class instance = new DOMElement_TokenAtom_Class();
			instance.SetLiteralClass(GetLiteralClass());
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLiteralClass(string input)
		{
			literal_class = input;
		}
		
		public string GetLiteralClass()
		{
			return literal_class;
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
	}
	
	public partial class DOMElement_TokenAtom_Period : DOMElement_TokenAtom
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		static public DOMElement_TokenAtom_Period DOMify(DOMEParser.TokenAtomPeriodContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_Period(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_Period DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomPeriodContext);
		}
		
		static new public DOMElement_TokenAtom_Period DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Period DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Period DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_Period()
		{
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_Period(DOMEParser.TokenAtomPeriodContext context) : this()
		{
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_Period instance = new DOMElement_TokenAtom_Period();
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
	}
	
	public partial class DOMElement_TokenAtom_TokenReference : DOMElement_TokenAtom
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_TokenReference> token_reference;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		static public DOMElement_TokenAtom_TokenReference DOMify(DOMEParser.TokenAtomTokenReferenceContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_TokenReference(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_TokenReference DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomTokenReferenceContext);
		}
		
		static new public DOMElement_TokenAtom_TokenReference DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_TokenReference DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_TokenReference DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_TokenReference()
		{
			token_reference = new HoldingSingle<DOMElement, DOMElement_TokenReference>(this);
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_TokenReference(DOMEParser.TokenAtomTokenReferenceContext context) : this()
		{
			SetTokenReference(DOMElement_TokenReference.DOMify(context.tokenReference()));
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_TokenReference instance = new DOMElement_TokenAtom_TokenReference();
			instance.SetTokenReference(GetTokenReference().IfNotNull(z => z.Duplicate()));
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTokenReference(DOMElement_TokenReference input)
		{
			token_reference.Set(input);
		}
		
		public DOMElement_TokenReference GetTokenReference()
		{
			return token_reference.Get();
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
	}
	
	public partial class DOMElement_TokenAtom_Group : DOMElement_TokenAtom
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_TokenAtom> token_atom;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		static public DOMElement_TokenAtom_Group DOMify(DOMEParser.TokenAtomGroupContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_Group(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_Group DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomGroupContext);
		}
		
		static new public DOMElement_TokenAtom_Group DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Group DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Group DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_Group()
		{
			token_atom = new HoldingSingle<DOMElement, DOMElement_TokenAtom>(this);
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_Group(DOMEParser.TokenAtomGroupContext context) : this()
		{
			SetTokenAtom(DOMElement_TokenAtom.DOMify(context.tokenAtom()));
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_Group instance = new DOMElement_TokenAtom_Group();
			instance.SetTokenAtom(GetTokenAtom().IfNotNull(z => z.Duplicate()));
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTokenAtom(DOMElement_TokenAtom input)
		{
			token_atom.Set(input);
		}
		
		public DOMElement_TokenAtom GetTokenAtom()
		{
			return token_atom.Get();
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
	}
	
	public partial class DOMElement_TokenAtom_Alternatives : DOMElement_TokenAtom
	{
		[RelatableChild]private HoldingList<DOMElement, DOMElement_TokenAtom> token_atoms;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Quantifier> quantifier;
		static public DOMElement_TokenAtom_Alternatives DOMify(DOMEParser.TokenAtomAlternativesContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_Alternatives(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_Alternatives DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomAlternativesContext);
		}
		
		static new public DOMElement_TokenAtom_Alternatives DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Alternatives DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Alternatives DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_Alternatives()
		{
			token_atoms = new HoldingList<DOMElement, DOMElement_TokenAtom>(this);
			quantifier = new HoldingSingle<DOMElement, DOMElement_Quantifier>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_Alternatives(DOMEParser.TokenAtomAlternativesContext context) : this()
		{
			AddTokenAtoms(context.tokenAtom().Convert(c => DOMElement_TokenAtom.DOMify(c)));
			SetQuantifier(DOMElement_Quantifier.DOMify(context.quantifier()));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_Alternatives instance = new DOMElement_TokenAtom_Alternatives();
			instance.SetTokenAtoms(GetTokenAtoms().Convert(i => i.IfNotNull(z => z.Duplicate())));
			instance.SetQuantifier(GetQuantifier().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void ClearTokenAtoms()
		{
			token_atoms.Clear();
		}
		
		private void SetTokenAtoms(IEnumerable<DOMElement_TokenAtom> input)
		{
			ClearTokenAtoms();
			AddTokenAtoms(input);
		}
		
		private void SetTokenAtoms(params DOMElement_TokenAtom[] input)
		{
			SetTokenAtoms((IEnumerable<DOMElement_TokenAtom>)input);
		}
		
		private void AddTokenAtom(DOMElement_TokenAtom input)
		{
			token_atoms.Add(input);
		}
		
		private void AddTokenAtoms(IEnumerable<DOMElement_TokenAtom> input)
		{
			input.ProcessCopy(i => AddTokenAtom(i));
		}
		
		private void AddTokenAtoms(params DOMElement_TokenAtom[] input)
		{
			AddTokenAtoms((IEnumerable<DOMElement_TokenAtom>)input);
		}
		
		public IEnumerable<DOMElement_TokenAtom> GetTokenAtoms()
		{
			return token_atoms;
		}
		
		private void SetQuantifier(DOMElement_Quantifier input)
		{
			quantifier.Set(input);
		}
		
		public DOMElement_Quantifier GetQuantifier()
		{
			return quantifier.Get();
		}
		
	}
	
	public partial class DOMElement_TokenAtom_Sequence : DOMElement_TokenAtom
	{
		[RelatableChild]private HoldingList<DOMElement, DOMElement_TokenAtom> token_atoms;
		static public DOMElement_TokenAtom_Sequence DOMify(DOMEParser.TokenAtomSequenceContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_Sequence(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_Sequence DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomSequenceContext);
		}
		
		static new public DOMElement_TokenAtom_Sequence DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Sequence DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_Sequence DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_Sequence()
		{
			token_atoms = new HoldingList<DOMElement, DOMElement_TokenAtom>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_Sequence(DOMEParser.TokenAtomSequenceContext context) : this()
		{
			AddTokenAtoms(context.tokenAtom().Convert(c => DOMElement_TokenAtom.DOMify(c)));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_Sequence instance = new DOMElement_TokenAtom_Sequence();
			instance.SetTokenAtoms(GetTokenAtoms().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearTokenAtoms()
		{
			token_atoms.Clear();
		}
		
		private void SetTokenAtoms(IEnumerable<DOMElement_TokenAtom> input)
		{
			ClearTokenAtoms();
			AddTokenAtoms(input);
		}
		
		private void SetTokenAtoms(params DOMElement_TokenAtom[] input)
		{
			SetTokenAtoms((IEnumerable<DOMElement_TokenAtom>)input);
		}
		
		private void AddTokenAtom(DOMElement_TokenAtom input)
		{
			token_atoms.Add(input);
		}
		
		private void AddTokenAtoms(IEnumerable<DOMElement_TokenAtom> input)
		{
			input.ProcessCopy(i => AddTokenAtom(i));
		}
		
		private void AddTokenAtoms(params DOMElement_TokenAtom[] input)
		{
			AddTokenAtoms((IEnumerable<DOMElement_TokenAtom>)input);
		}
		
		public IEnumerable<DOMElement_TokenAtom> GetTokenAtoms()
		{
			return token_atoms;
		}
		
	}
	
	public partial class DOMElement_TokenAtom_InfoGroup : DOMElement_TokenAtom
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_TokenAtom> token_atom;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_Configuration_Info> info;
		static public DOMElement_TokenAtom_InfoGroup DOMify(DOMEParser.TokenAtomInfoGroupContext context)
		{
			if(context != null)
			{
				return new DOMElement_TokenAtom_InfoGroup(context);
			}
			
			return null;
		}
		
		static new public DOMElement_TokenAtom_InfoGroup DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.TokenAtomInfoGroupContext);
		}
		
		static new public DOMElement_TokenAtom_InfoGroup DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_InfoGroup DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).tokenAtom());
		}
		
		static new public DOMElement_TokenAtom_InfoGroup DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).tokenAtom());
		}
		
		public DOMElement_TokenAtom_InfoGroup()
		{
			token_atom = new HoldingSingle<DOMElement, DOMElement_TokenAtom>(this);
			info = new HoldingSingle<DOMElement, DOMElement_Configuration_Info>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_TokenAtom_InfoGroup(DOMEParser.TokenAtomInfoGroupContext context) : this()
		{
			SetTokenAtom(DOMElement_TokenAtom.DOMify(context.tokenAtom()));
			SetInfo(DOMElement_Configuration_Info.DOMify(context.info()));
		}
		
		public override DOMElement_TokenAtom Duplicate()
		{
			DOMElement_TokenAtom_InfoGroup instance = new DOMElement_TokenAtom_InfoGroup();
			instance.SetTokenAtom(GetTokenAtom().IfNotNull(z => z.Duplicate()));
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTokenAtom(DOMElement_TokenAtom input)
		{
			token_atom.Set(input);
		}
		
		public DOMElement_TokenAtom GetTokenAtom()
		{
			return token_atom.Get();
		}
		
		private void SetInfo(DOMElement_Configuration_Info input)
		{
			info.Set(input);
		}
		
		public DOMElement_Configuration_Info GetInfo()
		{
			return info.Get();
		}
		
	}
	
	public partial class DOMElement_GrammarDefinition : DOMElement
	{
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_GrammarHeader> grammar_header;
		[RelatableChild]private HoldingSingle<DOMElement, DOMElement_ImportHeader> import_header;
		[RelatableChild]private HoldingList<DOMElement, DOMElement_Definition> definitions;
		static public DOMElement_GrammarDefinition DOMify(DOMEParser.GrammarDefinitionContext context)
		{
			if(context != null)
			{
				return new DOMElement_GrammarDefinition(context);
			}
			
			return null;
		}
		
		static public DOMElement_GrammarDefinition DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as DOMEParser.GrammarDefinitionContext);
		}
		
		static public DOMElement_GrammarDefinition DOMify(Stream stream)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(stream).grammarDefinition());
		}
		
		static public DOMElement_GrammarDefinition DOMify(string text)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateParser(text).grammarDefinition());
		}
		
		static public DOMElement_GrammarDefinition DOMifyFile(string filename)
		{
			return DOMify(DOMEDOMinatorUtilities.CreateFileParser(filename).grammarDefinition());
		}
		
		public DOMElement_GrammarDefinition()
		{
			grammar_header = new HoldingSingle<DOMElement, DOMElement_GrammarHeader>(this);
			import_header = new HoldingSingle<DOMElement, DOMElement_ImportHeader>(this);
			definitions = new HoldingList<DOMElement, DOMElement_Definition>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public DOMElement_GrammarDefinition(DOMEParser.GrammarDefinitionContext context) : this()
		{
			SetGrammarHeader(DOMElement_GrammarHeader.DOMify(context.grammarHeader()));
			SetImportHeader(DOMElement_ImportHeader.DOMify(context.importHeader()));
			AddDefinitions(context.definition().Convert(c => DOMElement_Definition.DOMify(c)));
		}
		
		public DOMElement_GrammarDefinition Duplicate()
		{
			DOMElement_GrammarDefinition instance = new DOMElement_GrammarDefinition();
			instance.SetGrammarHeader(GetGrammarHeader().IfNotNull(z => z.Duplicate()));
			instance.SetImportHeader(GetImportHeader().IfNotNull(z => z.Duplicate()));
			instance.SetDefinitions(GetDefinitions().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void SetGrammarHeader(DOMElement_GrammarHeader input)
		{
			grammar_header.Set(input);
		}
		
		public DOMElement_GrammarHeader GetGrammarHeader()
		{
			return grammar_header.Get();
		}
		
		private void SetImportHeader(DOMElement_ImportHeader input)
		{
			import_header.Set(input);
			OnSetImportHeader(input);
		}
		
		public DOMElement_ImportHeader GetImportHeader()
		{
			return import_header.Get();
		}
		
		private void ClearDefinitions()
		{
			definitions.Clear();
		}
		
		private void SetDefinitions(IEnumerable<DOMElement_Definition> input)
		{
			ClearDefinitions();
			AddDefinitions(input);
		}
		
		private void SetDefinitions(params DOMElement_Definition[] input)
		{
			SetDefinitions((IEnumerable<DOMElement_Definition>)input);
		}
		
		private void AddDefinition(DOMElement_Definition input)
		{
			definitions.Add(input);
		}
		
		private void AddDefinitions(IEnumerable<DOMElement_Definition> input)
		{
			input.ProcessCopy(i => AddDefinition(i));
		}
		
		private void AddDefinitions(params DOMElement_Definition[] input)
		{
			AddDefinitions((IEnumerable<DOMElement_Definition>)input);
		}
		
		public IEnumerable<DOMElement_Definition> GetDefinitions()
		{
			return definitions;
		}
		
	}
	
	public abstract partial class DOMElement : Object, Relatable, Holdable<DOMElement>
	{
		[HoldingContainer]private HoldingContainer<DOMElement> holding_container;
		public DOMElement()
		{
			holding_container = null;
			OnConstruct();
		}
		
		partial void OnConstruct();
		[RelatableParent]
		public DOMElement GetParent()
		{
			if(holding_container != null)
			{
				return holding_container.GetParent();
			}
			
			return null;
		}
		
	}
	
	static public class DOMEDOMinatorUtilities
	{
		static public DOMEParser CreateParser(ICharStream stream)
		{
			DOMEParser parser = new DOMEParser(new CommonTokenStream(new DOMELexer(stream)));
			parser.RemoveErrorListeners();
			parser.AddErrorListener(DOMESyntaxExceptionThrower.INSTANCE);
			return parser;
		}
		
		static public DOMEParser CreateParser(Stream stream)
		{
			return CreateParser(new AntlrInputStream(stream));
		}
		
		static public DOMEParser CreateParser(TextReader text_reader)
		{
			return CreateParser(new AntlrInputStream(text_reader));
		}
		
		static public DOMEParser CreateParser(string text)
		{
			return CreateParser(new StringReader(text));
		}
		
		static public DOMEParser CreateFileParser(string filename)
		{
			return CreateParser(new AntlrFileStream(filename));
		}
		
	}
	
	static public class DOMEIParseTreeExtensions
	{
		static public string GetTextEX(this IParseTree item)
		{
			if(item != null)
			{
				return item.GetText();
			}
			
			return "";
		}
		
	}
	
	public partial class DOMEResolver : DOMEBaseVisitor<DOMElement>
	{
		static private DOMEResolver instance;
		static public DOMEResolver GetInstance()
		{
			if(instance == null)
			{
				instance = new DOMEResolver();
			}
			
			return instance;
		}
		
		static public DOMElement Resolve(IParseTree parse_tree)
		{
			if(parse_tree != null)
			{
				return GetInstance().Visit(parse_tree);
			}
			
			return null;
		}
		
		static public T Resolve<T>(IParseTree parse_tree) where T : DOMElement
		{
			return Resolve(parse_tree) as T;
		}
		
		private DOMEResolver()
		{
		}
		
		public override DOMElement VisitDefinition_RuleDefinition_ConcreteDirect(DOMEParser.Definition_RuleDefinition_ConcreteDirectContext context)
		{
			return DOMElement_Definition_RuleDefinition_ConcreteDirect.DOMify(context);
		}
		
		public override DOMElement VisitDefinition_RuleDefinition_ConcreteInherited(DOMEParser.Definition_RuleDefinition_ConcreteInheritedContext context)
		{
			return DOMElement_Definition_RuleDefinition_ConcreteInherited.DOMify(context);
		}
		
		public override DOMElement VisitDefinition_RuleDefinition_Abstract(DOMEParser.Definition_RuleDefinition_AbstractContext context)
		{
			return DOMElement_Definition_RuleDefinition_Abstract.DOMify(context);
		}
		
		public override DOMElement VisitDefinition_TokenDefinition(DOMEParser.Definition_TokenDefinitionContext context)
		{
			return DOMElement_Definition_TokenDefinition.DOMify(context);
		}
		
		public override DOMElement VisitId(DOMEParser.IdContext context)
		{
			return DOMElement_Id.DOMify(context);
		}
		
		public override DOMElement VisitGrammarHeader(DOMEParser.GrammarHeaderContext context)
		{
			return DOMElement_GrammarHeader.DOMify(context);
		}
		
		public override DOMElement VisitImportHeader(DOMEParser.ImportHeaderContext context)
		{
			return DOMElement_ImportHeader.DOMify(context);
		}
		
		public override DOMElement VisitGrammarTypeParser(DOMEParser.GrammarTypeParserContext context)
		{
			return DOMElement_GrammarType_Parser.DOMify(context);
		}
		
		public override DOMElement VisitGrammarTypeLexer(DOMEParser.GrammarTypeLexerContext context)
		{
			return DOMElement_GrammarType_Lexer.DOMify(context);
		}
		
		public override DOMElement VisitInfo(DOMEParser.InfoContext context)
		{
			return DOMElement_Configuration_Info.DOMify(context);
		}
		
		public override DOMElement VisitQuantifierNoneOrOne(DOMEParser.QuantifierNoneOrOneContext context)
		{
			return DOMElement_Quantifier_NoneOrOne.DOMify(context);
		}
		
		public override DOMElement VisitQuantifierNoneOrMore(DOMEParser.QuantifierNoneOrMoreContext context)
		{
			return DOMElement_Quantifier_NoneOrMore.DOMify(context);
		}
		
		public override DOMElement VisitQuantifierOneOrMore(DOMEParser.QuantifierOneOrMoreContext context)
		{
			return DOMElement_Quantifier_OneOrMore.DOMify(context);
		}
		
		public override DOMElement VisitRuleReference(DOMEParser.RuleReferenceContext context)
		{
			return DOMElement_RuleReference.DOMify(context);
		}
		
		public override DOMElement VisitRuleDefinitionConcreteDirect(DOMEParser.RuleDefinitionConcreteDirectContext context)
		{
			return DOMElement_RuleDefinition_Concrete_Direct.DOMify(context);
		}
		
		public override DOMElement VisitRuleDefinitionConcreteInherited(DOMEParser.RuleDefinitionConcreteInheritedContext context)
		{
			return DOMElement_RuleDefinition_Concrete_Inherited.DOMify(context);
		}
		
		public override DOMElement VisitRuleDefinitionAbstract(DOMEParser.RuleDefinitionAbstractContext context)
		{
			return DOMElement_RuleDefinition_Abstract.DOMify(context);
		}
		
		public override DOMElement VisitRuleAtomLiteral(DOMEParser.RuleAtomLiteralContext context)
		{
			return DOMElement_RuleAtom_Literal.DOMify(context);
		}
		
		public override DOMElement VisitRuleAtomTokenReference(DOMEParser.RuleAtomTokenReferenceContext context)
		{
			return DOMElement_RuleAtom_Variable_Reference_Token.DOMify(context);
		}
		
		public override DOMElement VisitRuleAtomRuleReference(DOMEParser.RuleAtomRuleReferenceContext context)
		{
			return DOMElement_RuleAtom_Variable_Reference_Rule.DOMify(context);
		}
		
		public override DOMElement VisitRuleAtomGroup(DOMEParser.RuleAtomGroupContext context)
		{
			return DOMElement_RuleAtom_Group.DOMify(context);
		}
		
		public override DOMElement VisitRuleAtomInfoGroup(DOMEParser.RuleAtomInfoGroupContext context)
		{
			return DOMElement_RuleAtom_Variable_InfoGroup.DOMify(context);
		}
		
		public override DOMElement VisitRuleExpression_Sequence(DOMEParser.RuleExpression_SequenceContext context)
		{
			return DOMElement_RuleExpression_Sequence.DOMify(context);
		}
		
		public override DOMElement VisitRuleExpression_Alternatives(DOMEParser.RuleExpression_AlternativesContext context)
		{
			return DOMElement_RuleExpression_Alternatives.DOMify(context);
		}
		
		public override DOMElement VisitSettings(DOMEParser.SettingsContext context)
		{
			return DOMElement_Settings.DOMify(context);
		}
		
		public override DOMElement VisitSetting_Flag(DOMEParser.Setting_FlagContext context)
		{
			return DOMElement_Setting_Flag.DOMify(context);
		}
		
		public override DOMElement VisitSetting_Value(DOMEParser.Setting_ValueContext context)
		{
			return DOMElement_Setting_Value.DOMify(context);
		}
		
		public override DOMElement VisitTokenReference(DOMEParser.TokenReferenceContext context)
		{
			return DOMElement_TokenReference.DOMify(context);
		}
		
		public override DOMElement VisitTokenDefinition(DOMEParser.TokenDefinitionContext context)
		{
			return DOMElement_TokenDefinition.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomLiteral(DOMEParser.TokenAtomLiteralContext context)
		{
			return DOMElement_TokenAtom_Literal.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomClass(DOMEParser.TokenAtomClassContext context)
		{
			return DOMElement_TokenAtom_Class.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomPeriod(DOMEParser.TokenAtomPeriodContext context)
		{
			return DOMElement_TokenAtom_Period.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomTokenReference(DOMEParser.TokenAtomTokenReferenceContext context)
		{
			return DOMElement_TokenAtom_TokenReference.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomGroup(DOMEParser.TokenAtomGroupContext context)
		{
			return DOMElement_TokenAtom_Group.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomAlternatives(DOMEParser.TokenAtomAlternativesContext context)
		{
			return DOMElement_TokenAtom_Alternatives.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomSequence(DOMEParser.TokenAtomSequenceContext context)
		{
			return DOMElement_TokenAtom_Sequence.DOMify(context);
		}
		
		public override DOMElement VisitTokenAtomInfoGroup(DOMEParser.TokenAtomInfoGroupContext context)
		{
			return DOMElement_TokenAtom_InfoGroup.DOMify(context);
		}
		
		public override DOMElement VisitGrammarDefinition(DOMEParser.GrammarDefinitionContext context)
		{
			return DOMElement_GrammarDefinition.DOMify(context);
		}
		
	}
	
	public partial class DOMESyntaxException : Exception
	{
		private int line;
		private string base_message;
		public DOMESyntaxException(int l, string m) : base()
		{
			line = l;
			base_message = m;
		}
		
		public int GetLine()
		{
			return line;
		}
		
		public string GetBaseMessage()
		{
			return base_message;
		}
		
		public string GetMessage()
		{
			return "(" + line + ")" +  base_message;
		}
		
	}
	
	public class DOMESyntaxExceptionThrower : BaseErrorListener
	{
		static public readonly DOMESyntaxExceptionThrower INSTANCE = new DOMESyntaxExceptionThrower();
		private DOMESyntaxExceptionThrower()
		{
		}
		
		public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			throw new DOMESyntaxException(line, msg);
		}
		
	}
	
}
