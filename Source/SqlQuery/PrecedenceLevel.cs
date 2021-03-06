﻿using System;

namespace LinqToDB.SqlQuery
{
	public class PrecedenceLevel
	{
		public const int Primary            = 100; // (x) x.y f(x) a[x] x++ x-- new typeof sizeof checked unchecked
		public const int Unary              =  90; // + - ! ++x --x (T)x
		public const int Multiplicative     =  80; // * / %
		public const int Subtraction        =  70; // -
		public const int Additive           =  60; // +
		public const int Comparison         =  50; // ANY ALL SOME EXISTS, IS [NOT], IN, BETWEEN, LIKE, < > <= >=, == !=
		public const int Bitwise            =  40; // ^
		public const int LogicalNegation    =  30; // NOT
		public const int LogicalConjunction =  20; // AND
		public const int LogicalDisjunction =  10; // OR
		public const int Unknown            =   0;

        public PrecedenceLevel() : this(Unknown) { }
        public PrecedenceLevel(PrecedenceLevel constant) { this.Id = constant.Id; }
        public PrecedenceLevel(int id) { this.Id = id; }

        public override bool Equals(object obj)
        {
            return obj is PrecedenceLevel ? this.Id == (obj as PrecedenceLevel).Id : false;
        }
        public override int GetHashCode() { return Id;}

        public bool IsLess(int id) { return this.Id < id; }
        public bool IsLess(object obj)
        {
            return obj is PrecedenceLevel ? this.Id < (obj as PrecedenceLevel).Id : false;
        }

       public int Id {get; protected set;}
	}

	[Obsolete]
	public class Precedence : PrecedenceLevel
	{
	}
}
