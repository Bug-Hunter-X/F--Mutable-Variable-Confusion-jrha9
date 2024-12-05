# F# Mutability Bug
This example demonstrates a common issue in F# related to the interaction between mutable variables and function calls. The variable `z` is calculated once and is not updated when the values of `x` and `y` change later.

## Bug
The bug lies in the misunderstanding of how mutability works within the scope of the function and assignment.  While `x` and `y` are mutable, the result of `add x y` is assigned to the immutable `z`.   Changing `x` and `y` after that doesn't affect `z`.