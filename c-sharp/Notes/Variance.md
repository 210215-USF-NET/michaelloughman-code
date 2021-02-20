## VARIANCE -- A form of polymorphism ##

- Describes the type that may be substituted for another type

- Covariance: We say a substitution is a covariant with a type, Foo, if Foo or any other 
    class with a subclass relationship to Foo is valid.

- Contravariance: We say a substittion is contravariant with a type, Bar, if Bar or any other 
    class with a superclass relationship to Bar is valid.

- Invariance: We say a substitution is invariant with a type, Foo, if only types that are exactly Foo are valid

## Type Casting ##

- Boxing (Autoboxing)
    - Uupcasting
    - Casting to a supertype
    - Implicit Type Casting

- Unboxing
    - Downcasting
    - Casting to a subtype
    - Explicit Type Casting

** Note that types that are similar to each other such as your numeric types can be casted to another similar type
    -   For example when casting from int to double

## Type Checking ##

- is operator:
    - used to check if the run-time of an object is compatible with the given type or not
    - it returns true if the given object is of the same type, otherwise returns false. It also returns
        false for null objects

- typeof operator
    - used to get a type at the compile-time. In other words, this operator is used to get the System.Type 
        object for a type
    - gives you the CTS version of the type
    - This operator takes the Type itself as an argument and returns the marked type of the argument
    - Often confused with the GetType() method of an object
        - This method return the type in the c# sense of an object


## Resources ##
- Variance in Programming Languages
- Covariance and Contravariance in C#
- Microosoft Docs on Variance in C#






