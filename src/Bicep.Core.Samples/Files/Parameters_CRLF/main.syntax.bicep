/* 
  This is a block comment.
*/
//@[2:6) NewLine |\r\n\r\n|

// parameters without default value
//@[35:37) NewLine |\r\n|
param myString string
//@[0:21) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:14)  IdentifierSyntax
//@[6:14)   Identifier |myString|
//@[15:21)  TypeSyntax
//@[15:21)   Identifier |string|
//@[21:23) NewLine |\r\n|
param myInt int
//@[0:15) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:11)  IdentifierSyntax
//@[6:11)   Identifier |myInt|
//@[12:15)  TypeSyntax
//@[12:15)   Identifier |int|
//@[15:17) NewLine |\r\n|
param myBool bool
//@[0:17) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:12)  IdentifierSyntax
//@[6:12)   Identifier |myBool|
//@[13:17)  TypeSyntax
//@[13:17)   Identifier |bool|
//@[17:21) NewLine |\r\n\r\n|

// parameters with default value
//@[32:34) NewLine |\r\n|
param myString2 string = 'string value'
//@[0:39) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:15)  IdentifierSyntax
//@[6:15)   Identifier |myString2|
//@[16:22)  TypeSyntax
//@[16:22)   Identifier |string|
//@[23:39)  ParameterDefaultValueSyntax
//@[23:24)   Assignment |=|
//@[25:39)   StringSyntax
//@[25:39)    StringComplete |'string value'|
//@[39:41) NewLine |\r\n|
param myInt2 int = 42
//@[0:21) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:12)  IdentifierSyntax
//@[6:12)   Identifier |myInt2|
//@[13:16)  TypeSyntax
//@[13:16)   Identifier |int|
//@[17:21)  ParameterDefaultValueSyntax
//@[17:18)   Assignment |=|
//@[19:21)   IntegerLiteralSyntax
//@[19:21)    Integer |42|
//@[21:23) NewLine |\r\n|
param myTruth bool = true
//@[0:25) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:13)  IdentifierSyntax
//@[6:13)   Identifier |myTruth|
//@[14:18)  TypeSyntax
//@[14:18)   Identifier |bool|
//@[19:25)  ParameterDefaultValueSyntax
//@[19:20)   Assignment |=|
//@[21:25)   BooleanLiteralSyntax
//@[21:25)    TrueKeyword |true|
//@[25:27) NewLine |\r\n|
param myFalsehood bool = false
//@[0:30) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:17)  IdentifierSyntax
//@[6:17)   Identifier |myFalsehood|
//@[18:22)  TypeSyntax
//@[18:22)   Identifier |bool|
//@[23:30)  ParameterDefaultValueSyntax
//@[23:24)   Assignment |=|
//@[25:30)   BooleanLiteralSyntax
//@[25:30)    FalseKeyword |false|
//@[30:32) NewLine |\r\n|
param myEscapedString string = 'First line\r\nSecond\ttabbed\tline'
//@[0:67) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:21)  IdentifierSyntax
//@[6:21)   Identifier |myEscapedString|
//@[22:28)  TypeSyntax
//@[22:28)   Identifier |string|
//@[29:67)  ParameterDefaultValueSyntax
//@[29:30)   Assignment |=|
//@[31:67)   StringSyntax
//@[31:67)    StringComplete |'First line\r\nSecond\ttabbed\tline'|
//@[67:71) NewLine |\r\n\r\n|

