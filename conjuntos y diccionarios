class TorneoFutbol:
    def __init__(self):
        self.equipos = {}  # Diccionario para almacenar equipos y sus jugadores
        self.jugadores = set()  # Conjunto para evitar registros duplicados de jugadores

    def agregar_equipo(self, nombre_equipo):
        if nombre_equipo not in self.equipos:
            self.equipos[nombre_equipo] = set()
            print(f"Equipo '{nombre_equipo}' registrado correctamente.")
        else:
            print(f"El equipo '{nombre_equipo}' ya existe.")

    def agregar_jugador(self, nombre_jugador, equipo):
        if nombre_jugador in self.jugadores:
            print(f"El jugador '{nombre_jugador}' ya está registrado en otro equipo.")
            return
        if equipo in self.equipos:
            self.equipos[equipo].add(nombre_jugador)
            self.jugadores.add(nombre_jugador)
            print(f"Jugador '{nombre_jugador}' agregado al equipo '{equipo}'.")
        else:
            print(f"El equipo '{equipo}' no está registrado.")

    def mostrar_equipos(self):
        for equipo, jugadores in self.equipos.items():
            print(f"Equipo: {equipo}, Jugadores: {', '.join(jugadores)}")

# Ejemplo de uso
torneo = TorneoFutbol()
torneo.agregar_equipo("Leones")
torneo.agregar_jugador("Carlos Pérez", "Leones")
torneo.mostrar_equipos()