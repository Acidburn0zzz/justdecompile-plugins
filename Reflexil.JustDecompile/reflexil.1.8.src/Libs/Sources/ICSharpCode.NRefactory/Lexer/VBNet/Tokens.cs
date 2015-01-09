﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

// this file was autogenerated by a tool.
using System;
using System.Collections;

namespace ICSharpCode.NRefactory.Parser.VB
{
	public static class Tokens
	{
		// ----- terminal classes -----
		public const int EOF                  = 0;
		public const int EOL                  = 1;
		public const int Identifier           = 2;
		public const int LiteralString        = 3;
		public const int LiteralCharacter     = 4;
		public const int LiteralInteger       = 5;
		public const int LiteralDouble        = 6;
		public const int LiteralSingle        = 7;
		public const int LiteralDecimal       = 8;
		public const int LiteralDate          = 9;
		public const int XmlOpenTag           = 10;
		public const int XmlCloseTag          = 11;
		public const int XmlStartInlineVB     = 12;
		public const int XmlEndInlineVB       = 13;
		public const int XmlCloseTagEmptyElement = 14;
		public const int XmlOpenEndTag        = 15;
		public const int XmlContent           = 16;
		public const int XmlComment           = 17;
		public const int XmlCData             = 18;
		public const int XmlProcessingInstruction = 19;

		// ----- special character -----
		public const int Assign               = 20;
		public const int Colon                = 21;
		public const int Comma                = 22;
		public const int ConcatString         = 23;
		public const int Div                  = 24;
		public const int DivInteger           = 25;
		public const int Dot                  = 26;
		public const int TripleDot            = 27;
		public const int DotAt                = 28;
		public const int ExclamationMark      = 29;
		public const int Minus                = 30;
		public const int Plus                 = 31;
		public const int Power                = 32;
		public const int QuestionMark         = 33;
		public const int Times                = 34;
		public const int OpenCurlyBrace       = 35;
		public const int CloseCurlyBrace      = 36;
		public const int OpenParenthesis      = 37;
		public const int CloseParenthesis     = 38;
		public const int GreaterThan          = 39;
		public const int LessThan             = 40;
		public const int NotEqual             = 41;
		public const int GreaterEqual         = 42;
		public const int LessEqual            = 43;
		public const int ShiftLeft            = 44;
		public const int ShiftRight           = 45;
		public const int PlusAssign           = 46;
		public const int PowerAssign          = 47;
		public const int MinusAssign          = 48;
		public const int TimesAssign          = 49;
		public const int DivAssign            = 50;
		public const int DivIntegerAssign     = 51;
		public const int ShiftLeftAssign      = 52;
		public const int ShiftRightAssign     = 53;
		public const int ConcatStringAssign   = 54;
		public const int ColonAssign          = 55;

