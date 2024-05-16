INSTANCE MODIFIERS
	this
	base
	static
ACCESS MODIFIERS 
	public
	private
	protected
	internal
	protected internal
INHERITANCE MODIFIERS
	virtual => override
	abstract => override
	override => override
	new
	sealed
--------------

abstract class A						// CANNOT BE INSTANTIATED
	public void m() { }												A obj = new A();		// FAILS
	public virtual void n() { }			// MAY OVERRIDE				obj.m();  
	public abstract void o();			// MUST OVERRIDE			obj.n();
	public void q() { }												obj.o();  // fails due to no-code

abstract class B : A
	public void m() { }  -- not allowed								A objA = new B();
	public override void n() { }		// MAY OVERRIDE				objA.o();	// success!
	public override void o() { }
	new public void q()	{ }				// ECLIPSE / OVERSHADOW
	sealed public void n() { }

abstract class C : B
	public abstract void p();
	new public void n() { }				// FAIL

sealed class D : C						// CANNOT BE INHERITED
	public override n() { }
	public override void p();

class E : D							// FAIL
---------

class A 
	public virtual void p1() { C.WL("one"); }
	public virtual void p2() { C.WL("100"); }
	public virtual void p3() { C.WL("hello world 1"); }

class B : A
	public override void p1() { C.WL("two"); }
	public override void p3() { C.WL("hello world 2"); }

class C : B
	public override void p1() { C.WL("three"); }
	public override void p3() { C.WL("hello world 3"); }		// inherits B.p3()

class D : C
	public override void p1() { C.WL("four"); }
	new virtual public int p3() { C.WL("hello world 4"); }		// overshadow B.p3()

class E : D
	public override void p1() { C.WL("five"); }
	public override void p3() { C.WL("hello world 5"); }		// E.p3 -> D.p3
																//				-> C.p3 -> B.p3 -> A.p3

B objB = new E();
objB.p1();		// "five"
objB.p2();		// "100"
objB.p3();		// "hello world 3"

D objD = new E();
objD.p3();		// "hello world 5"