// object default value
//@[23:25) NewLine |\r\n|
param foo object = {
//@[0:253) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:9)  IdentifierSyntax
//@[6:9)   Identifier |foo|
//@[10:16)  TypeSyntax
//@[10:16)   Identifier |object|
//@[17:253)  ParameterDefaultValueSyntax
//@[17:18)   Assignment |=|
//@[19:253)   ObjectSyntax
//@[19:20)    LeftBrace |{|
//@[20:22)    NewLine |\r\n|
  enabled: true
//@[2:15)    ObjectPropertySyntax
//@[2:9)     IdentifierSyntax
//@[2:9)      Identifier |enabled|
//@[9:10)     Colon |:|
//@[11:15)     BooleanLiteralSyntax
//@[11:15)      TrueKeyword |true|
//@[15:17)    NewLine |\r\n|
  name: 'this is my object'
//@[2:27)    ObjectPropertySyntax
//@[2:6)     IdentifierSyntax
//@[2:6)      Identifier |name|
//@[6:7)     Colon |:|
//@[8:27)     StringSyntax
//@[8:27)      StringComplete |'this is my object'|
//@[27:29)    NewLine |\r\n|
  priority: 3
//@[2:13)    ObjectPropertySyntax
//@[2:10)     IdentifierSyntax
//@[2:10)      Identifier |priority|
//@[10:11)     Colon |:|
//@[12:13)     IntegerLiteralSyntax
//@[12:13)      Integer |3|
//@[13:15)    NewLine |\r\n|
  info: {
//@[2:26)    ObjectPropertySyntax
//@[2:6)     IdentifierSyntax
//@[2:6)      Identifier |info|
//@[6:7)     Colon |:|
//@[8:26)     ObjectSyntax
//@[8:9)      LeftBrace |{|
//@[9:11)      NewLine |\r\n|
    a: 'b'
//@[4:10)      ObjectPropertySyntax
//@[4:5)       IdentifierSyntax
//@[4:5)        Identifier |a|
//@[5:6)       Colon |:|
//@[7:10)       StringSyntax
//@[7:10)        StringComplete |'b'|
//@[10:12)      NewLine |\r\n|
  }
//@[2:3)      RightBrace |}|
//@[3:5)    NewLine |\r\n|
  empty: {
//@[2:15)    ObjectPropertySyntax
//@[2:7)     IdentifierSyntax
//@[2:7)      Identifier |empty|
//@[7:8)     Colon |:|
//@[9:15)     ObjectSyntax
//@[9:10)      LeftBrace |{|
//@[10:12)      NewLine |\r\n|
  }
//@[2:3)      RightBrace |}|
//@[3:5)    NewLine |\r\n|
  array: [
//@[2:122)    ObjectPropertySyntax
//@[2:7)     IdentifierSyntax
//@[2:7)      Identifier |array|
//@[7:8)     Colon |:|
//@[9:122)     ArraySyntax
//@[9:10)      LeftSquare |[|
//@[10:12)      NewLine |\r\n|
    'string item'
//@[4:17)      ArrayItemSyntax
//@[4:17)       StringSyntax
//@[4:17)        StringComplete |'string item'|
//@[17:19)      NewLine |\r\n|
    12
//@[4:6)      ArrayItemSyntax
//@[4:6)       IntegerLiteralSyntax
//@[4:6)        Integer |12|
//@[6:8)      NewLine |\r\n|
    true
//@[4:8)      ArrayItemSyntax
//@[4:8)       BooleanLiteralSyntax
//@[4:8)        TrueKeyword |true|
//@[8:10)      NewLine |\r\n|
    [
//@[4:40)      ArrayItemSyntax
//@[4:40)       ArraySyntax
//@[4:5)        LeftSquare |[|
//@[5:7)        NewLine |\r\n|
      'inner'
//@[6:13)        ArrayItemSyntax
//@[6:13)         StringSyntax
//@[6:13)          StringComplete |'inner'|
//@[13:15)        NewLine |\r\n|
      false
//@[6:11)        ArrayItemSyntax
//@[6:11)         BooleanLiteralSyntax
//@[6:11)          FalseKeyword |false|
//@[11:13)        NewLine |\r\n|
    ]
//@[4:5)        RightSquare |]|
//@[5:7)      NewLine |\r\n|
    {
//@[4:26)      ArrayItemSyntax
//@[4:26)       ObjectSyntax
//@[4:5)        LeftBrace |{|
//@[5:7)        NewLine |\r\n|
      a: 'b'
//@[6:12)        ObjectPropertySyntax
//@[6:7)         IdentifierSyntax
//@[6:7)          Identifier |a|
//@[7:8)         Colon |:|
//@[9:12)         StringSyntax
//@[9:12)          StringComplete |'b'|
//@[12:14)        NewLine |\r\n|
    }
//@[4:5)        RightBrace |}|
//@[5:7)      NewLine |\r\n|
  ]
//@[2:3)      RightSquare |]|
//@[3:5)    NewLine |\r\n|
}
//@[0:1)    RightBrace |}|
//@[1:5) NewLine |\r\n\r\n|

// array default value
//@[22:24) NewLine |\r\n|
param myArrayParam array = [
//@[0:52) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:18)  IdentifierSyntax
//@[6:18)   Identifier |myArrayParam|
//@[19:24)  TypeSyntax
//@[19:24)   Identifier |array|
//@[25:52)  ParameterDefaultValueSyntax
//@[25:26)   Assignment |=|
//@[27:52)   ArraySyntax
//@[27:28)    LeftSquare |[|
//@[28:30)    NewLine |\r\n|
  'a'
//@[2:5)    ArrayItemSyntax
//@[2:5)     StringSyntax
//@[2:5)      StringComplete |'a'|
//@[5:7)    NewLine |\r\n|
  'b'
//@[2:5)    ArrayItemSyntax
//@[2:5)     StringSyntax
//@[2:5)      StringComplete |'b'|
//@[5:7)    NewLine |\r\n|
  'c'
//@[2:5)    ArrayItemSyntax
//@[2:5)     StringSyntax
//@[2:5)      StringComplete |'c'|
//@[5:7)    NewLine |\r\n|
]
//@[0:1)    RightSquare |]|
//@[1:5) NewLine |\r\n\r\n|

// secure string
//@[16:18) NewLine |\r\n|
@secure()
//@[0:32) ParameterDeclarationSyntax
//@[0:9)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:9)   FunctionCallSyntax
//@[1:7)    IdentifierSyntax
//@[1:7)     Identifier |secure|
//@[7:8)    LeftParen |(|
//@[8:9)    RightParen |)|
//@[9:11)  NewLine |\r\n|
param password string
//@[0:5)  Identifier |param|
//@[6:14)  IdentifierSyntax
//@[6:14)   Identifier |password|
//@[15:21)  TypeSyntax
//@[15:21)   Identifier |string|
//@[21:25) NewLine |\r\n\r\n|

// secure object
//@[16:18) NewLine |\r\n|
@secure()
//@[0:36) ParameterDeclarationSyntax
//@[0:9)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:9)   FunctionCallSyntax
//@[1:7)    IdentifierSyntax
//@[1:7)     Identifier |secure|
//@[7:8)    LeftParen |(|
//@[8:9)    RightParen |)|
//@[9:11)  NewLine |\r\n|
param secretObject object
//@[0:5)  Identifier |param|
//@[6:18)  IdentifierSyntax
//@[6:18)   Identifier |secretObject|
//@[19:25)  TypeSyntax
//@[19:25)   Identifier |object|
//@[25:29) NewLine |\r\n\r\n|

