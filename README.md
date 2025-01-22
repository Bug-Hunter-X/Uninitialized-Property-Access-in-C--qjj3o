# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it's been assigned a value.  Uninitialized properties have default values (0 for integers, null for reference types, etc.), but relying on these defaults can lead to unexpected behavior and subtle bugs.