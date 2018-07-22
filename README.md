# インストール

nuget で提供されています。
```
Install-Package NrsLib.ClassFileGenerator
```

nuget: [https://www.nuget.org/packages/NrsLib.ClassFileGenerator/](https://www.nuget.org/packages/NrsLib.ClassFileGenerator/ "https://www.nuget.org/packages/NrsLib.ClassFileGenerator/")

# Class file generator CSharp
t4 テンプレートを利用したクラスファイルの作成用ライブラリです。  

詳細は以下に記載しています。  
[https://srnlib.com/class-file-generator/](https://srnlib.com/class-file-generator/ "https://srnlib.com/class-file-generator/")

# 使い方

```
var classMeta = new ClassMeta("TestNameSpace.Test", "TestClass");
var driver = new MainDriver();
var classText = driver.Create(classMeta, Language.CSharp);
```
上記のように利用します。  
```
classMeta.SetupFields()
    .AddField("testField", field => field.SetType("int").SetValue("1"));
```
というように設定するとメソッドが定義されます。  
MainDriver.Create の戻り値はただの文字列ですのでそのままファイルに出力などしてください。  

Sample プロジェクトに色々な設定方法を載せています。  