// enum parameter
//@[17:19) NewLine |\r\n|
@allowed([
//@[0:75) ParameterDeclarationSyntax
//@[0:50)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:50)   FunctionCallSyntax
//@[1:8)    IdentifierSyntax
//@[1:8)     Identifier |allowed|
//@[8:9)    LeftParen |(|
//@[9:49)    FunctionArgumentSyntax
//@[9:49)     ArraySyntax
//@[9:10)      LeftSquare |[|
//@[10:12)      NewLine |\r\n|
  'Standard_LRS'
//@[2:16)      ArrayItemSyntax
//@[2:16)       StringSyntax
//@[2:16)        StringComplete |'Standard_LRS'|
//@[16:18)      NewLine |\r\n|
  'Standard_GRS'
//@[2:16)      ArrayItemSyntax
//@[2:16)       StringSyntax
//@[2:16)        StringComplete |'Standard_GRS'|
//@[16:18)      NewLine |\r\n|
])
//@[0:1)      RightSquare |]|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param storageSku string
//@[0:5)  Identifier |param|
//@[6:16)  IdentifierSyntax
//@[6:16)   Identifier |storageSku|
//@[17:23)  TypeSyntax
//@[17:23)   Identifier |string|
//@[23:27) NewLine |\r\n\r\n|

// length constraint on a string
//@[32:34) NewLine |\r\n|
@minLength(3)
//@[0:55) ParameterDeclarationSyntax
//@[0:13)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:13)   FunctionCallSyntax
//@[1:10)    IdentifierSyntax
//@[1:10)     Identifier |minLength|
//@[10:11)    LeftParen |(|
//@[11:12)    FunctionArgumentSyntax
//@[11:12)     IntegerLiteralSyntax
//@[11:12)      Integer |3|
//@[12:13)    RightParen |)|
//@[13:15)  NewLine |\r\n|
@maxLength(24)
//@[0:14)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:14)   FunctionCallSyntax
//@[1:10)    IdentifierSyntax
//@[1:10)     Identifier |maxLength|
//@[10:11)    LeftParen |(|
//@[11:13)    FunctionArgumentSyntax
//@[11:13)     IntegerLiteralSyntax
//@[11:13)      Integer |24|
//@[13:14)    RightParen |)|
//@[14:16)  NewLine |\r\n|
param storageName string
//@[0:5)  Identifier |param|
//@[6:17)  IdentifierSyntax
//@[6:17)   Identifier |storageName|
//@[18:24)  TypeSyntax
//@[18:24)   Identifier |string|
//@[24:28) NewLine |\r\n\r\n|

// length constraint on an array
//@[32:34) NewLine |\r\n|
@minLength(3)
//@[0:52) ParameterDeclarationSyntax
//@[0:13)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:13)   FunctionCallSyntax
//@[1:10)    IdentifierSyntax
//@[1:10)     Identifier |minLength|
//@[10:11)    LeftParen |(|
//@[11:12)    FunctionArgumentSyntax
//@[11:12)     IntegerLiteralSyntax
//@[11:12)      Integer |3|
//@[12:13)    RightParen |)|
//@[13:15)  NewLine |\r\n|
@maxLength(24)
//@[0:14)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:14)   FunctionCallSyntax
//@[1:10)    IdentifierSyntax
//@[1:10)     Identifier |maxLength|
//@[10:11)    LeftParen |(|
//@[11:13)    FunctionArgumentSyntax
//@[11:13)     IntegerLiteralSyntax
//@[11:13)      Integer |24|
//@[13:14)    RightParen |)|
//@[14:16)  NewLine |\r\n|
param someArray array
//@[0:5)  Identifier |param|
//@[6:15)  IdentifierSyntax
//@[6:15)   Identifier |someArray|
//@[16:21)  TypeSyntax
//@[16:21)   Identifier |array|
//@[21:25) NewLine |\r\n\r\n|

// empty metadata
//@[17:19) NewLine |\r\n|
@metadata({})
//@[0:41) ParameterDeclarationSyntax
//@[0:13)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:13)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |metadata|
//@[9:10)    LeftParen |(|
//@[10:12)    FunctionArgumentSyntax
//@[10:12)     ObjectSyntax
//@[10:11)      LeftBrace |{|
//@[11:12)      RightBrace |}|
//@[12:13)    RightParen |)|
//@[13:15)  NewLine |\r\n|
param emptyMetadata string
//@[0:5)  Identifier |param|
//@[6:19)  IdentifierSyntax
//@[6:19)   Identifier |emptyMetadata|
//@[20:26)  TypeSyntax
//@[20:26)   Identifier |string|
//@[26:30) NewLine |\r\n\r\n|

// description
//@[14:16) NewLine |\r\n|
@metadata({
//@[0:74) ParameterDeclarationSyntax
//@[0:48)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:48)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |metadata|
//@[9:10)    LeftParen |(|
//@[10:47)    FunctionArgumentSyntax
//@[10:47)     ObjectSyntax
//@[10:11)      LeftBrace |{|
//@[11:13)      NewLine |\r\n|
  description: 'my description'
//@[2:31)      ObjectPropertySyntax
//@[2:13)       IdentifierSyntax
//@[2:13)        Identifier |description|
//@[13:14)       Colon |:|
//@[15:31)       StringSyntax
//@[15:31)        StringComplete |'my description'|
//@[31:33)      NewLine |\r\n|
})
//@[0:1)      RightBrace |}|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param description string
//@[0:5)  Identifier |param|
//@[6:17)  IdentifierSyntax
//@[6:17)   Identifier |description|
//@[18:24)  TypeSyntax
//@[18:24)   Identifier |string|
//@[24:28) NewLine |\r\n\r\n|