		// ----- keywords -----
		public const int AddHandler           = 56;
		public const int AddressOf            = 57;
		public const int Aggregate            = 58;
		public const int Alias                = 59;
		public const int And                  = 60;
		public const int AndAlso              = 61;
		public const int Ansi                 = 62;
		public const int As                   = 63;
		public const int Ascending            = 64;
		public const int Assembly             = 65;
		public const int Auto                 = 66;
		public const int Binary               = 67;
		public const int Boolean              = 68;
		public const int ByRef                = 69;
		public const int By                   = 70;
		public const int Byte                 = 71;
		public const int ByVal                = 72;
		public const int Call                 = 73;
		public const int Case                 = 74;
		public const int Catch                = 75;
		public const int CBool                = 76;
		public const int CByte                = 77;
		public const int CChar                = 78;
		public const int CDate                = 79;
		public const int CDbl                 = 80;
		public const int CDec                 = 81;
		public const int Char                 = 82;
		public const int CInt                 = 83;
		public const int Class                = 84;
		public const int CLng                 = 85;
		public const int CObj                 = 86;
		public const int Compare              = 87;
		public const int Const                = 88;
		public const int Continue             = 89;
		public const int CSByte               = 90;
		public const int CShort               = 91;
		public const int CSng                 = 92;
		public const int CStr                 = 93;
		public const int CType                = 94;
		public const int CUInt                = 95;
		public const int CULng                = 96;
		public const int CUShort              = 97;
		public const int Custom               = 98;
		public const int Date                 = 99;
		public const int Decimal              = 100;
		public const int Declare              = 101;
		public const int Default              = 102;
		public const int Delegate             = 103;
		public const int Descending           = 104;
		public const int Dim                  = 105;
		public const int DirectCast           = 106;
		public const int Distinct             = 107;
		public const int Do                   = 108;
		public const int Double               = 109;
		public const int Each                 = 110;
		public const int Else                 = 111;
		public const int ElseIf               = 112;
		public const int End                  = 113;
		public const int EndIf                = 114;
		public const int Enum                 = 115;
		new public const int Equals               = 116;
		public const int Erase                = 117;
		public const int Error                = 118;
		public const int Event                = 119;
		public const int Exit                 = 120;
		public const int Explicit             = 121;
		public const int False                = 122;
		public const int Finally              = 123;
		public const int For                  = 124;
		public const int Friend               = 125;
		public const int From                 = 126;
		public const int Function             = 127;
		public const int Get                  = 128;
		new public const int GetType              = 129;
		public const int Global               = 130;
		public const int GoSub                = 131;
		public const int GoTo                 = 132;
		public const int Group                = 133;
		public const int Handles              = 134;
		public const int If                   = 135;
		public const int Implements           = 136;
		public const int Imports              = 137;
		public const int In                   = 138;
		public const int Infer                = 139;
		public const int Inherits             = 140;
		public const int Integer              = 141;
		public const int Interface            = 142;
		public const int Into                 = 143;
		public const int Is                   = 144;
		public const int IsNot                = 145;
		public const int Join                 = 146;
		public const int Key                  = 147;
		public const int Let                  = 148;
		public const int Lib                  = 149;
		public const int Like                 = 150;
		public const int Long                 = 151;
		public const int Loop                 = 152;
		public const int Me                   = 153;
		public const int Mod                  = 154;
		public const int Module               = 155;
		public const int MustInherit          = 156;
		public const int MustOverride         = 157;
		public const int MyBase               = 158;
		public const int MyClass              = 159;
		public const int Namespace            = 160;
		public const int Narrowing            = 161;
		public const int New                  = 162;
		public const int Next                 = 163;
		public const int Not                  = 164;
		public const int Nothing              = 165;
		public const int NotInheritable       = 166;
		public const int NotOverridable       = 167;
		public const int Object               = 168;
		public const int Of                   = 169;
		public const int Off                  = 170;
		public const int On                   = 171;
		public const int Operator             = 172;
		public const int Option               = 173;
		public const int Optional             = 174;
		public const int Or                   = 175;
		public const int Order                = 176;
		public const int OrElse               = 177;
		public const int Out                  = 178;
		public const int Overloads            = 179;
		public const int Overridable          = 180;
		public const int Overrides            = 181;
		public const int ParamArray           = 182;
		public const int Partial              = 183;
		public const int Preserve             = 184;
		public const int Private              = 185;
		public const int Property             = 186;
		public const int Protected            = 187;
		public const int Public               = 188;
		public const int RaiseEvent           = 189;
		public const int ReadOnly             = 190;
		public const int ReDim                = 191;
		public const int Rem                  = 192;
		public const int RemoveHandler        = 193;
		public const int Resume               = 194;
		public const int Return               = 195;
		public const int SByte                = 196;
		public const int Select               = 197;
		public const int Set                  = 198;
		public const int Shadows              = 199;
		public const int Shared               = 200;
		public const int Short                = 201;
		public const int Single               = 202;
		public const int Skip                 = 203;
		public const int Static               = 204;
		public const int Step                 = 205;
		public const int Stop                 = 206;
		public const int Strict               = 207;
		public const int String               = 208;
		public const int Structure            = 209;
		public const int Sub                  = 210;
		public const int SyncLock             = 211;
		public const int Take                 = 212;
		public const int Text                 = 213;
		public const int Then                 = 214;
		public const int Throw                = 215;
		public const int To                   = 216;
		public const int True                 = 217;
		public const int Try                  = 218;
		public const int TryCast              = 219;
		public const int TypeOf               = 220;
		public const int UInteger             = 221;
		public const int ULong                = 222;
		public const int Unicode              = 223;
		public const int Until                = 224;
		public const int UShort               = 225;
		public const int Using                = 226;
		public const int Variant              = 227;
		public const int Wend                 = 228;
		public const int When                 = 229;
		public const int Where                = 230;
		public const int While                = 231;
		public const int Widening             = 232;
		public const int With                 = 233;
		public const int WithEvents           = 234;
		public const int WriteOnly            = 235;
		public const int Xor                  = 236;
		public const int GetXmlNamespace      = 237;

