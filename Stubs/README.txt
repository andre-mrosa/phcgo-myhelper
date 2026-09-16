PHC GO - Stubs locais para desenvolvimento
===========================================

Objetivo
--------
Esta pasta serve apenas para o projeto/DLL local no Visual Studio.
Não implementa o comportamento real do PHC GO e não deve ser publicada no PHC.

Como usar
---------
Mantém o Root Namespace do projeto PHCGo vazio, para poderes escrever diretamente:

   SDK.Query...
   SDKBiz
   PHCResult
   BoVO
   BiVO
   FtVO
   FiVO
   ClVO
   StVO

Se o projeto principal estiver separado, adiciona uma Project Reference para o projeto PHCGo.
À medida que o compilador acusar uma propriedade/método PHC que ainda não existe aqui, adiciona-o ao stub correspondente só depois de o confirmares no PHC/documentação.

Estrutura
---------
Core/       SDK, Business, Result, GenericVO
Query/      FilterItem, Comparison, QueryResultVO
Models/     BO/BI/FT/FI/CL/ST e MessageVO
Extensions/ extensões usadas pelos scripts

Notas importantes
-----------------
- Os métodos devolvem objetos/listas vazios: são compile-only.
- A fonte de verdade é sempre o SDK real do PHC GO.
- Os nomes incluídos aqui foram os que já apareceram nos scripts usados no projeto BookingLayer -> PHC GO.
- Comparison contém apenas Equal porque é o valor já usado/confirmado no projeto.