@sys.description('my description')
//@[0:61) ParameterDeclarationSyntax
//@[0:34)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:34)   InstanceFunctionCallSyntax
//@[1:4)    VariableAccessSyntax
//@[1:4)     IdentifierSyntax
//@[1:4)      Identifier |sys|
//@[4:5)    Dot |.|
//@[5:16)    IdentifierSyntax
//@[5:16)     Identifier |description|
//@[16:17)    LeftParen |(|
//@[17:33)    FunctionArgumentSyntax
//@[17:33)     StringSyntax
//@[17:33)      StringComplete |'my description'|
//@[33:34)    RightParen |)|
//@[34:36)  NewLine |\r\n|
param description2 string
//@[0:5)  Identifier |param|
//@[6:18)  IdentifierSyntax
//@[6:18)   Identifier |description2|
//@[19:25)  TypeSyntax
//@[19:25)   Identifier |string|
//@[25:29) NewLine |\r\n\r\n|

// random extra metadata
//@[24:26) NewLine |\r\n|
@metadata({
//@[0:143) ParameterDeclarationSyntax
//@[0:110)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:110)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |metadata|
//@[9:10)    LeftParen |(|
//@[10:109)    FunctionArgumentSyntax
//@[10:109)     ObjectSyntax
//@[10:11)      LeftBrace |{|
//@[11:13)      NewLine |\r\n|
  description: 'my description'
//@[2:31)      ObjectPropertySyntax
//@[2:13)       IdentifierSyntax
//@[2:13)        Identifier |description|
//@[13:14)       Colon |:|
//@[15:31)       StringSyntax
//@[15:31)        StringComplete |'my description'|
//@[31:33)      NewLine |\r\n|
  a: 1
//@[2:6)      ObjectPropertySyntax
//@[2:3)       IdentifierSyntax
//@[2:3)        Identifier |a|
//@[3:4)       Colon |:|
//@[5:6)       IntegerLiteralSyntax
//@[5:6)        Integer |1|
//@[6:8)      NewLine |\r\n|
  b: true
//@[2:9)      ObjectPropertySyntax
//@[2:3)       IdentifierSyntax
//@[2:3)        Identifier |b|
//@[3:4)       Colon |:|
//@[5:9)       BooleanLiteralSyntax
//@[5:9)        TrueKeyword |true|
//@[9:11)      NewLine |\r\n|
  c: [
//@[2:11)      ObjectPropertySyntax
//@[2:3)       IdentifierSyntax
//@[2:3)        Identifier |c|
//@[3:4)       Colon |:|
//@[5:11)       ArraySyntax
//@[5:6)        LeftSquare |[|
//@[6:8)        NewLine |\r\n|
  ]
//@[2:3)        RightSquare |]|
//@[3:5)      NewLine |\r\n|
  d: {
//@[2:28)      ObjectPropertySyntax
//@[2:3)       IdentifierSyntax
//@[2:3)        Identifier |d|
//@[3:4)       Colon |:|
//@[5:28)       ObjectSyntax
//@[5:6)        LeftBrace |{|
//@[6:8)        NewLine |\r\n|
    test: 'abc'
//@[4:15)        ObjectPropertySyntax
//@[4:8)         IdentifierSyntax
//@[4:8)          Identifier |test|
//@[8:9)         Colon |:|
//@[10:15)         StringSyntax
//@[10:15)          StringComplete |'abc'|
//@[15:17)        NewLine |\r\n|
  }
//@[2:3)        RightBrace |}|
//@[3:5)      NewLine |\r\n|
})
//@[0:1)      RightBrace |}|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param additionalMetadata string
//@[0:5)  Identifier |param|
//@[6:24)  IdentifierSyntax
//@[6:24)   Identifier |additionalMetadata|
//@[25:31)  TypeSyntax
//@[25:31)   Identifier |string|
//@[31:35) NewLine |\r\n\r\n|

// all modifiers together
//@[25:27) NewLine |\r\n|
@secure()
//@[0:176) ParameterDeclarationSyntax
//@[0:9)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:9)   FunctionCallSyntax
//@[1:7)    IdentifierSyntax
//@[1:7)     Identifier |secure|
//@[7:8)    LeftParen |(|
//@[8:9)    RightParen |)|
//@[9:11)  NewLine |\r\n|
@minLength(3)
//@[0:13)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:13)   FunctionCallSyntax
//@[1:10)    IdentifierSyntax
//@[1:10)     Identifier |minLength|
//@[10:11)    LeftParen |(|
//@[11:12)    FunctionArgumentSyntax
//@[11:12)     IntegerLiteralSyntax
//@[11:12)      Integer |3|
//@[12:13)    RightParen |)|
//@[13:15)  NewLine |\r\n|
@maxLength(24)
//@[0:14)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:14)   FunctionCallSyntax
//@[1:10)    IdentifierSyntax
//@[1:10)     Identifier |maxLength|
//@[10:11)    LeftParen |(|
//@[11:13)    FunctionArgumentSyntax
//@[11:13)     IntegerLiteralSyntax
//@[11:13)      Integer |24|
//@[13:14)    RightParen |)|
//@[14:16)  NewLine |\r\n|
@allowed([
//@[0:43)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:43)   FunctionCallSyntax
//@[1:8)    IdentifierSyntax
//@[1:8)     Identifier |allowed|
//@[8:9)    LeftParen |(|
//@[9:42)    FunctionArgumentSyntax
//@[9:42)     ArraySyntax
//@[9:10)      LeftSquare |[|
//@[10:12)      NewLine |\r\n|
  'one'
//@[2:7)      ArrayItemSyntax
//@[2:7)       StringSyntax
//@[2:7)        StringComplete |'one'|
//@[7:9)      NewLine |\r\n|
  'two'
//@[2:7)      ArrayItemSyntax
//@[2:7)       StringSyntax
//@[2:7)        StringComplete |'two'|
//@[7:9)      NewLine |\r\n|
  'three'
//@[2:9)      ArrayItemSyntax
//@[2:9)       StringSyntax
//@[2:9)        StringComplete |'three'|
//@[9:11)      NewLine |\r\n|
])
//@[0:1)      RightSquare |]|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
@metadata({
//@[0:61)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:61)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |metadata|
//@[9:10)    LeftParen |(|
//@[10:60)    FunctionArgumentSyntax
//@[10:60)     ObjectSyntax
//@[10:11)      LeftBrace |{|
//@[11:13)      NewLine |\r\n|
  description: 'Name of the storage account'
//@[2:44)      ObjectPropertySyntax
//@[2:13)       IdentifierSyntax
//@[2:13)        Identifier |description|
//@[13:14)       Colon |:|
//@[15:44)       StringSyntax
//@[15:44)        StringComplete |'Name of the storage account'|
//@[44:46)      NewLine |\r\n|
})
//@[0:1)      RightBrace |}|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param someParameter string
//@[0:5)  Identifier |param|
//@[6:19)  IdentifierSyntax
//@[6:19)   Identifier |someParameter|
//@[20:26)  TypeSyntax
//@[20:26)   Identifier |string|
//@[26:30) NewLine |\r\n\r\n|

