default initialization values - 0, false, null

{}  curly braces
[]  bar bracket
()  parethesis


Common Type System (CTS)  -- object
- ValueTypes
	char, int, long, bool, short (struct)
	custom valuetype
- ReferenceTypes
	string

------------------------

NAMING CONVENTION STYLES (for helping to identify Scope)

												HUNGARIAN PRINCIPLE OF MEMBER NAMING
firstname	Small Casing		Local			name			namestring		strname
FIRSTNAME	Capital Casing		Constants		NAME			NAMESTRING		STRNAME
FirstName	Pascal Casing		Public			Name			NameString		StrName
_firstName	Camel Casing		Private			_name			_nameString		_strName
firstName	Camel Casing		Protected		name			nameString		strName

------------------------

Tools of Programming
NAMESPACE
TYPE
	ValueTypes
		Enum
		Struct
	ReferenceTypes
		Class (including Generic Types)
		Interface
		Delegate
		Event		
OBJECT (exhibits Attributes and Behaviours)
	Data Field
	Method
	Property
	Indexer
	Constructor
		Type Constructor (Parameterless)
		Instance Constructor (Parameterless, Parametized)


Programming Concepts
- Declaration of Objects / Types
- Instantiation of Objects
- Initialization of Objects & Members
- Encapsulation 
	1. Authentication
	2. Authorization
	3. Validation
	4. Activity / Process
	5. Audit Logging
- Aggregation
- Inheritance
- Polymorphism
  - Overload
  - Override  (abstract, virtual, override, sealed, new)
  - Interface 
  - Delegate

INSTANCE MODIFIERS
	this
	base
	static
SCOPE ACCESS MODIFIERS 
	public				(available everywhere - current class, derived class, obj of current, obj of derived)
	private				(only within current class)
	protected			(current class, derived class)
	internal			(available everywhere - only in the same assembly )
	protected internal	(available eveywhere with the assembly + derived class in another class)
INHERITANCE MODIFIERS
	virtual => override
	abstract => override
	override => override
	new
	sealed

GoF (Gang Of Four) Design Patterns
- Creational Patterns
- Structural Patterns
	Late Instantiation Pattern
- Behavioural Patterns
	Observer Pattern

EVOLUTION PROGRAMMING LANGUAGE
	Statement Driven Programming	( HTML)
	Procedural Programming			( C, PASCAL, COBOL 85/87 )
	Object Oriented Programming		( C++* )
	Event Driven Programming	
	Declarative Programming

=============================================================

STANDARD DEVICES
	Standard Input => Input Object (IN)
	Standard Output => Output Object (OUT) / (PRN)
	Standard Error => Error Object (ERR)

Errors
	Compile Time Error (Syntax associated)
	Semantic Error (Logic associated)
	Run Time Error (most critical - abnormally terminates app)
Exception
	Handled Run Time Error  ( try ..  catch... finally, throw new )


System.Exception
	- System.SystemException (thrown by the OS / CLR)
		System.OutOfMemoryException
		...
	- System.ApplicationException (thrown by the user's code)
		System.DivideByZeorException
		System.IndexOutOfBoundsException
		System.ArithmeticOverflowException
		...