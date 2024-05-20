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
		Class
		Interface
		Delegate
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


GoF (Gang Of Four) Design Patterns
- Creational Patterns
- Structural Patterns
	Late Instantiation
- Behavioural Patterns