param defaultExpression bool = 18 != (true || false)
//@[0:52) ParameterDeclarationSyntax
//@[0:5)  Identifier |param|
//@[6:23)  IdentifierSyntax
//@[6:23)   Identifier |defaultExpression|
//@[24:28)  TypeSyntax
//@[24:28)   Identifier |bool|
//@[29:52)  ParameterDefaultValueSyntax
//@[29:30)   Assignment |=|
//@[31:52)   BinaryOperationSyntax
//@[31:33)    IntegerLiteralSyntax
//@[31:33)     Integer |18|
//@[34:36)    NotEquals |!=|
//@[37:52)    ParenthesizedExpressionSyntax
//@[37:38)     LeftParen |(|
//@[38:51)     BinaryOperationSyntax
//@[38:42)      BooleanLiteralSyntax
//@[38:42)       TrueKeyword |true|
//@[43:45)      LogicalOr ||||
//@[46:51)      BooleanLiteralSyntax
//@[46:51)       FalseKeyword |false|
//@[51:52)     RightParen |)|
//@[52:56) NewLine |\r\n\r\n|

@allowed([
//@[0:60) ParameterDeclarationSyntax
//@[0:32)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:32)   FunctionCallSyntax
//@[1:8)    IdentifierSyntax
//@[1:8)     Identifier |allowed|
//@[8:9)    LeftParen |(|
//@[9:31)    FunctionArgumentSyntax
//@[9:31)     ArraySyntax
//@[9:10)      LeftSquare |[|
//@[10:12)      NewLine |\r\n|
  'abc'
//@[2:7)      ArrayItemSyntax
//@[2:7)       StringSyntax
//@[2:7)        StringComplete |'abc'|
//@[7:9)      NewLine |\r\n|
  'def'
//@[2:7)      ArrayItemSyntax
//@[2:7)       StringSyntax
//@[2:7)        StringComplete |'def'|
//@[7:9)      NewLine |\r\n|
])
//@[0:1)      RightSquare |]|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param stringLiteral string
//@[0:5)  Identifier |param|
//@[6:19)  IdentifierSyntax
//@[6:19)   Identifier |stringLiteral|
//@[20:26)  TypeSyntax
//@[20:26)   Identifier |string|
//@[26:30) NewLine |\r\n\r\n|

@allowed([
//@[0:110) ParameterDeclarationSyntax
//@[0:41)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:41)   FunctionCallSyntax
//@[1:8)    IdentifierSyntax
//@[1:8)     Identifier |allowed|
//@[8:9)    LeftParen |(|
//@[9:40)    FunctionArgumentSyntax
//@[9:40)     ArraySyntax
//@[9:10)      LeftSquare |[|
//@[10:12)      NewLine |\r\n|
  'abc'
//@[2:7)      ArrayItemSyntax
//@[2:7)       StringSyntax
//@[2:7)        StringComplete |'abc'|
//@[7:9)      NewLine |\r\n|
  'def'
//@[2:7)      ArrayItemSyntax
//@[2:7)       StringSyntax
//@[2:7)        StringComplete |'def'|
//@[7:9)      NewLine |\r\n|
  'ghi'
//@[2:7)      ArrayItemSyntax
//@[2:7)       StringSyntax
//@[2:7)        StringComplete |'ghi'|
//@[7:9)      NewLine |\r\n|
])
//@[0:1)      RightSquare |]|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param stringLiteralWithAllowedValuesSuperset string = stringLiteral
//@[0:5)  Identifier |param|
//@[6:44)  IdentifierSyntax
//@[6:44)   Identifier |stringLiteralWithAllowedValuesSuperset|
//@[45:51)  TypeSyntax
//@[45:51)   Identifier |string|
//@[52:67)  ParameterDefaultValueSyntax
//@[52:53)   Assignment |=|
//@[54:67)   VariableAccessSyntax
//@[54:67)    IdentifierSyntax
//@[54:67)     Identifier |stringLiteral|
//@[67:71) NewLine |\r\n\r\n|

@secure()
//@[0:111) ParameterDeclarationSyntax
//@[0:9)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:9)   FunctionCallSyntax
//@[1:7)    IdentifierSyntax
//@[1:7)     Identifier |secure|
//@[7:8)    LeftParen |(|
//@[8:9)    RightParen |)|
//@[9:11)  NewLine |\r\n|
@minLength(2)
//@[0:13)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:13)   FunctionCallSyntax
//@[1:10)    IdentifierSyntax
//@[1:10)     Identifier |minLength|
//@[10:11)    LeftParen |(|
//@[11:12)    FunctionArgumentSyntax
//@[11:12)     IntegerLiteralSyntax
//@[11:12)      Integer |2|
//@[12:13)    RightParen |)|
//@[13:15)  NewLine |\r\n|
  @maxLength(10)
