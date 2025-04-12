class Animal:
    def __init__(self, nome, idade, nome_dono):
        self.nome = nome
        self.idade = idade
        self.nome_dono = nome_dono
        self.esta_vacinado = False

    def emitir_som(self):
        print("Som de animal...")

class Cachorro(Animal):
    def __init__(self, nome, idade, nome_dono):
        super().__init__(nome, idade, nome_dono)

    def emitir_som(self):
        print("Au Au!")

class Gato(Animal):
    def __init__(self, nome, idade, nome_dono):
        super().__init__(nome, idade, nome_dono)
        self.esta_vacinado = True 

    def emitir_som(self):
        print("Miau")

class Papagaio(Animal):
    def __init__(self, nome, idade, nome_dono):
        super().__init__(nome, idade, nome_dono)

    def emitir_som(self):
        print("Olá! papagaio aqui!")

class Veterinario:
    def __init__(self, nome_veterinario):
        self.nome_veterinario = nome_veterinario

    def vacinar(self, animal):
        if not animal.esta_vacinado:
            animal.esta_vacinado = True
            print(f"O {animal.__class__.__name__.lower()} {animal.nome} foi vacinado com sucesso!")
        else:
            print(f"O {animal.__class__.__name__.lower()} {animal.nome} já está vacinado.")



if __name__ == "__main__":

    rex = Cachorro("Rex", 5, "Carlos")
    lima = Gato("Lima", 7, "Isabelle")
    lucky = Papagaio("Lucky", 3, "Fernando")

    marcos = Veterinario("Dr. Marcos")

    marcos.vacinar(rex)
    marcos.vacinar(lima)
    marcos.vacinar(lucky)