		public const int MaxToken = 238;
		static BitArray NewSet(params int[] values)
		{
			BitArray bitArray = new BitArray(MaxToken);
			foreach (int val in values) {
			bitArray[val] = true;
			}
			return bitArray;
		}
		public static BitArray Null = NewSet(Nothing);
		public static BitArray BlockSucc = NewSet(Case, Catch, Else, ElseIf, End, Finally, Loop, Next);
		public static BitArray GlobalLevel = NewSet(Namespace, Module, Class, Structure, Imports, Option);
		public static BitArray TypeLevel = NewSet(Sub, Function, Property);
		public static BitArray IdentifierTokens = NewSet(Text, Binary, Compare, Assembly, Ansi, Auto, Preserve, Unicode, Until, Off, Out, Key, Explicit, Infer, From, Join, Equals, Distinct, Where, Take, Skip, Order, By, Ascending, Descending, Group, Into, Aggregate);
		public static BitArray ExpressionStart = NewSet(Me, MyBase, MyClass, True, False, Not, From, Aggregate, New, Nothing, AddressOf, GetType, TypeOf, GetXmlNamespace, Global, Boolean, Date, Char, String, Decimal, Byte, Short, Integer, Long, Single, Double, UInteger, ULong, UShort, SByte, Sub, Function, DirectCast, TryCast, CType, CBool, CByte, CChar, CDate, CDec, CDbl, CInt, CLng, CObj, CSByte, CShort, CSng, CStr, CUInt, CULng, CUShort);
		public static BitArray StatementStart = NewSet(Nothing, Me, MyBase, MyClass, True, False, Not, From, Aggregate, New, Nothing, AddressOf, GetType, TypeOf, GetXmlNamespace, Global, Boolean, Date, Char, String, Decimal, Byte, Short, Integer, Long, Single, Double, UInteger, ULong, UShort, SByte, Sub, Function, DirectCast, TryCast, CType, CBool, CByte, CChar, CDate, CDec, CDbl, CInt, CLng, CObj, CSByte, CShort, CSng, CStr, CUInt, CULng, CUShort, Dim, Const, Static, For, While, Do, Select);
		public static BitArray SimpleTypeName = NewSet(Boolean, Date, Char, String, Decimal, Byte, Short, Integer, Long, Single, Double, UInteger, ULong, UShort, SByte, Text, Binary, Compare, Assembly, Ansi, Auto, Preserve, Unicode, Until, Off, Out, Key, Explicit, Infer, From, Join, Equals, Distinct, Where, Take, Skip, Order, By, Ascending, Descending, Group, Into, Aggregate);
		public static BitArray CastExpressions = NewSet(DirectCast, TryCast, CType, CBool, CByte, CChar, CDate, CDec, CDbl, CInt, CLng, CObj, CSByte, CShort, CSng, CStr, CUInt, CULng, CUShort);
		public static BitArray BooleanExpressions = NewSet(True, False);
		public static BitArray LambdaStart = NewSet(Sub, Function);
		public static BitArray OperatorsAtStart = NewSet(Not, From, Aggregate);
		public static BitArray TypeKW = NewSet(Boolean, Date, Char, String, Decimal, Byte, Short, Integer, Long, Single, Double, UInteger, ULong, UShort, SByte);