//@[2:16)  DecoratorSyntax
//@[2:3)   At |@|
//@[3:16)   FunctionCallSyntax
//@[3:12)    IdentifierSyntax
//@[3:12)     Identifier |maxLength|
//@[12:13)    LeftParen |(|
//@[13:15)    FunctionArgumentSyntax
//@[13:15)     IntegerLiteralSyntax
//@[13:15)      Integer |10|
//@[15:16)    RightParen |)|
//@[16:18)  NewLine |\r\n|
@allowed([
//@[0:37)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:37)   FunctionCallSyntax
//@[1:8)    IdentifierSyntax
//@[1:8)     Identifier |allowed|
//@[8:9)    LeftParen |(|
//@[9:36)    FunctionArgumentSyntax
//@[9:36)     ArraySyntax
//@[9:10)      LeftSquare |[|
//@[10:12)      NewLine |\r\n|
  'Apple'
//@[2:9)      ArrayItemSyntax
//@[2:9)       StringSyntax
//@[2:9)        StringComplete |'Apple'|
//@[9:11)      NewLine |\r\n|
  'Banana'
//@[2:10)      ArrayItemSyntax
//@[2:10)       StringSyntax
//@[2:10)        StringComplete |'Banana'|
//@[10:12)      NewLine |\r\n|
])
//@[0:1)      RightSquare |]|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param decoratedString string
//@[0:5)  Identifier |param|
//@[6:21)  IdentifierSyntax
//@[6:21)   Identifier |decoratedString|
//@[22:28)  TypeSyntax
//@[22:28)   Identifier |string|
//@[28:32) NewLine |\r\n\r\n|

@minValue(200)
//@[0:44) ParameterDeclarationSyntax
//@[0:14)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:14)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |minValue|
//@[9:10)    LeftParen |(|
//@[10:13)    FunctionArgumentSyntax
//@[10:13)     IntegerLiteralSyntax
//@[10:13)      Integer |200|
//@[13:14)    RightParen |)|
//@[14:16)  NewLine |\r\n|
param decoratedInt int = 123
//@[0:5)  Identifier |param|
//@[6:18)  IdentifierSyntax
//@[6:18)   Identifier |decoratedInt|
//@[19:22)  TypeSyntax
//@[19:22)   Identifier |int|
//@[23:28)  ParameterDefaultValueSyntax
//@[23:24)   Assignment |=|
//@[25:28)   IntegerLiteralSyntax
//@[25:28)    Integer |123|
//@[28:32) NewLine |\r\n\r\n|

// negative integer literals are allowed as decorator values
//@[60:62) NewLine |\r\n|
@minValue(-10)
//@[0:55) ParameterDeclarationSyntax
//@[0:14)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:14)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |minValue|
//@[9:10)    LeftParen |(|
//@[10:13)    FunctionArgumentSyntax
//@[10:13)     UnaryOperationSyntax
//@[10:11)      Minus |-|
//@[11:13)      IntegerLiteralSyntax
//@[11:13)       Integer |10|
//@[13:14)    RightParen |)|
//@[14:16)  NewLine |\r\n|
@maxValue(-3)
//@[0:13)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:13)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |maxValue|
//@[9:10)    LeftParen |(|
//@[10:12)    FunctionArgumentSyntax
//@[10:12)     UnaryOperationSyntax
//@[10:11)      Minus |-|
//@[11:12)      IntegerLiteralSyntax
//@[11:12)       Integer |3|
//@[12:13)    RightParen |)|
//@[13:15)  NewLine |\r\n|
param negativeValues int
//@[0:5)  Identifier |param|
//@[6:20)  IdentifierSyntax
//@[6:20)   Identifier |negativeValues|
//@[21:24)  TypeSyntax
//@[21:24)   Identifier |int|
//@[24:28) NewLine |\r\n\r\n|

