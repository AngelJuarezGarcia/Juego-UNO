func @_UNO.Contratos.JuegoUNOServicio.BuscarJugador$string$(none) -> () loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :13 :8) {
^entry (%_nickname : none):
%0 = cbde.alloca none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :13 :34)
cbde.store %_nickname, %0 : memref<none> loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :13 :34)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :15 :50) // new AdminDatosJugador() (ObjectCreationExpression)
%3 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :16 :45) // Not a variable of known type: adminDatosJugador
%4 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :16 :78) // Not a variable of known type: nickname
%5 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :16 :45) // adminDatosJugador.ObtenerJugador(nickname) (InvocationExpression)
%7 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :18 :12) // Not a variable of known type: PerfilCallback
%8 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :18 :53) // Not a variable of known type: jugadorBuscado
%9 = cbde.unknown : none loc("D:\\Juego-UNO\\UNOServer\\UNO.Contratos\\PerfilServicio.cs" :18 :12) // PerfilCallback.ObtenerInformacionJugador(jugadorBuscado) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
