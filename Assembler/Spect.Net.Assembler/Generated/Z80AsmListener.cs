//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\Assembler\AntlrZ80AsmParserGenerator\ParserGenerator\Z80Asm.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.Assembler.Generated {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="Z80AsmParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public interface IZ80AsmListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] Z80AsmParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] Z80AsmParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.asmline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsmline([NotNull] Z80AsmParser.AsmlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.asmline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsmline([NotNull] Z80AsmParser.AsmlineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel([NotNull] Z80AsmParser.LabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel([NotNull] Z80AsmParser.LabelContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment([NotNull] Z80AsmParser.CommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment([NotNull] Z80AsmParser.CommentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.pragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma([NotNull] Z80AsmParser.PragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.pragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma([NotNull] Z80AsmParser.PragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirective([NotNull] Z80AsmParser.DirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirective([NotNull] Z80AsmParser.DirectiveContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.orgPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrgPragma([NotNull] Z80AsmParser.OrgPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.orgPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrgPragma([NotNull] Z80AsmParser.OrgPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.entPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntPragma([NotNull] Z80AsmParser.EntPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.entPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntPragma([NotNull] Z80AsmParser.EntPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.xentPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXentPragma([NotNull] Z80AsmParser.XentPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.xentPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXentPragma([NotNull] Z80AsmParser.XentPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.dispPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDispPragma([NotNull] Z80AsmParser.DispPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.dispPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDispPragma([NotNull] Z80AsmParser.DispPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.equPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquPragma([NotNull] Z80AsmParser.EquPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.equPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquPragma([NotNull] Z80AsmParser.EquPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.varPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarPragma([NotNull] Z80AsmParser.VarPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.varPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarPragma([NotNull] Z80AsmParser.VarPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.defbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefbPragma([NotNull] Z80AsmParser.DefbPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.defbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefbPragma([NotNull] Z80AsmParser.DefbPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.defwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefwPragma([NotNull] Z80AsmParser.DefwPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.defwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefwPragma([NotNull] Z80AsmParser.DefwPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.defmPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefmPragma([NotNull] Z80AsmParser.DefmPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.defmPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefmPragma([NotNull] Z80AsmParser.DefmPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.skipPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSkipPragma([NotNull] Z80AsmParser.SkipPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.skipPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSkipPragma([NotNull] Z80AsmParser.SkipPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.externPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExternPragma([NotNull] Z80AsmParser.ExternPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.externPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExternPragma([NotNull] Z80AsmParser.ExternPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.defsPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefsPragma([NotNull] Z80AsmParser.DefsPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.defsPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefsPragma([NotNull] Z80AsmParser.DefsPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.fillbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFillbPragma([NotNull] Z80AsmParser.FillbPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.fillbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFillbPragma([NotNull] Z80AsmParser.FillbPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.fillwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFillwPragma([NotNull] Z80AsmParser.FillwPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.fillwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFillwPragma([NotNull] Z80AsmParser.FillwPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.modelPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModelPragma([NotNull] Z80AsmParser.ModelPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.modelPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModelPragma([NotNull] Z80AsmParser.ModelPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.alignPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlignPragma([NotNull] Z80AsmParser.AlignPragmaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.alignPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlignPragma([NotNull] Z80AsmParser.AlignPragmaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperation([NotNull] Z80AsmParser.OperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperation([NotNull] Z80AsmParser.OperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.trivialOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrivialOperation([NotNull] Z80AsmParser.TrivialOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.trivialOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrivialOperation([NotNull] Z80AsmParser.TrivialOperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.compoundOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompoundOperation([NotNull] Z80AsmParser.CompoundOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.compoundOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompoundOperation([NotNull] Z80AsmParser.CompoundOperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.trivialNextOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrivialNextOperation([NotNull] Z80AsmParser.TrivialNextOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.trivialNextOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrivialNextOperation([NotNull] Z80AsmParser.TrivialNextOperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperand([NotNull] Z80AsmParser.OperandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperand([NotNull] Z80AsmParser.OperandContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.reg8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg8([NotNull] Z80AsmParser.Reg8Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.reg8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg8([NotNull] Z80AsmParser.Reg8Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.reg8Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg8Idx([NotNull] Z80AsmParser.Reg8IdxContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.reg8Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg8Idx([NotNull] Z80AsmParser.Reg8IdxContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.reg8Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg8Spec([NotNull] Z80AsmParser.Reg8SpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.reg8Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg8Spec([NotNull] Z80AsmParser.Reg8SpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.reg16"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg16([NotNull] Z80AsmParser.Reg16Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.reg16"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg16([NotNull] Z80AsmParser.Reg16Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.reg16Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg16Idx([NotNull] Z80AsmParser.Reg16IdxContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.reg16Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg16Idx([NotNull] Z80AsmParser.Reg16IdxContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.reg16Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg16Spec([NotNull] Z80AsmParser.Reg16SpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.reg16Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg16Spec([NotNull] Z80AsmParser.Reg16SpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.regIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegIndirect([NotNull] Z80AsmParser.RegIndirectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.regIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegIndirect([NotNull] Z80AsmParser.RegIndirectContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.cPort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCPort([NotNull] Z80AsmParser.CPortContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.cPort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCPort([NotNull] Z80AsmParser.CPortContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.memIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemIndirect([NotNull] Z80AsmParser.MemIndirectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.memIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemIndirect([NotNull] Z80AsmParser.MemIndirectContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.indexedAddr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexedAddr([NotNull] Z80AsmParser.IndexedAddrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.indexedAddr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexedAddr([NotNull] Z80AsmParser.IndexedAddrContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] Z80AsmParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] Z80AsmParser.ConditionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] Z80AsmParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] Z80AsmParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.orExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrExpr([NotNull] Z80AsmParser.OrExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.orExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrExpr([NotNull] Z80AsmParser.OrExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.xorExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXorExpr([NotNull] Z80AsmParser.XorExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.xorExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXorExpr([NotNull] Z80AsmParser.XorExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.andExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpr([NotNull] Z80AsmParser.AndExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.andExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpr([NotNull] Z80AsmParser.AndExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.equExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquExpr([NotNull] Z80AsmParser.EquExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.equExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquExpr([NotNull] Z80AsmParser.EquExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.relExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelExpr([NotNull] Z80AsmParser.RelExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.relExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelExpr([NotNull] Z80AsmParser.RelExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.shiftExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShiftExpr([NotNull] Z80AsmParser.ShiftExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.shiftExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShiftExpr([NotNull] Z80AsmParser.ShiftExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddExpr([NotNull] Z80AsmParser.AddExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddExpr([NotNull] Z80AsmParser.AddExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.multExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultExpr([NotNull] Z80AsmParser.MultExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.multExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultExpr([NotNull] Z80AsmParser.MultExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.unaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpr([NotNull] Z80AsmParser.UnaryExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.unaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpr([NotNull] Z80AsmParser.UnaryExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.functionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionInvocation([NotNull] Z80AsmParser.FunctionInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.functionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionInvocation([NotNull] Z80AsmParser.FunctionInvocationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.literalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralExpr([NotNull] Z80AsmParser.LiteralExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.literalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralExpr([NotNull] Z80AsmParser.LiteralExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80AsmParser.symbolExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSymbolExpr([NotNull] Z80AsmParser.SymbolExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80AsmParser.symbolExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSymbolExpr([NotNull] Z80AsmParser.SymbolExprContext context);
}
} // namespace Spect.Net.Assembler.Generated