@sys.description('A boolean.')
//@[0:229) ParameterDeclarationSyntax
//@[0:30)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:30)   InstanceFunctionCallSyntax
//@[1:4)    VariableAccessSyntax
//@[1:4)     IdentifierSyntax
//@[1:4)      Identifier |sys|
//@[4:5)    Dot |.|
//@[5:16)    IdentifierSyntax
//@[5:16)     Identifier |description|
//@[16:17)    LeftParen |(|
//@[17:29)    FunctionArgumentSyntax
//@[17:29)     StringSyntax
//@[17:29)      StringComplete |'A boolean.'|
//@[29:30)    RightParen |)|
//@[30:32)  NewLine |\r\n|
@metadata({
//@[0:145)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:145)   FunctionCallSyntax
//@[1:9)    IdentifierSyntax
//@[1:9)     Identifier |metadata|
//@[9:10)    LeftParen |(|
//@[10:144)    FunctionArgumentSyntax
//@[10:144)     ObjectSyntax
//@[10:11)      LeftBrace |{|
//@[11:13)      NewLine |\r\n|
    description: 'I will be overrode.'
//@[4:38)      ObjectPropertySyntax
//@[4:15)       IdentifierSyntax
//@[4:15)        Identifier |description|
//@[15:16)       Colon |:|
//@[17:38)       StringSyntax
//@[17:38)        StringComplete |'I will be overrode.'|
//@[38:40)      NewLine |\r\n|
    foo: 'something'
//@[4:20)      ObjectPropertySyntax
//@[4:7)       IdentifierSyntax
//@[4:7)        Identifier |foo|
//@[7:8)       Colon |:|
//@[9:20)       StringSyntax
//@[9:20)        StringComplete |'something'|
//@[20:22)      NewLine |\r\n|
    bar: [
//@[4:66)      ObjectPropertySyntax
//@[4:7)       IdentifierSyntax
//@[4:7)        Identifier |bar|
//@[7:8)       Colon |:|
//@[9:66)       ArraySyntax
//@[9:10)        LeftSquare |[|
//@[10:12)        NewLine |\r\n|
        {          }
//@[8:20)        ArrayItemSyntax
//@[8:20)         ObjectSyntax
//@[8:9)          LeftBrace |{|
//@[19:20)          RightBrace |}|
//@[20:22)        NewLine |\r\n|
        true
//@[8:12)        ArrayItemSyntax
//@[8:12)         BooleanLiteralSyntax
//@[8:12)          TrueKeyword |true|
//@[12:14)        NewLine |\r\n|
        123
//@[8:11)        ArrayItemSyntax
//@[8:11)         IntegerLiteralSyntax
//@[8:11)          Integer |123|
//@[11:13)        NewLine |\r\n|
    ]
//@[4:5)        RightSquare |]|
//@[5:7)      NewLine |\r\n|
})
//@[0:1)      RightBrace |}|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
param decoratedBool bool = (true && false) != true
//@[0:5)  Identifier |param|
//@[6:19)  IdentifierSyntax
//@[6:19)   Identifier |decoratedBool|
//@[20:24)  TypeSyntax
//@[20:24)   Identifier |bool|
//@[25:50)  ParameterDefaultValueSyntax
//@[25:26)   Assignment |=|
//@[27:50)   BinaryOperationSyntax
//@[27:42)    ParenthesizedExpressionSyntax
//@[27:28)     LeftParen |(|
//@[28:41)     BinaryOperationSyntax
//@[28:32)      BooleanLiteralSyntax
//@[28:32)       TrueKeyword |true|
//@[33:35)      LogicalAnd |&&|
//@[36:41)      BooleanLiteralSyntax
//@[36:41)       FalseKeyword |false|
//@[41:42)     RightParen |)|
//@[43:45)    NotEquals |!=|
//@[46:50)    BooleanLiteralSyntax
//@[46:50)     TrueKeyword |true|
//@[50:54) NewLine |\r\n\r\n|

@secure()
//@[0:276) ParameterDeclarationSyntax
//@[0:9)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:9)   FunctionCallSyntax
//@[1:7)    IdentifierSyntax
//@[1:7)     Identifier |secure|
//@[7:8)    LeftParen |(|
//@[8:9)    RightParen |)|
//@[9:11)  NewLine |\r\n|
param decoratedObject object = {
//@[0:5)  Identifier |param|
//@[6:21)  IdentifierSyntax
//@[6:21)   Identifier |decoratedObject|
//@[22:28)  TypeSyntax
//@[22:28)   Identifier |object|
//@[29:265)  ParameterDefaultValueSyntax
//@[29:30)   Assignment |=|
//@[31:265)   ObjectSyntax
//@[31:32)    LeftBrace |{|
//@[32:34)    NewLine |\r\n|
  enabled: true
//@[2:15)    ObjectPropertySyntax
//@[2:9)     IdentifierSyntax
//@[2:9)      Identifier |enabled|
//@[9:10)     Colon |:|
//@[11:15)     BooleanLiteralSyntax
//@[11:15)      TrueKeyword |true|
//@[15:17)    NewLine |\r\n|
  name: 'this is my object'
//@[2:27)    ObjectPropertySyntax
//@[2:6)     IdentifierSyntax
//@[2:6)      Identifier |name|
//@[6:7)     Colon |:|
//@[8:27)     StringSyntax
//@[8:27)      StringComplete |'this is my object'|
//@[27:29)    NewLine |\r\n|
  priority: 3
//@[2:13)    ObjectPropertySyntax
//@[2:10)     IdentifierSyntax
//@[2:10)      Identifier |priority|
//@[10:11)     Colon |:|
//@[12:13)     IntegerLiteralSyntax
//@[12:13)      Integer |3|
//@[13:15)    NewLine |\r\n|
  info: {
//@[2:26)    ObjectPropertySyntax
//@[2:6)     IdentifierSyntax
//@[2:6)      Identifier |info|
//@[6:7)     Colon |:|
//@[8:26)     ObjectSyntax
//@[8:9)      LeftBrace |{|
//@[9:11)      NewLine |\r\n|
    a: 'b'
//@[4:10)      ObjectPropertySyntax
//@[4:5)       IdentifierSyntax
//@[4:5)        Identifier |a|
//@[5:6)       Colon |:|
//@[7:10)       StringSyntax
//@[7:10)        StringComplete |'b'|
//@[10:12)      NewLine |\r\n|
  }
//@[2:3)      RightBrace |}|
//@[3:5)    NewLine |\r\n|
  empty: {
//@[2:15)    ObjectPropertySyntax
//@[2:7)     IdentifierSyntax
//@[2:7)      Identifier |empty|
//@[7:8)     Colon |:|
//@[9:15)     ObjectSyntax
//@[9:10)      LeftBrace |{|
//@[10:12)      NewLine |\r\n|
  }
//@[2:3)      RightBrace |}|
//@[3:5)    NewLine |\r\n|
  array: [
//@[2:122)    ObjectPropertySyntax
//@[2:7)     IdentifierSyntax
//@[2:7)      Identifier |array|
//@[7:8)     Colon |:|
//@[9:122)     ArraySyntax
//@[9:10)      LeftSquare |[|
//@[10:12)      NewLine |\r\n|
    'string item'
//@[4:17)      ArrayItemSyntax
//@[4:17)       StringSyntax
//@[4:17)        StringComplete |'string item'|
//@[17:19)      NewLine |\r\n|
    12
//@[4:6)      ArrayItemSyntax
//@[4:6)       IntegerLiteralSyntax
//@[4:6)        Integer |12|
//@[6:8)      NewLine |\r\n|
    true
//@[4:8)      ArrayItemSyntax
//@[4:8)       BooleanLiteralSyntax
//@[4:8)        TrueKeyword |true|
//@[8:10)      NewLine |\r\n|
    [
//@[4:40)      ArrayItemSyntax
//@[4:40)       ArraySyntax
//@[4:5)        LeftSquare |[|
//@[5:7)        NewLine |\r\n|
      'inner'
//@[6:13)        ArrayItemSyntax
//@[6:13)         StringSyntax
//@[6:13)          StringComplete |'inner'|
//@[13:15)        NewLine |\r\n|
      false
//@[6:11)        ArrayItemSyntax
//@[6:11)         BooleanLiteralSyntax
//@[6:11)          FalseKeyword |false|
//@[11:13)        NewLine |\r\n|
    ]
//@[4:5)        RightSquare |]|
//@[5:7)      NewLine |\r\n|
    {
//@[4:26)      ArrayItemSyntax
//@[4:26)       ObjectSyntax
//@[4:5)        LeftBrace |{|
//@[5:7)        NewLine |\r\n|
      a: 'b'
//@[6:12)        ObjectPropertySyntax
//@[6:7)         IdentifierSyntax
//@[6:7)          Identifier |a|
//@[7:8)         Colon |:|
//@[9:12)         StringSyntax
//@[9:12)          StringComplete |'b'|
//@[12:14)        NewLine |\r\n|
    }
//@[4:5)        RightBrace |}|
//@[5:7)      NewLine |\r\n|
  ]
//@[2:3)      RightSquare |]|
//@[3:5)    NewLine |\r\n|
}
//@[0:1)    RightBrace |}|
//@[1:5) NewLine |\r\n\r\n|

