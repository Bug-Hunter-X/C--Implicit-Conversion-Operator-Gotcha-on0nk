# C# Implicit Conversion Operator Gotcha

This example demonstrates a potential issue with implicit conversion operators in C#. While convenient, they can sometimes lead to unexpected behavior or make code harder to understand, especially in more complex scenarios.  The implicit conversion between `MyClass` and `int` appears straightforward for simple assignments but can become less readable when used within more complex expressions.

## Bug
The `Bug.cs` file shows how implicit conversion operators can cause confusion when used in arithmetic expressions. The addition operation (`obj2 + 5`) relies on implicit conversion from `MyClass` to `int`, which might be less obvious without understanding the implicit operators defined in `MyClass`.

## Solution
The `BugSolution.cs` suggests ways to improve the code's clarity, such as using explicit conversions or re-evaluating the need for implicit operators entirely.  This enhances readability and reduces the chance of unexpected results.