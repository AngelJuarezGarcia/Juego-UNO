func @_UNO.Contratos.JuegoUNOServicio.CrearSala$UNO.Contratos.LogicaJuego.Sala.UNO.Dominio.Jugador$(none, none) -> () loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :19 :8) {
^entry (%_nuevaSala : none, %_jugador : none):
%0 = cbde.alloca none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :19 :30)
cbde.store %_nuevaSala, %0 : memref<none> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :19 :30)
%1 = cbde.alloca none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :19 :46)
cbde.store %_jugador, %1 : memref<none> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :19 :46)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :21 :44) // Not a variable of known type: JuegoCallbackActual
%4 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :23 :12) // Not a variable of known type: nuevaSala
%5 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :23 :12) // nuevaSala.Id (SimpleMemberAccessExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: ObtenerNuevoCodigoSala
%6 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :23 :27) // ObtenerNuevoCodigoSala() (InvocationExpression)
%7 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :24 :12) // Not a variable of known type: nuevaSala
%8 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :24 :12) // nuevaSala.JugadoresEnSala (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :24 :42) // Not a variable of known type: jugador
%10 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :24 :51) // Not a variable of known type: callbackActual
%11 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :24 :12) // nuevaSala.JugadoresEnSala.Add(jugador, callbackActual) (InvocationExpression)
%12 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :26 :12) // Not a variable of known type: salasCreadas
%13 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :26 :29) // Not a variable of known type: nuevaSala
%14 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :26 :12) // salasCreadas.Add(nuevaSala) (InvocationExpression)
%15 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :27 :12) // Not a variable of known type: callbackActual
%16 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :27 :51) // Not a variable of known type: nuevaSala
%17 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :27 :12) // callbackActual.NotificarCreacionDeSala(nuevaSala) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function UnirseASala(none, none), it contains poisonous unsupported syntaxes

// Skipping function AgregarNuevoJugadorEnSala(none, none), it contains poisonous unsupported syntaxes

func @_UNO.Contratos.JuegoUNOServicio.HayCupoEnSala$UNO.Contratos.LogicaJuego.Sala$(none) -> i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :85 :8) {
^entry (%_sala : none):
%0 = cbde.alloca none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :85 :35)
cbde.store %_sala, %0 : memref<none> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :85 :35)
br ^0

^0: // BinaryBranchBlock
%1 = constant 0 : i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :87 :27) // false
%2 = cbde.alloca i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :87 :17) // hayCupo
cbde.store %1, %2 : memref<i1> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :87 :17)
%3 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :89 :16) // Not a variable of known type: sala
%4 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :89 :16) // sala.JugadoresEnSala (SimpleMemberAccessExpression)
%5 = cbde.unknown : i32 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :89 :16) // sala.JugadoresEnSala.Count (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :89 :45) // Not a variable of known type: sala
%7 = cbde.unknown : i32 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :89 :45) // sala.NumeroTotalDeJugadores (SimpleMemberAccessExpression)
%8 = cmpi "slt", %5, %7 : i32 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :89 :16)
cond_br %8, ^1, ^2 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :89 :16)

^1: // SimpleBlock
%9 = constant 1 : i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :91 :26) // true
cbde.store %9, %2 : memref<i1> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :91 :16)
br ^2

^2: // JumpBlock
%10 = cbde.load %2 : memref<i1> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :94 :19)
return %10 : i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :94 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_UNO.Contratos.JuegoUNOServicio.ObtenerNuevoCodigoSala$$() -> none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :97 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :99 :28) // new Random() (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :101 :28) // Not a variable of known type: random
%3 = constant 10000 : i32 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :101 :40)
%4 = constant 99999 : i32 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :101 :47)
%5 = cbde.unknown : i32 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :101 :28) // random.Next(10000, 99999) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :101 :28) // random.Next(10000, 99999).ToString() (InvocationExpression)
%8 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :103 :19) // Not a variable of known type: idSala
return %8 : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :103 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function SalirDeSala(none, none), it contains poisonous unsupported syntaxes

// Skipping function EliminarSalaPorFaltaDeJugadores(none), it contains poisonous unsupported syntaxes

// Skipping function NotificarJugadorEliminado(none, none), it contains poisonous unsupported syntaxes

// Skipping function EliminarSala(none), it contains poisonous unsupported syntaxes

func @_UNO.Contratos.JuegoUNOServicio.EsCreadorDeLaSala$UNO.Contratos.LogicaJuego.Sala.UNO.Dominio.Jugador$(none, none) -> i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :189 :8) {
^entry (%_sala : none, %_jugador : none):
%0 = cbde.alloca none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :189 :39)
cbde.store %_sala, %0 : memref<none> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :189 :39)
%1 = cbde.alloca none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :189 :50)
cbde.store %_jugador, %1 : memref<none> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :189 :50)
br ^0

^0: // BinaryBranchBlock
%2 = constant 0 : i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :191 :29) // false
%3 = cbde.alloca i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :191 :17) // esCreador
cbde.store %2, %3 : memref<i1> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :191 :17)
%4 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :193 :16) // Not a variable of known type: sala
%5 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :193 :16) // sala.CreadaPor (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :193 :38) // Not a variable of known type: jugador
%7 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :193 :38) // jugador.Nickname (SimpleMemberAccessExpression)
%8 = cbde.unknown : i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :193 :16) // sala.CreadaPor.Equals(jugador.Nickname) (InvocationExpression)
cond_br %8, ^1, ^2 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :193 :16)

^1: // SimpleBlock
%9 = constant 1 : i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :195 :28) // true
cbde.store %9, %3 : memref<i1> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :195 :16)
br ^2

^2: // JumpBlock
%10 = cbde.load %3 : memref<i1> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :198 :19)
return %10 : i1 loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\ServicioDeSala.cs" :198 :12)

^3: // ExitBlock
cbde.unreachable

}