		static string[] tokenList = new string[] {
			// ----- terminal classes -----
			"<EOF>",
			"<EOL>",
			"<Identifier>",
			"<LiteralString>",
			"<LiteralCharacter>",
			"<LiteralInteger>",
			"<LiteralDouble>",
			"<LiteralSingle>",
			"<LiteralDecimal>",
			"<LiteralDate>",
			"<XmlOpenTag>",
			"<XmlCloseTag>",
			"<XmlStartInlineVB>",
			"<XmlEndInlineVB>",
			"<XmlCloseTagEmptyElement>",
			"<XmlOpenEndTag>",
			"<XmlContent>",
			"<XmlComment>",
			"<XmlCData>",
			"<XmlProcessingInstruction>",
			// ----- special character -----
			"=",
			":",
			",",
			"&",
			"/",
			"\\",
			".",
			"...",
			".@",
			"!",
			"-",
			"+",
			"^",
			"?",
			"*",
			"{",
			"}",
			"(",
			")",
			">",
			"<",
			"<>",
			">=",
			"<=",
			"<<",
			">>",
			"+=",
			"^=",
			"-=",
			"*=",
			"/=",
			"\\=",
			"<<=",
			">>=",
			"&=",
			":=",
			// ----- keywords -----
			"AddHandler",
			"AddressOf",
			"Aggregate",
			"Alias",
			"And",
			"AndAlso",
			"Ansi",
			"As",
			"Ascending",
			"Assembly",
			"Auto",
			"Binary",
			"Boolean",
			"ByRef",
			"By",
			"Byte",
			"ByVal",
			"Call",
			"Case",
			"Catch",
			"CBool",
			"CByte",
			"CChar",
			"CDate",
			"CDbl",
			"CDec",
			"Char",
			"CInt",
			"Class",
			"CLng",
			"CObj",
			"Compare",
			"Const",
			"Continue",
			"CSByte",
			"CShort",
			"CSng",
			"CStr",
			"CType",
			"CUInt",
			"CULng",
			"CUShort",
			"Custom",
			"Date",
			"Decimal",
			"Declare",
			"Default",
			"Delegate",
			"Descending",
			"Dim",
			"DirectCast",
			"Distinct",
			"Do",
			"Double",
			"Each",
			"Else",
			"ElseIf",
			"End",
			"EndIf",
			"Enum",
			"Equals",
			"Erase",
			"Error",
			"Event",
			"Exit",
			"Explicit",
			"False",
			"Finally",
			"For",
			"Friend",
			"From",
			"Function",
			"Get",
			"GetType",
			"Global",
			"GoSub",
			"GoTo",
			"Group",
			"Handles",
			"If",
			"Implements",
			"Imports",
			"In",
			"Infer",
			"Inherits",
			"Integer",
			"Interface",
			"Into",
			"Is",
			"IsNot",
			"Join",
			"Key",
			"Let",
			"Lib",
			"Like",
			"Long",
			"Loop",
			"Me",
			"Mod",
			"Module",
			"MustInherit",
			"MustOverride",
			"MyBase",
			"MyClass",
			"Namespace",
			"Narrowing",
			"New",
			"Next",
			"Not",
			"Nothing",
			"NotInheritable",
			"NotOverridable",
			"Object",
			"Of",
			"Off",
			"On",
			"Operator",
			"Option",
			"Optional",
			"Or",
			"Order",
			"OrElse",
			"Out",
			"Overloads",
			"Overridable",
			"Overrides",
			"ParamArray",
			"Partial",
			"Preserve",
			"Private",
			"Property",
			"Protected",
			"Public",
			"RaiseEvent",
			"ReadOnly",
			"ReDim",
			"Rem",
			"RemoveHandler",
			"Resume",
			"Return",
			"SByte",
			"Select",
			"Set",
			"Shadows",
			"Shared",
			"Short",
			"Single",
			"Skip",
			"Static",
			"Step",
			"Stop",
			"Strict",
			"String",
			"Structure",
			"Sub",
			"SyncLock",
			"Take",
			"Text",
			"Then",
			"Throw",
			"To",
			"True",
			"Try",
			"TryCast",
			"TypeOf",
			"UInteger",
			"ULong",
			"Unicode",
			"Until",
			"UShort",
			"Using",
			"Variant",
			"Wend",
			"When",
			"Where",
			"While",
			"Widening",
			"With",
			"WithEvents",
			"WriteOnly",
			"Xor",
			"GetXmlNamespace",
		};
		public static string GetTokenString(int token)
		{
			if (token >= 0 && token < tokenList.Length) {
				return tokenList[token];
			}
			throw new System.NotSupportedException("Unknown token:" + token);
		}
	}
}