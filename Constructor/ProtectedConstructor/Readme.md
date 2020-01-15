## ProtectedConstructor.java

This java file contains Class with protected constructor. So first compile it with following command

```bash
javac -d . ProtectedConstructor.java
```
It will create a new package ProtectedConstructorPackage containing the compiled .class file. 
## UtilClass.java

This java file contains a subclass which extends ProtectedConstructor.That subclass depicts the access of protected constructor in other package. After compiling ProtectedConstructor.java, compile this file using command

```bash
javac -d . UtilClass.java
```
It will create a new package UtilPackage containing two compiled .class file.
Now run the program using command
```bash
java UtilPackage.UtilClass
```