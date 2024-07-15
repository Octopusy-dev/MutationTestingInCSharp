# Mutation testing en C# avec Stryker.NET


## Introduction
Le but des tests de mutation est de tester nos tests unitaires. 
En effet, il est possible d'avoir des tests unitaires qui passent mais qui ne sont pas suffisamment robustes. Les tests de mutation permettent de vérifier la qualité de nos tests unitaires en modifiant le code source et en vérifiant si les tests unitaires échouent. 
Si les tests unitaires passent, c'est que les tests unitaires ne sont pas assez robustes.

## Process
Le but est ici d'introduire une mutation dans notre code et de voir comment les tests reagissent
par exemple

```csharp
-  var result = number1 + number2;
+ var result = number1 - number2;
```


## Sources
-[Mutation Testing with Stryker](https://engincanv.github.io/c%23/.net/stryker/2024/02/10/mutation-testing-in-c-sharp-with-stryker.html)

-[GitHub Stryker](https://stryker-mutator.io/docs/stryker-net/introduction/)