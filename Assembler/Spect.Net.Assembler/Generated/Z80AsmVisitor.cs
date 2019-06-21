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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Z80AsmParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public interface IZ80AsmVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionInvocationExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionInvocationExpr([NotNull] Z80AsmParser.FunctionInvocationExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryPlusExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryPlusExpr([NotNull] Z80AsmParser.UnaryPlusExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TernaryExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTernaryExpr([NotNull] Z80AsmParser.TernaryExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AddExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddExpr([NotNull] Z80AsmParser.AddExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SymbolExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbolExpr([NotNull] Z80AsmParser.SymbolExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryMinusExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryMinusExpr([NotNull] Z80AsmParser.UnaryMinusExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>EquExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquExpr([NotNull] Z80AsmParser.EquExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>XorExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXorExpr([NotNull] Z80AsmParser.XorExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MacroParamExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroParamExpr([NotNull] Z80AsmParser.MacroParamExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BinaryNotExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryNotExpr([NotNull] Z80AsmParser.BinaryNotExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MultExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultExpr([NotNull] Z80AsmParser.MultExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BracketedExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBracketedExpr([NotNull] Z80AsmParser.BracketedExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalNotExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalNotExpr([NotNull] Z80AsmParser.LogicalNotExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpr([NotNull] Z80AsmParser.OrExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AndExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpr([NotNull] Z80AsmParser.AndExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ShiftExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftExpr([NotNull] Z80AsmParser.ShiftExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralExpr([NotNull] Z80AsmParser.LiteralExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpr([NotNull] Z80AsmParser.ParenthesizedExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MinMaxExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMinMaxExpr([NotNull] Z80AsmParser.MinMaxExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BuiltInFunctionExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBuiltInFunctionExpr([NotNull] Z80AsmParser.BuiltInFunctionExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>RelExpr</c>
	/// labeled alternative in <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelExpr([NotNull] Z80AsmParser.RelExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TextOfInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTextOfInvoke([NotNull] Z80AsmParser.TextOfInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsIndexedAddrInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsIndexedAddrInvoke([NotNull] Z80AsmParser.IsIndexedAddrInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsReg16IdxInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsReg16IdxInvoke([NotNull] Z80AsmParser.IsReg16IdxInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsReg16Invoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsReg16Invoke([NotNull] Z80AsmParser.IsReg16InvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsReg8IdxInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsReg8IdxInvoke([NotNull] Z80AsmParser.IsReg8IdxInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsReg8StdInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsReg8StdInvoke([NotNull] Z80AsmParser.IsReg8StdInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsReg8StdSpecInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsReg8StdSpecInvoke([NotNull] Z80AsmParser.IsReg8StdSpecInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DefInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefInvoke([NotNull] Z80AsmParser.DefInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsConditionInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsConditionInvoke([NotNull] Z80AsmParser.IsConditionInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsRegIndirectInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsRegIndirectInvoke([NotNull] Z80AsmParser.IsRegIndirectInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsReg8Invoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsReg8Invoke([NotNull] Z80AsmParser.IsReg8InvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsReg16StdInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsReg16StdInvoke([NotNull] Z80AsmParser.IsReg16StdInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsExprInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsExprInvoke([NotNull] Z80AsmParser.IsExprInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IsCportInvoke</c>
	/// labeled alternative in <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsCportInvoke([NotNull] Z80AsmParser.IsCportInvokeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>StringLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringLiteral([NotNull] Z80AsmParser.StringLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BinLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinLiteral([NotNull] Z80AsmParser.BinLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>HexLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHexLiteral([NotNull] Z80AsmParser.HexLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolLiteral([NotNull] Z80AsmParser.BoolLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>RealLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRealLiteral([NotNull] Z80AsmParser.RealLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CurCounterLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCurCounterLiteral([NotNull] Z80AsmParser.CurCounterLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CharLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharLiteral([NotNull] Z80AsmParser.CharLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>OctalLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOctalLiteral([NotNull] Z80AsmParser.OctalLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DecimalLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecimalLiteral([NotNull] Z80AsmParser.DecimalLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CurAddrLiteral</c>
	/// labeled alternative in <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCurAddrLiteral([NotNull] Z80AsmParser.CurAddrLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] Z80AsmParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.asmline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsmline([NotNull] Z80AsmParser.AsmlineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.lineBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineBody([NotNull] Z80AsmParser.LineBodyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] Z80AsmParser.LabelContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] Z80AsmParser.CommentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.pragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma([NotNull] Z80AsmParser.PragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirective([NotNull] Z80AsmParser.DirectiveContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] Z80AsmParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.iterationTest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIterationTest([NotNull] Z80AsmParser.IterationTestContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroStatement([NotNull] Z80AsmParser.MacroStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroEndMarker([NotNull] Z80AsmParser.MacroEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.procStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcStatement([NotNull] Z80AsmParser.ProcStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.procEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcEndMarker([NotNull] Z80AsmParser.ProcEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.loopEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopEndMarker([NotNull] Z80AsmParser.LoopEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.repeatStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatStatement([NotNull] Z80AsmParser.RepeatStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.whileEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileEndMarker([NotNull] Z80AsmParser.WhileEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] Z80AsmParser.IfStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseStatement([NotNull] Z80AsmParser.ElseStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.endifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndifStatement([NotNull] Z80AsmParser.EndifStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] Z80AsmParser.ForStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.nextStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNextStatement([NotNull] Z80AsmParser.NextStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreakStatement([NotNull] Z80AsmParser.BreakStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContinueStatement([NotNull] Z80AsmParser.ContinueStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.moduleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleStatement([NotNull] Z80AsmParser.ModuleStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.moduleEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleEndMarker([NotNull] Z80AsmParser.ModuleEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.structStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructStatement([NotNull] Z80AsmParser.StructStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.structEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructEndMarker([NotNull] Z80AsmParser.StructEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroOrStructInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroOrStructInvocation([NotNull] Z80AsmParser.MacroOrStructInvocationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroArgument([NotNull] Z80AsmParser.MacroArgumentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.fieldAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldAssignment([NotNull] Z80AsmParser.FieldAssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.orgPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrgPragma([NotNull] Z80AsmParser.OrgPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.xorgPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXorgPragma([NotNull] Z80AsmParser.XorgPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.entPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEntPragma([NotNull] Z80AsmParser.EntPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.xentPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXentPragma([NotNull] Z80AsmParser.XentPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.dispPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDispPragma([NotNull] Z80AsmParser.DispPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.equPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquPragma([NotNull] Z80AsmParser.EquPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.varPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarPragma([NotNull] Z80AsmParser.VarPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefbPragma([NotNull] Z80AsmParser.DefbPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefwPragma([NotNull] Z80AsmParser.DefwPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defcPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefcPragma([NotNull] Z80AsmParser.DefcPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defmPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefmPragma([NotNull] Z80AsmParser.DefmPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defnPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefnPragma([NotNull] Z80AsmParser.DefnPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defhPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefhPragma([NotNull] Z80AsmParser.DefhPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.skipPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSkipPragma([NotNull] Z80AsmParser.SkipPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.externPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExternPragma([NotNull] Z80AsmParser.ExternPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defsPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefsPragma([NotNull] Z80AsmParser.DefsPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.fillbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFillbPragma([NotNull] Z80AsmParser.FillbPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.fillwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFillwPragma([NotNull] Z80AsmParser.FillwPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.modelPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModelPragma([NotNull] Z80AsmParser.ModelPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.alignPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlignPragma([NotNull] Z80AsmParser.AlignPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.tracePragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTracePragma([NotNull] Z80AsmParser.TracePragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.rndSeedPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRndSeedPragma([NotNull] Z80AsmParser.RndSeedPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defgxPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefgxPragma([NotNull] Z80AsmParser.DefgxPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defgPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefgPragma([NotNull] Z80AsmParser.DefgPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.errorPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitErrorPragma([NotNull] Z80AsmParser.ErrorPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.incBinPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIncBinPragma([NotNull] Z80AsmParser.IncBinPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.compareBinPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareBinPragma([NotNull] Z80AsmParser.CompareBinPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.byteEmPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitByteEmPragma([NotNull] Z80AsmParser.ByteEmPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation([NotNull] Z80AsmParser.OperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.trivialOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrivialOperation([NotNull] Z80AsmParser.TrivialOperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.compoundOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundOperation([NotNull] Z80AsmParser.CompoundOperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.trivialNextOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrivialNextOperation([NotNull] Z80AsmParser.TrivialNextOperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperand([NotNull] Z80AsmParser.OperandContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg8([NotNull] Z80AsmParser.Reg8Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg8Idx([NotNull] Z80AsmParser.Reg8IdxContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg8Spec([NotNull] Z80AsmParser.Reg8SpecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16([NotNull] Z80AsmParser.Reg16Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16Idx([NotNull] Z80AsmParser.Reg16IdxContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16Std"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16Std([NotNull] Z80AsmParser.Reg16StdContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16Spec([NotNull] Z80AsmParser.Reg16SpecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.regIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRegIndirect([NotNull] Z80AsmParser.RegIndirectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.cPort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCPort([NotNull] Z80AsmParser.CPortContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.memIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemIndirect([NotNull] Z80AsmParser.MemIndirectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.indexedAddr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexedAddr([NotNull] Z80AsmParser.IndexedAddrContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] Z80AsmParser.ConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] Z80AsmParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.functionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionInvocation([NotNull] Z80AsmParser.FunctionInvocationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.builtinFunctionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBuiltinFunctionInvocation([NotNull] Z80AsmParser.BuiltinFunctionInvocationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] Z80AsmParser.LiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbol([NotNull] Z80AsmParser.SymbolContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroParam([NotNull] Z80AsmParser.MacroParamContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.regs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRegs([NotNull] Z80AsmParser.RegsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.regsAndConds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRegsAndConds([NotNull] Z80AsmParser.RegsAndCondsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.mnemonic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMnemonic([NotNull] Z80AsmParser.MnemonicContext context);
}
} // namespace Spect.Net.Assembler.Generated