@sys.metadata({
//@[0:174) ParameterDeclarationSyntax
//@[0:49)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:49)   InstanceFunctionCallSyntax
//@[1:4)    VariableAccessSyntax
//@[1:4)     IdentifierSyntax
//@[1:4)      Identifier |sys|
//@[4:5)    Dot |.|
//@[5:13)    IdentifierSyntax
//@[5:13)     Identifier |metadata|
//@[13:14)    LeftParen |(|
//@[14:48)    FunctionArgumentSyntax
//@[14:48)     ObjectSyntax
//@[14:15)      LeftBrace |{|
//@[15:17)      NewLine |\r\n|
    description: 'An array.'
//@[4:28)      ObjectPropertySyntax
//@[4:15)       IdentifierSyntax
//@[4:15)        Identifier |description|
//@[15:16)       Colon |:|
//@[17:28)       StringSyntax
//@[17:28)        StringComplete |'An array.'|
//@[28:30)      NewLine |\r\n|
})
//@[0:1)      RightBrace |}|
//@[1:2)    RightParen |)|
//@[2:4)  NewLine |\r\n|
@sys.maxLength(20)
//@[0:18)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:18)   InstanceFunctionCallSyntax
//@[1:4)    VariableAccessSyntax
//@[1:4)     IdentifierSyntax
//@[1:4)      Identifier |sys|
//@[4:5)    Dot |.|
//@[5:14)    IdentifierSyntax
//@[5:14)     Identifier |maxLength|
//@[14:15)    LeftParen |(|
//@[15:17)    FunctionArgumentSyntax
//@[15:17)     IntegerLiteralSyntax
//@[15:17)      Integer |20|
//@[17:18)    RightParen |)|
//@[18:20)  NewLine |\r\n|
@sys.description('I will be overrode.')
//@[0:39)  DecoratorSyntax
//@[0:1)   At |@|
//@[1:39)   InstanceFunctionCallSyntax
//@[1:4)    VariableAccessSyntax
//@[1:4)     IdentifierSyntax
//@[1:4)      Identifier |sys|
//@[4:5)    Dot |.|
//@[5:16)    IdentifierSyntax
//@[5:16)     Identifier |description|
//@[16:17)    LeftParen |(|
//@[17:38)    FunctionArgumentSyntax
//@[17:38)     StringSyntax
//@[17:38)      StringComplete |'I will be overrode.'|
//@[38:39)    RightParen |)|
//@[39:41)  NewLine |\r\n|
param decoratedArray array = [
//@[0:5)  Identifier |param|
//@[6:20)  IdentifierSyntax
//@[6:20)   Identifier |decoratedArray|
//@[21:26)  TypeSyntax
//@[21:26)   Identifier |array|
//@[27:62)  ParameterDefaultValueSyntax
//@[27:28)   Assignment |=|
//@[29:62)   ArraySyntax
//@[29:30)    LeftSquare |[|
//@[30:32)    NewLine |\r\n|
    utcNow()
//@[4:12)    ArrayItemSyntax
//@[4:12)     FunctionCallSyntax
//@[4:10)      IdentifierSyntax
//@[4:10)       Identifier |utcNow|
//@[10:11)      LeftParen |(|
//@[11:12)      RightParen |)|
//@[12:14)    NewLine |\r\n|
    newGuid()
//@[4:13)    ArrayItemSyntax
//@[4:13)     FunctionCallSyntax
//@[4:11)      IdentifierSyntax
//@[4:11)       Identifier |newGuid|
//@[11:12)      LeftParen |(|
//@[12:13)      RightParen |)|
//@[13:15)    NewLine |\r\n|
]
//@[0:1)    RightSquare |]|
//@[1:3) NewLine |\r\n|

//@[0:0) EndOfFile ||
